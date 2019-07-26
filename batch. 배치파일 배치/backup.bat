:://년,월,날짜별로 폴더 디렉토리를 생성해 백업파일을 복사하고 원본 파일삭제하는 배치파일 만들기

ECHO off

::오늘 날짜를 변수 DT에 담는다.
SET DT=%DATE% 
echo "%DT%"

                                                                             
FOR /F "tokens=1-4 delims=-" %%A in ('echo %DT%') Do SET DT=%%A%%B%%C     
        
::경로에 해당년,월,일 디렉토리가 존재하지 않는다면(IF NOT EXIST), 디렉토리를 생성(MD)한다
::IF NOT EXIST ".\%DT:~0,4%\%DT:~4,2%\%DT:~6,2%" MD ".\bakup\%DT:~0,4%\%DT:~4,2%\%DT:~6,2%"   
IF NOT EXIST ".\%DT:~0,4%%DT:~4,2%%DT:~6,2%" MD ".\backup\%DT:~0,4%%DT:~4,2%%DT:~6,2%"   

::생성된 오늘날짜 디렉토리로 이동
::CD "C:\PDF\bak\%DT:~0,4%\%DT:~4,2%\%DT:~6,2%"



::원본파일경로를 복사해 생성된 오늘날짜 디렉토리로 복사한다.
::XCOPY /E /Y "C:\PDF\out\*.*" "C:\PDF\bak\%DT:~0,4%\%DT:~4,2%\%DT:~6,2%"

::원본파일이 있는 디렉토리에 파일이 존재한다면 모두 삭제
::IF EXIST *.* DEL /s /f /q *.*


XCOPY ".\Src" ".\backup\%DT:~0,4%%DT:~4,2%%DT:~6,2%"

pause
