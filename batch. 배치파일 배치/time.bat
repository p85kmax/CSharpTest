:: 도스에서 특정 날짜와 시간으로 파일을 생성할 때 문제점
::- %time% 변수 값의 시간 구분자가 일반적으로 ":(콜론)" 이 사용되어 파일명으로 사용불가
::- ex) echo %time% ->15:59:46.85-> 파일 명으로 사용불가
::변수 사용시 반드시 = 양옆 붙여서..스페이스없이...할것!!
@echo on

SET date=%DATE% 
echo %date%
         
set TM=%time% 
echo %TM% 

 
set HH=%TM:~0,2%

echo %HH%

set MM=%TM:~3,2%
set SS=%TM:~6,2%

set HH1=%HH:~0,1%
set HH2=%HH:~1,1%

if "%HH1%" == " " set HH=0%HH2%
   
if "%HH1%" == "1" set HH=X%HH2%

echo orginal time = %TM%
echo transforomed time = %HH%%MM%%SS%
 

pause
