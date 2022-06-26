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
set /a x=7

for %%a in ( *.mmm ) do (
	echo %%a
	echo ............
	for /f "delims=. tokens=1,2" %%b in ("%%a") do (
	    rem %x% 랑 !x!랑 다름. 후자가 정상 동작

		if !x! lss 10 ( 
			set prefix=000!x!
		) else (
			if !x! lss 100 ( set prefix=00!x!
			) else (
				if !x! lss 1000 set prefix=0!x!
				) 
			)
		)
		
		set /a "x*=10"
				
				
	    echo [!prefix!]
	    rem %x% 랑 !x!랑 다름. 후자가 정상 동작
		rem echo %x% 
		rem echo __
		rem echo [!x!] [%%b]  [%%c]
		rem echo %%a ---!x!%%b.%%c
		echo !x!%%a  ////
		rem rename %%a !x!%%a
	)
)
pause > nul