:: �������� Ư�� ��¥�� �ð����� ������ ������ �� ������
::- %time% ���� ���� �ð� �����ڰ� �Ϲ������� ":(�ݷ�)" �� ���Ǿ� ���ϸ����� ���Ұ�
::- ex) echo %time% ->15:59:46.85-> ���� ������ ���Ұ�
::���� ���� �ݵ�� = �翷 �ٿ���..�����̽�����...�Ұ�!!
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
