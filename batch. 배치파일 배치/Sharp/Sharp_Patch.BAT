title /****  Sharp Patch (1.0 by ms) ****/
@echo off
cls
if "%1"=="/d" (
	@echo on
)
cd /d %~dp0

rem set destPC=\\192.168.1.
set destPC=d:\SharpPC

echo 0:All, X: 51 ~ 60
echo ex)57 //oblique 
set /p destination_IP=Which one do you want? 

if %destination_IP%==0 (
	echo.
	echo Patch All
	call :Patch 51
	call :Patch 52
	call :Patch 53
	call :Patch 54
	call :Patch 55
	call :Patch 56
	call :Patch 57
	call :Patch 58
	call :Patch 59
	call :Patch 60
	echo Copy Done
) else (
	echo.
	call :Patch %destination_IP%
	echo _Patch Done
)
pause
goto :EOF



:Patch
	echo _arg1: %1
	echo _arg2: %2

	echo patch start.............................................................
	
	
	rem set patchpath=\\192.168.1.%_arg1%\Kistem
	set patchpath=%destPC%\%1
	
	
	echo patch path is = %patchpath%
	rem net use %1 "" /user:administrator

	xcopy .\bin %patchpath%\bin\ /h /k /y /e /f
	xcopy .\config %patchpath%\config\ /h /k /y /e /f

	rem mkdir %1\Update\bin\
	rem copy Release\UserManager.exe %1\Update\bin
	rem echo %date%>%1\Update\PatchDate
	rem net use %1 /delete
	echo ########################################################################
	
	
	
	
	
	