using System;
using System.IO.Ports;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArduinoController
{
    public partial class Form1 : Form
    {
        // Khai báo đối tượng SerialPort
        SerialPort serialPort;
        int currentNumber = 0;  // Biến lưu giá trị số hiển thị hiện tại

        public Form1()
        {
            InitializeComponent();
            // Thiết lập SerialPort với cổng COM kết nối Arduino và tốc độ baud
            serialPort = new SerialPort("COM3", 9600);  // Đổi "COM3" thành cổng bạn sử dụng
            serialPort.Open();  // Mở kết nối Serial
        }

        // Hàm xử lý khi nhấn nút "Count Up"
        private void btnCountUp_Click(object sender, EventArgs e)
        {
            if (currentNumber < 9)  // Giới hạn số lên tới 9
                currentNumber++;

            serialPort.WriteLine(currentNumber.ToString());  // Gửi số qua Serial
            textBox2.Text = currentNumber.ToString();  // Cập nhật giá trị lên TextBox
        }

        // Hàm xử lý khi nhấn nút "Count Down"
        private void btnCountDown_Click(object sender, EventArgs e)
        {
            if (currentNumber > 0)  // Giới hạn số giảm tới 0
                currentNumber--;

            serialPort.WriteLine(currentNumber.ToString());  // Gửi số qua Serial
            textBox2.Text = currentNumber.ToString();  // Cập nhật giá trị lên TextBox
        }
    }
}
