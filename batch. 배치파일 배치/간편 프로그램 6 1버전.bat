@echo off
set vision=6.1


color b
if not exist "C:\BATprogram" goto help
:first
SET DT=%DATE%
SET TE=%TIME%
title 간단한 프로그램
echo.>>C:\BATprogram\BAT.txt
echo ---------------------%DATE% %TIME%----------------------->>C:\BATprogram\BAT.txt
echo.>>C:\BATprogram\BAT.txt
echo %DATE% %TIME%:  프로그램 실행!>>C:\BATprogram\BAT.txt
echo %DATE% %TIME%:  실행 버전:%vision%>>C:\BATprogram\BAT.txt
mode 1000
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□■■■□□■□□■■■□□□■■■□□□■■□■■□□□■■■□□
echo □■□□□■□□□■□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□■□■□■□■□□□■■■■■□■□■□□□□□■□□□■□■□□■□□■□■■■■■□
echo □□■□■□■□■□□□■□□□□□■□■□□□□□■□□□■□■□□■□□■□■□□□□□
echo □□□■□□□■□□□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□□■□□□■□□□□□■■■□□■□□■■■□□□■■■□□■□□■□□■□□■■■□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                         실행 버전:%vision%
timeout /t 1 > nul
cls
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□■■■□□■□□■■■□□□■■■□□□■■□■■□□□■■■□□
echo □■□□□■□□□■□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□■□■□■□■□□□■■■■■□■□■□□□□□■□□□■□■□□■□□■□■■■■■□
echo □□■□■□■□■□□□■□□□□□■□■□□□□□■□□□■□■□□■□□■□■□□□□□
echo □□□■□□□■□□□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□□■□□□■□□□□□■■■□□■□□■■■□□□■■■□□■□□■□□■□□■■■□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  프로그램 파일을 확인합니다.(BATprogram folder check)
timeout /t 1 > nul
if not exist "C:\BATprogram" goto erro1
cls
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□■■■□□■□□■■■□□□■■■□□□■■□■■□□□■■■□□
echo □■□□□■□□□■□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□■□■□■□■□□□■■■■■□■□■□□□□□■□□□■□■□□■□□■□■■■■■□
echo □□■□■□■□■□□□■□□□□□■□■□□□□□■□□□■□■□□■□□■□■□□□□□
echo □□□■□□□■□□□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□□■□□□■□□□□□■■■□□■□□■■■□□□■■■□□■□□■□□■□□■■■□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  프로그램 파일을 확인합니다.(mainsetting folder check)
timeout /t 1 > nul
if not exist "C:\BATprogram\main" goto mainset
cls
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□■■■□□■□□■■■□□□■■■□□□■■□■■□□□■■■□□
echo □■□□□■□□□■□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□■□■□■□■□□□■■■■■□■□■□□□□□■□□□■□■□□■□□■□■■■■■□
echo □□■□■□■□■□□□■□□□□□■□■□□□□□■□□□■□■□□■□□■□■□□□□□
echo □□□■□□□■□□□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□□■□□□■□□□□□■■■□□■□□■■■□□□■■■□□■□□■□□■□□■■■□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  프로그램 파일을 확인합니다.(main\??)
timeout /t 1 > nul
echo %DATE% %TIME%:  프로그램폴더 확인 성공>>C:\BATprogram\BAT.txt
goto lode1212

:lode1212
cls
echo 불러오는중.
if not exist "C:\BATprogram\main\main1" goto main2rerro
if exist "C:\BATprogram\main\main1" goto main

:main2rerro
cls
echo 불러오는중2.
if not exist "C:\BATprogram\main\main2" goto errocode2
if exist "C:\BATprogram\main\main2" goto main2r

:errocode2
cls
echo %DATE% %TIME%:  오류 발생 오류코드:2>>C:\BATprogram\BAT.txt
echo ┌─────────────────┐
echo │                                  │
echo │   메인 설정을 불러올 수 없음     │
echo │       (백신을 종료해 보세요)     │
echo │          erro code:2             │
echo └─────────────────┘
echo.
echo.
echo (자동복구를 실행합니다)
echo.
echo.
pause
timeout /t 10
rd /s /q C:\batprogram\main
echo 프로그램 재시작...
timeout /t 3
goto first



:mainset
cls
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□■■■□□■□□■■■□□□■■■□□□■■□■■□□□■■■□□
echo □■□□□■□□□■□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□■□■□■□■□□□■■■■■□■□■□□□□□■□□□■□■□□■□□■□■■■■■□
echo □□■□■□■□■□□□■□□□□□■□■□□□□□■□□□■□■□□■□□■□■□□□□□
echo □□□■□□□■□□□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□□■□□□■□□□□□■■■□□■□□■■■□□□■■■□□■□□■□□■□□■■■□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  메인세팅을 찾을 수 없습니다.
echo.
echo                                   3초후 설정으로 이동됩니다. 
timeout /t 1 > nul
echo %DATE% %TIME%:  메인세팅을 찾을 수 없습니다.>>C:\BATprogram\BAT.txt
cls
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□■■■□□■□□■■■□□□■■■□□□■■□■■□□□■■■□□
echo □■□□□■□□□■□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□■□■□■□■□□□■■■■■□■□■□□□□□■□□□■□■□□■□□■□■■■■■□
echo □□■□■□■□■□□□■□□□□□■□■□□□□□■□□□■□■□□■□□■□■□□□□□
echo □□□■□□□■□□□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□□■□□□■□□□□□■■■□□■□□■■■□□□■■■□□■□□■□□■□□■■■□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  메인세팅을 찾을 수 없습니다.
echo.
echo                                   2초후 설정으로 이동됩니다. 
timeout /t 1 > nul
cls
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo ■□□□□□□□□□■□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□□□□□□■□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □■□□□■□□□■□□□■■■□□■□□■■■□□□■■■□□□■■□■■□□□■■■□□
echo □■□□□■□□□■□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□■□■□■□■□□□■■■■■□■□■□□□□□■□□□■□■□□■□□■□■■■■■□
echo □□■□■□■□■□□□■□□□□□■□■□□□□□■□□□■□■□□■□□■□■□□□□□
echo □□□■□□□■□□□□■□□□■□■□■□□□■□■□□□■□■□□■□□■□■□□□■□
echo □□□■□□□■□□□□□■■■□□■□□■■■□□□■■■□□■□□■□□■□□■■■□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
echo                                   Program virsion:%vision%V PRO 
echo.
echo.
echo                                  메인세팅을 찾을 수 없습니다.
echo.
echo                                   1초후 설정으로 이동됩니다. 
timeout /t 1 > nul
goto check

:erro1
cls
echo %DATE% %TIME%:  오류발생 에러코드:1>>C:\BATprogram\BAT.txt
echo ┌─────────────────┐
echo │                                  │
echo │ 프로그램 파일을 찾을 수 없습니다.│
echo │  (C드라이브에서 실행해 주세요)   │
echo │          erro code:1             │
echo └─────────────────┘
pause
goto EXIT

:check
cls
echo 불러오는중
if not exist "C:\BATprogram\main" goto checkgo

:checkgo
cls
echo %DATE% %TIME%:  메인설정>>C:\BATprogram\BAT.txt
echo 일반(원조)메인:1
echo Simple(새로운)메인:2
echo.
echo 일반메인 미리보기:1m
echo 새로운메인 미리보기:2m
echo.
set /p b=원하시는 번호를 입력하세요:
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
echo %DATE% %TIME%:  메인2 미리보기 진입>>C:\BATprogram\BAT.txt
echo ┌─────────────────┐
echo │메인(프로그램버전:%vision%)            │
echo └─────────────────┘
echo ┌─────────────────┐
echo │                                  │
echo │ 1:시작  2:설정  3:CMD실행        │
echo │ 4:업데이트 내용                  │
echo │ 5:EXIT                           │
echo └─────────────────┘
pause
goto checkgo

:main2r
cls
echo %DATE% %TIME%:  메인2 진입>>C:\BATprogram\BAT.txt


echo ┌─────────────────┐
echo │메인(프로그램버전:%vision%)            │
echo └─────────────────┘
echo ┌─────────────────┐
echo │                                  │
echo │ 1:시작  2:설정  3:CMD실행        │
echo │ 4:업데이트 내용                  │
echo │ 5:EXIT                           │
echo └─────────────────┘
set /p an=원하시는 번호를 선택하세요:
if %an%==1 goto page2
if %an%==2 goto setting2
if %an%==3 goto CMDgo
if %an%==4 goto report
if %an%==5 goto EXIT

