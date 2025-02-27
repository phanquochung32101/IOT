const int green1 = 2, yellow1 = 3, red1 = 4;
const int green2 = 5, yellow2 = 6, red2 = 7;
const int buttonPin = 8;

unsigned long previousMillis = 0;
unsigned long greenDuration = 10000;  // Thời gian mặc định cho đèn xanh (10 giây)
unsigned long yellowDuration = 5000;  // Thời gian mặc định cho đèn vàng (5 giây)
unsigned long redDuration = 10000;    // Thời gian mặc định cho đèn đỏ (10 giây)

int state = 0;  // 0 = Đèn xanh 1 bật, 1 = Đèn xanh 2 bật
int buttonState = HIGH;
int lastButtonState = HIGH;
unsigned long debounceDelay = 50;
unsigned long lastDebounceTime = 0;

void setup() {
  Serial.begin(9600);

  pinMode(green1, OUTPUT);
  pinMode(yellow1, OUTPUT);
  pinMode(red1, OUTPUT);
  pinMode(green2, OUTPUT);
  pinMode(yellow2, OUTPUT);
  pinMode(red2, OUTPUT);
  pinMode(buttonPin, INPUT_PULLUP);  // Nút nhấn với điện trở kéo lên
  
  // Khởi tạo trạng thái ban đầu
  digitalWrite(red1, HIGH);
  digitalWrite(red2, HIGH);
}

void loop() {
  // Kiểm tra xem có dữ liệu Serial đến từ WinForms không
  if (Serial.available() > 0) {
    String data = Serial.readStringUntil('\n');
    processIncomingData(data);
  }

  // Điều khiển đèn giao thông theo thời gian được gửi từ WinForms
  unsigned long currentMillis = millis();
  if (state == 0) {
    controlTrafficLight1(currentMillis);
  } else {
    controlTrafficLight2(currentMillis);
  }

  // Kiểm tra trạng thái nút nhấn để đảo giữa đèn xanh 1 và đèn xanh 2
  int reading = digitalRead(buttonPin);
  if (reading != lastButtonState) {
    lastDebounceTime = currentMillis;
  }
  
  if ((currentMillis - lastDebounceTime) > debounceDelay) {
    if (reading != buttonState) {
      buttonState = reading;
      if (buttonState == LOW) {
        state = !state; // Đảo trạng thái giữa đèn 1 và đèn 2
        Serial.println(state == 0 ? "Xanh 1 Bật" : "Xanh 2 Bật");
      }
    }
  }

  lastButtonState = reading;
}

// Hàm xử lý dữ liệu thời gian điều khiển từ WinForms
void processIncomingData(String data) {
  int index1 = data.indexOf(',');
  int index2 = data.indexOf(',', index1 + 1);

  if (index1 > 0 && index2 > index1) {
    greenDuration = data.substring(0, index1).toInt() * 1000;
    yellowDuration = data.substring(index1 + 1, index2).toInt() * 1000;
    redDuration = data.substring(index2 + 1).toInt() * 1000;

    Serial.println("Đã nhận thời gian mới");
  }
}

// Hàm điều khiển đèn giao thông hướng 1
void controlTrafficLight1(unsigned long currentMillis) {
  unsigned long interval = currentMillis - previousMillis;
  if (interval < greenDuration) {
    // Bật đèn xanh 1, đèn đỏ 2
    digitalWrite(green1, HIGH);
    digitalWrite(yellow1, LOW);
    digitalWrite(red1, LOW);
    digitalWrite(green2, LOW);
    digitalWrite(yellow2, LOW);
    digitalWrite(red2, HIGH);
    Serial.println("Xanh 1 Bật");
  } else if (interval < greenDuration + yellowDuration) {
    // Bật đèn vàng 1
    digitalWrite(green1, LOW);
    digitalWrite(yellow1, HIGH);
    digitalWrite(red1, LOW);
    Serial.println("Vàng 1 Bật");
  } else {
    // Bật đèn đỏ 1
    digitalWrite(green1, LOW);
    digitalWrite(yellow1, LOW);
    digitalWrite(red1, HIGH);
    Serial.println("Đỏ 1 Bật");

    if (interval > greenDuration + yellowDuration + redDuration) {
      previousMillis = currentMillis; // Reset lại thời gian
    }
  }
}

// Hàm điều khiển đèn giao thông hướng 2
void controlTrafficLight2(unsigned long currentMillis) {
  unsigned long interval = currentMillis - previousMillis;
  if (interval < greenDuration) {
    // Bật đèn xanh 2, đèn đỏ 1
    digitalWrite(green2, HIGH);
    digitalWrite(yellow2, LOW);
    digitalWrite(red2, LOW);
    digitalWrite(green1, LOW);
    digitalWrite(yellow1, LOW);
    digitalWrite(red1, HIGH);
    Serial.println("Xanh 2 Bật");
  } else if (interval < greenDuration + yellowDuration) {
    // Bật đèn vàng 2
    digitalWrite(green2, LOW);
    digitalWrite(yellow2, HIGH);
    digitalWrite(red2, LOW);
    Serial.println("Vàng 2 Bật");
  } else {
    // Bật đèn đỏ 2
    digitalWrite(green2, LOW);
    digitalWrite(yellow2, LOW);
    digitalWrite(red2, HIGH);
    Serial.println("Đỏ 2 Bật");

    if (interval > greenDuration + yellowDuration + redDuration) {
      previousMillis = currentMillis; // Reset lại thời gian
    }
  }
}
