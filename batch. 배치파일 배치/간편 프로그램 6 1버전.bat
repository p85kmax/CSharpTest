@echo off
set vision=6.1


color b
if not exist "C:\BATprogram" goto help
:first
SET DT=%DATE%
SET TE=%TIME%
title ������ ���α׷�
echo.>>C:\BATprogram\BAT.txt
echo ---------------------%DATE% %TIME%----------------------->>C:\BATprogram\BAT.txt
echo.>>C:\BATprogram\BAT.txt
echo %DATE% %TIME%:  ���α׷� ����!>>C:\BATprogram\BAT.txt
echo %DATE% %TIME%:  ���� ����:%vision%>>C:\BATprogram\BAT.txt
mode 1000
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                         ���� ����:%vision%
timeout /t 1 > nul
cls
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  ���α׷� ������ Ȯ���մϴ�.(BATprogram folder check)
timeout /t 1 > nul
if not exist "C:\BATprogram" goto erro1
cls
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  ���α׷� ������ Ȯ���մϴ�.(mainsetting folder check)
timeout /t 1 > nul
if not exist "C:\BATprogram\main" goto mainset
cls
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  ���α׷� ������ Ȯ���մϴ�.(main\??)
timeout /t 1 > nul
echo %DATE% %TIME%:  ���α׷����� Ȯ�� ����>>C:\BATprogram\BAT.txt
goto lode1212

:lode1212
cls
echo �ҷ�������.
if not exist "C:\BATprogram\main\main1" goto main2rerro
if exist "C:\BATprogram\main\main1" goto main

:main2rerro
cls
echo �ҷ�������2.
if not exist "C:\BATprogram\main\main2" goto errocode2
if exist "C:\BATprogram\main\main2" goto main2r

:errocode2
cls
echo %DATE% %TIME%:  ���� �߻� �����ڵ�:2>>C:\BATprogram\BAT.txt
echo ��������������������������������������
echo ��                                  ��
echo ��   ���� ������ �ҷ��� �� ����     ��
echo ��       (����� ������ ������)     ��
echo ��          erro code:2             ��
echo ��������������������������������������
echo.
echo.
echo (�ڵ������� �����մϴ�)
echo.
echo.
pause
timeout /t 10
rd /s /q C:\batprogram\main
echo ���α׷� �����...
timeout /t 3
goto first



:mainset
cls
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  ���μ����� ã�� �� �����ϴ�.
echo.
echo                                   3���� �������� �̵��˴ϴ�. 
timeout /t 1 > nul
echo %DATE% %TIME%:  ���μ����� ã�� �� �����ϴ�.>>C:\BATprogram\BAT.txt
cls
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  ���μ����� ã�� �� �����ϴ�.
echo.
echo                                   2���� �������� �̵��˴ϴ�. 
timeout /t 1 > nul
cls
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo �����������������������������������������������
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  ���μ����� ã�� �� �����ϴ�.
echo.
echo                                   1���� �������� �̵��˴ϴ�. 
timeout /t 1 > nul
goto check

:erro1
cls
echo %DATE% %TIME%:  �����߻� �����ڵ�:1>>C:\BATprogram\BAT.txt
echo ��������������������������������������
echo ��                                  ��
echo �� ���α׷� ������ ã�� �� �����ϴ�.��
echo ��  (C����̺꿡�� ������ �ּ���)   ��
echo ��          erro code:1             ��
echo ��������������������������������������
pause
goto EXIT

:check
cls
echo �ҷ�������
if not exist "C:\BATprogram\main" goto checkgo

:checkgo
cls
echo %DATE% %TIME%:  ���μ���>>C:\BATprogram\BAT.txt
echo �Ϲ�(����)����:1
echo Simple(���ο�)����:2
echo.
echo �Ϲݸ��� �̸�����:1m
echo ���ο���� �̸�����:2m
echo.
set /p b=���Ͻô� ��ȣ�� �Է��ϼ���:
if %b%==1 goto mainse
if %b%==2 goto mainse2r
if %b%==1m goto 1mi
if %b%==2m goto 2mi

:mainse
cls
if not exist "C:\BATprogram\main" goto makemainset
if not exist "C:\BATprogram\main\main1" goto makemainset1
goto first

:mainse2r
cls
if not exist "C:\BATprogram\main" goto makemainset22
if not exist "C:\BATprogram\main\main2" goto makemainset2
goto first

:2mi
cls
echo %DATE% %TIME%:  ����2 �̸����� ����>>C:\BATprogram\BAT.txt
echo ��������������������������������������
echo ������(���α׷�����:%vision%)            ��
echo ��������������������������������������
echo ��������������������������������������
echo ��                                  ��
echo �� 1:����  2:����  3:CMD����        ��
echo �� 4:������Ʈ ����                  ��
echo �� 5:EXIT                           ��
echo ��������������������������������������
pause
goto checkgo

:main2r
cls
echo %DATE% %TIME%:  ����2 ����>>C:\BATprogram\BAT.txt


echo ��������������������������������������
echo ������(���α׷�����:%vision%)            ��
echo ��������������������������������������
echo ��������������������������������������
echo ��                                  ��
echo �� 1:����  2:����  3:CMD����        ��
echo �� 4:������Ʈ ����                  ��
echo �� 5:EXIT                           ��
echo ��������������������������������������
set /p an=���Ͻô� ��ȣ�� �����ϼ���:
if %an%==1 goto page2
if %an%==2 goto setting2
if %an%==3 goto CMDgo
if %an%==4 goto report
if %an%==5 goto EXIT

:setting
cls 
echo %DATE% %TIME%:  ���� ����>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������
echo �� ����
echo �Ʀ�����������������������������������������������������������������
echo �Ȧ�����������������������������������������������������������������        
echo ��                                                             
echo �� 1:�ؽ�Ʈ�� ����              2:���α׷� �ʱ�ȭ
echo ��     
echo �� 3:��ɾ� ���̱�              4:�α� ����
echo ��                          
echo �� 5:���κ���                   6:�����ڿ� ī��
echo �� 
echo �� 7:������Ʈ Ȯ��
echo �� 
echo �� 
echo �� 
echo �� 
echo �Ʀ�����������������������������������������������������������������        
echo �Ȧ�����������������������������������������������������������������
echo �� �ڷΰ���:11
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto color
if %a%==2 goto resetyn
if %a%==3 goto com
if %a%==4 goto LOG1
if %a%==5 goto changemainyn
if %a%==6 goto ice
if %a%==7 goto update
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto main
if %a%==12 goto 

:setting2
cls 
echo %DATE% %TIME%:  ���� ����>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������
echo �� ����
echo �Ʀ�����������������������������������������������������������������
echo �Ȧ�����������������������������������������������������������������        
echo ��                                                             
echo �� 1:�ؽ�Ʈ�� ����              2:���α׷� �ʱ�ȭ
echo ��     
echo �� 3:��ɾ� ���̱�              4:�α� ����
echo ��                          
echo �� 5:���κ���                   6:�����ڿ� 
echo �� 
echo �� 7:������Ʈ Ȯ��
echo �� 
echo �� 
echo �� 
echo �� 
echo �Ʀ�����������������������������������������������������������������        
echo �Ȧ�����������������������������������������������������������������
echo �� �ڷΰ���:11
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto color22
if %a%==2 goto resetyn2
if %a%==3 goto com2
if %a%==4 goto LOG2
if %a%==5 goto changemainyn2
if %a%==6 goto ice
if %a%==7 goto update
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto main2r
if %a%==12 goto 


:ice
cls
echo %DATE% %TIME%:  ��������>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������
echo �� 
echo �Ʀ�����������������������������������������������������������������
echo �Ȧ�����������������������������������������������������������������        
echo ��                                                             
echo �� 1.īī����(����)
echo ��     
echo �� 
echo ��                          
echo ��
echo �� 
echo �� 
echo �� 
echo �� 
echo �� 
echo �� 
echo �Ʀ�����������������������������������������������������������������        
echo �Ȧ�����������������������������������������������������������������
echo �� �ڷΰ���:11
echo �Ʀ�����������������������������������������������������������������

set /p se=��ȣ�� �Է��ϼ���:
if %se%==1 goto kakao
if $se%==11 goto lode1212

:kakao
start https://open.kakao.com/o/smmH1yx
goto lode1212


:update
start http://blog.naver.com/victory1577/221042267669
goto lode1212

:changemainyn
cls
echo %DATE% %TIME%:  ���κ��� Ȯ�� ����>>C:\BATprogram\BAT.txt
set /p anse=������ �����Ͻðڽ��ϱ�?Y/N:
if %anse%==n goto setting
if %anse%==y goto changemain2
if %anse%==N goto setting
if %anse%==Y goto changemain2

:changemainyn2
cls
echo %DATE% %TIME%:  ���κ��� Ȯ�� ����>>C:\BATprogram\BAT.txt
set /p a=������ �����Ͻðڽ��ϱ�?Y/N:
if %a%==n goto setting2
if %a%==y goto changemain2
if %a%==N goto setting2
if %a%==Y goto changemain2





:changemain2
echo %DATE% %TIME%:  ���μ��� �ʱ�ȭ ����>>C:\BATprogram\BAT.txt
cls
if not exist "C:\batprogramchange" goto changemainmaker2
cd C:\BATprogramchange
change
pause
goto first

:changemainmaker2
echo %DATE% %TIME%:  ���κ��� ��ġ������ �������>>C:\BATprogram\BAT.txt
cd C:\
md batprogramchange
echo @echo off>>C:\batprogramchange\change.bat
echo echo ��ø���ٷ��ּ���>>C:\batprogramchange\change.bat
echo timeout /t 3 > nul>>C:\batprogramchange\change.bat
echo rd /s /q C:\batprogram\main>>C:\batprogramchange\change.bat
echo echo �Ϸ�>>C:\batprogramchange\change.bat
echo pause>>C:\batprogramchange\change.bat
echo ���κ��� ��ġ���� ������
timeout /t 3 > NUL
goto changemain2

:resetyn
cls
echo %DATE% %TIME%:  ���α׷� �ʱ�ȭ Ȯ�� ����>>C:\BATprogram\BAT.txt
set /p ans=�������ʱ�ȭ �Ͻðڽ��ϱ�? Y/N:
if %ans%==N goto setting
if %ans%==Y goto reset
if %ans%==n goto setting
if %ans%==y goto reset

:resetyn2
cls
echo %DATE% %TIME%:  ���α׷� �ʱ�ȭ Ȯ�� ����>>C:\BATprogram\BAT.txt
set /p ans=�������ʱ�ȭ �Ͻðڽ��ϱ�? Y/N:
if %ans%==N goto setting2
if %ans%==Y goto reset
if %ans%==n goto setting2
if %ans%==y goto reset


:1mi
cls
mode 100


echo %DATE% %TIME%:  1���� �̸����� �̵�>>C:\BATprogram\BAT.txt

echo.
echo ���α׷� ����:%vision%����ǻ�� ����:100 l ����:123
echo �Ȧ�����������������������������������������������������������������        
echo �� 1 : ���ͳ�(DNSĳ�� û��)  
echo ��-------------------------------------------------------------
echo ����������:��ǻ�͸� ������ �ð��Ŀ� �ڵ����� ���� �մϴ�.             
echo �� 2 : ���� ���� ���
echo �� 3 : 30�� ���� ����                                 
echo �� 4 : 1�ð� ���� ����
echo �� 5 : 1�ð� 30�� ���� ����            
echo �� 6 : 2�ð� ��������
echo �� 7 : 2�ð� 30�� ���� ����
echo �� 8 : 3�ð� ��������
echo �� 9 : 4�ð� ���� ����
echo ��-------------------------------------------------------------
echo ��10 : ������2 
echo ��11 : EXIT   l   12 : CMD����  l  13 : ������Ʈ ����
echo �Ʀ�����������������������������������������������������������������
pause 
goto checkgo
:main
cls
mode 100


