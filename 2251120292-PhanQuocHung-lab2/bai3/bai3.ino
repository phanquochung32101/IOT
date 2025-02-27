int ledPins[] = {2, 3, 4, 5, 6, 7, 8, 9}; // Mảng chứa các chân nối LED

void setup() {
  // Thiết lập các chân là OUTPUT
  for (int i = 0; i < 8; i++) {
    pinMode(ledPins[i], OUTPUT);
  }
}

void loop() {
  // Đếm từ 0 đến 100
  for (int i = 0; i <= 100; i++) {
    displayBinary(i);   // Gọi hàm hiển thị số nhị phân
    delay(500);         // Đợi 500ms giữa mỗi lần đếm
  }
}

// Hàm hiển thị số nhị phân lên các đèn LED
void displayBinary(int number) {
  for (int i = 0; i < 8; i++) {
    // Kiểm tra từng bit của số 'number' và bật/tắt LED tương ứng
    int bit = (number >> i) & 1;  // Dịch bit và kiểm tra
    digitalWrite(ledPins[i], bit);
  }
}