:setting
cls 
echo %DATE% %TIME%:  설정 진입>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 설정
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │                                                             
echo │ 1:텍스트색 변경              2:프로그램 초기화
echo │     
echo │ 3:명령어 보이기              4:로그 관리
echo │                          
echo │ 5:메인변경                   6:개발자와 카톡
echo │ 
echo │ 7:업데이트 확인
echo │ 
echo │ 
echo │ 
echo │ 
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 뒤로가기:11
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  설정 진입>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 설정
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │                                                             
echo │ 1:텍스트색 변경              2:프로그램 초기화
echo │     
echo │ 3:명령어 보이기              4:로그 관리
echo │                          
echo │ 5:메인변경                   6:개발자와 
echo │ 
echo │ 7:업데이트 확인
echo │ 
echo │ 
echo │ 
echo │ 
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 뒤로가기:11
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  문의진입>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │                                                             
echo │ 1.카카오톡(오픈)
echo │     
echo │ 
echo │                          
echo │
echo │ 
echo │ 
echo │ 
echo │ 
echo │ 
echo │ 
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 뒤로가기:11
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p se=번호를 입력하세요:
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
echo %DATE% %TIME%:  메인변경 확인 여부>>C:\BATprogram\BAT.txt
set /p anse=정말로 변경하시겠습니까?Y/N:
if %anse%==n goto setting
if %anse%==y goto changemain2
if %anse%==N goto setting
if %anse%==Y goto changemain2

:changemainyn2
cls
echo %DATE% %TIME%:  메인변경 확인 여부>>C:\BATprogram\BAT.txt
set /p a=정말로 변경하시겠습니까?Y/N:
if %a%==n goto setting2
if %a%==y goto changemain2
if %a%==N goto setting2
if %a%==Y goto changemain2





:changemain2
echo %DATE% %TIME%:  메인설정 초기화 실행>>C:\BATprogram\BAT.txt
cls
if not exist "C:\batprogramchange" goto changemainmaker2
cd C:\BATprogramchange
change
pause
goto first

:changemainmaker2
echo %DATE% %TIME%:  메인변경 배치파일이 만들어짐>>C:\BATprogram\BAT.txt
cd C:\
md batprogramchange
echo @echo off>>C:\batprogramchange\change.bat
echo echo 잠시만기다려주세요>>C:\batprogramchange\change.bat
echo timeout /t 3 > nul>>C:\batprogramchange\change.bat
echo rd /s /q C:\batprogram\main>>C:\batprogramchange\change.bat
echo echo 완료>>C:\batprogramchange\change.bat
echo pause>>C:\batprogramchange\change.bat
echo 메인변경 배치파일 생성중
timeout /t 3 > NUL
goto changemain2

:resetyn
cls
echo %DATE% %TIME%:  프로그램 초기화 확인 여부>>C:\BATprogram\BAT.txt
set /p ans=정말로초기화 하시겠습니까? Y/N:
if %ans%==N goto setting
if %ans%==Y goto reset
if %ans%==n goto setting
if %ans%==y goto reset

:resetyn2
cls
echo %DATE% %TIME%:  프로그램 초기화 확인 여부>>C:\BATprogram\BAT.txt
set /p ans=정말로초기화 하시겠습니까? Y/N:
if %ans%==N goto setting2
if %ans%==Y goto reset
if %ans%==n goto setting2
if %ans%==y goto reset


:1mi
cls
mode 100


echo %DATE% %TIME%:  1메인 미리보기 이동>>C:\BATprogram\BAT.txt

echo.
echo 프로그램 버전:%vision%ㅣ컴퓨터 종료:100 l 설정:123
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │ 1 : 인터넷(DNS캐쉬 청소)  
echo │-------------------------------------------------------------
echo │예약종료:컴퓨터를 지정된 시간후에 자동으로 종료 합니다.             
echo │ 2 : 예약 종료 취소
echo │ 3 : 30분 예약 종료                                 
echo │ 4 : 1시간 예약 종료
echo │ 5 : 1시간 30분 예약 종료            
echo │ 6 : 2시간 예약종료
echo │ 7 : 2시간 30분 예약 종료
echo │ 8 : 3시간 예약종료
echo │ 9 : 4시간 예약 종료
echo │-------------------------------------------------------------
echo │10 : 페이지2 
echo │11 : EXIT   l   12 : CMD실행  l  13 : 업데이트 내용
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
pause 
goto checkgo
:main
cls
mode 100


echo %DATE% %TIME%:  메인이동>>C:\BATprogram\BAT.txt

echo.
echo 프로그램 버전:%vision%ㅣ컴퓨터 종료:100 l 설정:123
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │ 1 : 인터넷(DNS캐쉬 청소) 
echo │-------------------------------------------------------------
echo │예약종료:컴퓨터를 지정된 시간후에 자동으로 종료 합니다.             
echo │ 2 : 예약 종료 취소
echo │ 3 : 30분 예약 종료                                 
echo │ 4 : 1시간 예약 종료
echo │ 5 : 1시간 30분 예약 종료            
echo │ 6 : 2시간 예약종료
echo │ 7 : 2시간 30분 예약 종료
echo │ 8 : 3시간 예약종료
echo │ 9 : 4시간 예약 종료
echo │-------------------------------------------------------------
echo │10 : 페이지2 
echo │11 : EXIT   l   12 : CMD실행  l  13 : 업데이트 내용
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호 또는 문자 를 입력하세요.:
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
echo %DATE% %TIME%:  프로그램이 초기화됨>>C:\BATprogram\BAT.txt
reset.bat
goto EXIT


:resetmake
echo %DATE% %TIME%:  초기화 배치파일 만드는중>>C:\BATprogram\BAT.txt
echo 초기화배치파일 만드는중.
echo. 잠시만 기다려 주세요.
cd C:\
md batprogramreset
echo @echo off>>C:\batprogramreset\reset.bat
echo echo 잠시만기다려주세요>>C:\batprogramreset\reset.bat
echo timeout /t 3 > nul>>C:\batprogramreset\reset.bat
echo rd /s /q C:\batprogram>>C:\batprogramreset\reset.bat
echo echo 완료>>C:\batprogramreset\reset.bat
echo pause>>C:\batprogramreset\reset.bat
goto reset

:makemainset1
cls
echo %DATE% %TIME%:  메인1설정파일을 만드는중>>C:\BATprogram\BAT.txt
echo 설정파일을 만드는중.
cd C:\BATprogram\main
md main1
timeout /t 1 > nul
goto first



:makemainset2
cls
echo %DATE% %TIME%:  메인2설정파일을 만드는중>>C:\BATprogram\BAT.txt
echo 설정파일을 만드는중.
cd C:\BATprogram\main
md main2
timeout /t 1 > nul
goto first


:makemainset
cls
echo %DATE% %TIME%:  메인설정파일을 만드는중>>C:\BATprogram\BAT.txt
echo 메인설정 만드는중
cd C:\BATprogram
md main
timeout /t 1 > nul
goto mainse


:makemainset22
cls
echo %DATE% %TIME%:  메인설정파일을 만드는중>>C:\BATprogram\BAT.txt
echo 메인설정 만드는중
cd C:\BATprogram
md main
timeout /t 1 > nul
goto mainse2r

:color
cls
echo %DATE% %TIME%:  텍스트 색 변경으로 이동>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │ 텍스트색 변경                  뒤로가기:110
echo │-------------------------------------------------------------
echo │ 1:기본                        l 11:연한 초록색
echo │ 2:파랑색                      l 12:연한 청록색
echo │ 3:초록색                      l 13:연한 빨강색
echo │ 4:청록색                      l 14:연한 자주색
echo │ 5:빨강색                      l 15:연한 노랑색
echo │ 6:자주색                      l 16:밝은 흰색
echo │ 7:노랑색                      l 17:사용자 지정(배경,글자)
echo │ 8:흰색                        l 18:
echo │ 9:회색                        l 19:
echo │ 10:연한 파랑색                l 20:
echo │                               l
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하시는 색상을 선택해 주세요:
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
echo %DATE% %TIME%:  텍스트 색 변경으로 이동>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │ 텍스트색 변경                  뒤로가기:110
echo │-------------------------------------------------------------
echo │ 1:기본                        l 11:연한 초록색
echo │ 2:파랑색                      l 12:연한 청록색
echo │ 3:초록색                      l 13:연한 빨강색
echo │ 4:청록색                      l 14:연한 자주색
echo │ 5:빨강색                      l 15:연한 노랑색
echo │ 6:자주색                      l 16:밝은 흰색
echo │ 7:노랑색                      l 17:사용자 지정(배경,글자)
echo │ 8:흰색                        l 18:
echo │ 9:회색                        l 19:
echo │ 10:연한 파랑색                l 20:
echo │                               l
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하시는 색상을 선택해 주세요:
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
echo %DATE% %TIME%:  텍스트색을 기본 으로 변경>>C:\BATprogram\BAT.txt
goto color

:color2
cls
color 1
echo %DATE% %TIME%:  텍스트색을 파랑색 으로 변경>>C:\BATprogram\BAT.txt
goto color

:color3
cls
color 2
echo %DATE% %TIME%:  텍스트색을 초록색 으로 변경>>C:\BATprogram\BAT.txt
goto color

:color4
cls
color 3
echo %DATE% %TIME%:  텍스트색을 옥색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color5
cls
echo %DATE% %TIME%:  텍스트색을 빨강색으로 변경>>C:\BATprogram\BAT.txt
color 4

goto color