echo %DATE% %TIME%:  �����̵�>>C:\BATprogram\BAT.txt

echo.
echo ���α׷� ����:%vision%����ǻ�� ����:100 l ����:123
echo �Ȧ�����������������������������������������������������������������        
echo �� 1 : ���ͳ�(DNSĳ�� û��) 
echo ��-------------------------------------------------------------
echo ����������:��ǻ�͸� ������ �ð��Ŀ� �ڵ����� ���� �մϴ�.             
echo �� 2 : ���� ���� ���
echo �� 3 : 30�� ���� ����                                 
echo �� 4 : 1�ð� ���� ����
echo �� 5 : 1�ð� 30�� ���� ����            
echo �� 6 : 2�ð� ��������
echo �� 7 : 2�ð� 30�� ���� ����
echo �� 8 : 3�ð� ��������
echo �� 9 : 4�ð� ���� ����
echo ��-------------------------------------------------------------
echo ��10 : ������2 
echo ��11 : EXIT   l   12 : CMD����  l  13 : ������Ʈ ����
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ �Ǵ� ���� �� �Է��ϼ���.:
if %a%==1 goto DNSr
if %a%==2 goto cancle
if %a%==3 goto 30
if %a%==4 goto 1h
if %a%==5 goto 1h3s
if %a%==6 goto 2h
if %a%==7 goto 2h3s
if %a%==8 goto 3h
if %a%==9 goto 4h
if %a%==10 goto page2
if %a%==11 goto EXIT
if %a%==12 goto CMDgo
if %a%==13 goto report
if %a%==100 goto shutdown
if %a%==log goto LOG1
if %a%==com goto Com
if %a%==Com goto Com
if %a%==color goto color
if %a%==123 goto setting

:reset
cls
echo 3
pause
echo 2
pause
echo 1
pause
if not exist "C:\batprogramreset" goto resetmake
cd C:\batprogramreset
echo %DATE% %TIME%:  ���α׷��� �ʱ�ȭ��>>C:\BATprogram\BAT.txt
reset.bat
goto EXIT


:resetmake
echo %DATE% %TIME%:  �ʱ�ȭ ��ġ���� �������>>C:\BATprogram\BAT.txt
echo �ʱ�ȭ��ġ���� �������.
echo. ��ø� ��ٷ� �ּ���.
cd C:\
md batprogramreset
echo @echo off>>C:\batprogramreset\reset.bat
echo echo ��ø���ٷ��ּ���>>C:\batprogramreset\reset.bat
echo timeout /t 3 > nul>>C:\batprogramreset\reset.bat
echo rd /s /q C:\batprogram>>C:\batprogramreset\reset.bat
echo echo �Ϸ�>>C:\batprogramreset\reset.bat
echo pause>>C:\batprogramreset\reset.bat
goto reset

:makemainset1
cls
echo %DATE% %TIME%:  ����1���������� �������>>C:\BATprogram\BAT.txt
echo ���������� �������.
cd C:\BATprogram\main
md main1
timeout /t 1 > nul
goto first



:makemainset2
cls
echo %DATE% %TIME%:  ����2���������� �������>>C:\BATprogram\BAT.txt
echo ���������� �������.
cd C:\BATprogram\main
md main2
timeout /t 1 > nul
goto first


:makemainset
cls
echo %DATE% %TIME%:  ���μ��������� �������>>C:\BATprogram\BAT.txt
echo ���μ��� �������
cd C:\BATprogram
md main
timeout /t 1 > nul
goto mainse


:makemainset22
cls
echo %DATE% %TIME%:  ���μ��������� �������>>C:\BATprogram\BAT.txt
echo ���μ��� �������
cd C:\BATprogram
md main
timeout /t 1 > nul
goto mainse2r

:color
cls
echo %DATE% %TIME%:  �ؽ�Ʈ �� �������� �̵�>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo �� �ؽ�Ʈ�� ����                  �ڷΰ���:110
echo ��-------------------------------------------------------------
echo �� 1:�⺻                        l 11:���� �ʷϻ�
echo �� 2:�Ķ���                      l 12:���� û�ϻ�
echo �� 3:�ʷϻ�                      l 13:���� ������
echo �� 4:û�ϻ�                      l 14:���� ���ֻ�
echo �� 5:������                      l 15:���� �����
echo �� 6:���ֻ�                      l 16:���� ���
echo �� 7:�����                      l 17:����� ����(���,����)
echo �� 8:���                        l 18:
echo �� 9:ȸ��                        l 19:
echo �� 10:���� �Ķ���                l 20:
echo ��                               l
echo ��
echo �Ʀ�����������������������������������������������������������������

set /p a=���Ͻô� ������ ������ �ּ���:
if %a%==1 goto color1
if %a%==2 goto color2
if %a%==3 goto color3
if %a%==4 goto color4
if %a%==5 goto color5
if %a%==6 goto color6
if %a%==7 goto color7
if %a%==8 goto color8
if %a%==9 goto color9
if %a%==10 goto color10
if %a%==11 goto color11
if %a%==12 goto color12
if %a%==13 goto color13
if %a%==14 goto color14
if %a%==15 goto color15
if %a%==16 goto color16
if %a%==110 goto lode1212
if %a%==17 goto color17

:color22
cls
echo %DATE% %TIME%:  �ؽ�Ʈ �� �������� �̵�>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo �� �ؽ�Ʈ�� ����                  �ڷΰ���:110
echo ��-------------------------------------------------------------
echo �� 1:�⺻                        l 11:���� �ʷϻ�
echo �� 2:�Ķ���                      l 12:���� û�ϻ�
echo �� 3:�ʷϻ�                      l 13:���� ������
echo �� 4:û�ϻ�                      l 14:���� ���ֻ�
echo �� 5:������                      l 15:���� �����
echo �� 6:���ֻ�                      l 16:���� ���
echo �� 7:�����                      l 17:����� ����(���,����)
echo �� 8:���                        l 18:
echo �� 9:ȸ��                        l 19:
echo �� 10:���� �Ķ���                l 20:
echo ��                               l
echo ��
echo �Ʀ�����������������������������������������������������������������

set /p a=���Ͻô� ������ ������ �ּ���:
if %a%==1 goto color1
if %a%==2 goto color2
if %a%==3 goto color3
if %a%==4 goto color4
if %a%==5 goto color5
if %a%==6 goto color6
if %a%==7 goto color7
if %a%==8 goto color8
if %a%==9 goto color9
if %a%==10 goto color10
if %a%==11 goto color11
if %a%==12 goto color12
if %a%==13 goto color13
if %a%==14 goto color14
if %a%==15 goto color15
if %a%==16 goto color16
if %a%==110 goto lode1212
if %a%==17 goto color17




:color1
cls
color b
echo %DATE% %TIME%:  �ؽ�Ʈ���� �⺻ ���� ����>>C:\BATprogram\BAT.txt
goto color

:color2
cls
color 1
echo %DATE% %TIME%:  �ؽ�Ʈ���� �Ķ��� ���� ����>>C:\BATprogram\BAT.txt
goto color

:color3
cls
color 2
echo %DATE% %TIME%:  �ؽ�Ʈ���� �ʷϻ� ���� ����>>C:\BATprogram\BAT.txt
goto color

:color4
cls
color 3
echo %DATE% %TIME%:  �ؽ�Ʈ���� �������� ����>>C:\BATprogram\BAT.txt
goto color

:color5
cls
echo %DATE% %TIME%:  �ؽ�Ʈ���� ���������� ����>>C:\BATprogram\BAT.txt
color 4

goto color

:color6
cls
color 5
echo %DATE% %TIME%:  �ؽ�Ʈ���� ���ֻ����� ����>>C:\BATprogram\BAT.txt
goto color

:color7
cls
color 6
echo %DATE% %TIME%:  �ؽ�Ʈ���� ��������� ����>>C:\BATprogram\BAT.txt
goto color

:color8
cls
color 7
echo %DATE% %TIME%:  �ؽ�Ʈ���� ������� ����>>C:\BATprogram\BAT.txt
goto color

:color9
cls
color 8
echo %DATE% %TIME%:  �ؽ�Ʈ���� ȸ������ ����>>C:\BATprogram\BAT.txt
goto color

:color10
cls
color 9
echo %DATE% %TIME%:  �ؽ�Ʈ���� ���� �Ķ������� ����>>C:\BATprogram\BAT.txt
goto color

:color11
cls
color A
echo %DATE% %TIME%:  �ؽ�Ʈ���� ���� �ʷϻ����� ����>>C:\BATprogram\BAT.txt
goto color

:color12
cls
color B
echo %DATE% %TIME%:  �ؽ�Ʈ���� ���� û�ϻ����� ����>>C:\BATprogram\BAT.txt
goto color

:color13
cls
color C
echo %DATE% %TIME%:  �ؽ�Ʈ���� ���� ���������� ����>>C:\BATprogram\BAT.txt
goto color

:color14
cls
color D
echo %DATE% %TIME%:  �ؽ�Ʈ���� ���� ���ֻ����� ����>>C:\BATprogram\BAT.txt
goto color

:color15
cls
color E
echo %DATE% %TIME%:  �ؽ�Ʈ���� ���� ��������� ����>>C:\BATprogram\BAT.txt
goto color

:color16
cls
color F
echo %DATE% %TIME%:  �ؽ�Ʈ���� ���� ������� ����>>C:\BATprogram\BAT.txt
goto color

:color17
cls
echo �����ڵ���ڻ��ڵ� ex)07
set /p a=���ϴ� ����� ���ڵ带 �Է��ϼ���:
set /p b=���ϴ� ������ ���ڵ带 �Է��ϼ���:
color %a%%b%
echo %DATE% %TIME%:  ����:%a% �ؽ�Ʈ��:%b% ���� ����>>C:\BATprogram\BAT.txt
goto color





:Com
cls
echo %DATE% %TIME%:  ��ɾ� ���̱�/�� ���̱�>>C:\BATprogram\BAT.txt
echo ��ɾ� ���̱�:1
echo ��ɾ� �� ���̰�:2
echo �ڷΰ��� : 11
set /p a=���Ͻô� ����� �����ϼ���:
if %a%==1 goto comon
if %a%==2 goto comoff
if %a$==11 goto setting

:Com2
cls
echo %DATE% %TIME%:  ��ɾ� ���̱�/�� ���̱�>>C:\BATprogram\BAT.txt
echo ��ɾ� ���̱�:1
echo ��ɾ� �� ���̰�:2
echo �ڷΰ��� : 11
set /p a=���Ͻô� ����� �����ϼ���:
if %a%==1 goto comon2
if %a%==2 goto comoff2
if %a$==11 goto setting2


:comoff
cls
echo %DATE% %TIME%:  ��ɾ� �� ���̱�>>C:\BATprogram\BAT.txt
@echo off
echo �Ϸ�
pause
goto setting

:comoff2
cls
echo %DATE% %TIME%:  ��ɾ� �� ���̱�>>C:\BATprogram\BAT.txt
@echo off
echo �Ϸ�
pause
goto setting2

