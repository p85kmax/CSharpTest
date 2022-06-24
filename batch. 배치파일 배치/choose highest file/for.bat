@echo off
::FOR %%변수 IN (집합) DO 명령어
::기본적으로 (파일명), ("문자열") 형태가 있는데여기서 (파일명)은 파일명 아닌거 같으면 걍 문자열로 처리한다.


::현재 폴더의 파일들을 출력하고 문자열 miku와 문자열 daisuki도 출력
for %%c in (* miku daisuki) do echo %%c

::그리고 여러개를 처리할때는 사이에 공백이나 콤마(,) 세미클론(;)을 넣는다.
for %%a in (1;2 3,4) do echo %%a

::현재 폴더에서 확장자가 cmd이거나 bak인 파일 목록 출력
for %%c in (*.cmd *.bak) do echo %%c

::현재 폴더의 파일 목록을 출력해준다
for %%c in (*) do echo %%c


:3. 증감 For문
::FOR /L %%변수 IN (시작,단계,끝) DO 명령문

::1부터 100까지 홀수 출력
for /L %%a in (1,2,100) do echo %%a

:4. recursive for문
::FOR /R [경로] %%변수 IN (집합) DO 명령어
::경로에서 recursive하게 탐색하여 각 디렉토리마다 for문을 실행한다.
::경로를 생략하면 현재 폴더에서 탐색을 시작한다.
for /r c:\ %%a in (*.mp4 *.avi) do echo %%a


:5. directory For문
::FOR /D %변수 IN (집합) DO 명령어
::(파일명) -> (폴더명)
for /d %%a in (*) do echo %%a
::현재 폴더의 폴더목록 출력


for /L %%a in (0,1,9) do (
	for /L %%b in (0,1,9) do (
		for /L %%c in (0,1,9) do (
			echo %%a%%b%%c
		)
	)
)



pause > nul
