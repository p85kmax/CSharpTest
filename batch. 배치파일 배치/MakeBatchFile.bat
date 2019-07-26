echo REM Restore......................................................... > Restore.BAT
echo xcopy .\bin\  ..\bin\ /D /H /K /Y /E >>Restore.BAT
echo xcopy .\config\  ..\config\ /D /H /K /Y /E >>Restore.BAT
echo xcopy .\Result\  ..\Result\ /D /H /K /Y /E >>Restore.BAT
