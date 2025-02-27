// Khai báo các chân kết nối với đèn LED
int ledPins[] = {2, 3, 4, 5, 6, 7, 8, 9};

void setup() {
  // Thiết lập các chân là OUTPUT
  for (int i = 0; i < 8; i++) {
    pinMode(ledPins[i], OUTPUT);
  }
}

void loop() {
  // Sáng từ trái qua phải
  for (int i = 0; i < 8; i++) {
    digitalWrite(ledPins[i], HIGH); // Sáng đèn
    delay(200);                     // Đợi 200ms
    digitalWrite(ledPins[i], LOW);  // Tắt đèn
  }

  // Sáng từ phải qua trái
  for (int i = 7; i >= 0; i--) {
    digitalWrite(ledPins[i], HIGH); // Sáng đèn
    delay(200);                     // Đợi 200ms
    digitalWrite(ledPins[i], LOW);  // Tắt đèn
  }
}