:comon
cls
echo %DATE% %TIME%:  ��ɾ� ���̱�>>C:\BATprogram\BAT.txt
@echo on
echo �Ϸ�
pause
goto setting2

:comon2
cls
echo %DATE% %TIME%:  ��ɾ� ���̱�>>C:\BATprogram\BAT.txt
@echo on
echo �Ϸ�
pause
goto setting2

:LOG1
cls 
echo %DATE% %TIME%:  �α� ���>>C:\BATprogram\BAT.txt
echo �α����� �ʱ�ȭ : 1
echo �α����� ���� : 2
echo �ڷΰ��� : 11
set /p a=���Ͻô� ��ȣ�� �Է��ϼ���:
if %a%==1 goto delLOG
if %a%==2 goto LOGopen
if %a%==11 goto setting


:LOG2
cls 
echo %DATE% %TIME%:  �α� ���>>C:\BATprogram\BAT.txt
echo �α����� �ʱ�ȭ : 1
echo �α����� ���� : 2
echo �ڷΰ��� : 11
set /p a=���Ͻô� ��ȣ�� �Է��ϼ���:
if %a%==1 goto delLOG2
if %a%==2 goto LOGopen2
if %a%==11 goto setting2


:LOGopen
cls
echo %DATE% %TIME%:  �α����� open>>C:\BATprogram\BAT.txt
cd C:\BATprogram
start BAT.txt
goto LOG1

:LOGopen
cls
echo %DATE% %TIME%:  �α����� open>>C:\BATprogram\BAT.txt
cd C:\BATprogram
start BAT.txt
goto LOG2

:delLOG
cls
color c
set /p a=�α������� �ʱ�ȭ ��Ű�� ���ϱ�? y/n:
if %a%==y goto delLOG3
if %a%==n goto LOG1

color b

:delLOG2
cls
color c
set /p a=�α������� �ʱ�ȭ ��Ű�� ���ϱ�? y/n:
if %a%==y goto delLOG4
if %a%==n goto LOG2

color b

:delLOG3

cls
echo %DATE% %TIME%:  �α��ʱ�ȭ>C:\BATprogram\BAT.txt
echo �Ϸ�
pause
goto LOG1

:delLOG4

cls
echo %DATE% %TIME%:  �α��ʱ�ȭ>C:\BATprogram\BAT.txt
echo �Ϸ�
pause
goto LOG2






:report
cls
echo %DATE% %TIME%:  ������Ʈ �������� �̵�>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo �� %vision%���� ������Ʈ
echo ��-------------------------------------------------------------
echo �� 1.��� ���� ��ġ                  
echo �� 2.
echo �� 3.
echo �� 4.
echo �� 5.       
echo �� 6.
echo �� 7.
echo �� 8.
echo �� 9.
echo �� 10.
echo �� 11.
echo ��
echo �Ʀ�����������������������������������������������������������������

pause
goto lode1212



:CMDgo
echo %DATE% %TIME%:  CMD����>>C:\BATprogram\BAT.txt
start
goto main

:DNSr
echo %DATE% %TIME%:  ���ͳ� ����ȭ (DNSĳ�� �ʱ�ȭ)�� �Ұ��ΰ�? ���Ұ� �ΰ�?>>C:\BATprogram\BAT.txt
cls
echo DNSĳ�������� û���Ͽ� ���ͳ� �ӵ��� ����ŵ�ϴ�.
echo ����Ͻ÷��� y,����Ͻ÷���n �� �Է��� �ּ���.
set /p a=���ϴ� ����� �Է��ϼ���.:
if %a%==n goto main
if %a%==y goto DNS

:DNS

cls
echo.
echo �����α׷��� DNSĳ�� û�� ��ɾ� Ȱ�� cmd�Դϴ� 
echo �������� �߻��ҽ� �����ڿʹ� ����� �����ϴ�. 
echo �����Ͻǲ��� �ƹ�Ű�����缼��...
pause
echo %DATE% %TIME%:  DNSĳ�� û�Ҹ� �����ϼ˽��ϴ�.>>C:\BATprogram\BAT.txt
color 0c
cls
ipconfig/displaydns
ipconfig/flushdns
echo.
echo.
echo û�ҿϷ�.�ƹ�Ű�� ����ÿ� ...
pause
goto main

:cancle
cls
echo %DATE% %TIME%:  �������� ���>>C:\BATprogram\BAT.txt
shutdown -a
echo �������� ��ҿϷ�
pause
cls
goto main

:30
cls
echo %DATE% %TIME%:  30�� ��������>>C:\BATprogram\BAT.txt
shutdown -s -t 1800
echo 30���� ���� ���� �Ϸ�
pause
cls
goto main

:1h
cls
echo %DATE% %TIME%:  1�ð� ��������>>C:\BATprogram\BAT.txt
shutdown -s -t 3600
echo 1�ð��� ���� ���� �Ϸ�
pause
cls
goto main

:1h3s
cls
echo %DATE% %TIME%:  1�ð�30�� ��������>>C:\BATprogram\BAT.txt
shutdown -s -t 5400
echo 1�ð�30���� ���� ���� �Ϸ�
pause
cls
goto main

:2h
cls
echo %DATE% %TIME%:  2�ð� ��������>>C:\BATprogram\BAT.txt
shutdown -s -t 7200
echo 2�ð��� ���� ���� �Ϸ�
pause
cls
goto main

:2h3s
cls
echo %DATE% %TIME%:  2�ð�30�� ��������>>C:\BATprogram\BAT.txt
shutdown -s -t 9000
echo 2�ð�30���� ���� ���� �Ϸ�
pause
cls
goto main


:3h
cls
echo %DATE% %TIME%:  3�ð� ��������>>C:\BATprogram\BAT.txt
shutdown -s -t 10800
echo 3�ð��� ���� ���� �Ϸ�
pause
cls
goto main


:4h
cls
echo %DATE% %TIME%:  4�ð� ��������>>C:\BATprogram\BAT.txt
shutdown -s -t 14400
echo 4�ð��� ���� ���� �Ϸ�
pause
cls
goto main

:page2
cls 
echo %DATE% %TIME%:  ������2 ����>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������
echo �� ������ 2
echo �Ʀ�����������������������������������������������������������������
echo �Ȧ�����������������������������������������������������������������        
echo ��                                                             
echo �� 1 : ���� �޴��� 
echo �� 2 : �׽�Ʈ ���     
echo �� 3 : �׷�
echo �� 4 : ���α׷� ����                              
echo �� 5 : CMD��ɾ��
echo �� 6 : �����ڰ� �ɽ��ؼ� ����͵�
echo �� 7 : �� ����/�α׿���/���� ���
echo �� 8 : ���ͳ� ����Ʈ ����
echo �� 9 : ping �׽�Ʈ (���)
echo �� 10 : ��ǻ�� ����
echo �� 11 : ��ġ���ϸ����
echo �Ʀ�����������������������������������������������������������������        
echo �Ȧ�����������������������������������������������������������������
echo �� ����������:12
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto lode1212
if %a%==2 goto TEST
if %a%==3 goto Tr
if %a%==4 goto programs
if %a%==5 goto CMDms
if %a%==6 goto simsim
if %a%==7 goto shut
if %a%==8 goto innet
if %a%==9 goto ping
if %a%==10 goto erro
if %a%==11 goto batmaker 
if %a%==12 goto page3
if %a%==43 goto RE

:page3
cls 
echo %DATE% %TIME%:  ������3 ����>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������
echo �� ������ 3 
echo �Ʀ�����������������������������������������������������������������
echo �Ȧ�����������������������������������������������������������������        
echo ��                                                             
echo �� 1 : �ڷΰ���
echo �� 2 : ����     
echo �� 3 : 
echo �� 4 :                             
echo �� 5 : 
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo �� 9 : 
echo �� 10 : 
echo �� 11 : 
echo �Ʀ�����������������������������������������������������������������        

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto page2
if %a%==2 goto plus
if %a%==3 goto 
if %a%==4 goto
if %a%==5 goto
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto
if %a%==10 goto 
if %a%==11 goto 
if %a%==12 goto 
if %a%==43 goto RE


:plus
cls
echo %DATE% %TIME%:  ���� ����>>C:\BATprogram\BAT.txt
echo ���ڸ� �Է��� �ּ���. (2��)X    (2)o
set /p ch=�� ��� ���Ͻ� �ǰ���?(2~10):
if %ch%==2 goto plus2
if %ch%==3 goto plus3
if %ch%==4 goto plus4
if %ch%==5 goto plus5
if %ch%==6 goto plus6
if %ch%==7 goto plus7
if %ch%==8 goto plus8
if %ch%==9 goto plus9
if %ch%==10 goto plus10
echo %DATE% %TIME%:  ����%ch%�� ����>>C:\BATprogram\BAT.txt


:plus2
cls
echo %DATE% %TIME%:  ����%ch%�� ����>>C:\BATprogram\BAT.txt
set /p a1=ù��°�� ���� ���� �Է��ϼ���:
set /p a2=�ι�°�� ���� ���� �Է��ϼ���:
set /a answ=a1+a2
echo.
echo %a1% + %a2% = %answ%
echo %DATE% %TIME%: %a1% + %a2% = %answ% ���>>C:\BATprogram\BAT.txt
pause
goto page3

:plus3
cls
echo %DATE% %TIME%:  ����%ch%�� ����>>C:\BATprogram\BAT.txt
set /p a1=ù��°�� ���� ���� �Է��ϼ���:
set /p a2=�ι�°�� ���� ���� �Է��ϼ���:
set /p a3=����°�� ���� ���� �Է��ϼ���:
set /a answ=a1+a2+a3
echo.
echo %a1% + %a2% +%a3% = %answ%
echo %DATE% %TIME%: %a1% + %a2% +%a3% = %answ% ���>>C:\BATprogram\BAT.txt
pause
goto page3

:plus4
cls
echo %DATE% %TIME%:  ����%ch%�� ����>>C:\BATprogram\BAT.txt
set /p a1=ù��°�� ���� ���� �Է��ϼ���:
set /p a2=�ι�°�� ���� ���� �Է��ϼ���:
set /p a3=����°�� ���� ���� �Է��ϼ���:
set /p a4=�׹�°�� ���� ���� �Է��ϼ���:
set /a answ=a1+a2+a3+a4
echo.
echo %a1% + %a2% + %a3% + %a4%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4%= %answ% ���>>C:\BATprogram\BAT.txt
pause
goto page3

:plus5
cls
echo %DATE% %TIME%:  ����%ch%�� ����>>C:\BATprogram\BAT.txt
set /p a1=ù��°�� ���� ���� �Է��ϼ���:
set /p a2=�ι�°�� ���� ���� �Է��ϼ���:
set /p a3=����°�� ���� ���� �Է��ϼ���:
set /p a4=�׹�°�� ���� ���� �Է��ϼ���:
set /p a5=�ټ���°�� ���� ���� �Է��ϼ���:
set /a answ=a1+a2+a3+a4+a5
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5%= %answ% ���>>C:\BATprogram\BAT.txt
pause
goto page3