:color6
cls
color 5
echo %DATE% %TIME%:  텍스트색을 자주색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color7
cls
color 6
echo %DATE% %TIME%:  텍스트색을 노랑색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color8
cls
color 7
echo %DATE% %TIME%:  텍스트색을 흰색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color9
cls
color 8
echo %DATE% %TIME%:  텍스트색을 회색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color10
cls
color 9
echo %DATE% %TIME%:  텍스트색을 연한 파란색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color11
cls
color A
echo %DATE% %TIME%:  텍스트색을 연한 초록색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color12
cls
color B
echo %DATE% %TIME%:  텍스트색을 연한 청록색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color13
cls
color C
echo %DATE% %TIME%:  텍스트색을 연한 빨강색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color14
cls
color D
echo %DATE% %TIME%:  텍스트색을 연한 자주색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color15
cls
color E
echo %DATE% %TIME%:  텍스트색을 연한 노랑색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color16
cls
color F
echo %DATE% %TIME%:  텍스트색을 밝은 흰색으로 변경>>C:\BATprogram\BAT.txt
goto color

:color17
cls
echo 배경색코드글자색코드 ex)07
set /p a=원하는 배경의 색코드를 입력하세요:
set /p b=원하는 글자의 색코드를 입력하세요:
color %a%%b%
echo %DATE% %TIME%:  배경색:%a% 텍스트색:%b% 으로 변경>>C:\BATprogram\BAT.txt
goto color





:Com
cls
echo %DATE% %TIME%:  명령어 보이기/안 보이기>>C:\BATprogram\BAT.txt
echo 명령어 보이기:1
echo 명령어 안 보이게:2
echo 뒤로가기 : 11
set /p a=원하시는 기능을 선택하세요:
if %a%==1 goto comon
if %a%==2 goto comoff
if %a$==11 goto setting

:Com2
cls
echo %DATE% %TIME%:  명령어 보이기/안 보이기>>C:\BATprogram\BAT.txt
echo 명령어 보이기:1
echo 명령어 안 보이게:2
echo 뒤로가기 : 11
set /p a=원하시는 기능을 선택하세요:
if %a%==1 goto comon2
if %a%==2 goto comoff2
if %a$==11 goto setting2


:comoff
cls
echo %DATE% %TIME%:  명령어 안 보이기>>C:\BATprogram\BAT.txt
@echo off
echo 완료
pause
goto setting

:comoff2
cls
echo %DATE% %TIME%:  명령어 안 보이기>>C:\BATprogram\BAT.txt
@echo off
echo 완료
pause
goto setting2

:comon
cls
echo %DATE% %TIME%:  명령어 보이기>>C:\BATprogram\BAT.txt
@echo on
echo 완료
pause
goto setting2

:comon2
cls
echo %DATE% %TIME%:  명령어 보이기>>C:\BATprogram\BAT.txt
@echo on
echo 완료
pause
goto setting2

:LOG1
cls 
echo %DATE% %TIME%:  로그 목록>>C:\BATprogram\BAT.txt
echo 로그파일 초기화 : 1
echo 로그파일 열기 : 2
echo 뒤로가기 : 11
set /p a=원하시는 번호를 입력하세요:
if %a%==1 goto delLOG
if %a%==2 goto LOGopen
if %a%==11 goto setting


:LOG2
cls 
echo %DATE% %TIME%:  로그 목록>>C:\BATprogram\BAT.txt
echo 로그파일 초기화 : 1
echo 로그파일 열기 : 2
echo 뒤로가기 : 11
set /p a=원하시는 번호를 입력하세요:
if %a%==1 goto delLOG2
if %a%==2 goto LOGopen2
if %a%==11 goto setting2


:LOGopen
cls
echo %DATE% %TIME%:  로그파일 open>>C:\BATprogram\BAT.txt
cd C:\BATprogram
start BAT.txt
goto LOG1

:LOGopen
cls
echo %DATE% %TIME%:  로그파일 open>>C:\BATprogram\BAT.txt
cd C:\BATprogram
start BAT.txt
goto LOG2

:delLOG
cls
color c
set /p a=로그파일을 초기화 시키겠 습니까? y/n:
if %a%==y goto delLOG3
if %a%==n goto LOG1

color b

:delLOG2
cls
color c
set /p a=로그파일을 초기화 시키겠 습니까? y/n:
if %a%==y goto delLOG4
if %a%==n goto LOG2

color b

:delLOG3

cls
echo %DATE% %TIME%:  로그초기화>C:\BATprogram\BAT.txt
echo 완료
pause
goto LOG1

:delLOG4

cls
echo %DATE% %TIME%:  로그초기화>C:\BATprogram\BAT.txt
echo 완료
pause
goto LOG2






:report
cls
echo %DATE% %TIME%:  업데이트 내용으로 이동>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │ %vision%버전 업데이트
echo │-------------------------------------------------------------
echo │ 1.긴급 버그 패치                  
echo │ 2.
echo │ 3.
echo │ 4.
echo │ 5.       
echo │ 6.
echo │ 7.
echo │ 8.
echo │ 9.
echo │ 10.
echo │ 11.
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

pause
goto lode1212



:CMDgo
echo %DATE% %TIME%:  CMD실행>>C:\BATprogram\BAT.txt
start
goto main

:DNSr
echo %DATE% %TIME%:  인터넷 최적화 (DNS캐쉬 초기화)를 할것인가? 안할것 인가?>>C:\BATprogram\BAT.txt
cls
echo DNS캐시파일을 청소하여 인터넷 속도를 향상시킵니다.
echo 계속하시려면 y,취소하시려면n 를 입력해 주세요.
set /p a=원하는 명령을 입력하세요.:
if %a%==n goto main
if %a%==y goto DNS

:DNS

cls
echo.
echo 이프로그램은 DNS캐시 청소 명령어 활용 cmd입니다 
echo 불이익이 발생할시 제작자와는 상관이 없습니다. 
echo 동의하실꺼면 아무키나누루세요...
pause
echo %DATE% %TIME%:  DNS캐쉬 청소를 진행하셧습니다.>>C:\BATprogram\BAT.txt
color 0c
cls
ipconfig/displaydns
ipconfig/flushdns
echo.
echo.
echo 청소완료.아무키나 누루시오 ...
pause
goto main

:cancle
cls
echo %DATE% %TIME%:  예약종료 취소>>C:\BATprogram\BAT.txt
shutdown -a
echo 예약종료 취소완료
pause
cls
goto main

:30
cls
echo %DATE% %TIME%:  30분 예약종료>>C:\BATprogram\BAT.txt
shutdown -s -t 1800
echo 30분후 종료 예약 완료
pause
cls
goto main

:1h
cls
echo %DATE% %TIME%:  1시간 예약종료>>C:\BATprogram\BAT.txt
shutdown -s -t 3600
echo 1시간후 종료 예약 완료
pause
cls
goto main

:1h3s
cls
echo %DATE% %TIME%:  1시간30분 예약종료>>C:\BATprogram\BAT.txt
shutdown -s -t 5400
echo 1시간30분후 종료 예약 완료
pause
cls
goto main

:2h
cls
echo %DATE% %TIME%:  2시간 예약종료>>C:\BATprogram\BAT.txt
shutdown -s -t 7200
echo 2시간후 종료 예약 완료
pause
cls
goto main

:2h3s
cls
echo %DATE% %TIME%:  2시간30분 예약종료>>C:\BATprogram\BAT.txt
shutdown -s -t 9000
echo 2시간30분후 종료 예약 완료
pause
cls
goto main


:3h
cls
echo %DATE% %TIME%:  3시간 예약종료>>C:\BATprogram\BAT.txt
shutdown -s -t 10800
echo 3시간후 종료 예약 완료
pause
cls
goto main


:4h
cls
echo %DATE% %TIME%:  4시간 예약종료>>C:\BATprogram\BAT.txt
shutdown -s -t 14400
echo 4시간후 종료 예약 완료
pause
cls
goto main

:page2
cls 
echo %DATE% %TIME%:  페이지2 진입>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 페이지 2
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │                                                             
echo │ 1 : 메인 메뉴로 
echo │ 2 : 테스트 기능     
echo │ 3 : 테러
echo │ 4 : 프로그램 모음                              
echo │ 5 : CMD명령어들
echo │ 6 : 개발자가 심심해서 만든것들
echo │ 7 : 컴 종료/로그오프/절전 등등
echo │ 8 : 인터넷 사이트 모음
echo │ 9 : ping 테스트 (방법)
echo │ 10 : 컴퓨터 에러
echo │ 11 : 배치파일만들기
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 다음페이지:12
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  페이지3 진입>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 페이지 3 
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │                                                             
echo │ 1 : 뒤로가기
echo │ 2 : 덧셈     
echo │ 3 : 
echo │ 4 :                             
echo │ 5 : 
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │ 9 : 
echo │ 10 : 
echo │ 11 : 
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  덧셈 진입>>C:\BATprogram\BAT.txt
echo 숫자만 입력해 주세요. (2개)X    (2)o
set /p ch=총 몇개를 더하실 건가요?(2~10):
if %ch%==2 goto plus2
if %ch%==3 goto plus3
if %ch%==4 goto plus4
if %ch%==5 goto plus5
if %ch%==6 goto plus6
if %ch%==7 goto plus7
if %ch%==8 goto plus8
if %ch%==9 goto plus9
if %ch%==10 goto plus10
echo %DATE% %TIME%:  덧셈%ch%개 선택>>C:\BATprogram\BAT.txt


