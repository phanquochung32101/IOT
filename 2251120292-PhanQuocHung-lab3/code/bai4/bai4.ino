// Khai báo các chân của LED 7 đoạn
const int led7Segments[7] = {2, 3, 4, 5, 6, 7, 8};  // Các chân điều khiển LED 7 đoạn
const int buttonPin = 9;  // Chân kết nối nút nhấn

int count = 9;            // Biến đếm, bắt đầu từ 0
int buttonState = 0;      // Trạng thái hiện tại của nút nhấn
int lastButtonState = 0;  // Trạng thái trước đó của nút nhấn
bool isCountingUp = true; // Biến kiểm soát hướng đếm (tăng hoặc giảm)

// Mã hiển thị số 0-9 trên LED 7 đoạn
int digits[10][7] = {
  {1, 1, 1, 1, 1, 1, 0}, // Số 0
  {0, 1, 1, 0, 0, 0, 0}, // Số 1
  {1, 1, 0, 1, 1, 0, 1}, // Số 2
  {1, 1, 1, 1, 0, 0, 1}, // Số 3
  {0, 1, 1, 0, 0, 1, 1}, // Số 4
  {1, 0, 1, 1, 0, 1, 1}, // Số 5
  {1, 0, 1, 1, 1, 1, 1}, // Số 6
  {1, 1, 1, 0, 0, 0, 0}, // Số 7
  {1, 1, 1, 1, 1, 1, 1}, // Số 8
  {1, 1, 1, 0, 0, 1, 1}  // Số 9
};

void setup() {
  // Khởi tạo các chân LED 7 đoạn là OUTPUT
  for (int i = 0; i < 7; i++) {
    pinMode(led7Segments[i], OUTPUT);
  }
  
  // Khởi tạo nút nhấn là INPUT
  pinMode(buttonPin, INPUT);
}

void loop() {
  // Đọc trạng thái của nút nhấn
  buttonState = digitalRead(buttonPin);

  // Kiểm tra khi nút nhấn được nhả ra sau khi bấm
  if (buttonState != lastButtonState) {
    if (buttonState == HIGH) {
      if (isCountingUp == true) {
        count--;  // Giảm biến đếm
        if (count < 0) {
          count = 0;  // Giữ ở 0 nếu nhỏ hơn 0
          isCountingUp = false;  // Đổi hướng đếm tăng
        }
      } else {
        count++;  // Tăng biến đếm
        if (count > 9) {
          count = 9;  // Giữ ở 9 nếu lớn hơn 9
          isCountingUp = true;  // Đổi hướng đếm giảm
        }
      }
    }
    delay(50);  // Tránh lỗi debounce
  }

  // Lưu trạng thái của nút nhấn
  lastButtonState = buttonState;

  // Hiển thị số lần nhấn trên LED 7 đoạn
  displayDigit(count);
}

// Hàm hiển thị số lên LED 7 đoạn
void displayDigit(int num) {
  for (int i = 0; i < 7; i++) {
    digitalWrite(led7Segments[i], digits[num][i]);
  }
}
