<p>@echo off<br>setlocal enabledelayedexpansion
mode con cols=80 lines=25</p><p>   for /F "tokens=1,2 delims=#" %%a in ('"prompt #$H#$E# & echo on & for %%b in (1) do rem"') do (
      set "DEL=%%a"
   )</p><p>for /l %%a in (1,1,5) do (
   for /l %%b in (1,1,6) do (
      call:ColorText "ÿÿÿ" "90"
      call:ColorText "xÿ" "9F"
   )
   for /l %%b in (1,1,30) do (
      call:ColorText "ÿ" "C0"
   )
   echo/
   for /l %%b in (1,1,6) do (
      call:ColorText "x" "9F"
      call:ColorText "ÿÿÿÿ" "90"
   )
   for /l %%b in (1,1,30) do (
      call:ColorText "ÿ" "F0"
   )
   echo/
)
for /l %%b in (1,1,3) do (
   for /l %%b in (1,1,60) do (
      call:ColorText "ÿ" "C0"
   )
   echo/
   for /l %%b in (1,1,60) do (
      call:ColorText "ÿ" "F0"
   )
   echo/
)
pause>nul
exit/b
:ColorText
    "%~1"
   findstr /v /a:%2 /R "^

@echo off
setlocal enabledelayedexpansion
mode con cols=80 lines=25

   for /F "tokens=1,2 delims=#" %%a in ('"prompt #$H#$E# & echo on & for %%b in (1) do rem"') do (
      set "DEL=%%a"
   )

for /l %%a in (1,1,5) do (
   for /l %%b in (1,1,6) do (
      call:ColorText "ÿÿÿ" "90"
      call:ColorText "xÿ" "9F"
   )
   for /l %%b in (1,1,30) do (
      call:ColorText "ÿ" "C0"
   )
   echo/
   for /l %%b in (1,1,6) do (
      call:ColorText "x" "9F"
      call:ColorText "ÿÿÿÿ" "90"
   )
   for /l %%b in (1,1,30) do (
      call:ColorText "ÿ" "F0"
   )
   echo/
)
for /l %%b in (1,1,3) do (
   for /l %%b in (1,1,60) do (
      call:ColorText "ÿ" "C0"
   )
   echo/
   for /l %%b in (1,1,60) do (
      call:ColorText "ÿ" "F0"
   )
   echo/
)
pause>nul
exit/b
:ColorText
    "%~1"
   findstr /v /a:%2 /R "^$" "%~1" nul
   del "%~1" > nul 2>&1
   exit/b
::http://www.dostips.com/forum/viewtopic.php?f=3&t=5641&hilit=Batch+circle+file


quot; "%~1" nul
   del "%~1" > nul 2>&1
   exit/b
::http://www.dostips.com/forum/viewtopic.php?f=3&t=5641&hilit=Batch+circle+file</p>