:plus6
cls
echo %DATE% %TIME%:  ����%ch%�� ����>>C:\BATprogram\BAT.txt
set /p a1=ù��°�� ���� ���� �Է��ϼ���:
set /p a2=�ι�°�� ���� ���� �Է��ϼ���:
set /p a3=����°�� ���� ���� �Է��ϼ���:
set /p a4=�׹�°�� ���� ���� �Է��ϼ���:
set /p a5=�ټ���°�� ���� ���� �Է��ϼ���:
set /p a6=������°�� ���� ���� �Է��ϼ���:
set /a answ=a1+a2+a3+a4+a5+a6
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5% + %a6%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5% + %a6%= %answ% ���>>C:\BATprogram\BAT.txt
pause
goto page3

:plus7
cls
echo %DATE% %TIME%:  ����%ch%�� ����>>C:\BATprogram\BAT.txt
set /p a1=ù��°�� ���� ���� �Է��ϼ���:
set /p a2=�ι�°�� ���� ���� �Է��ϼ���:
set /p a3=����°�� ���� ���� �Է��ϼ���:
set /p a4=�׹�°�� ���� ���� �Է��ϼ���:
set /p a5=�ټ���°�� ���� ���� �Է��ϼ���:
set /p a6=������°�� ���� ���� �Է��ϼ���:
set /p a7=�ϰ���°�� ���� ���� �Է��ϼ���:
set /a answ=a1+a2+a3+a4+a5+a6+a7
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7%= %answ% ���>>C:\BATprogram\BAT.txt
pause
goto page3

:plus8
cls
echo %DATE% %TIME%:  ����%ch%�� ����>>C:\BATprogram\BAT.txt
set /p a1=ù��°�� ���� ���� �Է��ϼ���:
set /p a2=�ι�°�� ���� ���� �Է��ϼ���:
set /p a3=����°�� ���� ���� �Է��ϼ���:
set /p a4=�׹�°�� ���� ���� �Է��ϼ���:
set /p a5=�ټ���°�� ���� ���� �Է��ϼ���:
set /p a6=������°�� ���� ���� �Է��ϼ���:
set /p a7=�ϰ���°�� ���� ���� �Է��ϼ���:
set /p a8=������°�� ���� ���� �Է��ϼ���:
set /a answ=a1+a2+a3+a4+a5+a6+a7+a8
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8%= %answ% ���>>C:\BATprogram\BAT.txt
pause
goto page3


:plus9
cls
echo %DATE% %TIME%:  ����%ch%�� ����>>C:\BATprogram\BAT.txt
set /p a1=ù��°�� ���� ���� �Է��ϼ���:
set /p a2=�ι�°�� ���� ���� �Է��ϼ���:
set /p a3=����°�� ���� ���� �Է��ϼ���:
set /p a4=�׹�°�� ���� ���� �Է��ϼ���:
set /p a5=�ټ���°�� ���� ���� �Է��ϼ���:
set /p a6=������°�� ���� ���� �Է��ϼ���:
set /p a7=�ϰ���°�� ���� ���� �Է��ϼ���:
set /p a8=������°�� ���� ���� �Է��ϼ���:
set /p a9=��ȩ��°�� ���� ���� �Է��ϼ���:
set /a answ=a1+a2+a3+a4+a5+a6+a7+a8+a9
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8% + %a9%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8% + %a9%= %answ% ���>>C:\BATprogram\BAT.txt
pause
goto page3

:plus10
cls
echo %DATE% %TIME%:  ����%ch%�� ����>>C:\BATprogram\BAT.txt
set /p a1=ù��°�� ���� ���� �Է��ϼ���:
set /p a2=�ι�°�� ���� ���� �Է��ϼ���:
set /p a3=����°�� ���� ���� �Է��ϼ���:
set /p a4=�׹�°�� ���� ���� �Է��ϼ���:
set /p a5=�ټ���°�� ���� ���� �Է��ϼ���:
set /p a6=������°�� ���� ���� �Է��ϼ���:
set /p a7=�ϰ���°�� ���� ���� �Է��ϼ���:
set /p a8=������°�� ���� ���� �Է��ϼ���:
set /p a9=��ȩ��°�� ���� ���� �Է��ϼ���:
set /p a10=����°�� ���� ���� �Է��ϼ���:
set /a answ=a1+a2+a3+a4+a5+a6+a7+a8+a9+a10
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8% + %a9% + %a10%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8% + %a9% + %a10%= %answ% ���>>C:\BATprogram\BAT.txt
pause
goto page3


:batmaker
cls
echo ����ڰ� ����� ���� �������
echo ��ġ ������ �ۼ��մϴ�.
pause
if not exist C:\BATprogram\batmaker goto batmaker1
if exist C:\BATprogram\batmaker goto batmaker2

:batmaker1
echo %DATE% %TIME%:  ��ġ���� ����>>C:\BATprogram\BAT.txt
echo ��ġ������ �����մϴ�.
cd C:\BATprogram
md batmaker
echo @echo off>>C:\BATprogram\batmaker\BATmaker.bat
echo :main>>C:\BATprogram\batmaker\BATmaker.bat
pause
goto batmaker

:batmaker2
cls
echo ���� ��ġ������ Ȯ���߽��ϴ�.
echo.
pause
goto batmaker3

:batmaker3
cls
echo %DATE% %TIME%:  ��ġ���� ����� ����>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : �ڷΰ���
echo �� 2 : �������� �ϱ�(echo)    
echo �� 3 : ����Ϸ��� �ƹ�Ű�� ����ÿ�(pause)
echo �� 4 : �����ٷ�(echo.)                              
echo �� 5 : ���
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo �� 9 : 
echo �� 10 : 
echo �� 11 : ��ġ���� �����ϱ�
echo ��
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto page2
if %a%==2 goto echo
if %a%==3 goto pause
if %a%==4 goto echo.
if %a%==5 goto command
if %a%==6 goto simsim
if %a%==7 goto shut
if %a%==8 goto innet
if %a%==9 goto ping
if %a%==10 goto minecraft
if %a%==11 goto startbat 
if %a%==43 goto RE


:command
cls
set /p comm=���ϴ� ����� ��������:
echo echo %comm%>>C:\BATprogram\batmaker\BATmaker.bat

cls
echo ������� Ȯ���ϼ���!
cd C:\BATprogram\batmaker
call BATmaker.bat
echo %DATE% %TIME%:  ��ġ���Ͽ� ��ɾ�%comm%��(��) �ۼ� >>C:\BATprogram\BAT.txt
pause
goto batmaker3


:echo.
cls
echo echo.>>C:\BATprogram\batmaker\BATmaker.bat
echo �����
cd C:\BATprogram\batmaker
call BATmaker.bat
echo %DATE% %TIME%:  ��ġ���Ͽ� echo. �� �ۼ� >>C:\BATprogram\BAT.txt
pause
goto batmaker3

:startbat
cls
cd C:\BATprogram\batmaker
call BATmaker.bat
pause 
goto batmaker3

:echo
cls
set /p c=���ϴ� ���� ��������:
echo echo %c%>>C:\BATprogram\batmaker\BATmaker.bat
echo �Ϸ� !

echo %DATE% %TIME%:  ��ġ���Ͽ� %c% ��� �޼����� ����>>C:\BATprogram\BAT.txt

echo �����
cd C:\BATprogram\batmaker
call BATmaker.bat

pause
goto batmaker3

:pause
cls
echo pause>>C:\BATprogram\batmaker\BATmaker.bat
echo �����
cd C:\BATprogram\batmaker
call BATmaker.bat
echo %DATE% %TIME%:  ��ġ���Ͽ� pause �� �ۼ� >>C:\BATprogram\BAT.txt
pause
goto batmaker3

:erro
cls 
echo %DATE% %TIME%:  ��ǻ�� ���� ��� ����>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : �ĺ����� �ʴ� ��Ʈ��ũ(�ڵ� ����)
echo �� 2 :      
echo �� 3 : 
echo �� 4 :                               
echo �� 5 : 
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo �� 9 : 
echo ��
echo ��
echo ���ڷΰ���:11
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto netknow
if %a%==2 goto 
if %a%==3 goto 
if %a%==4 goto 
if %a%==5 goto 
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto page2 
if %a%==43 goto RE


:netknow
cls
set /p a=�����Ϸ��� y �ڷΰ�����n:
if a==n goto erro
if a==y goto netknowgo


:netknowgo
cls
ipconfig /release
ipconfig /renew
netsh winsock reset
netsh int ip reset
ipconfig /flushdns
ipconfig /registerdns
netsh int tcp set heuristics disabled
netsh int tcp set global autotuninglevel=disabled
netsh int tcp set global rss=enabled
netsh int tcp show global

pause
cls
echo �Ϸ� �Ǿ����ϴ�.
pause
goto erro


cd C:\Users\XNOTE\AppData\Roaming\.minecraft
pkzip -rp BACUP
oause
echo �Ϸ�!

:ping
echo %DATE% %TIME%:  ping �׽�Ʈ ����or�ڷΰ���>>C:\BATprogram\BAT.txt
cls
echo ���� ȭ�鿡�� ������ 
echo '�⺻ ����Ʈ����' �� �ܿ��ּ���
set /p a=����ϱ�:y �׸��ϱ�:n  :
if %a%==y goto pingtest
if %a%==n goto page2

:pingtest
cls
echo %DATE% %TIME%:  ping�׽�Ʈ ����>>C:\BATprogram\BAT.txt
echo ���� ȭ�鿡�� ������ 
echo '�⺻ ����Ʈ����' �� �ܿ��ּ���.ex)192.116.5.9
pause
ipconfig
echo.
echo.
echo.
echo.
echo.
echo '�⺻ ����Ʈ����'�� �ܿ��ּ���ex)192.116.5.9
pause
start
echo �� cmd â���� ping -t �ܿ� ������ �ּ� �� �Է��� �ּ���.
echo ����: ping -t 192.845.54.8
pause
echo %DATE% %TIME%:  ping�׽�Ʈ ���� �Ϸ�>>C:\BATprogram\BAT.txt
goto page2



:innet
echo %DATE% %TIME%:  ����Ʈ ��� ����>>C:\BATprogram\BAT.txt
cls
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : ���̹�
echo �� 2 : ����
echo �� 3 : ����Ʈ
echo �� 4 : ����                              
echo �� 5 : ��ӹڽ�
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo ��
echo ��
echo ��
echo ������������:22                                    �ڷΰ���:11
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto naver
if %a%==2 goto daum
if %a%==3 goto nate
if %a%==4 goto google
if %a%==5 goto dropbox
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto page2
if %a%==22 goto innet2


:innet2
echo %DATE% %TIME%:  ����Ʈ ��� 2��° ������ ����>>C:\BATprogram\BAT.txt
cls
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : ��۱� ����Ʈ
echo �� 2 : �ؿ� ����Ʈ
echo �� 3 : 
echo �� 4 :                           
echo �� 5 : 
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo ��
echo ��
echo ��
echo ������������:22                                   �ڷΰ���:11
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto bcs
if %a%==2 goto hs
if %a%==3 goto 
if %a%==4 goto 
if %a%==5 goto 
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto innet
if %a%==22 goto innet3


:bcs
cls
echo %DATE% %TIME%:  ��۱� ����Ʈ ��� ����>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : ���� ��۱� ����Ʈ
echo �� 2 : �ؿ� ��۱� ����Ʈ
echo �� 3 : �ڷΰ���
echo �� 4 :                           
echo �� 5 : 
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo ��
echo ��
echo ��
echo ���ڷΰ���:22
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto koreabcs
if %a%==2 goto hbcs
if %a%==3 goto innet2
if %a%==4 goto 
if %a%==5 goto 
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto innet2
if %a%==22 goto 


