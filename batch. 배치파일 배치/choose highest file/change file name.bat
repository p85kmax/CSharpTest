@echo off
setlocal enabledelayedexpansion
:: Enableextensions / Disableextensions 

:: Enabledelayedexpansion / Disabledelayedexpasion
::언뜻 보면 정말... 어려워 보이지만.. 이것은 C언어에서 헤더파일과 거의 같은 계념입니다.
::C에서는 기본적으로 입력, 출력이 가능한 #include <stdio.h> 를 사용하잖아요?
::배치파일 또한 변수 표현을 더 확장시켜 주시 위해서 필요하다고 보면 되겠습니다.
::배치파일에서 A라는 변수에 10을 넣었을때, 출력을 하기 위해서는
::echo %A% 라고 우리는 항상 이렇게 써왔습니다.
::하지만 변수 확장을 한다면, echo !A! 라고 표현을 하면 됩니다.


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
REM setlocal Disableextensions
endlocal
