const int ledPin = 13;  // the pin that the LED is attached to

void setup() {
  // initialize serial communication:
  Serial.begin(9600);
  // initialize the LED pin as an output:
  pinMode(ledPin, OUTPUT);
}

void loop() {
  // Check if there's any data available in the serial buffer
  if (Serial.available() > 0) {
    // Read the incoming data as a string
    String data = Serial.readString();

    // Control the LED based on the received command
    if (data == "on") {
      digitalWrite(ledPin, HIGH);  // Turn the LED on
    } else if (data == "off") {
      digitalWrite(ledPin, LOW);   // Turn the LED off
    }
  }
}
