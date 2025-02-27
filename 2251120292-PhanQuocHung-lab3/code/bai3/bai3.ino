const int ledPins[] = {2, 3, 4, 5, 6, 7, 8, 9}; // Các chân điều khiển LED
const int numLeds = 8;
const int buttonModePin = 10; // Nút chọn chế độ
const int buttonNextPin = 11; // Nút chuyển sang chế độ tiếp theo

int mode = 0; // Biến lưu trữ chế độ hiện tại
int lastButtonStateMode = LOW;
int lastButtonStateNext = LOW;
unsigned long lastDebounceTime = 0;
unsigned long debounceDelay = 50;

void setup() {
  for (int i = 0; i < numLeds; i++) {
    pinMode(ledPins[i], OUTPUT);
  }
  pinMode(buttonModePin, INPUT);
  pinMode(buttonNextPin, INPUT);
  Serial.begin(9600);
}

void loop() {
  // Kiểm tra nút chọn chế độ
  int readingMode = digitalRead(buttonModePin);
  if (readingMode != lastButtonStateMode) {
    lastDebounceTime = millis();
  }
  if ((millis() - lastDebounceTime) > debounceDelay) {
    if (readingMode == HIGH) {
      mode = (mode + 1) % 4; // Chọn chế độ tiếp theo
      Serial.println("Chế độ hiện tại: " + String(mode));
    }
  }
  lastButtonStateMode = readingMode;

  // Chạy các chế độ hiển thị
  switch (mode) {
    case 0:
      ledAlternating();
      break;
    case 1:
      ledLeftToRight();
      break;
    case 2:
      ledRightToLeft();
      break;
    case 3:
      ledPingPong();
      break;
  }
}

void ledAlternating() {
  // Chớp tắt xen kẽ các đèn
  for (int i = 0; i < numLeds; i++) {
    if (i % 2 == 0) {
      digitalWrite(ledPins[i], HIGH);
    } else {
      digitalWrite(ledPins[i], LOW);
    }
  }
  delay(500);
  for (int i = 0; i < numLeds; i++) {
    if (i % 2 == 0) {
      digitalWrite(ledPins[i], LOW);
    } else {
      digitalWrite(ledPins[i], HIGH);
    }
  }
  delay(500);
}

void ledLeftToRight() {
  // Đèn LED sáng từ trái qua phải
  for (int i = 0; i < numLeds; i++) {
    digitalWrite(ledPins[i], HIGH);
    delay(200);
    digitalWrite(ledPins[i], LOW);
  }
}

void ledRightToLeft() {
  // Đèn LED sáng từ phải qua trái
  for (int i = numLeds - 1; i >= 0; i--) {
    digitalWrite(ledPins[i], HIGH);
    delay(200);
    digitalWrite(ledPins[i], LOW);
  }
}

void ledPingPong() {
  // Đèn LED sáng chạy từ trái qua phải sau đó chạy ngược lại
  for (int i = 0; i < numLeds; i++) {
    digitalWrite(ledPins[i], HIGH);
    delay(200);
    digitalWrite(ledPins[i], LOW);
  }
  for (int i = numLeds - 1; i >= 0; i--) {
    digitalWrite(ledPins[i], HIGH);
    delay(200);
    digitalWrite(ledPins[i], LOW);
  }
}