:koreabcs
cls
echo %DATE% %TIME%:  �ѱ� ��۱� ����Ʈ ��� ����>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : KBS
echo �� 2 : MBS
echo �� 3 : SBS
echo �� 4 : YTN                        
echo �� 5 : JTBC
echo �� 6 : tvN
echo �� 7 : MBN
echo �� 8 : ä��A
echo �� 9 : TV����
echo �� 10 : ���մ���
echo ��
echo �� �ڷΰ���:11 ����������:�غ���  
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto KBS
if %a%==2 goto MBC
if %a%==3 goto SBS
if %a%==4 goto YTN
if %a%==5 goto JTBC
if %a%==6 goto Tvn
if %a%==7 goto MBN
if %a%==8 goto chA
if %a%==9 goto TVz
if %a%==10 goto dgnews
if %a%==11 goto bcs
if %a%==22 goto 


:dgnews
cls
echo %DATE% %TIME%:  ���մ��� ����Ʈ ����>>C:\BATprogram\BAT.txt
start www.yonhapnews.co.kr
goto koreabcs

:TVz
cls
echo %DATE% %TIME%:  TV���� ����Ʈ ����>>C:\BATprogram\BAT.txt
start www.tvchosun.com
goto koreabcs

:chA
cls
echo %DATE% %TIME%:  ä��A ����Ʈ ����>>C:\BATprogram\BAT.txt
start m.ichannela.com
goto koreabcs


:MBN
cls
echo %DATE% %TIME%:  MBN ����Ʈ ����>>C:\BATprogram\BAT.txt
start mbn.mk.co.kr
goto koreabcs

:tvN
cls
echo %DATE% %TIME%:  Tvn ����Ʈ ����>>C:\BATprogram\BAT.txt
start tvn.tving.com
goto koreabcs

:JTBC
cls
start onair.jtbc.joins.com
echo %DATE% %TIME%:  JTBC ����Ʈ ����>>C:\BATprogram\BAT.txt
goto koreabcs

:YTN
cls
start http://www.ytn.co.kr/
echo %DATE% %TIME%:  YTN ����Ʈ ����>>C:\BATprogram\BAT.txt
goto koreabcs

:SBS
cls
start www.sbs.co.kr
echo %DATE% %TIME%:  SBS ����Ʈ ����>>C:\BATprogram\BAT.txt
goto koreabcs

:MBC
cls
start www.imbc.com
echo %DATE% %TIME%:  MBC ����Ʈ ����>>C:\BATprogram\BAT.txt
goto koreabcs

:hbcs
cls
echo %DATE% %TIME%:  �ؿ� ��۱� ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : CNN
echo �� 2 : BBC
echo �� 3 : �Ϻ� ��۱�
echo �� 4 : �߱� ��۱�                      
echo �� 5 : �̱� ��۱�
echo �� 6 : ĳ���� ��۱�
echo �� 7 : ȣ�� ��۱�
echo �� 8 : Ÿ�̿� ��۱�
echo ��
echo ��
echo ��
echo �� �ڷΰ���:11 ����������:�غ���  
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto CNN
if %a%==2 goto BBC
if %a%==3 goto jpan
if %a%==4 goto ch
if %a%==5 goto usa
if %a%==6 goto ca
if %a%==7 goto hz
if %a%==8 goto hk
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto bcs
if %a%==22 goto 


:hk
cls
echo %DATE% %TIME%:  Ÿ�̿� ��۱� ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : TTV
echo �� 2 : CTV
echo �� 3 : CTS
echo �� 4 : FTV                     
echo �� 5 : PTS
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo ��
echo ��
echo ��
echo �� �ڷΰ���:11 ����������:�غ���  ����:��Ű���
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto TTV
if %a%==2 goto CTV
if %a%==3 goto CTS
if %a%==4 goto FTV
if %a%==5 goto PTS
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto hbcs
if %a%==22 goto 


:TTV
echo %DATE% %TIME%:  TTV ����Ʈ ����>>C:\BATprogram\BAT.txt
cls
start http://www.ttv.com.tw/
goto hk

:CTV
cls
start http://beta.ctv.com.tw/
echo %DATE% %TIME%:  CTV ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hk

:CTS
cls
start http://www.cts.com.tw/
echo %DATE% %TIME%:  CTS ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hk

:FTV
cls
start http://www.ftv.com.tw/index.aspx
echo %DATE% %TIME%:  FTV ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hk

:PTS
cls
start http://www.pts.org.tw/
echo %DATE% %TIME%:  PTS ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hk

:jpan
cls
echo %DATE% %TIME%:  �Ϻ� ��۱� ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : NHK �����ڷ�����
echo �� 2 : NTV ���� TV ��۸�
echo �� 3 : ������
echo �� 4 : TV�ƻ���                 
echo �� 5 : ����TV
echo �� 6 : TV����
echo �� 7 : ���� ��Ʈ������ź �ڷ�����
echo �� 8 : 
echo ��
echo ��
echo ��
echo �� �ڷΰ���:11 ����������:�غ���  ����:��Ű���
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto NHK
if %a%==2 goto NTV
if %a%==3 goto TBS
if %a%==4 goto ANB
if %a%==5 goto hz
if %a%==6 goto dk
if %a%==7 goto dm
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto hbcs
if %a%==22 goto 


:hz
cls
echo %DATE% %TIME%:  ���� ����Ʈ ����>>C:\BATprogram\BAT.txt
start http://www.fujitv.co.jp/index.html
goto jpan

:dk
cls
start http://www.tv-tokyo.co.jp/
echo %DATE% %TIME%:  ���� ����Ʈ ����>>C:\BATprogram\BAT.txt
goto jpan

:dm
cls
start http://s.mxtv.jp/
echo %DATE% %TIME%:  ���� ��Ʈ�� ����ź �ڷ����� ����Ʈ ����>>C:\BATprogram\BAT.txt
goto jpan

:ch
cls
echo %DATE% %TIME%:  �߱� ��۱� ����Ʈ ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : CCTV
echo �� 2 : CETV
echo �� 3 : BTV
echo �� 4 : TJTV                     
echo �� 5 : SMG
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo ��
echo ��
echo �� 
echo �� �ڷΰ���:11 ����������:�غ���  ����:��Ű���
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto CCTV
if %a%==2 goto CETV
if %a%==3 goto BTY
if %a%==4 goto TJTY
if %a%==5 goto SMG
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto hbcs
if %a%==22 goto 


:CCTV
cls
start http://www.cctv.com/
echo %DATE% %TIME%:  CCTV(��۱�) ����Ʈ ����>>C:\BATprogram\BAT.txt
goto ch

:CETV
cls
start http://www.cetv.edu.cn/
echo %DATE% %TIME%:  CETV ����Ʈ ����>>C:\BATprogram\BAT.txt
goto ch

:BTY
cls
start http://www.btime.com/btv/btvsy_index
echo %DATE% %TIME%:  BTY ����Ʈ ����>>C:\BATprogram\BAT.txt
goto ch

:TJTY
cls
start http://tjtv.enorth.com.cn/
echo %DATE% %TIME%:  TJTY ����Ʈ ����>>C:\BATprogram\BAT.txt
goto ch

:SMG
cls
start http://www.smg.cn/
echo %DATE% %TIME%:  SMG ����Ʈ ����>>C:\BATprogram\BAT.txt
goto ch

:usa
cls
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : ABC
echo �� 2 : CBS
echo �� 3 : The CW
echo �� 4 : PBS                  
echo �� 5 : 
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo ��
echo ��
echo ��
echo �� �ڷΰ���:11 ����������:�غ���  ����:��Ű���
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto ABC
if %a%==2 goto CBS
if %a%==3 goto CW
if %a%==4 goto PBS
if %a%==5 goto 
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto hbcs
if %a%==22 goto 


:ABC
cls
start http://abc.go.com/
echo %DATE% %TIME%:  ABC����Ʈ ����>>C:\BATprogram\BAT.txt
goto usa

:CBS
cls
start http://www.cbs.com/
echo %DATE% %TIME%:  CBS ����Ʈ ����>>C:\BATprogram\BAT.txt
goto usa 

:CW
cls
start http://www.cwtv.com/
echo %DATE% %TIME%:  CW ����Ʈ ����>>C:\BATprogram\BAT.txt
goto usa

:PBS
cls
start http://www.pbs.org/
echo %DATE% %TIME%:  PBS ����Ʈ ����>>C:\BATprogram\BAT.txt
goto usa

:ca
cls
echo %DATE% %TIME%:  ĳ���� ��۱� ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : CBC
echo �� 2 : SRC
echo �� 3 : CTV
echo �� 4 :                         
echo �� 5 : 
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo ��
echo ��
echo ��
echo �� �ڷΰ���:11 ����������:�غ���  ����:��Ű���
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto CBC
if %a%==2 goto SRC
if %a%==3 goto CTV
if %a%==4 goto 
if %a%==5 goto 
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto hbcs
if %a%==22 goto 


:CBC
cls
start http://www.cbc.ca/television/
echo %DATE% %TIME%:  CBC ����Ʈ ����>>C:\BATprogram\BAT.txt
goto ca

:SRC
cls
start http://ici.radio-canada.ca/television/
echo %DATE% %TIME%:  SRC ����Ʈ ����>>C:\BATprogram\BAT.txt
goto ca

:CTV
cls
start http://www.ctv.ca/
echo %DATE% %TIME%:  CTV ����Ʈ ����>>C:\BATprogram\BAT.txt
goto ca


:hz
cls
echo %DATE% %TIME%:  ȣ�� ��۱� ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : ABC TV
echo �� 2 : SBS TV
echo �� 3 : 
echo �� 4 :                         
echo �� 5 : 
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo ��
echo ��
echo ��
echo �� �ڷΰ���:11 ����������:�غ���  ����:��Ű���
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto ABCTV
if %a%==2 goto SBSTV
if %a%==3 goto 
if %a%==4 goto 
if %a%==5 goto 
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto hbcs
if %a%==22 goto 


:ABCTV
cls
start http://www.abc.net.au/
echo %DATE% %TIME%:  ABC(ȣ��) ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hz


:SBSTV
cls
start http://www.sbs.com.au/
echo %DATE% %TIME%:  SBS(ȣ��) ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hz


:ANB
cls
start http://www.tv-asahi.co.jp/
echo %DATE% %TIME%:  ANB ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hbcs

:TBS
cls
start http://www.tbs.co.jp/
echo %DATE% %TIME%:  TBS ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hbcs

:NTV
cls
start http://www.ntv.co.jp/
echo %DATE% %TIME%:  NTV ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hbcs

:NHK
cls
start http://www.nhk.or.jp
echo %DATE% %TIME%:  NHK ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hbcs

:BBC
cls
start www.bbc.co.uk
echo %DATE% %TIME%:  BBC ����Ʈ ����>>C:\BATprogram\BAT.txt
goto hbcs

:CNN
cls
start www.cnn.com
echo %DATE% %TIME%:  CNN����Ʈ ����>>C:\BATprogram\BAT.txt
goto hbcs


:KBS
cls
start http://www.kbs.co.kr/
echo %DATE% %TIME%:  KBS ����Ʈ ����>>C:\BATprogram\BAT.txt
goto innet

:dropbox
cls
start https://www.dropbox.com
echo %DATE% %TIME%:  dropbox ����Ʈ ����>>C:\BATprogram\BAT.txt
goto innet 