:plus2
cls
echo %DATE% %TIME%:  덧셈%ch%개 선택>>C:\BATprogram\BAT.txt
set /p a1=첫번째로 더할 값을 입력하세요:
set /p a2=두번째로 더할 값을 입력하세요:
set /a answ=a1+a2
echo.
echo %a1% + %a2% = %answ%
echo %DATE% %TIME%: %a1% + %a2% = %answ% 계산>>C:\BATprogram\BAT.txt
pause
goto page3

:plus3
cls
echo %DATE% %TIME%:  덧셈%ch%개 선택>>C:\BATprogram\BAT.txt
set /p a1=첫번째로 더할 값을 입력하세요:
set /p a2=두번째로 더할 값을 입력하세요:
set /p a3=세번째로 더할 값을 입력하세요:
set /a answ=a1+a2+a3
echo.
echo %a1% + %a2% +%a3% = %answ%
echo %DATE% %TIME%: %a1% + %a2% +%a3% = %answ% 계산>>C:\BATprogram\BAT.txt
pause
goto page3

:plus4
cls
echo %DATE% %TIME%:  덧셈%ch%개 선택>>C:\BATprogram\BAT.txt
set /p a1=첫번째로 더할 값을 입력하세요:
set /p a2=두번째로 더할 값을 입력하세요:
set /p a3=세번째로 더할 값을 입력하세요:
set /p a4=네번째로 더할 값을 입력하세요:
set /a answ=a1+a2+a3+a4
echo.
echo %a1% + %a2% + %a3% + %a4%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4%= %answ% 계산>>C:\BATprogram\BAT.txt
pause
goto page3

:plus5
cls
echo %DATE% %TIME%:  덧셈%ch%개 선택>>C:\BATprogram\BAT.txt
set /p a1=첫번째로 더할 값을 입력하세요:
set /p a2=두번째로 더할 값을 입력하세요:
set /p a3=세번째로 더할 값을 입력하세요:
set /p a4=네번째로 더할 값을 입력하세요:
set /p a5=다섯번째로 더할 값을 입력하세요:
set /a answ=a1+a2+a3+a4+a5
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5%= %answ% 계산>>C:\BATprogram\BAT.txt
pause
goto page3


:plus6
cls
echo %DATE% %TIME%:  덧셈%ch%개 선택>>C:\BATprogram\BAT.txt
set /p a1=첫번째로 더할 값을 입력하세요:
set /p a2=두번째로 더할 값을 입력하세요:
set /p a3=세번째로 더할 값을 입력하세요:
set /p a4=네번째로 더할 값을 입력하세요:
set /p a5=다섯번째로 더할 값을 입력하세요:
set /p a6=여섯번째로 더할 값을 입력하세요:
set /a answ=a1+a2+a3+a4+a5+a6
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5% + %a6%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5% + %a6%= %answ% 계산>>C:\BATprogram\BAT.txt
pause
goto page3

:plus7
cls
echo %DATE% %TIME%:  덧셈%ch%개 선택>>C:\BATprogram\BAT.txt
set /p a1=첫번째로 더할 값을 입력하세요:
set /p a2=두번째로 더할 값을 입력하세요:
set /p a3=세번째로 더할 값을 입력하세요:
set /p a4=네번째로 더할 값을 입력하세요:
set /p a5=다섯번째로 더할 값을 입력하세요:
set /p a6=여섯번째로 더할 값을 입력하세요:
set /p a7=일곱번째로 더할 값을 입력하세요:
set /a answ=a1+a2+a3+a4+a5+a6+a7
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7%= %answ% 계산>>C:\BATprogram\BAT.txt
pause
goto page3

:plus8
cls
echo %DATE% %TIME%:  덧셈%ch%개 선택>>C:\BATprogram\BAT.txt
set /p a1=첫번째로 더할 값을 입력하세요:
set /p a2=두번째로 더할 값을 입력하세요:
set /p a3=세번째로 더할 값을 입력하세요:
set /p a4=네번째로 더할 값을 입력하세요:
set /p a5=다섯번째로 더할 값을 입력하세요:
set /p a6=여섯번째로 더할 값을 입력하세요:
set /p a7=일곱번째로 더할 값을 입력하세요:
set /p a8=여덟번째로 더할 값을 입력하세요:
set /a answ=a1+a2+a3+a4+a5+a6+a7+a8
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8%= %answ% 계산>>C:\BATprogram\BAT.txt
pause
goto page3


:plus9
cls
echo %DATE% %TIME%:  덧셈%ch%개 선택>>C:\BATprogram\BAT.txt
set /p a1=첫번째로 더할 값을 입력하세요:
set /p a2=두번째로 더할 값을 입력하세요:
set /p a3=세번째로 더할 값을 입력하세요:
set /p a4=네번째로 더할 값을 입력하세요:
set /p a5=다섯번째로 더할 값을 입력하세요:
set /p a6=여섯번째로 더할 값을 입력하세요:
set /p a7=일곱번째로 더할 값을 입력하세요:
set /p a8=여덟번째로 더할 값을 입력하세요:
set /p a9=아홉번째로 더할 값을 입력하세요:
set /a answ=a1+a2+a3+a4+a5+a6+a7+a8+a9
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8% + %a9%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8% + %a9%= %answ% 계산>>C:\BATprogram\BAT.txt
pause
goto page3

:plus10
cls
echo %DATE% %TIME%:  덧셈%ch%개 선택>>C:\BATprogram\BAT.txt
set /p a1=첫번째로 더할 값을 입력하세요:
set /p a2=두번째로 더할 값을 입력하세요:
set /p a3=세번째로 더할 값을 입력하세요:
set /p a4=네번째로 더할 값을 입력하세요:
set /p a5=다섯번째로 더할 값을 입력하세요:
set /p a6=여섯번째로 더할 값을 입력하세요:
set /p a7=일곱번째로 더할 값을 입력하세요:
set /p a8=여덟번째로 더할 값을 입력하세요:
set /p a9=아홉번째로 더할 값을 입력하세요:
set /p a10=열번째로 더할 값을 입력하세요:
set /a answ=a1+a2+a3+a4+a5+a6+a7+a8+a9+a10
echo.
echo %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8% + %a9% + %a10%= %answ%
echo %DATE% %TIME%: %a1% + %a2% + %a3% + %a4% + %a5% + %a6% + %a7% + %a8% + %a9% + %a10%= %answ% 계산>>C:\BATprogram\BAT.txt
pause
goto page3


:batmaker
cls
echo 사용자가 명령을 내린 순서대로
echo 배치 파일을 작성합니다.
pause
if not exist C:\BATprogram\batmaker goto batmaker1
if exist C:\BATprogram\batmaker goto batmaker2

:batmaker1
echo %DATE% %TIME%:  배치파일 생성>>C:\BATprogram\BAT.txt
echo 배치파일을 생성합니다.
cd C:\BATprogram
md batmaker
echo @echo off>>C:\BATprogram\batmaker\BATmaker.bat
echo :main>>C:\BATprogram\batmaker\BATmaker.bat
pause
goto batmaker

:batmaker2
cls
echo 기존 배치파일을 확인했습니다.
echo.
pause
goto batmaker3

:batmaker3
cls
echo %DATE% %TIME%:  배치파일 만들기 진입>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : 뒤로가기
echo │ 2 : 말나오게 하기(echo)    
echo │ 3 : 계속하려면 아무키나 누루시오(pause)
echo │ 4 : 다음줄로(echo.)                              
echo │ 5 : 명령
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │ 9 : 
echo │ 10 : 
echo │ 11 : 배치파일 실행하기
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
set /p comm=원하는 명령을 적으세요:
echo echo %comm%>>C:\BATprogram\batmaker\BATmaker.bat

cls
echo 결과물을 확인하세요!
cd C:\BATprogram\batmaker
call BATmaker.bat
echo %DATE% %TIME%:  배치파일에 명령어%comm%을(를) 작성 >>C:\BATprogram\BAT.txt
pause
goto batmaker3


:echo.
cls
echo echo.>>C:\BATprogram\batmaker\BATmaker.bat
echo 결과물
cd C:\BATprogram\batmaker
call BATmaker.bat
echo %DATE% %TIME%:  배치파일에 echo. 를 작성 >>C:\BATprogram\BAT.txt
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
set /p c=원하는 말을 적으세요:
echo echo %c%>>C:\BATprogram\batmaker\BATmaker.bat
echo 완료 !

echo %DATE% %TIME%:  배치파일에 %c% 라는 메세지를 만듬>>C:\BATprogram\BAT.txt

echo 결과물
cd C:\BATprogram\batmaker
call BATmaker.bat

pause
goto batmaker3

:pause
cls
echo pause>>C:\BATprogram\batmaker\BATmaker.bat
echo 결과물
cd C:\BATprogram\batmaker
call BATmaker.bat
echo %DATE% %TIME%:  배치파일에 pause 를 작성 >>C:\BATprogram\BAT.txt
pause
goto batmaker3

