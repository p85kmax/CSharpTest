:: �������� Ư�� ��¥�� �ð����� ������ ������ �� ������
::- %time% ���� ���� �ð� �����ڰ� �Ϲ������� ":(�ݷ�)" �� ���Ǿ� ���ϸ����� ���Ұ�
::- ex) echo %time% ->15:59:46.85-> ���� ������ ���Ұ�
::���� ���� �ݵ�� = �翷 �ٿ���..�����̽�����...�Ұ�!!
@echo off

set /p score=enter your score:

if %score% GEQ 90 (
echo Very good
) else (
echo Not good
)

echo "score= [%score%]"

set /p aaa=enter asdf:

if "%aaa%"=="asdf" (
echo alright asdf
) else (
echo wrong asdf
)

if %aaa%==asdf (
echo alright asdf
) else (
echo wrong asdf
)


set /p aaa=enter 55:

if "%aaa%"=="55" (
echo alright 55
) else (
echo wrong 55
)

set /p aaa=enter 66:

if %aaa%==66 (
echo alright 66
) else (
echo wrong 66
)


pause

rem  equ equal ����
rem  neq not equal ����
rem  gtr greater �ʰ�
rem  geq greater than equal �̻�
rem  leq less than equal ����
rem  lss less �̸�
rem  == ���ں񱳿��� ���

set var1=bbc
set var2=BBC
if /i "%var1%" equ "%var2%" (
	echo result1  // "/i" �ɼ����� ��ҹ��� �������� ���� ����
) else (
	echo result2
)