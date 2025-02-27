#include <Arduino.h>

// Định nghĩa các chân LED
#define WEST_GREEN 2
#define WEST_YELLOW 3
#define WEST_RED 4

#define EAST_GREEN 5
#define EAST_YELLOW 6
#define EAST_RED 7

#define SOUTH_GREEN 8
#define SOUTH_YELLOW 9
#define SOUTH_RED 10

#define NORTH_GREEN 11
#define NORTH_YELLOW 12
#define NORTH_RED 13

// Trạng thái ban đầu của hệ thống
int x1 = 25, v1 = 5, d1 = 30;
int x2 = 25, v2 = 5, d2 = 30;
int x3 = 25, v3 = 5, d3 = 30;
int x4 = 25, v4 = 5, d4 = 30;

void setup() {
  // Khởi tạo Serial Communication
  Serial.begin(9600);

  // Cấu hình các chân LED là đầu ra
  pinMode(WEST_GREEN, OUTPUT);
  pinMode(WEST_YELLOW, OUTPUT);
  pinMode(WEST_RED, OUTPUT);

  pinMode(EAST_GREEN, OUTPUT);
  pinMode(EAST_YELLOW, OUTPUT);
  pinMode(EAST_RED, OUTPUT);

  pinMode(SOUTH_GREEN, OUTPUT);
  pinMode(SOUTH_YELLOW, OUTPUT);
  pinMode(SOUTH_RED, OUTPUT);

  pinMode(NORTH_GREEN, OUTPUT);
  pinMode(NORTH_YELLOW, OUTPUT);
  pinMode(NORTH_RED, OUTPUT);

  resetLights();
}

void loop() {
  // Kiểm tra dữ liệu nhận từ Serial
  if (Serial.available() > 0) {
    char command = Serial.read();

    switch (command) {
      case '0': // Reset
        resetLights();
        break;
      case '1': // Chế độ 1: Tây & Đông xanh, Bắc & Nam đỏ
        mode1();
        break;
      case '2': // Chế độ 2: Tây & Đông vàng
        mode2();
        break;
      case '3': // Chế độ 3: Bắc & Nam xanh, Tây & Đông đỏ
        mode3();
        break;
      case '4': // Chế độ 4: Bắc & Nam vàng
        mode4();
        break;
      case '5':
        priorityEast5();
        break;
    }
  }
}

// Hàm reset hệ thống
void resetLights() {
  digitalWrite(WEST_GREEN, HIGH);
  digitalWrite(WEST_YELLOW, LOW);
  digitalWrite(WEST_RED, LOW);

  digitalWrite(EAST_GREEN, HIGH);
  digitalWrite(EAST_YELLOW, LOW);
  digitalWrite(EAST_RED, LOW);

  digitalWrite(SOUTH_GREEN, LOW);
  digitalWrite(SOUTH_YELLOW, LOW);
  digitalWrite(SOUTH_RED, HIGH);

  digitalWrite(NORTH_GREEN, LOW);
  digitalWrite(NORTH_YELLOW, LOW);
  digitalWrite(NORTH_RED, HIGH);
}

// Chế độ 1: Tây & Đông xanh, Bắc & Nam đỏ
void mode1() {
  digitalWrite(WEST_GREEN, HIGH);
  digitalWrite(WEST_YELLOW, LOW);
  digitalWrite(WEST_RED, LOW);

  digitalWrite(EAST_GREEN, HIGH);
  digitalWrite(EAST_YELLOW, LOW);
  digitalWrite(EAST_RED, LOW);

  digitalWrite(SOUTH_GREEN, LOW);
  digitalWrite(SOUTH_YELLOW, LOW);
  digitalWrite(SOUTH_RED, HIGH);

  digitalWrite(NORTH_GREEN, LOW);
  digitalWrite(NORTH_YELLOW, LOW);
  digitalWrite(NORTH_RED, HIGH);
}

