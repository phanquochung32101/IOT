using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers; // Thêm thư viện Timer

namespace Test
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM5", 9600);
            serialPort.Open();

            // Khởi tạo Timer để đọc dữ liệu real-time từ Arduino
            timer = new System.Timers.Timer(1000); // Đọc trạng thái mỗi giây
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    string data = serialPort.ReadLine();
                    // Cập nhật giao diện theo dữ liệu nhận được
                    Invoke(new Action(() => UpdateTrafficLightStatus(data)));
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    Invoke(new Action(() => lblstatus.Text = "Lỗi đọc dữ liệu: " + ex.Message));
                }
            }
        }
        // Cập nhật giao diện khi nhận được dữ liệu từ Arduino
        private void UpdateTrafficLightStatus(string status)
        {

            // Reset màu nền của các đèn khác khi cần thiết
            ResetLightColors();
            // Hiển thị trạng thái đèn dựa trên chuỗi nhận được
            lblstatus.Text = status; // Hiển thị trạng thái trong Label

            // Cập nhật trực quan cho các đèn giao thông (ví dụ: thay đổi màu nền của các ô TextBox/Label)
            if (status.Contains("Xanh 1 Bật"))
            {
                txtgreenTime1.BackColor = System.Drawing.Color.Green;
                txtredtime2.BackColor = System.Drawing.Color.Red;
            }
            else if (status.Contains("Vàng 1 Bật"))
            {
                txtyellowTime1.BackColor = System.Drawing.Color.Yellow;
            }
            else if (status.Contains("Xanh 2 Bật"))
            {
                txtgreenTime2.BackColor = System.Drawing.Color.Green;
                txtredtime1.BackColor = System.Drawing.Color.Red;
            }
            else if (status.Contains("Vàng 2 Bật"))
            {
                txtyellowtime2.BackColor = System.Drawing.Color.Yellow;
            }
        }

        // Hàm reset màu các đèn giao thông
        private void ResetLightColors()
        {
            txtgreenTime1.BackColor = System.Drawing.Color.White;
            txtyellowTime1.BackColor = System.Drawing.Color.White;
            txtredtime1.BackColor = System.Drawing.Color.White;
            txtgreenTime2.BackColor = System.Drawing.Color.White;
            txtyellowtime2.BackColor = System.Drawing.Color.White;
            txtredtime2.BackColor = System.Drawing.Color.White;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Gửi thời gian điều khiển đèn tới Arduino
            string greenTime = txtgreenTime1.Text;
            string yellowTime = txtyellowTime1.Text;
            string redTime = txtredtime1.Text;

            string command = greenTime + "," + yellowTime + "," + redTime;
            serialPort.WriteLine(command);

            lblstatus.Text = "Đã gửi lệnh thành công!";
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
