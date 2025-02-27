const byte ledPin = 13;
const byte interruptPin = 2;
byte state = LOW;
byte count=0;
bool flag=false;
void setup() {
  // put your setup code here, to run once:
pinMode(ledPin, OUTPUT);
pinMode(interruptPin, INPUT_PULLUP);
attachInterrupt(digitalPinToInterrupt(interruptPin), blink, LOW);
}
void loop() {
  // put your main code here, to run repeatedly:
if(flag)
 for(int i=1;i<=count;i++){
    digitalWrite(ledPin, HIGH);  // turn the LED on (HIGH is the voltage level)
    delay(1000);                      // wait for a second
    digitalWrite(ledPin, LOW);   // turn the LED off by making the voltage LOW
    delay(1000);                      // wait for a second
  }
  flag=false; 
}
void blink() {
  if(count==11) count=1;
  else count++;
 flag=true;}