:erro
cls 
echo %DATE% %TIME%:  컴퓨터 오류 목록 진입>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : 식별되지 않는 네트워크(자동 수정)
echo │ 2 :      
echo │ 3 : 
echo │ 4 :                               
echo │ 5 : 
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │ 9 : 
echo │
echo │
echo │뒤로가기:11
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
set /p a=진행하려면 y 뒤로가려면n:
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
echo 완료 되었습니다.
pause
goto erro


cd C:\Users\XNOTE\AppData\Roaming\.minecraft
pkzip -rp BACUP
oause
echo 완료!

:ping
echo %DATE% %TIME%:  ping 테스트 진행or뒤로가기>>C:\BATprogram\BAT.txt
cls
echo 다음 화면에서 나오는 
echo '기본 게이트웨이' 를 외워주세요
set /p a=계속하기:y 그만하기:n  :
if %a%==y goto pingtest
if %a%==n goto page2

:pingtest
cls
echo %DATE% %TIME%:  ping테스트 진행>>C:\BATprogram\BAT.txt
echo 다음 화면에서 나오는 
echo '기본 게이트웨이' 를 외워주세요.ex)192.116.5.9
pause
ipconfig
echo.
echo.
echo.
echo.
echo.
echo '기본 게이트웨이'를 외워주세요ex)192.116.5.9
pause
start
echo 새 cmd 창에서 ping -t 외운 아이피 주소 를 입력해 주세요.
echo 예시: ping -t 192.845.54.8
pause
echo %DATE% %TIME%:  ping테스트 진행 완료>>C:\BATprogram\BAT.txt
goto page2



:innet
echo %DATE% %TIME%:  사이트 목록 진입>>C:\BATprogram\BAT.txt
cls
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : 네이버
echo │ 2 : 다음
echo │ 3 : 네이트
echo │ 4 : 구글                              
echo │ 5 : 드롭박스
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │
echo │
echo │
echo │다음페이지:22                                    뒤로가기:11
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  사이트 목록 2번째 페이지 진입>>C:\BATprogram\BAT.txt
cls
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : 방송국 사이트
echo │ 2 : 해외 사이트
echo │ 3 : 
echo │ 4 :                           
echo │ 5 : 
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │
echo │
echo │
echo │다음페이지:22                                   뒤로가기:11
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  방송국 사이트 목록 진입>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : 국내 방송국 사이트
echo │ 2 : 해외 방송국 사이트
echo │ 3 : 뒤로가기
echo │ 4 :                           
echo │ 5 : 
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │
echo │
echo │
echo │뒤로가기:22
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  한국 방송국 사이트 목록 진입>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : KBS
echo │ 2 : MBS
echo │ 3 : SBS
echo │ 4 : YTN                        
echo │ 5 : JTBC
echo │ 6 : tvN
echo │ 7 : MBN
echo │ 8 : 채널A
echo │ 9 : TV조선
echo │ 10 : 연합뉴스
echo │
echo │ 뒤로가기:11 다음페이지:준비중  
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  연합뉴스 사이트 접속>>C:\BATprogram\BAT.txt
start www.yonhapnews.co.kr
goto koreabcs

:TVz
cls
echo %DATE% %TIME%:  TV조선 사이트 접속>>C:\BATprogram\BAT.txt
start www.tvchosun.com
goto koreabcs

:chA
cls
echo %DATE% %TIME%:  채널A 사이트 접속>>C:\BATprogram\BAT.txt
start m.ichannela.com
goto koreabcs


:MBN
cls
echo %DATE% %TIME%:  MBN 사이트 접속>>C:\BATprogram\BAT.txt
start mbn.mk.co.kr
goto koreabcs

:tvN
cls
echo %DATE% %TIME%:  Tvn 사이트 접속>>C:\BATprogram\BAT.txt
start tvn.tving.com
goto koreabcs

:JTBC
cls
start onair.jtbc.joins.com
echo %DATE% %TIME%:  JTBC 사이트 접속>>C:\BATprogram\BAT.txt
goto koreabcs

:YTN
cls
start http://www.ytn.co.kr/
echo %DATE% %TIME%:  YTN 사이트 접속>>C:\BATprogram\BAT.txt
goto koreabcs

:SBS
cls
start www.sbs.co.kr
echo %DATE% %TIME%:  SBS 사이트 접속>>C:\BATprogram\BAT.txt
goto koreabcs

:MBC
cls
start www.imbc.com
echo %DATE% %TIME%:  MBC 사이트 접속>>C:\BATprogram\BAT.txt
goto koreabcs

:hbcs
cls
echo %DATE% %TIME%:  해외 방송국 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : CNN
echo │ 2 : BBC
echo │ 3 : 일본 방송국
echo │ 4 : 중국 방송국                      
echo │ 5 : 미국 방송국
echo │ 6 : 캐나다 방송국
echo │ 7 : 호주 방송국
echo │ 8 : 타이완 방송국
echo │
echo │
echo │
echo │ 뒤로가기:11 다음페이지:준비중  
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  타이완 방송국 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : TTV
echo │ 2 : CTV
echo │ 3 : CTS
echo │ 4 : FTV                     
echo │ 5 : PTS
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │
echo │
echo │
echo │ 뒤로가기:11 다음페이지:준비중  참고:위키백과
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  TTV 사이트 접속>>C:\BATprogram\BAT.txt
cls
start http://www.ttv.com.tw/
goto hk

:CTV
cls
start http://beta.ctv.com.tw/
echo %DATE% %TIME%:  CTV 사이트 접속>>C:\BATprogram\BAT.txt
goto hk

:CTS
cls
start http://www.cts.com.tw/
echo %DATE% %TIME%:  CTS 사이트 접속>>C:\BATprogram\BAT.txt
goto hk

:FTV
cls
start http://www.ftv.com.tw/index.aspx
echo %DATE% %TIME%:  FTV 사이트 접속>>C:\BATprogram\BAT.txt
goto hk

:PTS
cls
start http://www.pts.org.tw/
echo %DATE% %TIME%:  PTS 사이트 접속>>C:\BATprogram\BAT.txt
goto hk

:jpan
cls
echo %DATE% %TIME%:  일본 방송국 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : NHK 종합텔레비전
echo │ 2 : NTV 닛폰 TV 방송망
echo │ 3 : 도쿄방송
echo │ 4 : TV아사이                 
echo │ 5 : 후지TV
echo │ 6 : TV도쿄
echo │ 7 : 도쿄 메트로폴리탄 텔레비전
echo │ 8 : 
echo │
echo │
echo │
echo │ 뒤로가기:11 다음페이지:준비중  참고:위키백과
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  후지 사이트 접속>>C:\BATprogram\BAT.txt
start http://www.fujitv.co.jp/index.html
goto jpan

:dk
cls
start http://www.tv-tokyo.co.jp/
echo %DATE% %TIME%:  도쿄 사이트 접속>>C:\BATprogram\BAT.txt
goto jpan

:dm
cls
start http://s.mxtv.jp/
echo %DATE% %TIME%:  도쿄 메트로 폴리탄 텔레비전 사이트 접속>>C:\BATprogram\BAT.txt
goto jpan

:ch
cls
echo %DATE% %TIME%:  중국 방송국 사이트 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : CCTV
echo │ 2 : CETV
echo │ 3 : BTV
echo │ 4 : TJTV                     
echo │ 5 : SMG
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │
echo │
echo │ 
echo │ 뒤로가기:11 다음페이지:준비중  참고:위키백과
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  CCTV(방송국) 사이트 접속>>C:\BATprogram\BAT.txt
goto ch

:CETV
cls
start http://www.cetv.edu.cn/
echo %DATE% %TIME%:  CETV 사이트 접속>>C:\BATprogram\BAT.txt
goto ch

:BTY
cls
start http://www.btime.com/btv/btvsy_index
echo %DATE% %TIME%:  BTY 사이트 접속>>C:\BATprogram\BAT.txt
goto ch

:TJTY
cls
start http://tjtv.enorth.com.cn/
echo %DATE% %TIME%:  TJTY 사이트 접속>>C:\BATprogram\BAT.txt
goto ch

:SMG
cls
start http://www.smg.cn/
echo %DATE% %TIME%:  SMG 사이트 접속>>C:\BATprogram\BAT.txt
goto ch

:usa
cls
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : ABC
echo │ 2 : CBS
echo │ 3 : The CW
echo │ 4 : PBS                  
echo │ 5 : 
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │
echo │
echo │
echo │ 뒤로가기:11 다음페이지:준비중  참고:위키백과
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  ABC사이트 접속>>C:\BATprogram\BAT.txt
goto usa

:CBS
cls
start http://www.cbs.com/
echo %DATE% %TIME%:  CBS 사이트 접속>>C:\BATprogram\BAT.txt
goto usa 

:CW
cls
start http://www.cwtv.com/
echo %DATE% %TIME%:  CW 사이트 접속>>C:\BATprogram\BAT.txt
goto usa