:google
cls
start https://www.google.co.kr
echo %DATE% %TIME%:  ���� ����Ʈ ����>>C:\BATprogram\BAT.txt
goto innet

:nate
cls
start http://www.nate.com
echo %DATE% %TIME%:  ����Ʈ ����Ʈ ����>>C:\BATprogram\BAT.txt
goto innet

:daum
cls
start http://www.daum.net
echo %DATE% %TIME%:  daum ����Ʈ ����>>C:\BATprogram\BAT.txt
goto innet

:naver
cls
start www.naver.com
echo %DATE% %TIME%:  ���̹� ����Ʈ ����>>C:\BATprogram\BAT.txt
goto innet

:shut
cls
echo %DATE% %TIME%:  ���� ����,�α׿��� ��� ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo �����ϴ� ����� ��ȣ�� �Է��Ͻø� Ÿ�̸� ������ ���ɴϴ�.
echo �� 1 : �ڷΰ���
echo �� 2 : ����
echo �� 3 : �α׿���
echo �� 4 : �����                    
echo �� 5 : �����(g)
echo �� 6 : �������
echo �� 7 : ��������
echo ��
echo ��
echo ��
echo �� �� ��ɵ��� �׽�Ʈ������ ���� �ʾҽ��ϴ�.
echo ��
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto page2
if %a%==2 goto shutdowntime
if %a%==3 goto l
if %a%==4 goto r
if %a%==5 goto g
if %a%==6 goto h
if %a%==7 goto i
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto 


:shutdowntime
cls
echo %DATE% %TIME%:  ���� ���� ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo �����ϴ� ����� ��ȣ�� �Է��Ͻø� Ÿ�̸� ������ ���ɴϴ�.
echo �� 1 : �ڷΰ���
echo �� 2 : 30��
echo �� 3 : 1�ð�
echo �� 4 : 1�ð�30��              
echo �� 5 : 2�ð�
echo �� 6 : 2�ð�30��	
echo �� 7 : 3�ð�
echo �� 8 : 4�ð�
echo �� 9 : ����
echo �� 10 : ����� ����
echo ��
echo ��
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto shut
if %a%==2 goto 30s
if %a%==3 goto 1hs
if %a%==4 goto 1h3ss
if %a%==5 goto 2hs
if %a%==6 goto 2h3ss
if %a%==7 goto 3hs
if %a%==8 goto 4hs
if %a%==9 goto shutdown
if %a%==10 goto user
if %a%==11 goto 


:user
cls
echo �������� ������ : 0000
echo.
echo.
echo �ִ� 199999999��
echo.
echo.
set /p a=���Ͻô� �ð�(�ʴ���) �� �Է��ϼ���:
echo %DATE% %TIME%:  %a%�� ���� ����>>C:\BATprogram\BAT.txt
echo %a%���� ��ǻ�Ͱ� ����˴ϴ�.
shutdown -s -t %a%

pause
goto shutdowntime

:30s
cls
shutdown -s -t 1800
echo 30���� ���� ���� �Ϸ�
pause
cls
echo %DATE% %TIME%:  30�� ���� ����>>C:\BATprogram\BAT.txt
goto shut

:1hs
cls
shutdown -s -t 3600
echo 1�ð��� ���� ���� �Ϸ�
echo %DATE% %TIME%:  1�ð� ���� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1h3ss
cls
shutdown -s -t 5400
echo 1�ð�30���� ���� ���� �Ϸ�
echo %DATE% %TIME%:  1�ð� 30�� ���� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2hs
cls
shutdown -s -t 7200
echo 2�ð��� ���� ���� �Ϸ�
echo %DATE% %TIME%:  2�ð� ���� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2h3ss
cls
shutdown -s -t 9000
echo 2�ð�30���� ���� ���� �Ϸ�
echo %DATE% %TIME%:  2�ð� 30�� ���� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:3hs
cls
shutdown -s -t 10800
echo 3�ð��� ���� ���� �Ϸ�
echo %DATE% %TIME%:  3�ð� ���� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:4hs
cls
shutdown -s -t 14400
echo 4�ð��� ���� ���� �Ϸ�
echo %DATE% %TIME%:  4�ð� ���� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut



:l
cls
echo %DATE% %TIME%:  �α׿��� ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo �����ϴ� ����� ��ȣ�� �Է��Ͻø� Ÿ�̸� ������ ���ɴϴ�.
echo �� 1 : �ڷΰ���
echo �� 2 : 30��
echo �� 3 : 1�ð�
echo �� 4 : 1�ð�30��              
echo �� 5 : 2�ð�
echo �� 6 : 2�ð�30��	
echo �� 7 : 3�ð�
echo �� 8 : 4�ð�
echo �� 9 : ����
echo ��
echo ��
echo ��
echo �Ʀ�����������������������������������������������������������������


set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto shut
if %a%==2 goto 30l
if %a%==3 goto 1hl
if %a%==4 goto 1h3sl
if %a%==5 goto 2hl
if %a%==6 goto 2h3sl
if %a%==7 goto 3hl
if %a%==8 goto 4hl
if %a%==9 goto rightnowl
if %a%==10 goto 
if %a%==11 goto 


:30l
cls
shutdown -l -t 1800
echo 30����  ���� �Ϸ�
echo %DATE% %TIME%:  �α׿��� 30 �� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1hl
cls
shutdown -l -t 3600
echo 1�ð���  ���� �Ϸ�
echo %DATE% %TIME%:  �α׿��� 1�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1h3sl
cls
shutdown -l -t 5400
echo 1�ð�30����  ���� �Ϸ�
echo %DATE% %TIME%:  �α׿��� 1�ð� 30�� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2hl
cls
shutdown -l -t 7200
echo 2�ð���  ���� �Ϸ�
echo %DATE% %TIME%:  �α׿��� 2�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2h3sl
cls
shutdown -l -t 9000
echo 2�ð�30����  ���� �Ϸ�
echo %DATE% %TIME%:  �α׿��� 2�ð� 30�� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:3hl
cls
shutdown -l -t 10800
echo 3�ð���  ���� �Ϸ�
echo %DATE% %TIME%:  �α׿��� 3�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:4hl
cls
shutdown -l -t 14400
echo 4�ð��� ���� �Ϸ�
echo %DATE% %TIME%:  �α׿��� 4�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:rightnowl
cls
echo %DATE% %TIME%:  �α׿��� ����>>C:\BATprogram\BAT.txt
shutdown -l -t 0
goto shut

:g
cls
echo %DATE% %TIME%:  �����(g) ��� >>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo �����ϴ� ����� ��ȣ�� �Է��Ͻø� Ÿ�̸� ������ ���ɴϴ�.
echo �� 1 : �ڷΰ���
echo �� 2 : 30��
echo �� 3 : 1�ð�
echo �� 4 : 1�ð�30��              
echo �� 5 : 2�ð�
echo �� 6 : 2�ð�30��	
echo �� 7 : 3�ð�
echo �� 8 : 4�ð�
echo �� 9 : ����
echo ��
echo ��
echo ��
echo �Ʀ�����������������������������������������������������������������


set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto shut
if %a%==2 goto 30lg
if %a%==3 goto 1hlg
if %a%==4 goto 1h3slg
if %a%==5 goto 2hlg
if %a%==6 goto 2h3slg
if %a%==7 goto 3hlg
if %a%==8 goto 4hlg
if %a%==9 goto rightnowg
if %a%==10 goto 
if %a%==11 goto 


:30lg
cls
shutdown -g -t 1800
echo 30����  ���� �Ϸ�
echo %DATE% %TIME%:  �����(g)30�� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1hlg
cls
shutdown -g -t 3600
echo 1�ð���  ���� �Ϸ�
echo %DATE% %TIME%:  �����(g) 1�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1h3slg
cls
shutdown -g -t 5400
echo 1�ð�30����  ���� �Ϸ�
echo %DATE% %TIME%:  �����(g) 1�ð� 30�� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2hlg
cls
shutdown -g -t 7200
echo 2�ð���  ���� �Ϸ�
echo %DATE% %TIME%:  �����(g) 2�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2h3slg
cls
shutdown -g -t 9000
echo 2�ð�30����  ���� �Ϸ�
echo %DATE% %TIME%:  �����(g) 2�ð�30�� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:3hlg
cls
shutdown -g -t 10800
echo 3�ð���  ���� �Ϸ�
echo %DATE% %TIME%:  �����(g) 3�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:4hlg
cls
shutdown -g -t 14400
echo %DATE% %TIME%:  �����(g) 4�ð� ����>>C:\BATprogram\BAT.txt
echo 4�ð��� ���� �Ϸ�
pause
cls
goto shut

:rightnowg
echo %DATE% %TIME%:  �����(g) ����>>C:\BATprogram\BAT.txt
cls
shutdown -g -t 0
goto shut


:r
cls
echo %DATE% %TIME%:  ����� ���>>C:\BATprogram\BAT.txt
cls
echo �Ȧ�����������������������������������������������������������������        
echo �����ϴ� ����� ��ȣ�� �Է��Ͻø� Ÿ�̸� ������ ���ɴϴ�.
echo �� 1 : �ڷΰ���
echo �� 2 : 30��
echo �� 3 : 1�ð�
echo �� 4 : 1�ð�30��              
echo �� 5 : 2�ð�
echo �� 6 : 2�ð�30��	
echo �� 7 : 3�ð�
echo �� 8 : 4�ð�
echo �� 9 : ����
echo ��
echo ��
echo ��
echo �Ʀ�����������������������������������������������������������������


set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto shut
if %a%==2 goto 30r
if %a%==3 goto 1hr
if %a%==4 goto 1h3sr
if %a%==5 goto 2hr
if %a%==6 goto 2h3sr
if %a%==7 goto 3hr
if %a%==8 goto 4hr
if %a%==9 goto rightnowr
if %a%==10 goto 
if %a%==11 goto 


:30r
cls
shutdown -r -t 1800
echo 30����  ���� �Ϸ�
echo %DATE% %TIME%:  ����� 30�� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1hr
cls
shutdown -r -t 3600
echo 1�ð���  ���� �Ϸ�
echo %DATE% %TIME%:  ����� 1�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1h3sr
cls
shutdown -r -t 5400
echo 1�ð�30����  ���� �Ϸ�
echo %DATE% %TIME%:  ����� 1�ð�30�� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2hr
cls
shutdown -r -t 7200
echo 2�ð���  ���� �Ϸ�
echo %DATE% %TIME%:  ����� 2�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2h3sr
cls
shutdown -r -t 9000
echo 2�ð�30����  ���� �Ϸ�
echo %DATE% %TIME%:  ����� 2�ð�30�� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:3hr
cls
shutdown -r -t 10800
echo 3�ð���  ���� �Ϸ�
echo %DATE% %TIME%:  ����� 3�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:4hr
cls
shutdown -r -t 14400
echo 4�ð��� ���� �Ϸ�
echo %DATE% %TIME%:  ����� 4�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:rightnowr
echo %DATE% %TIME%:  ����� ����>>C:\BATprogram\BAT.txt
cls
shutdown -r -t 0
goto shut

:h
cls
echo %DATE% %TIME%:  ������� ���>>C:\BATprogram\BAT.txt
cls
echo �Ȧ�����������������������������������������������������������������        
echo �����ϴ� ����� ��ȣ�� �Է��Ͻø� Ÿ�̸� ������ ���ɴϴ�.
echo �� 1 : �ڷΰ���
echo �� 2 : 30��
echo �� 3 : 1�ð�
echo �� 4 : 1�ð�30��              
echo �� 5 : 2�ð�
echo �� 6 : 2�ð�30��	
echo �� 7 : 3�ð�
echo �� 8 : 4�ð�
echo �� 9 : ����
echo ��
echo ��
echo ��
echo �Ʀ�����������������������������������������������������������������


