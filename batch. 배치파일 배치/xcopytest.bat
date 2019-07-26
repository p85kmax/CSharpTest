SET src=D:\batch
SET backupdir=%src%\backup\%DATE:~0,4%%DATE:~5,2%%DATE:~8,2%_%time:~0,2%%time:~3,2%
echo %backupdir%
rem MD %backupdir%

xcopy %src%\config %backupdir%\config\ /D /H /K /Y /E

pause
