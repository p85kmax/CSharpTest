// houghline.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"
#include <iostream>

#ifdef _DEBUG 
#pragma comment (lib, "opencv_world330d.lib") 
#else 
#pragma comment (lib, "opencv_world330.lib")
#endif
#include <opencv2\opencv.hpp>

using namespace cv;
#define PI 3.1415926

int main()
{
	//cv::Mat image = cv::imread("R:\\Calibration_20180103_100833.bmp", 0);
	cv::Mat image = cv::imread("R:\\Calibration_123.bmp", 0);
	cv::Mat colorimage = cv::imread("R:\\Calibration_123.bmp", IMREAD_COLOR);
	cv::namedWindow("Original Image");
	//cv::imshow("Original Image", image);

	Mat gray=image.clone();
	//if (image.channels() == 1) gray=(Mat)cvClone(&image);
	//else cvtColor(image, gray, CV_BGR2GRAY);

	// Sobel Filter
	Mat sobel;
	Mat sobelX;
	Mat sobelY;
	Sobel(gray, sobelX, CV_8U, 1, 0);
	Sobel(gray, sobelY, CV_8U, 0, 1);
	sobel = abs(sobelX) + abs(sobelY);

	cv::threshold(sobelY, sobelY, 200, 255, CV_THRESH_BINARY);



	//cv::imshow("gray", gray);		cv::waitKey();
	//cv::imshow("sobelX", sobelX);	cv::waitKey();
	//cv::imshow("sobelY", sobelY);	cv::waitKey();
	cv::imshow("sobel", sobel);		cv::waitKey();


	// ĳ�� �˰��� ����
	cv::Mat contours;
	cv::Canny(image, contours, 125, 350);
	cv::imshow("contours", contours);	cv::waitKey();

	cv::bitwise_and(contours, sobelY, contours);

	cv::imshow("contours", contours);	cv::waitKey();


	// �� ���� ���� ���� ��ȯ
	std::vector<cv::Vec2f> lines;
	cv::HoughLines(contours, lines,
		1, PI / 180, // �ܰ躰 ũ��
		80);  // ��ǥ(vote) �ִ� ����

			  // �� �׸���
	cv::Mat result(contours.rows, contours.cols, CV_8U, cv::Scalar(255));
	std::cout << "Lines detected: " << lines.size() << std::endl;

	// �� ���͸� �ݺ��� �� �׸���
	std::vector<cv::Vec2f>::const_iterator it = lines.begin();
	while (it != lines.end()) {
		float rho = (*it)[0];   // ù ��° ��Ҵ� rho �Ÿ�
		float theta = (*it)[1]; // �� ��° ��Ҵ� ��Ÿ ����
		if (theta < PI / 4. || theta > 3.*PI / 4.) { // ���� ��
			cv::Point pt1(rho / cos(theta), 0); // ù �࿡�� �ش� ���� ������   
			cv::Point pt2((rho - result.rows*sin(theta)) / cos(theta), result.rows);
			// ������ �࿡�� �ش� ���� ������
			cv::line(image, pt1, pt2, cv::Scalar(255), 1); // �Ͼ� ������ �׸���

		}
		else { // ���� ��
			cv::Point pt1(0, rho / sin(theta)); // ù ��° ������ �ش� ���� ������  
			cv::Point pt2(result.cols, (rho - result.cols*cos(theta)) / sin(theta));
			// ������ ������ �ش� ���� ������
			cv::line(image, pt1, pt2, cv::Scalar(255), 1); // �Ͼ� ������ �׸���
		}
		std::cout << "line: (" << rho << "," << theta << ")\n";
		++it;
	}

	cv::namedWindow("Detected Lines with Hough");
	cv::imshow("Detected Lines with Hough", image);

	cv::waitKey(0);

	return 0;
}