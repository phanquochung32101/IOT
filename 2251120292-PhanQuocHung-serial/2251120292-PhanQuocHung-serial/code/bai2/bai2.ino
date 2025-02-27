const int segmentPins[] = {2, 3, 4, 5, 6, 7, 8};  // Chân nối tới 7 đoạn LED
const int digits[10][7] = {
    {1, 1, 1, 1, 1, 1, 0},  // 0
    {0, 1, 1, 0, 0, 0, 0},  // 1
    {1, 1, 0, 1, 1, 0, 1},  // 2
    {1, 1, 1, 1, 0, 0, 1},  // 3
    {0, 1, 1, 0, 0, 1, 1},  // 4
    {1, 0, 1, 1, 0, 1, 1},  // 5
    {1, 0, 1, 1, 1, 1, 1},  // 6
    {1, 1, 1, 0, 0, 0, 0},  // 7
    {1, 1, 1, 1, 1, 1, 1},  // 8
    {1, 1, 1, 1, 0, 1, 1}   // 9
};

void setup() {
    for (int i = 0; i < 7; i++) {
        pinMode(segmentPins[i], OUTPUT);
    }
    Serial.begin(9600);  // Bắt đầu giao tiếp serial với tốc độ baud 9600
}

void loop() {
    if (Serial.available()) {
        int number = Serial.parseInt();  // Đọc số từ serial
        if (number >= 0 && number <= 9) {
            displayDigit(number);  // Hiển thị số trên 7-segment LED
        }
    }
}

void displayDigit(int number) {
    for (int i = 0; i < 7; i++) {
        digitalWrite(segmentPins[i], digits[number][i]);  // Hiển thị số bằng cách bật/tắt các chân LED
    }
}
