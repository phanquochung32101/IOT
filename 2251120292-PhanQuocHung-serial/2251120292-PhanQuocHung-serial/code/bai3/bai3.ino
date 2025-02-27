int currentNumber = 0;  // Số thứ tự hiện tại
int calledNumber = 0;   // Số thứ tự đang được gọi
int buttonPin = 9;      // Chân kết nối nút bấm
int buttonState = 0;

const int segmentPins[] = {2, 3, 4, 5, 6, 7, 8}; // Các chân LED 7 đoạn

const int digits[10][7] = {
  {1, 1, 1, 1, 1, 1, 0}, // 0
  {0, 1, 1, 0, 0, 0, 0}, // 1
  {1, 1, 0, 1, 1, 0, 1}, // 2
  {1, 1, 1, 1, 0, 0, 1}, // 3
  {0, 1, 1, 0, 0, 1, 1}, // 4
  {1, 0, 1, 1, 0, 1, 1}, // 5
  {1, 0, 1, 1, 1, 1, 1}, // 6
  {1, 1, 1, 0, 0, 0, 0}, // 7
  {1, 1, 1, 1, 1, 1, 1}, // 8
  {1, 1, 1, 1, 0, 1, 1}  // 9
};

void setup() {
  Serial.begin(9600);
  for (int i = 0; i < 7; i++) {
    pinMode(segmentPins[i], OUTPUT); // Chân đầu ra cho LED 7 đoạn
  }
  pinMode(buttonPin, INPUT);         // Nút bấm để người dùng lấy số
}

void loop() {
  // Đọc nút bấm để lấy số thứ tự
  buttonState = digitalRead(buttonPin);
  if (buttonState == HIGH) {
    currentNumber++;
    if (currentNumber > 99) currentNumber = 0; // Reset khi vượt quá 99
    displayNumber(currentNumber);
    delay(500); // Tránh nhấn nhiều lần
  }

  // Nhận số thứ tự từ phần mềm WinForms
  if (Serial.available() > 0) {
    String incoming = Serial.readString();
    calledNumber = incoming.toInt();
    displayNumber(calledNumber);
  }
}

// Hàm hiển thị số lên LED 7 đoạn
void displayNumber(int num) {
  int tens = num / 10;
  int ones = num % 10;
  // Hiển thị số hàng chục
  for (int i = 0; i < 7; i++) {
    digitalWrite(segmentPins[i], digits[tens][i]);
  }
  delay(1000); // Hiển thị số hàng đơn vị sau đó
  for (int i = 0; i < 7; i++) {
    digitalWrite(segmentPins[i], digits[ones][i]);
  }
}
