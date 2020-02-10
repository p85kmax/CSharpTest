// GravuerCalculateWithSIMD.cpp : DLL ���� ���α׷��� ���� ������ �Լ��� �����մϴ�.
//

#include "stdafx.h"

#include <iostream>  

#define TRADITIONALDLL_EXPORTS  
#ifdef TRADITIONALDLL_EXPORTS  
#define TRADITIONALDLL_API __declspec(dllexport)  
#else  
#define TRADITIONALDLL_API __declspec(dllimport)  
#endif  

extern "C" {
	TRADITIONALDLL_API void TakesAnArray(int len, int[]);
	TRADITIONALDLL_API void Print();
	TRADITIONALDLL_API int Sum(int a, int b);
	TRADITIONALDLL_API int SumArray(int a[]);
	TRADITIONALDLL_API void CopyArray(int a[], int b[]);
	TRADITIONALDLL_API void CopyPtr(int* a, int* b, int size);

	TRADITIONALDLL_API void GravuerCalculateWithSIMD(BYTE *pSrc, BYTE* pRef, BYTE* pMask, BYTE* pDst, int nSrcPitch, int nDstPitch, BYTE nThreshold, int nWidth, int nHeight);
}

void CopyPtr(int* a, int* b, int size)
{
	for (int i = 0; i < size; i++)
		b[i] = a[i];
}

void CopyArray(int a[], int b[])
{
	b[0] = a[0];
	b[1] = a[1];
}

int SumArray(int a[])
{
	return a[0] + a[1];
}

int Sum(int a, int b)
{
	return a + b;
}

void Print()
{
	printf_s("Test Print\n");
}

void TakesAnArray(int len, int data[]) {
	printf_s("[unmanaged]\n");
	for (int i = 0; i < len; i++)
		printf_s("%d = %d\n", i, data[i]);
}


