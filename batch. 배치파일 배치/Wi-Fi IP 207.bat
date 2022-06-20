@echo off
 :: BatchGotAdmin
 :-------------------------------------
 REM  --> 권한을 체크를 합니다.
 >nul 2>&1 "%SYSTEMROOT%\system32\cacls.exe" "%SYSTEMROOT%\system32\config\system"
 
REM --> If error flag set, we do not have admin.
 if '%errorlevel%' NEQ '0' (
     echo Requesting administrative privileges...
     goto UACPrompt
 ) else ( goto gotAdmin )
 
:UACPrompt
     echo Set UAC = CreateObject^("Shell.Application"^) > "%temp%\getadmin.vbs"
     echo UAC.ShellExecute "%~s0", "", "", "runas", 1 >> "%temp%\getadmin.vbs"
 
    "%temp%\getadmin.vbs"
     exit /B
 
:gotAdmin
     if exist "%temp%\getadmin.vbs" ( del "%temp%\getadmin.vbs" )
     pushd "%CD%"
     CD /D "%~dp0"
 

netsh -c int ip set address "Wi-Fi" static 192.168.1.207 255.255.255.0 192.168.1.1
netsh interface ip set dns "Wi-Fi" static 192.168.1.1 primary
netsh interface ip show config "Wi-Fi"
pause
