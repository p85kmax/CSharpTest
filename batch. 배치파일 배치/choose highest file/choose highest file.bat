setlocal enabledelayedexpansion
@echo ON



echo /---------------------------------------------------------/
set max=0
for /f "tokens=1* delims=-.0"%%A in ('dir /b /a-d version-*.txt') do if %%B gtr !max! set max=%%B
echo highest version : version-%max%.txt

pause


echo /---------------------------------------------------------/

set max=0

for %%x in (version-*.txt) do (
set "FN=%%~nx"

set "FN=!FN:version-=!"

for !FN! GTR !max! set max=!FN!
)
echo highest version : version-%max%.txt

pause