:PBS
cls
start http://www.pbs.org/
echo %DATE% %TIME%:  PBS 사이트 접속>>C:\BATprogram\BAT.txt
goto usa

:ca
cls
echo %DATE% %TIME%:  캐나다 방송국 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : CBC
echo │ 2 : SRC
echo │ 3 : CTV
echo │ 4 :                         
echo │ 5 : 
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │
echo │
echo │
echo │ 뒤로가기:11 다음페이지:준비중  참고:위키백과
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  CBC 사이트 접속>>C:\BATprogram\BAT.txt
goto ca

:SRC
cls
start http://ici.radio-canada.ca/television/
echo %DATE% %TIME%:  SRC 사이트 접속>>C:\BATprogram\BAT.txt
goto ca

:CTV
cls
start http://www.ctv.ca/
echo %DATE% %TIME%:  CTV 사이트 접속>>C:\BATprogram\BAT.txt
goto ca


:hz
cls
echo %DATE% %TIME%:  호주 방송국 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : ABC TV
echo │ 2 : SBS TV
echo │ 3 : 
echo │ 4 :                         
echo │ 5 : 
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │
echo │
echo │
echo │ 뒤로가기:11 다음페이지:준비중  참고:위키백과
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  ABC(호주) 사이트 접속>>C:\BATprogram\BAT.txt
goto hz


:SBSTV
cls
start http://www.sbs.com.au/
echo %DATE% %TIME%:  SBS(호주) 사이트 접속>>C:\BATprogram\BAT.txt
goto hz


:ANB
cls
start http://www.tv-asahi.co.jp/
echo %DATE% %TIME%:  ANB 사이트 접속>>C:\BATprogram\BAT.txt
goto hbcs

:TBS
cls
start http://www.tbs.co.jp/
echo %DATE% %TIME%:  TBS 사이트 접속>>C:\BATprogram\BAT.txt
goto hbcs

:NTV
cls
start http://www.ntv.co.jp/
echo %DATE% %TIME%:  NTV 사이트 접속>>C:\BATprogram\BAT.txt
goto hbcs

:NHK
cls
start http://www.nhk.or.jp
echo %DATE% %TIME%:  NHK 사이트 접속>>C:\BATprogram\BAT.txt
goto hbcs

:BBC
cls
start www.bbc.co.uk
echo %DATE% %TIME%:  BBC 사이트 접속>>C:\BATprogram\BAT.txt
goto hbcs

:CNN
cls
start www.cnn.com
echo %DATE% %TIME%:  CNN사이트 접속>>C:\BATprogram\BAT.txt
goto hbcs


:KBS
cls
start http://www.kbs.co.kr/
echo %DATE% %TIME%:  KBS 사이트 접속>>C:\BATprogram\BAT.txt
goto innet

:dropbox
cls
start https://www.dropbox.com
echo %DATE% %TIME%:  dropbox 사이트 접속>>C:\BATprogram\BAT.txt
goto innet 

:google
cls
start https://www.google.co.kr
echo %DATE% %TIME%:  구글 사이트 접속>>C:\BATprogram\BAT.txt
goto innet

:nate
cls
start http://www.nate.com
echo %DATE% %TIME%:  네이트 사이트 접속>>C:\BATprogram\BAT.txt
goto innet

:daum
cls
start http://www.daum.net
echo %DATE% %TIME%:  daum 사이트 접속>>C:\BATprogram\BAT.txt
goto innet

:naver
cls
start www.naver.com
echo %DATE% %TIME%:  네이버 사이트 접속>>C:\BATprogram\BAT.txt
goto innet

:shut
cls
echo %DATE% %TIME%:  강제 종료,로그오프 등등 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │원하는 기능의 번호를 입력하시면 타이머 설정이 나옵니다.
echo │ 1 : 뒤로가기
echo │ 2 : 종료
echo │ 3 : 로그오프
echo │ 4 : 재시작                    
echo │ 5 : 재시작(g)
echo │ 6 : 절전모드
echo │ 7 : 원격종료
echo │
echo │
echo │
echo │ 이 기능들은 테스트진행이 되지 않았습니다.
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  예약 종료 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │원하는 기능의 번호를 입력하시면 타이머 설정이 나옵니다.
echo │ 1 : 뒤로가기
echo │ 2 : 30분
echo │ 3 : 1시간
echo │ 4 : 1시간30분              
echo │ 5 : 2시간
echo │ 6 : 2시간30분	
echo │ 7 : 3시간
echo │ 8 : 4시간
echo │ 9 : 당장
echo │ 10 : 사용자 지정
echo │
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo 메인으로 나가기 : 0000
echo.
echo.
echo 최대 199999999초
echo.
echo.
set /p a=원하시는 시간(초단위) 를 입력하세요:
echo %DATE% %TIME%:  %a%초 예약 종료>>C:\BATprogram\BAT.txt
echo %a%초후 컴퓨터가 종료됩니다.
shutdown -s -t %a%

pause
goto shutdowntime

:30s
cls
shutdown -s -t 1800
echo 30분후 종료 예약 완료
pause
cls
echo %DATE% %TIME%:  30분 예약 종료>>C:\BATprogram\BAT.txt
goto shut

:1hs
cls
shutdown -s -t 3600
echo 1시간후 종료 예약 완료
echo %DATE% %TIME%:  1시간 종료 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1h3ss
cls
shutdown -s -t 5400
echo 1시간30분후 종료 예약 완료
echo %DATE% %TIME%:  1시간 30분 종료 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2hs
cls
shutdown -s -t 7200
echo 2시간후 종료 예약 완료
echo %DATE% %TIME%:  2시간 종료 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2h3ss
cls
shutdown -s -t 9000
echo 2시간30분후 종료 예약 완료
echo %DATE% %TIME%:  2시간 30분 종료 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:3hs
cls
shutdown -s -t 10800
echo 3시간후 종료 예약 완료
echo %DATE% %TIME%:  3시간 종료 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:4hs
cls
shutdown -s -t 14400
echo 4시간후 종료 예약 완료
echo %DATE% %TIME%:  4시간 종료 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut



:l
cls
echo %DATE% %TIME%:  로그오프 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │원하는 기능의 번호를 입력하시면 타이머 설정이 나옵니다.
echo │ 1 : 뒤로가기
echo │ 2 : 30분
echo │ 3 : 1시간
echo │ 4 : 1시간30분              
echo │ 5 : 2시간
echo │ 6 : 2시간30분	
echo │ 7 : 3시간
echo │ 8 : 4시간
echo │ 9 : 당장
echo │
echo │
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━


set /p a=원하는 번호를 입력하세요.:
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
echo 30분후  예약 완료
echo %DATE% %TIME%:  로그오프 30 분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1hl
cls
shutdown -l -t 3600
echo 1시간후  예약 완료
echo %DATE% %TIME%:  로그오프 1시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1h3sl
cls
shutdown -l -t 5400
echo 1시간30분후  예약 완료
echo %DATE% %TIME%:  로그오프 1시간 30분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2hl
cls
shutdown -l -t 7200
echo 2시간후  예약 완료
echo %DATE% %TIME%:  로그오프 2시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2h3sl
cls
shutdown -l -t 9000
echo 2시간30분후  예약 완료
echo %DATE% %TIME%:  로그오프 2시간 30분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:3hl
cls
shutdown -l -t 10800
echo 3시간후  예약 완료
echo %DATE% %TIME%:  로그오프 3시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:4hl
cls
shutdown -l -t 14400
echo 4시간후 예약 완료
echo %DATE% %TIME%:  로그오프 4시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:rightnowl
cls
echo %DATE% %TIME%:  로그오프 실행>>C:\BATprogram\BAT.txt
shutdown -l -t 0
goto shut

:g
cls
echo %DATE% %TIME%:  재부팅(g) 목록 >>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │원하는 기능의 번호를 입력하시면 타이머 설정이 나옵니다.
echo │ 1 : 뒤로가기
echo │ 2 : 30분
echo │ 3 : 1시간
echo │ 4 : 1시간30분              
echo │ 5 : 2시간
echo │ 6 : 2시간30분	
echo │ 7 : 3시간
echo │ 8 : 4시간
echo │ 9 : 당장
echo │
echo │
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━


set /p a=원하는 번호를 입력하세요.:
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
echo 30분후  예약 완료
echo %DATE% %TIME%:  재부팅(g)30분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1hlg
cls
shutdown -g -t 3600
echo 1시간후  예약 완료
echo %DATE% %TIME%:  재부팅(g) 1시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1h3slg
cls
shutdown -g -t 5400
echo 1시간30분후  예약 완료
echo %DATE% %TIME%:  재부팅(g) 1시간 30분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2hlg
cls
shutdown -g -t 7200
echo 2시간후  예약 완료
echo %DATE% %TIME%:  재부팅(g) 2시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2h3slg
cls
shutdown -g -t 9000
echo 2시간30분후  예약 완료
echo %DATE% %TIME%:  재부팅(g) 2시간30분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:3hlg
cls
shutdown -g -t 10800
echo 3시간후  예약 완료
echo %DATE% %TIME%:  재부팅(g) 3시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:4hlg
cls
shutdown -g -t 14400
echo %DATE% %TIME%:  재부팅(g) 4시간 예약>>C:\BATprogram\BAT.txt
echo 4시간후 예약 완료
pause
cls
goto shut

