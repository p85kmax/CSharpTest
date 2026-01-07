// the setup function runs once when you press reset or power the board

#define LED1 13
#define LED2 12
#define LED3 11
#define LED4 10
#define BUZ 3

#define BUTTON1 A1
#define BUTTON2 A2
#define BUTTON3 A3

#define LATCH_DIO 4
#define CLK_DIO 7
#define DATA_DIO 8

 /* Segment byte maps for numbers 0 to 9 */
const byte SEGMENT_MAP[] = {0xC0,0xF9,0xA4,0xB0,0x99,0x92,0x82,0xF8,0X80,0X90};

/* Byte maps to select digit 1 to 4 */
const byte SEGMENT_SELECT[] = {0xF1,0xF2,0xF4,0xF8};

void setup() 
{
    Serial.begin(9600);
    /* Set DIO pins to outputs */
pinMode(LATCH_DIO,OUTPUT);
pinMode(CLK_DIO,OUTPUT);
pinMode(DATA_DIO,OUTPUT);

  // initialize digital pin LED_BUILTIN as an output.
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(LED4, OUTPUT);  

  pinMode(BUZ, OUTPUT);  
  digitalWrite(BUZ, HIGH);   //Off
  digitalWrite(LED1, LOW);     
  digitalWrite(LED2, HIGH);   
   digitalWrite(LED3, LOW);     
   digitalWrite(LED4, HIGH);   

  // tone(3, 1000);
  Serial.println(F("//********************Start minsong Tester*******************************//"));
  Serial.print(analogRead(BUTTON1)); Serial.print("/");
  Serial.print(analogRead(BUTTON2)); Serial.print("/");
  Serial.println(analogRead(BUTTON3));

  Beep(200);delay(55);
  Beep(200);delay(55);
  Beep(200);delay(55);

  WriteNumberToSegment(0 , 0);
  WriteNumberToSegment(1 , 1);
  WriteNumberToSegment(2 , 2);

  //PORTB |=0b00101000;
  //PORTB &=0b11101011;

}

bool c=false;
int n=0;
// the loop function runs over and over again forever
unsigned int gLineCount =345;

void loop() 
{
   noInterrupts();
   OneShot(gLineCount);

  // interrupts();
  // Serial.print(".");
  // delay(10);

  //  WriteNumberToSegment(3 , n++ %10);
     //gLineCount+=25;
    //if(gLineCount > 1000) gLineCount = 50;
}
/*
          if(analogRead(BUTTON1) < 128)
                {
                  c ^=1;
                   Beep(20);
                   OneShot(1200);
                   delay(333);
                } 
*/

void Beep(unsigned int delayms)
{
    digitalWrite(BUZ, LOW); //On
    delay(delayms);
    digitalWrite(BUZ, HIGH);  //Off
}

void OneShot(unsigned int linecount)
{
   unsigned int i=0;
   
   //delay(1);
    for(i=0;i<linecount ;i++)
    {
        TRIG();
    } 
    StartSignal(false);
  // delay(1000);
  delayMicroseconds(10);
    StartSignal(true);

}

void StartSignal(bool on)
{
  if(on)
  {
    //digitalWrite(LED3, HIGH);     //11PB3
    //digitalWrite(LED4, LOW);  //10PB2
    //PORTB |=0b00001000;
    //PORTB &=0b11111011;
    PORTB = PORTB^0b00001100;
  }
  else
  {
      //digitalWrite(LED3, LOW);     
      //digitalWrite(LED4, HIGH);     
      //PORTB &=0b11110111;
      //PORTB |=0b00000100;
      PORTB = PORTB^0b00001100;
  }
}

void TRIG()
{
   //digitalWrite(LED1, HIGH);   //13 : PB5
   //digitalWrite(LED2, LOW);    //12 : PB4
   //PORTB |=0b00100000;
   //PORTB &=0b11101111;
   PORTB = PORTB^0b00110000;

   //Serial.println("On.....");
   delayMicroseconds(200);
  //digitalWrite(LED1,LOW );     
  //digitalWrite(LED2, HIGH);
   //PORTB &=0b11011111;
   //PORTB |=0b00010000;
   PORTB = PORTB^0b00110000;
  //Serial.println("Off.....");
  delayMicroseconds(200);   
}

void WriteNumberToSegment(byte Segment, byte Value)
{
    digitalWrite(LATCH_DIO,LOW);
    shiftOut(DATA_DIO, CLK_DIO, MSBFIRST, SEGMENT_MAP[Value]);
    shiftOut(DATA_DIO, CLK_DIO, MSBFIRST, SEGMENT_SELECT[Segment] );
    digitalWrite(LATCH_DIO,HIGH);
}