set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto shut
if %a%==2 goto 30h
if %a%==3 goto 1hh
if %a%==4 goto 1h3sh
if %a%==5 goto 2hh
if %a%==6 goto 2h3sh
if %a%==7 goto 3hh
if %a%==8 goto 4hh
if %a%==9 goto rightnowh
if %a%==10 goto 
if %a%==11 goto 


:30h
cls
shutdown -h -t 1800
echo 30����  ���� �Ϸ�
echo %DATE% %TIME%:  ������� 30�� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1hh
cls
shutdown -h -t 3600
echo %DATE% %TIME%:  ������� 1�ð� ����>>C:\BATprogram\BAT.txt
echo 1�ð���  ���� �Ϸ�
pause
cls
goto shut

:1h3sh
cls
shutdown -h -t 5400
echo 1�ð�30����  ���� �Ϸ�
echo %DATE% %TIME%:  ������� 1�ð�30�� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2hh
cls
shutdown -h -t 7200
echo 2�ð���  ���� �Ϸ�
echo %DATE% %TIME%:  ������� 2�ð� ����>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2h3sh
cls
shutdown -h -t 9000
echo %DATE% %TIME%:  ������� 2�ð�30�� ����>>C:\BATprogram\BAT.txt
echo 2�ð�30����  ���� �Ϸ�
pause
cls
goto shut


:3hh
cls
shutdown -h -t 10800
echo %DATE% %TIME%:  ������� 3�ð� ����>>C:\BATprogram\BAT.txt
echo 3�ð���  ���� �Ϸ�
pause
cls
goto shut

:4hh
cls
shutdown -h -t 14400
echo %DATE% %TIME%:  ������� 4�ð� ����>>C:\BATprogram\BAT.txt
echo 4�ð��� ���� �Ϸ�
pause
cls
goto shut

:rightnowh
cls

shutdown -h -t 0
echo %DATE% %TIME%:  ������� ����>>C:\BATprogram\BAT.txt
cls
goto shut


:i
cls
echo %DATE% %TIME%:  ���� ���� ���>>C:\BATprogram\BAT.txt
cls
echo �Ȧ�����������������������������������������������������������������        
echo �����ϴ� ����� ��ȣ�� �Է��Ͻø� Ÿ�̸� ������ ���ɴϴ�.
echo �� 1 : �ڷΰ���
echo �� 2 : 
echo �� 3 : 
echo �� 4 :              
echo �� 5 : 
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo �� 9 : ����
echo ��
echo ��
echo ��
echo �Ʀ�����������������������������������������������������������������


set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto shut
if %a%==2 goto 30li
if %a%==3 goto 1hli
if %a%==4 goto 1h3sli
if %a%==5 goto 2hli
if %a%==6 goto 2h3sli
if %a%==7 goto 3hli
if %a%==8 goto 4hli
if %a%==9 goto rightnowi
if %a%==10 goto 
if %a%==11 goto 


:30li
cls
shutdown -i -t 1800
echo 30����  ���� �Ϸ�
pause
cls
goto shut

:1hli
cls
shutdown -i -t 3600
echo 1�ð���  ���� �Ϸ�
pause
cls
goto shut

:1h3sli
cls
shutdown -i -t 5400
echo 1�ð�30����  ���� �Ϸ�
pause
cls
goto shut

:2hli
cls
shutdown -i -t 7200
echo 2�ð���  ���� �Ϸ�
pause
cls
goto shut

:2h3sli
cls
shutdown -i -t 9000
echo 2�ð�30����  ���� �Ϸ�
pause
cls
goto shut


:3hli
cls
shutdown -i -t 10800
echo 3�ð���  ���� �Ϸ�
pause
cls
goto shut


:4hli
cls
shutdown -i -t 14400
echo 4�ð��� ���� �Ϸ�
pause
cls
goto shut

:rightnowi
cls
shutdown -i -t 0
echo %DATE% %TIME%:  �������� ����>>C:\BATprogram\BAT.txt
cls
goto shut


:simsim
cls
echo %DATE% %TIME%:  �����ڰ� �ɽ��ؼ� ���� ��ɵ� ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : �ڷΰ���
echo �� 2 : ���� ũ����
echo �� 3 : CMD����
echo �� 4 : �޹���                          
echo �� 
echo �� 
echo ��
echo ��
echo ��
echo ��
echo ��
echo ��
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto page2
if %a%==2 goto joclack
if %a%==3 goto CMDdo
if %a%==4 goto parrot
if %a%==5 goto 
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto 


:parrot
cls
echo [�޹���]�ƹ����̳� �غ���
echo %DATE% %TIME%:  �޹��� ����>>C:\BATprogram\BAT.txt
goto parrot2

:parrot2


echo.
set /p a=���ϴ� ��:

echo.
echo [�޹���]%a%
echo %DATE% %TIME%:  �޹������� "%a%" ��� ���ϼ� ���ϴ�.>>C:\BATprogram\BAT.txt
goto parrot2




:net
echo %DATE% %TIME%:  net>>C:\BATprogram\BAT.txt
cls
echo ���ͳ� ������ ���� �ع����ϴ�.
echo.
echo �� ����� �����ϰ� ��������� �����Ͻ÷���
echo ������ 2 ���� 43�� �Է��ϼ���. 
echo.
echo �� ����� �����ϰ� ��������� �����Ͻ÷���
echo ������ 2 ���� 43�� �Է��ϼ���.
echo.
echo �� ����� �����ϰ� ��������� �����Ͻ÷���
echo ������ 2 ���� 43�� �Է��ϼ���.
echo.
echo �� ����� �����ϰ� ��������� �����Ͻ÷���
echo ������ 2 ���� 43�� �Է��ϼ���.

set /p a==y���� n����.:
if %a%==y goto netgo
if %a%==n goto TEST



:netgo
cls
echo %DATE% %TIME%:  ��Ʈ��ũ ���� ����>>C:\BATprogram\BAT.txt
cls
ipconfig/release
echo ���� �Ϸ�......
echo �� ����� �����ϰ� ��������� �����Ͻ÷���
echo ������ 2 ���� 43�� �Է��ϼ���.
echo.
echo �� ����� �����ϰ� ��������� �����Ͻ÷���
echo ������ 2 ���� 43�� �Է��ϼ���. 
echo.
echo �� ����� �����ϰ� ��������� �����Ͻ÷���
echo ������ 2 ���� 43�� �Է��ϼ���.
echo.
echo �� ����� �����ϰ� ��������� �����Ͻ÷���
echo ������ 2 ���� 43�� �Է��ϼ���.
echo.
echo �� ����� �����ϰ� ��������� �����Ͻ÷���
echo ������ 2 ���� 43�� �Է��ϼ���.
pause 
goto Tr

:CMDdo
cls
echo %DATE% %TIME%:  CMD ���踦 �Ͻðڽ��ϱ�?>>C:\BATprogram\BAT.txt
echo are you ready?
echo y/n

set /p a=y/n:
if %a%==n goto simsim
if %a%==y goto CMDdo2


:CMDdo2
echo %DATE% %TIME%:  CMD���� ����>>C:\BATprogram\BAT.txt
goto CMDdo3


:CMDdo3 



echo �ȳ��Ͻÿ�?
echo ����⿡ �����ôٴ� �ݰ���
echo ����� ���ڼ� 
echo �����(?)

goto CMDdo3


:joclack
cls
echo %DATE% %TIME%:  ���� ũ���� ���� (�峭��)>>C:\BATprogram\BAT.txt
color 5a

echo ���� ũ���� 86.886V
pause
echo ll
pause
echo ���� ����.�Ϸ�!
pause
echo ���� ���� �Դϴ� �����̽��ٸ� �� 3���� �����ּ��� ! (��)
pause
pause
pause

:random
echo ??? %ramdom%



pause
echo �ٽ�
pause
color 0a
mode 1000

:A
echo %random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%




goto A

:CMDms
cls
echo ��ɾ� ������ �˰�,��� �뵵�� �ƽôºи�
echo �����Ͻñ� �ٶ��ϴ�.
pause
echo ��ɾ� ������ �˰�,��� �뵵�� �ƽôºи�
echo �����Ͻñ� �ٶ��ϴ�.
pause
goto CMDs

:CMDs
cls
echo %DATE% %TIME%:  CMD��ɾ� ��� ����>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������
echo �� CMD��ɾ� ���
echo �Ʀ�����������������������������������������������������������������
echo �Ȧ�����������������������������������������������������������������        
echo ��                                                             
echo �� 1 :  �⺻ ��ɾ�
echo �� 2 :  ��Ʈ��ũ ���� ��ɾ�
echo �� 3 : 
echo �� 4 :                             
echo �� 5 : 
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo �� 9 : 
echo �� 10 : 
echo �� 
echo �Ʀ�����������������������������������������������������������������        
echo �Ȧ�����������������������������������������������������������������
echo �� �ڷΰ���:11
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto CMDn
if %a%==2 goto CMDnetwork
if %a%==3 goto 
if %a%==4 goto 
if %a%==5 goto 
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto page2


:CMDn
cls
cls
echo %DATE% %TIME%:  CMD��ɾ� ���-�⺻>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������
echo �� CMD��ɾ� ���(�⺻)
echo �Ʀ�����������������������������������������������������������������
echo �Ȧ�����������������������������������������������������������������        
echo ��                                                             
echo �� 1 :  
echo �� 2 : ipconfig
echo �� 3 : diskpart
echo �� 4 : msconfig                    
echo �� 5 : tree(���� ��ġ)
echo �� 6 : tree(C����̺� ��ġ)
echo �� 7 : netstat
echo �� 8 : 
echo �� 9 : 
echo �� 10 : 
echo �� 
echo �Ʀ�����������������������������������������������������������������        
echo �Ȧ�����������������������������������������������������������������
echo �� �ڷΰ���:11
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto 
if %a%==2 goto ipconfig
if %a%==3 goto diskpart
if %a%==4 goto msconfig
if %a%==5 goto tree
if %a%==6 goto treeC
if %a%==7 goto netstat
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto CMDs


:CMDnetwork
cls
cls
echo %DATE% %TIME%:  CMD��ɾ� ���-��Ʈ��ũ ����>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������
echo �� ��Ʈ��ũ ���� CMD��ɾ�
echo �Ʀ�����������������������������������������������������������������
echo �Ȧ�����������������������������������������������������������������        
echo ��                                                             
echo �� 1 : ipconfig
echo �� 2 : ipconfig /release
echo �� 3 : ipconfig /renew
echo �� 4 : ipconfig /flushdns
echo �� 5 : ipconfig /registerdns    
echo �� 6 : netsh winsock reset
echo �� 7 : netsh int ip reset
echo �� 8 : netsh int tcp set heuristics disabled
echo �� 9 : netsh int tcp set global autotuninglevel=disabled
echo �� 10 : netsh int tcp set global rss=enabled
echo ��  
echo �� 
echo �Ʀ�����������������������������������������������������������������        
echo �Ȧ�����������������������������������������������������������������
echo �� �ڷΰ���:11         ����������:12
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto ipconfig
if %a%==2 goto ipconfigrelease
if %a%==3 goto ipconfigrenew
if %a%==4 goto ipconfigflushdns
if %a%==5 goto ipconfigregisterdns
if %a%==6 goto netshwinsockreset
if %a%==7 goto netshintipreset
if %a%==8 goto netshinttcpsetheuristicsdisabled
if %a%==9 goto netshinttcpsetglobalautotuningleveldisabled
if %a%==10 goto netshinttcpsetglobalrssenabled
if %a%==11 goto CMDs
if %a%==12 goto CMDnetwork2



