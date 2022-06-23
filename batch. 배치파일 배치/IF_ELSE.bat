:: 도스에서 특정 날짜와 시간으로 파일을 생성할 때 문제점
::- %time% 변수 값의 시간 구분자가 일반적으로 ":(콜론)" 이 사용되어 파일명으로 사용불가
::- ex) echo %time% ->15:59:46.85-> 파일 명으로 사용불가
::변수 사용시 반드시 = 양옆 붙여서..스페이스없이...할것!!
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
