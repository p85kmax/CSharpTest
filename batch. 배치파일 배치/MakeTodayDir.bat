ECHO off
SET backupdir=%DATE:~0,4%%DATE:~5,2%%DATE:~8,2%_%time:~0,2%%time:~3,2%
echo %backupdir%
MD %backupdir%

pause