:rightnowg
echo %DATE% %TIME%:  재부팅(g) 실행>>C:\BATprogram\BAT.txt
cls
shutdown -g -t 0
goto shut


:r
cls
echo %DATE% %TIME%:  재부팅 목록>>C:\BATprogram\BAT.txt
cls
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │원하는 기능의 번호를 입력하시면 타이머 설정이 나옵니다.
echo │ 1 : 뒤로가기
echo │ 2 : 30분
echo │ 3 : 1시간
echo │ 4 : 1시간30분              
echo │ 5 : 2시간
echo │ 6 : 2시간30분	
echo │ 7 : 3시간
echo │ 8 : 4시간
echo │ 9 : 당장
echo │
echo │
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━


set /p a=원하는 번호를 입력하세요.:
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
echo 30분후  예약 완료
echo %DATE% %TIME%:  재부팅 30분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1hr
cls
shutdown -r -t 3600
echo 1시간후  예약 완료
echo %DATE% %TIME%:  재부팅 1시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1h3sr
cls
shutdown -r -t 5400
echo 1시간30분후  예약 완료
echo %DATE% %TIME%:  재부팅 1시간30분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2hr
cls
shutdown -r -t 7200
echo 2시간후  예약 완료
echo %DATE% %TIME%:  재부팅 2시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2h3sr
cls
shutdown -r -t 9000
echo 2시간30분후  예약 완료
echo %DATE% %TIME%:  재부팅 2시간30분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:3hr
cls
shutdown -r -t 10800
echo 3시간후  예약 완료
echo %DATE% %TIME%:  재부팅 3시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut


:4hr
cls
shutdown -r -t 14400
echo 4시간후 예약 완료
echo %DATE% %TIME%:  재부팅 4시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:rightnowr
echo %DATE% %TIME%:  재부팅 실행>>C:\BATprogram\BAT.txt
cls
shutdown -r -t 0
goto shut

:h
cls
echo %DATE% %TIME%:  절전모드 목록>>C:\BATprogram\BAT.txt
cls
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │원하는 기능의 번호를 입력하시면 타이머 설정이 나옵니다.
echo │ 1 : 뒤로가기
echo │ 2 : 30분
echo │ 3 : 1시간
echo │ 4 : 1시간30분              
echo │ 5 : 2시간
echo │ 6 : 2시간30분	
echo │ 7 : 3시간
echo │ 8 : 4시간
echo │ 9 : 당장
echo │
echo │
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━


set /p a=원하는 번호를 입력하세요.:
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
echo 30분후  예약 완료
echo %DATE% %TIME%:  절전모드 30분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:1hh
cls
shutdown -h -t 3600
echo %DATE% %TIME%:  절전모드 1시간 예약>>C:\BATprogram\BAT.txt
echo 1시간후  예약 완료
pause
cls
goto shut

:1h3sh
cls
shutdown -h -t 5400
echo 1시간30분후  예약 완료
echo %DATE% %TIME%:  절전모드 1시간30분 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2hh
cls
shutdown -h -t 7200
echo 2시간후  예약 완료
echo %DATE% %TIME%:  절전모드 2시간 예약>>C:\BATprogram\BAT.txt
pause
cls
goto shut

:2h3sh
cls
shutdown -h -t 9000
echo %DATE% %TIME%:  절전모드 2시간30분 예약>>C:\BATprogram\BAT.txt
echo 2시간30분후  예약 완료
pause
cls
goto shut


:3hh
cls
shutdown -h -t 10800
echo %DATE% %TIME%:  절전모드 3시간 예약>>C:\BATprogram\BAT.txt
echo 3시간후  예약 완료
pause
cls
goto shut

:4hh
cls
shutdown -h -t 14400
echo %DATE% %TIME%:  절전모드 4시간 예약>>C:\BATprogram\BAT.txt
echo 4시간후 예약 완료
pause
cls
goto shut

:rightnowh
cls

shutdown -h -t 0
echo %DATE% %TIME%:  절전모드 실행>>C:\BATprogram\BAT.txt
cls
goto shut


:i
cls
echo %DATE% %TIME%:  원격 종료 목록>>C:\BATprogram\BAT.txt
cls
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │원하는 기능의 번호를 입력하시면 타이머 설정이 나옵니다.
echo │ 1 : 뒤로가기
echo │ 2 : 
echo │ 3 : 
echo │ 4 :              
echo │ 5 : 
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │ 9 : 당장
echo │
echo │
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━


set /p a=원하는 번호를 입력하세요.:
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
echo 30분후  예약 완료
pause
cls
goto shut

:1hli
cls
shutdown -i -t 3600
echo 1시간후  예약 완료
pause
cls
goto shut

:1h3sli
cls
shutdown -i -t 5400
echo 1시간30분후  예약 완료
pause
cls
goto shut

:2hli
cls
shutdown -i -t 7200
echo 2시간후  예약 완료
pause
cls
goto shut

:2h3sli
cls
shutdown -i -t 9000
echo 2시간30분후  예약 완료
pause
cls
goto shut


:3hli
cls
shutdown -i -t 10800
echo 3시간후  예약 완료
pause
cls
goto shut


:4hli
cls
shutdown -i -t 14400
echo 4시간후 예약 완료
pause
cls
goto shut

:rightnowi
cls
shutdown -i -t 0
echo %DATE% %TIME%:  원격종료 실행>>C:\BATprogram\BAT.txt
cls
goto shut


:simsim
cls
echo %DATE% %TIME%:  개발자가 심심해서 만든 기능들 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : 뒤로가기
echo │ 2 : 문상 크랙기
echo │ 3 : CMD도배
echo │ 4 : 앵무새                          
echo │ 
echo │ 
echo │
echo │
echo │
echo │
echo │
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo [앵무새]아무말이나 해봐요
echo %DATE% %TIME%:  앵무새 실행>>C:\BATprogram\BAT.txt
goto parrot2

:parrot2


echo.
set /p a=원하는 말:

echo.
echo [앵무새]%a%
echo %DATE% %TIME%:  앵무새에게 "%a%" 라고 말하셧 습니다.>>C:\BATprogram\BAT.txt
goto parrot2




:net
echo %DATE% %TIME%:  net>>C:\BATprogram\BAT.txt
cls
echo 인터넷 연결을 해제 해버립니다.
echo.
echo 이 기능을 실행하고 복구명령을 실행하시려면
echo 페이지 2 에서 43을 입력하세요. 
echo.
echo 이 기능을 실행하고 복구명령을 실행하시려면
echo 페이지 2 에서 43을 입력하세요.
echo.
echo 이 기능을 실행하고 복구명령을 실행하시려면
echo 페이지 2 에서 43을 입력하세요.
echo.
echo 이 기능을 실행하고 복구명령을 실행하시려면
echo 페이지 2 에서 43을 입력하세요.

set /p a==y실행 n거절.:
if %a%==y goto netgo
if %a%==n goto TEST



:netgo
cls
echo %DATE% %TIME%:  네트워크 연결 해제>>C:\BATprogram\BAT.txt
cls
ipconfig/release
echo 실행 완료......
echo 이 기능을 실행하고 복구명령을 실행하시려면
echo 페이지 2 에서 43을 입력하세요.
echo.
echo 이 기능을 실행하고 복구명령을 실행하시려면
echo 페이지 2 에서 43을 입력하세요. 
echo.
echo 이 기능을 실행하고 복구명령을 실행하시려면
echo 페이지 2 에서 43을 입력하세요.
echo.
echo 이 기능을 실행하고 복구명령을 실행하시려면
echo 페이지 2 에서 43을 입력하세요.
echo.
echo 이 기능을 실행하고 복구명령을 실행하시려면
echo 페이지 2 에서 43을 입력하세요.
pause 
goto Tr

:CMDdo
cls
echo %DATE% %TIME%:  CMD 도배를 하시겠습니까?>>C:\BATprogram\BAT.txt
echo are you ready?
echo y/n

set /p a=y/n:
if %a%==n goto simsim
if %a%==y goto CMDdo2


:CMDdo2
echo %DATE% %TIME%:  CMD도배 시작>>C:\BATprogram\BAT.txt
goto CMDdo3


:CMDdo3 



echo 안녕하시오?
echo 도배기에 들어오시다니 반갑소
echo 행운을 빌겠소 
echo 맞춤법(?)

goto CMDdo3


:joclack
cls
echo %DATE% %TIME%:  문상 크랙기 실행 (장난용)>>C:\BATprogram\BAT.txt
color 5a

echo 문상 크랙기 86.886V
pause
echo ll
pause
echo 서버 접속.완료!
pause
echo 보안 절차 입니다 스페이스바를 딱 3번만 눌러주세요 ! (꼭)
pause
pause
pause

:random
echo ??? %ramdom%



pause
echo 다시
pause
color 0a
mode 1000

:A
echo %random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%%random%




goto A