//GravuerCalculateWithSIMD
//BYTE *Src, BYTE* Ref, BYTE* Mask, BYTE* Dst, ������ ���ڴ� ���� ó���� ��ġ�� �ּ�
//step = �迭�� ���� ����
//Threshod = ����ȭ ���ΰ�
//width = ó���� 
void GravuerCalculateWithSIMD(BYTE *pSrc, BYTE* pRef, BYTE* pMask, BYTE* pDst, int nSrcPitch, int nDstPitch, BYTE nThreshold, int nWidth, int nHeight)//full=97.7, width-1=98.236
{
#define PARALLEL_COUNT 0x10
	//Src, Ref, Mask, Dst, Step, Threshold, roi
	//#pragma omp parallel 
	{
		BYTE *_pSrc = pSrc;
		BYTE* _pRef = pRef;
		BYTE* _pMask = pMask;
		BYTE* _pDst = pDst;

		int i, j;

		int quotient = nWidth / PARALLEL_COUNT;
		int remainder = nWidth % PARALLEL_COUNT;

		__m128i xmmA;
		__m128i xmmB;
		__m128i xmmC;
		__m128i xmmR;
		__m128i xmmT = _mm_set1_epi16(nThreshold);
		__m128i xmm0 = _mm_set1_epi8(0);
		if (quotient && remainder == 0 && nWidth == nSrcPitch) //���ΰ� PARALLEL_COUNT ����̰�, ROI�� ��ü �����϶�....
		{
			int size = nSrcPitch * nHeight;
			int r = size >> 4;
			for (i = 0; i < r; i++)
			{
				//pDst[index] = pSrc1[index] - pSrc2[index];
				xmmA = _mm_loadu_si128((__m128i*)(_pSrc)); //src �̹���
				xmmB = _mm_loadu_si128((__m128i*)(_pRef)); //REF �̹���
				xmmC = _mm_loadu_si128((__m128i*)(_pMask)); //Mask �̹���

															//xmmR = _mm_sub_epi8(xmmA, xmmB); //�����÷� �߻�
				xmmR = _mm_adds_epu8(_mm_subs_epu8(xmmA, xmmB), _mm_subs_epu8(xmmB, xmmA)); //0~255 Saturation����, 0 �ƴϸ� ���̰��̹Ƿ� ���� ���ϸ� ���̰���
				xmmR = _mm_and_si128(xmmR, xmmC); //����ŷ

				xmmA = _mm_unpackhi_epi8(xmmR, xmm0);
				xmmA = _mm_cmplt_epi16(xmmT, xmmA); //����ȭ//C=(A<B)? 0xFF: 0x00;

				xmmB = _mm_unpacklo_epi8(xmmR, xmm0);
				xmmB = _mm_cmplt_epi16(xmmT, xmmB); //����ȭ//C=(A<B)? 0xFF: 0x00;

				xmmR = _mm_packs_epi16(xmmB, xmmA); //8bit�� ��Ű¡
				_mm_storeu_si128((__m128i*)_pDst, xmmR); //��� ����

				_pSrc += PARALLEL_COUNT;
				_pRef += PARALLEL_COUNT;
				_pDst += PARALLEL_COUNT;
				_pMask += PARALLEL_COUNT;
			}
			return;
		}
		else if (quotient)
		{
			for (j = 0; j < nHeight; j++)
			{
				_pSrc = pSrc + j*nSrcPitch;
				_pRef = pRef + j*nSrcPitch;
				_pMask = pMask + j*nSrcPitch;
				_pDst = pDst + j*nDstPitch;
				for (i = 0; i < quotient; i++)
				{
					//pDst[index] = pSrc1[index] - pSrc2[index];
					xmmA = _mm_loadu_si128((__m128i*)(_pSrc)); //src �̹���
					xmmB = _mm_loadu_si128((__m128i*)(_pRef)); //REF �̹���
					xmmC = _mm_loadu_si128((__m128i*)(_pMask)); //Mask �̹���

																//xmmR = _mm_sub_epi8(xmmA, xmmB); //�����÷� �߻�
																//0~255 Saturation����, 0 �ƴϸ� ���̰��̹Ƿ� ���� ���ϸ� ���̰���
					xmmR = _mm_adds_epu8(_mm_subs_epu8(xmmA, xmmB), _mm_subs_epu8(xmmB, xmmA)); //���̰� _mm256_cmpgt_epi8
					xmmR = _mm_and_si128(xmmR, xmmC); //����ŷ
													  //xmmR = _mm_cmplt_epi8(xmmT, xmmR); //����ȭ//C=(A<B)? 0xFF: 0x00;

					xmmA = _mm_unpackhi_epi8(xmmR, xmm0);
					xmmA = _mm_cmplt_epi16(xmmT, xmmA); //����ȭ//C=(A<B)? 0xFF: 0x00;
					xmmB = _mm_unpacklo_epi8(xmmR, xmm0);
					xmmB = _mm_cmplt_epi16(xmmT, xmmB); //����ȭ//C=(A<B)? 0xFF: 0x00;
					xmmR = _mm_packs_epi16(xmmB, xmmA); //8bit�� ��Ű¡

					_mm_storeu_si128((__m128i*)_pDst, xmmR); //��� ����

					_pSrc += PARALLEL_COUNT;
					_pRef += PARALLEL_COUNT;
					_pMask += PARALLEL_COUNT;
					_pDst += PARALLEL_COUNT;
				}
			}//for(j
		}

		if (remainder)
		{
			if (quotient)
			{
				for (j = 0; j < nHeight; j++)
				{
					_pSrc = pSrc + j*nSrcPitch - (nSrcPitch - nWidth) - PARALLEL_COUNT;
					_pRef = pRef + j*nSrcPitch - (nSrcPitch - nWidth) - PARALLEL_COUNT;
					_pMask = pMask + j*nSrcPitch - (nSrcPitch - nWidth) - PARALLEL_COUNT;
					_pDst = pDst + j*nDstPitch - (nDstPitch - nWidth) - PARALLEL_COUNT;

					//pDst[index] = pSrc1[index] - pSrc2[index];
					xmmA = _mm_loadu_si128((__m128i*)(_pSrc)); //src �̹���
					xmmB = _mm_loadu_si128((__m128i*)(_pRef)); //REF �̹���
					xmmC = _mm_loadu_si128((__m128i*)(_pMask)); //Mask �̹���

																//xmmR = _mm_sub_epi8(xmmA, xmmB); //�����÷� �߻�
																//0~255 Saturation����, 0 �ƴϸ� ���̰��̹Ƿ� ���� ���ϸ� ���̰���
					xmmR = _mm_adds_epu8(_mm_subs_epu8(xmmA, xmmB), _mm_subs_epu8(xmmB, xmmA)); //���̰� _mm256_cmpgt_epi8
					xmmR = _mm_and_si128(xmmR, xmmC); //����ŷ
													  //xmmR = _mm_cmplt_epi8(xmmT, xmmR); //����ȭ//C=(A<B)? 0xFF: 0x00;

					xmmA = _mm_unpackhi_epi8(xmmR, xmm0);
					xmmA = _mm_cmplt_epi16(xmmT, xmmA); //����ȭ//C=(A<B)? 0xFF: 0x00;
					xmmB = _mm_unpacklo_epi8(xmmR, xmm0);
					xmmB = _mm_cmplt_epi16(xmmT, xmmB); //����ȭ//C=(A<B)? 0xFF: 0x00;
					xmmR = _mm_packs_epi16(xmmB, xmmA); //8bit�� ��Ű¡

					_mm_storeu_si128((__m128i*)_pDst, xmmR); //��� ����
				}
			}
			else  if (!quotient) // �׳� �Ϲ� C-language �� ó��
			{
				_pSrc = pSrc;
				_pRef = pRef;
				_pMask = pMask;
				_pDst = pDst;
				int srcindex = 0;
				int dstindex = 0;
				BYTE diff = 0;
				for (j = 0; j < nHeight; j++)
				{
					for (i = 0; i < nWidth; i++)
					{
						srcindex = j*nSrcPitch + i;
						dstindex = j*nDstPitch + i;
						diff = abs(_pSrc[srcindex] - _pRef[srcindex]) & (pMask[srcindex]>0?0xff:0x00);
						if (nThreshold < diff) _pDst[dstindex] = 0xFF;
						else _pDst[dstindex] = 0x00;
					}
				}
			}
		}//if(remainder)
	}//#pragma omp parallel 
} //*/

