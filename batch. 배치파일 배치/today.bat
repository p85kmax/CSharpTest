@echo off

::p   
SET TODAY=%date:~-10%

::%date%에서 모든 하이픈(-)을 지워 버림 / 폴더생성 YYYYMMDD
::set date1=%date:-=%

  
SET YYYYMM=%TODAY:~0,4%%TODAY:~5,2%

echo %YYYYMM%

SET YYYY=%TODAY:~0,4%

echo %YYYY%

 
:: 요일 삭제한, 날짜 문자열로 디렉토리 만들기
cd D:\batch_schedule_log

md %YYYYMM%

:: 1년에 한번 YYYYMM폴더문자열로 디렉토리 만들기
cd E:\SysLog\CenterVPN
md %YYYY%01;%YYYY%02;%YYYY%03;%YYYY%04;%YYYY%05;%YYYY%06;%YYYY%07;%YYYY%08;%YYYY%09;%YYYY%10;%YYYY%11;%YYYY%12


pause

exit
::출처: https://applejara.tistory.com/574 [애플자라]