:CMDms
cls
echo 명령어 사용법을 알고,사용 용도를 아시는분만
echo 진행하시기 바랍니다.
pause
echo 명령어 사용법을 알고,사용 용도를 아시는분만
echo 진행하시기 바랍니다.
pause
goto CMDs

:CMDs
cls
echo %DATE% %TIME%:  CMD명령어 목록 진입>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ CMD명령어 목록
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │                                                             
echo │ 1 :  기본 명령어
echo │ 2 :  네트워크 관련 명령어
echo │ 3 : 
echo │ 4 :                             
echo │ 5 : 
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │ 9 : 
echo │ 10 : 
echo │ 
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 뒤로가기:11
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  CMD명령어 목록-기본>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ CMD명령어 목록(기본)
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │                                                             
echo │ 1 :  
echo │ 2 : ipconfig
echo │ 3 : diskpart
echo │ 4 : msconfig                    
echo │ 5 : tree(실행 위치)
echo │ 6 : tree(C드라이브 위치)
echo │ 7 : netstat
echo │ 8 : 
echo │ 9 : 
echo │ 10 : 
echo │ 
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 뒤로가기:11
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  CMD명령어 목록-네트워크 관련>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 네트워크 관련 CMD명령어
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │                                                             
echo │ 1 : ipconfig
echo │ 2 : ipconfig /release
echo │ 3 : ipconfig /renew
echo │ 4 : ipconfig /flushdns
echo │ 5 : ipconfig /registerdns    
echo │ 6 : netsh winsock reset
echo │ 7 : netsh int ip reset
echo │ 8 : netsh int tcp set heuristics disabled
echo │ 9 : netsh int tcp set global autotuninglevel=disabled
echo │ 10 : netsh int tcp set global rss=enabled
echo │  
echo │ 
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 뒤로가기:11         다음페이지:12
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  CMD명령어 목록-네트워크 관련2>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 네트워크 관련 CMD명령어2
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │                                                             
echo │ 1 : netsh int tcp show global
echo │ 2 : 
echo │ 3 : 
echo │ 4 :                   
echo │ 5 : 
echo │ 6 : 
echo │ 7 : 
echo │ 8 : 
echo │ 9 : 
echo │ 10 : 
echo │ 
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
echo │ 뒤로가기:11
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  netstat 명령 실행>>C:\BATprogram\BAT.txt
pause
goto CMDs

:treeC
cls
cd C:\
tree
echo %DATE% %TIME%:  C드라이브에서 tree명령어 실행>>C:\BATprogram\BAT.txt
pause
goto CMDs

:tree
cls
tree
echo %DATE% %TIME%:  tree 명령어 실행>>C:\BATprogram\BAT.txt
pause
goto CMDs

:msconfig
cls
msconfig
echo %DATE% %TIME%:  msconfig 명령어 실행>>C:\BATprogram\BAT.txt
goto Cmds

:ipconfig
cls
ipconfig
echo %DATE% %TIME%:  ipconfig 명령어 실행>>C:\BATprogram\BAT.txt
pause
goto CMDs

:diskpart
cls
diskpart
echo 명령 실행 완료
echo %DATE% %TIME%:  diskpart 명령어 실행>>C:\BATprogram\BAT.txt
pause
goto CMDs

:programs
cls
echo %DATE% %TIME%:  프로그램들 목록>>C:\BATprogram\BAT.txt 
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : 뒤로가기
echo │ 2 : 메모장 실행
echo │ 3 : msconfig
echo │ 4 : 작업관리자                             
echo │ 5 : 캡쳐도구
echo │ 6 : 워드패드        
echo │ 7 : 그림판
echo │ 8 : 문자표
echo │ 9 : 인터넷 연결 문제해결사
echo │ 10 : 들어오는 연결 문제해결사
echo │ 11 : 네트워크 어댑터 문제해결사
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  문자표 실행>>C:\BATprogram\BAT.txt
goto programs

:mspaint
cls
cd %windir%\system32
mspaint.exe
echo %DATE% %TIME%:  그림판 실행>>C:\BATprogram\BAT.txt
goto programs

:wordpad
cls
cd %ProgramFiles%\Windows NT\Accessories
wordpad.exe
echo %DATE% %TIME%:  워드패드 실행>>C:\BATprogram\BAT.txt
goto programs

:SnippingTool
cls
cd %windir%\system32
SnippingTool.exe
echo %DATE% %TIME%:  캡쳐도구 실행>>C:\BATprogram\BAT.txt
goto programs

:Taskmgr
cls
cd C:\WINDOWS\system32
echo %DATE% %TIME%:  작업관리자 실행>>C:\BATprogram\BAT.txt
goto programs


:notepad
cls
cd C:\WINDOWS\system32
notepad.exe
echo %DATE% %TIME%:  메모장 실행>>C:\BATprogram\BAT.txt
goto programs


:Tr
cls
echo %DATE% %TIME%:  테러기능 목록>>C:\BATprogram\BAT.txt
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1.뒤로가기
echo │ 2.CMD 테러
echo │ 3.CMD 테러(매우강함)(실행 하지 마시길 바랍니다)
echo │ 4.폴더 테러기
echo │ 5.인터넷 연결 해제
echo │         
echo │
echo │
echo │
echo │
echo │
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  CMD테러 (약함) >>C:\BATprogram\BAT.txt
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
echo %DATE% %TIME%:  CMD테러 (매우강함)>>C:\BATprogram\BAT.txt
START %0


pause
goto Tr

:BT
cls
echo %DATE% %TIME%:  바탕화면 테러를 하시겠습니까?>>C:\BATprogram\BAT.txt
echo  이 기능은 반자동(?) 입니다.
pause
echo 이 기능은 폴더를 생성하여 테러하는 방식 입니다. 사용법은 도움말을 참고하세요.
set /p a=계속 하시려면1번 뒤로 가시려면 2번 도움말을 보시려면3번 을 입력해 주세요. EX)3:
if %a%==1 goto BTgo
if %a%==2 goto Tr
if %a%==3 goto BThelp


:BTgo
set /p a=원하시는 경로를 입력하세요:
if not exist %a% goto BTerro
if %a%==0000 BT
if exist %a% goto BTgogo


:BTgogo
echo %DATE% %TIME%:  %a%에 폴더 테러 실행>>C:\BATprogram\BAT.txt
cd %a%
md %random%%random%%random%
goto BTgogo


:BTerro
경로를 찾을 수 없습니다.
pasue
goto BT

 

:BThelp
cls
echo %DATE% %TIME%:  바탕화면 테러 도움말 실행>>C:\BATprogram\BAT.txt
echo 원하시는 폴더에 테러하시려면?
echo 폴더의 경로를 입력하세요!
echo.
echo 바탕화면에 태러하려면?
echo 경로: C:\Users\유저이름\Desktop
echo 사용자의 이름이 hello 라면,
echo 경로는 C:\Users\hello\Deskop 입니다.

pause
goto BT
:TEST
cls
echo %DATE% %TIME%:  테스트 기능 목록>>C:\BATprogram\BAT.txt 
echo ┍━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━        
echo │
echo │ 1 : 뒤로가기
echo │ 2 : bat파일모음기 재실행(?)
echo │ 3 : 컴퓨터 종료 (카테고리)
echo │ 4 :                             
echo │
echo │         
echo │
echo │
echo │
echo │
echo │
echo │
echo ┕━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

set /p a=원하는 번호를 입력하세요.:
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
echo %DATE% %TIME%:  테스트 기능-프로그램 다시시작>>C:\BATprogram\BAT.txt
echo 실 행 하 시 겠 습 니  까?
pause
bat파일모음5+5.bat

pause

:RE
cls
echo %DATE% %TIME%:  net 복구 기능>>C:\BATprogram\BAT.txt
echo 잠시만 기다려 주세요.
ipconfig/renew


pause
goto page2

:shutdown
cls
echo %DATE% %TIME%:  컴퓨터 종료>>C:\BATprogram\BAT.txt
shutdown -s -t 0

echo 굿 바이
pause




:help
echo 처음으로 오셧군요~?
pause 
cd C:\
md BATprogram
echo 간단프로그램LOG>C:\BATprogram\BAT.txt





echo.
echo 환영합니다! 

pause
echo.
echo 이 화면은 처음 실행시에만 나타납니다.

pause
cls
set /p b=당신의 이름은?:
echo 오!%b%님! 정말 멋진 이름이네요!
pause 
echo.
echo.
echo 만나서 반가워요 %b%님!

echo.
echo.
pause

set /p a=%b%님! 제작자를 보려시면y를 프로그램을 시작하시려면 n을 입력해 주세요!:
if %a%==y goto maker
if %a%==n goto first

pause
cls
goto first



:maker
cls
echo ▼제작자▼
echo 한초
echo 프로젝트를 제작하신분
echo.
echo.
echo 새별
echo.
echo.
pause
echo.
echo.
echo 그리고 당신
echo 바로 "%b%"님
echo.
pause
echo.
echo.
echo %b%님도 버그제보,추가기능 등을 제보하여
echo 이 프로그램에 도움을 주실 수 있습니다.
echo.
echo.


pause 
goto first