// Chế độ 2: Tây & Đông vàng
void mode2() {
  digitalWrite(WEST_GREEN, LOW);
  digitalWrite(WEST_YELLOW, HIGH);
  digitalWrite(WEST_RED, LOW);

  digitalWrite(EAST_GREEN, LOW);
  digitalWrite(EAST_YELLOW, HIGH);
  digitalWrite(EAST_RED, LOW);

  digitalWrite(SOUTH_GREEN, LOW);
  digitalWrite(SOUTH_YELLOW, LOW);
  digitalWrite(SOUTH_RED, HIGH);

  digitalWrite(NORTH_GREEN, LOW);
  digitalWrite(NORTH_YELLOW, LOW);
  digitalWrite(NORTH_RED, HIGH);
}

// Chế độ 3: Bắc & Nam xanh, Tây & Đông đỏ
void mode3() {
  digitalWrite(WEST_GREEN, LOW);
  digitalWrite(WEST_YELLOW, LOW);
  digitalWrite(WEST_RED, HIGH);

  digitalWrite(EAST_GREEN, LOW);
  digitalWrite(EAST_YELLOW, LOW);
  digitalWrite(EAST_RED, HIGH);

  digitalWrite(SOUTH_GREEN, HIGH);
  digitalWrite(SOUTH_YELLOW, LOW);
  digitalWrite(SOUTH_RED, LOW);

  digitalWrite(NORTH_GREEN, HIGH);
  digitalWrite(NORTH_YELLOW, LOW);
  digitalWrite(NORTH_RED, LOW);
}

// Chế độ 4: Bắc & Nam vàng
void mode4() {
  digitalWrite(WEST_GREEN, LOW);
  digitalWrite(WEST_YELLOW, LOW);
  digitalWrite(WEST_RED, HIGH);

  digitalWrite(EAST_GREEN, LOW);
  digitalWrite(EAST_YELLOW, LOW);
  digitalWrite(EAST_RED, HIGH);

  digitalWrite(SOUTH_GREEN, LOW);
  digitalWrite(SOUTH_YELLOW, HIGH);
  digitalWrite(SOUTH_RED, LOW);

  digitalWrite(NORTH_GREEN, LOW);
  digitalWrite(NORTH_YELLOW, HIGH);
  digitalWrite(NORTH_RED, LOW);
}


// Chế độ ưu tiên cho hướng Đông
void priorityEast5() {
  // Đèn xanh cho Đông
  digitalWrite(EAST_GREEN, HIGH);
  digitalWrite(EAST_YELLOW, LOW);
  digitalWrite(EAST_RED, LOW);

  // Đèn đỏ cho Tây
  digitalWrite(WEST_GREEN, LOW);
  digitalWrite(WEST_YELLOW, LOW);
  digitalWrite(WEST_RED, HIGH);

  // Đèn đỏ cho Nam
  digitalWrite(SOUTH_GREEN, LOW);
  digitalWrite(SOUTH_YELLOW, LOW);
  digitalWrite(SOUTH_RED, HIGH);

  // Đèn đỏ cho Bắc
  digitalWrite(NORTH_GREEN, LOW);
  digitalWrite(NORTH_YELLOW, LOW);
  digitalWrite(NORTH_RED, HIGH);

}

// Chế độ bình thường
// void normalTraffic() {
//   digitalWrite(EAST_GREEN, HIGH);  // Đèn xanh cho Đông
//   digitalWrite(EAST_YELLOW, LOW);
//   digitalWrite(EAST_RED, LOW);

//   digitalWrite(WEST_GREEN, LOW);  // Đèn xanh cho Tây
//   digitalWrite(WEST_YELLOW, LOW);
//   digitalWrite(WEST_RED, LOW);

//   digitalWrite(SOUTH_GREEN, LOW); // Đèn đỏ cho Nam
//   digitalWrite(SOUTH_YELLOW, LOW);
//   digitalWrite(SOUTH_RED, HIGH);

//   digitalWrite(NORTH_GREEN, LOW); // Đèn đỏ cho Bắc
//   digitalWrite(NORTH_YELLOW, LOW);
//   digitalWrite(NORTH_RED, HIGH);
// }