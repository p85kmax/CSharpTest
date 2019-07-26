title Call Test
color C

call :func1

echo Now going to Finish!!!!!!!!!!!!!!!

pause
goto :EOF

:func1
echo func1(111111111111)
pause

title Call !!!!!!!!!!!!!!!!!!!!!!!
color E


goto :EOF

:func2
echo func2(222222222222)
goto :EOF

:finish
echo Finish
goto :EOF

