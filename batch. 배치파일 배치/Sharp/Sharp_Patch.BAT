title /****  Sharp Patch (1.0 by ms) ****/
@echo off
cls
if "%1"=="/d" (
	@echo on
)
cd /d %~dp0
color A

set TEST_MODE=true

if /i %TEST_MODE%==true (
	set destPC=d:\SharpPC
	Echo Test Mode !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
) else (
	set destPC=\\192.168.1.
)


:START
echo ========================== Sharp Patch =============================
if /i %TEST_MODE%==true (
	Echo Test Mode !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
)
Echo Destination PC Group = "%destPC%(input ip)"
echo _      
echo 0:All, last ip number : 51 ~ 60
echo _                                                                                                                      
echo 0 : All Inspector PC
echo 51 : Align A
echo 52 : EdgeA-1 (Door) 
echo 53 : EdgeA-2
echo 54 : Align B
echo 55 : EdgeB-1 (Door)
echo 56 : EdgeB-2
echo 57 : Oblique A (Top)
echo 58 : Oblique B (Bottom)
echo 59 : Normal A (Top)
echo 60 : Normal B (Bottom)
echo _                                                                                                                      
echo ====================================================================

set /p destination_IP=Which one do you want Patch? 

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
	echo All Patch Done	
	pause
	cls
	goto :START
	 
) else (
	echo.
	call :Patch %destination_IP%
	echo Patch Done
	pause
	
	goto :START
)

if %destination_IP% gtr 60 (
	cls
	echo your input is wrong !!!!!!!!!
	goto :START
)

if %destination_IP% lss 51 (
	cls
	echo your input is wrong !!!!!!!!!
	goto :START
)


echo All job was done ................................................
echo Press any key to exit.
pause
goto :EOF



:Patch
	echo --------------------patch start (%1)----------------------------
	echo _arg1: %1
	echo _arg2: %2
	
if /i %TEST_MODE%==true (
	set patchpath=%destPC%\%1
) else (
	set patchpath=%destPC%%1\Kistem
)
	echo ###### "%patchpath%"
	
	rem Backup #############################################################################
	rem net use %1 "" /user:administrator
	SET backupdir=%patchpath%\backup\%DATE:~0,4%%DATE:~5,2%%DATE:~8,2%_%time:~0,2%%time:~3,2%
	echo Backup Path is = %backupdir%
	mkdir %backupdir%
rem	mkdir %backupdir%\bin
rem	mkdir %backupdir%\config
	
rem	xcopy %patchpath%\bin		%backupdir%		/h /k /y /e /f  /f is full path display
	xcopy %patchpath%\bin		%backupdir%\bin\		/h /k /y /e
	xcopy %patchpath%\config	%backupdir%\config\		/h /k /y /e

	rem PATCH COPY #############################################################################
	echo Patch path is = %patchpath%
	xcopy .\bin %patchpath%\bin\ /h /k /y /e
	xcopy .\config %patchpath%\config\ /h /k /y /e

	rem mkdir %1\Update\bin\
	rem copy Release\UserManager.exe %1\Update\bin
	rem echo %date%>%1\Update\PatchDate
	rem net use %1 /delete
	echo --------------------patch finish (%1)----------------------------
	
	
	
	
	
	