:ipconfig
cls
ipconfig

pause
goto CMDnetwork

:ipconfigrelease
cls
ipconfig /release

pause
goto CMDnetwork

:ipconfigrenew
cls
ipconfig /renew
pause
goto CMDnetwork

:ipconfigflushdns
cls
ipconfig /flushdns
pause
goto CMDnetwork

:ipconfigregisterdns
cls
ipconfig /registerdns
pause
goto CMDnetwork

:netshwinsockreset
cls
netsh winsock reset
pause
goto CMDnetwork

:netshintipreset
cls
netsh int ip reset
pause
goto CMDnetwork

:netshinttcpsetheuristicsdisabled
cls
netsh int tcp set heuristics disabled
pause
goto CMDnetwork

:netshinttcpsetglobalautotuningleveldisabled
cls
netsh int tcp set global autotuninglevel=disabled
pause
goto CMDnetwork

:netshinttcpsetglobalrssenabled
cls
netsh int tcp set global rss=enabled
pause
goto CMDnetwork



:CMDnetwork2
cls
cls
echo %DATE% %TIME%:  CMD��ɾ� ���-��Ʈ��ũ ����2>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������
echo �� ��Ʈ��ũ ���� CMD��ɾ�2
echo �Ʀ�����������������������������������������������������������������
echo �Ȧ�����������������������������������������������������������������        
echo ��                                                             
echo �� 1 : netsh int tcp show global
echo �� 2 : 
echo �� 3 : 
echo �� 4 :                   
echo �� 5 : 
echo �� 6 : 
echo �� 7 : 
echo �� 8 : 
echo �� 9 : 
echo �� 10 : 
echo �� 
echo �Ʀ�����������������������������������������������������������������        
echo �Ȧ�����������������������������������������������������������������
echo �� �ڷΰ���:11
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto netshinttcpshowglobal
if %a%==2 goto 
if %a%==3 goto 
if %a%==4 goto 
if %a%==5 goto 
if %a%==6 goto 
if %a%==7 goto
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto CMDnetwork


:netshinttcpshowglobal
cls
netsh int tcp show global
pause
goto CMDnetwork




:??
cls

puase
goto CMDs

:netstat
cls
netstat
echo %DATE% %TIME%:  netstat ��� ����>>C:\BATprogram\BAT.txt
pause
goto CMDs

:treeC
cls
cd C:\
tree
echo %DATE% %TIME%:  C����̺꿡�� tree��ɾ� ����>>C:\BATprogram\BAT.txt
pause
goto CMDs

:tree
cls
tree
echo %DATE% %TIME%:  tree ��ɾ� ����>>C:\BATprogram\BAT.txt
pause
goto CMDs

:msconfig
cls
msconfig
echo %DATE% %TIME%:  msconfig ��ɾ� ����>>C:\BATprogram\BAT.txt
goto Cmds

:ipconfig
cls
ipconfig
echo %DATE% %TIME%:  ipconfig ��ɾ� ����>>C:\BATprogram\BAT.txt
pause
goto CMDs

:diskpart
cls
diskpart
echo ��� ���� �Ϸ�
echo %DATE% %TIME%:  diskpart ��ɾ� ����>>C:\BATprogram\BAT.txt
pause
goto CMDs

:programs
cls
echo %DATE% %TIME%:  ���α׷��� ���>>C:\BATprogram\BAT.txt 
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : �ڷΰ���
echo �� 2 : �޸��� ����
echo �� 3 : msconfig
echo �� 4 : �۾�������                             
echo �� 5 : ĸ�ĵ���
echo �� 6 : �����е�        
echo �� 7 : �׸���
echo �� 8 : ����ǥ
echo �� 9 : ���ͳ� ���� �����ذ��
echo �� 10 : ������ ���� �����ذ��
echo �� 11 : ��Ʈ��ũ ����� �����ذ��
echo ��
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto page2
if %a%==2 goto notepad
if %a%==3 goto msconfig
if %a%==4 goto Taskmgr
if %a%==5 goto SnippingTool
if %a%==6 goto wordpad
if %a%==7 goto mspaint
if %a%==8 goto harmap
if %a%==9 goto ndw
if %a%==10 goto ndc
if %a%==11 goto ndna


:ndw
cls
msdt.exe -id NetworkDiagnosticsWeb
goto programs

:ndc
cls
msdt.exe -id NetworkDiagnosticsInbound
goto programs

:ndna
cls
msdt.exe -id NetworkDiagnosticsNetworkAdapter
goto programs

:harmap
cls
cd %windir%\system32
charmap.exe
echo %DATE% %TIME%:  ����ǥ ����>>C:\BATprogram\BAT.txt
goto programs

:mspaint
cls
cd %windir%\system32
mspaint.exe
echo %DATE% %TIME%:  �׸��� ����>>C:\BATprogram\BAT.txt
goto programs

:wordpad
cls
cd %ProgramFiles%\Windows NT\Accessories
wordpad.exe
echo %DATE% %TIME%:  �����е� ����>>C:\BATprogram\BAT.txt
goto programs

:SnippingTool
cls
cd %windir%\system32
SnippingTool.exe
echo %DATE% %TIME%:  ĸ�ĵ��� ����>>C:\BATprogram\BAT.txt
goto programs

:Taskmgr
cls
cd C:\WINDOWS\system32
echo %DATE% %TIME%:  �۾������� ����>>C:\BATprogram\BAT.txt
goto programs


:notepad
cls
cd C:\WINDOWS\system32
notepad.exe
echo %DATE% %TIME%:  �޸��� ����>>C:\BATprogram\BAT.txt
goto programs


:Tr
cls
echo %DATE% %TIME%:  �׷���� ���>>C:\BATprogram\BAT.txt
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1.�ڷΰ���
echo �� 2.CMD �׷�
echo �� 3.CMD �׷�(�ſ찭��)(���� ���� ���ñ� �ٶ��ϴ�)
echo �� 4.���� �׷���
echo �� 5.���ͳ� ���� ����
echo ��         
echo ��
echo ��
echo ��
echo ��
echo ��
echo ��
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto back
if %a%==2 goto CMD
if %a%==3 goto CMD2
if %a%==4 goto BT
if %a%==5 goto net
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto 


:back
cls
goto page2

:CMD
echo %DATE% %TIME%:  CMD�׷� (����) >>C:\BATprogram\BAT.txt
cls
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start
start


:CMD2
echo %DATE% %TIME%:  CMD�׷� (�ſ찭��)>>C:\BATprogram\BAT.txt
START %0


pause
goto Tr

:BT
cls
echo %DATE% %TIME%:  ����ȭ�� �׷��� �Ͻðڽ��ϱ�?>>C:\BATprogram\BAT.txt
echo  �� ����� ���ڵ�(?) �Դϴ�.
pause
echo �� ����� ������ �����Ͽ� �׷��ϴ� ��� �Դϴ�. ������ ������ �����ϼ���.
set /p a=��� �Ͻ÷���1�� �ڷ� ���÷��� 2�� ������ ���÷���3�� �� �Է��� �ּ���. EX)3:
if %a%==1 goto BTgo
if %a%==2 goto Tr
if %a%==3 goto BThelp


:BTgo
set /p a=���Ͻô� ��θ� �Է��ϼ���:
if not exist %a% goto BTerro
if %a%==0000 BT
if exist %a% goto BTgogo


:BTgogo
echo %DATE% %TIME%:  %a%�� ���� �׷� ����>>C:\BATprogram\BAT.txt
cd %a%
md %random%%random%%random%
goto BTgogo


:BTerro
��θ� ã�� �� �����ϴ�.
pasue
goto BT

 

:BThelp
cls
echo %DATE% %TIME%:  ����ȭ�� �׷� ���� ����>>C:\BATprogram\BAT.txt
echo ���Ͻô� ������ �׷��Ͻ÷���?
echo ������ ��θ� �Է��ϼ���!
echo.
echo ����ȭ�鿡 �·��Ϸ���?
echo ���: C:\Users\�����̸�\Desktop
echo ������� �̸��� hello ���,
echo ��δ� C:\Users\hello\Deskop �Դϴ�.

pause
goto BT
:TEST
cls
echo %DATE% %TIME%:  �׽�Ʈ ��� ���>>C:\BATprogram\BAT.txt 
echo �Ȧ�����������������������������������������������������������������        
echo ��
echo �� 1 : �ڷΰ���
echo �� 2 : bat���ϸ����� �����(?)
echo �� 3 : ��ǻ�� ���� (ī�װ�)
echo �� 4 :                             
echo ��
echo ��         
echo ��
echo ��
echo ��
echo ��
echo ��
echo ��
echo �Ʀ�����������������������������������������������������������������

set /p a=���ϴ� ��ȣ�� �Է��ϼ���.:
if %a%==1 goto page2
if %a%==2 goto REBOOT
if %a%==3 goto shutdown
if %a%==4 goto 
if %a%==5 goto 
if %a%==6 goto 
if %a%==7 goto 
if %a%==8 goto 
if %a%==9 goto 
if %a%==10 goto 
if %a%==11 goto 


:REBOOT
cls
echo %DATE% %TIME%:  �׽�Ʈ ���-���α׷� �ٽý���>>C:\BATprogram\BAT.txt
echo �� �� �� �� �� �� ��  ��?
pause
bat���ϸ���5+5.bat

pause

:RE
cls
echo %DATE% %TIME%:  net ���� ���>>C:\BATprogram\BAT.txt
echo ��ø� ��ٷ� �ּ���.
ipconfig/renew


pause
goto page2

:shutdown
cls
echo %DATE% %TIME%:  ��ǻ�� ����>>C:\BATprogram\BAT.txt
shutdown -s -t 0

echo �� ����
pause




:help
echo ó������ ���˱���~?
pause 
cd C:\
md BATprogram
echo �������α׷�LOG>C:\BATprogram\BAT.txt





echo.
echo ȯ���մϴ�! 

pause
echo.
echo �� ȭ���� ó�� ����ÿ��� ��Ÿ���ϴ�.

pause
cls
set /p b=����� �̸���?:
echo ��!%b%��! ���� ���� �̸��̳׿�!
pause 
echo.
echo.
echo ������ �ݰ����� %b%��!

echo.
echo.
pause

set /p a=%b%��! �����ڸ� �����ø�y�� ���α׷��� �����Ͻ÷��� n�� �Է��� �ּ���!:
if %a%==y goto maker
if %a%==n goto first

pause
cls
goto first



:maker
cls
echo �������ڡ�
echo ����
echo ������Ʈ�� �����Ͻź�
echo.
echo.
echo ����
echo.
echo.
pause
echo.
echo.
echo �׸��� ���
echo �ٷ� "%b%"��
echo.
pause
echo.
echo.
echo %b%�Ե� ��������,�߰���� ���� �����Ͽ�
echo �� ���α׷��� ������ �ֽ� �� �ֽ��ϴ�.
echo.
echo.


pause 
goto first