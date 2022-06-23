ECHO off
SET backupdir=%DATE:~0,4%%DATE:~5,2%%DATE:~8,2%_%time:~0,2%%time:~3,2%
echo %backupdir%
MD %backupdir%


echo %DATE%
echo %time%

rem /////////////////////////////////////////////////////////////////////
set str1=\\192.168.1.234
set str2=\Unieye
set str3=\Config\
set /p str4=input name :
set destpath=%str1%%str2%%str3%%str4%
echo %destpath%
MD %destpath%
pause
