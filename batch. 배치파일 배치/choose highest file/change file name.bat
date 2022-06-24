@echo off
setlocal enabledelayedexpansion
::for /f %%a in (*.txt) do echo %%a
set x=7
echo %x%
set /a x+=1
echo %x%	
set /a x+=1
		echo %x%
set /a x+=1
echo %x%


for %%a in ( *.mmm ) do (
	echo %%a
	echo ............
	for /f "delims=. tokens=1,2" %%b in ("%%a") do (
	    set /a "x+=1"
		::%x% 랑 !x!랑 다름. 후자가 정상 동작
		echo %x% 
		echo __
		echo [!x!] [%%b]  [%%c]
		echo %%a ---!x!%%b.%%c
		echo !x!%%a  ////
		rename %%a !x!%%a
	)
)
pause > nul