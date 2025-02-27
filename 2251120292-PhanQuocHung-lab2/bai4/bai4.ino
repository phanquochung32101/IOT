int denxanh = 1;
int denvang = 2;
int dendo = 3;
void setup() 
    {
      pinMode(denxanh,OUTPUT);
      pinMode(denvang,OUTPUT);
      pinMode(dendo,OUTPUT);

    }

void loop() 
    {
      digitalWrite(denxanh,HIGH);
      delay(20000);
      digitalWrite(denxanh,LOW);
      digitalWrite(denvang,HIGH);
      delay(3000);
      digitalWrite(denvang,LOW);
      digitalWrite(dendo,HIGH);
      delay(17000);
      digitalWrite(dendo,LOW);
    }