void setup() {
  // Khai báo các chân từ 2 đến 9 là OUTPUT
  for (int i = 2; i <= 9; i++) {
    pinMode(i, OUTPUT);
  }
}

void loop() {
  // Đèn sáng tắt xen kẽ
  for (int i = 2; i <= 9; i++) {
    if (i % 2 == 0) {
      digitalWrite(i, HIGH); // Sáng đèn chẵn
    } else {
      digitalWrite(i, LOW);  // Tắt đèn lẻ
    }
  }
  delay(500); // Đợi 500ms

  for (int i = 2; i <= 9; i++) {
    if (i % 2 == 0) {
      digitalWrite(i, LOW);  // Tắt đèn chẵn
    } else {
      digitalWrite(i, HIGH); // Sáng đèn lẻ
    }
  }
  delay(500); // Đợi 500ms
}
