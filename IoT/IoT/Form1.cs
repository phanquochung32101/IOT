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

namespace IoT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        int i;
        int x1, v1, d1, x2, v2, d2, x3, v3, d3, x4, v4, d4;
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Đặt lại giá trị của biến và nhãn về giá trị ban đầu
            i = 0;
            x1 = 25; v1 = 5; d1 = 30;
            x2 = 25; v2 = 5; d2 = 30;
            x3 = 25; v3 = 5; d3 = 30;
            x4 = 25; v4 = 5; d4 = 30;

            // Cập nhật lại các nhãn với giá trị ban đầu
            lblTay.Text = x1.ToString();
            lblDong.Text = x3.ToString();
            lblNam.Text = d2.ToString();
            lblBac.Text = d4.ToString();

            // Đặt lại màu cho các đèn về trạng thái ban đầu
            picWestGreen.BackColor = Color.Green;
            picWestYellow.BackColor = Color.White;
            picWestRed.BackColor = Color.White;

            picEastGreen.BackColor = Color.Green;
            picEastYellow.BackColor = Color.White;
            picEastRed.BackColor = Color.White;

            picSouthGreen.BackColor = Color.White;
            picSouthYellow.BackColor = Color.White;
            picSouthRed.BackColor = Color.Red;

            picNorthGreen.BackColor = Color.White;
            picNorthYellow.BackColor = Color.White;
            picNorthRed.BackColor = Color.Red;

            // Gửi tín hiệu Reset qua Serial Port nếu cần
            serialPort1.Write("0"); // Giả sử "0" là tín hiệu để reset
        }
        private void btnCheDo1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            // 1:Tây(West);  3:Đông(East);       2:Nam(South);  4: Bắc(North)
            // Đông,Tây: xanh ;  Bắc,Nam: Đỏ
            i = 0;
            x1 = x2 = x3 = x4 = 25;
            v1 = v2 = v3 = v4 = 5;
            d1 = d2 = d3 = d4 = 30;
            timer1.Start();
            // Hướng Tây
            lblTay.Text = x1.ToString();
            picWestGreen.BackColor = Color.Green;
            picWestYellow.BackColor = Color.White;
            picWestRed.BackColor = Color.White;

            // Hướng Đông
            lblDong.Text = x3.ToString();
            picEastGreen.BackColor = Color.Green;
            picEastYellow.BackColor = Color.White;
            picEastRed.BackColor = Color.White;

            // Hướng Nam
            lblNam.Text = d2.ToString();
            picSouthGreen.BackColor = Color.White;
            picSouthYellow.BackColor = Color.White;
            picSouthRed.BackColor = Color.Red;

            // Hướng Bắc
            lblBac.Text = d4.ToString();
            picNorthGreen.BackColor = Color.White;
            picNorthYellow.BackColor = Color.White;
            picNorthRed.BackColor = Color.Red;

            lblTrangThai.Text = "Bình Thường";
            lblTrangThai.ForeColor = Color.Green;
            serialPort1.Write("1");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if(i <= 25)
            {
                x1--;
                x3--;
                d2--;
                d4--;

                lblTay.Text = x1.ToString();
                picWestGreen.BackColor = Color.Green;
                lblDong.Text = x3.ToString();
                picEastGreen.BackColor = Color.Green;

                lblNam.Text = d2.ToString();
                picSouthRed.BackColor = Color.Red;
                lblBac.Text = d4.ToString();
                picNorthRed.BackColor = Color.Red;

                serialPort1.Write("1");
            }

            if(i >=25 && i < 30)
            {
                // Nam Bắc: đỏ
                lblNam.Text = d2.ToString();
                lblBac.Text = d4.ToString();
                picSouthRed.BackColor = Color.Red;
                picNorthRed.BackColor = Color.Red;
                d2--;
                d4--;

                // Đông Tây chuyển sang vàng 
                lblDong.Text = v3.ToString();
                lblTay.Text = v1.ToString();
                picEastGreen.BackColor = Color.White;
                picEastYellow.BackColor = Color.Yellow;
                picWestGreen.BackColor= Color.White;
                picWestYellow.BackColor= Color.Yellow;
                v3--;
                v1--;
                serialPort1.Write("2");
            }

            if(i >=30 && i < 55)
            {
               
                lblDong.Text = d3.ToString();
                lblTay.Text = d1.ToString();
                picEastRed.BackColor = Color.Red;
                picEastYellow.BackColor = Color.White;
                picWestYellow.BackColor = Color.White;
                picWestRed.BackColor = Color.Red;
                d3--;
                d1--;

                lblNam.Text = x2.ToString();
                lblBac.Text= x4.ToString();
                picSouthGreen.BackColor = Color.Green;
                picSouthRed.BackColor = Color.White;
                picNorthGreen.BackColor = Color.Green;
                picNorthRed.BackColor = Color.White;
                x2--;
                x4--;

                serialPort1.Write("3");
            }

            if (i >= 55 && i < 60)
            {
/*                if (i == 55)
                {
                    d3++;
                    d1++;
                }*/

                // Nam Bắc chuyển sang vàng 
                lblNam.Text = v2.ToString();
                lblBac.Text = v4.ToString();
                picSouthGreen.BackColor = Color.White;
                picSouthYellow.BackColor = Color.Yellow;
                picNorthGreen.BackColor = Color.White;
                picNorthYellow.BackColor = Color.Yellow;
                v2--;
                v4--;


                // Đông Tây: đỏ
                lblDong.Text = d3.ToString();
                lblTay.Text = d1.ToString();
                picEastRed.BackColor = Color.Red;
                picWestRed.BackColor = Color.Red;
                d3--;
                d1--;

                serialPort1.Write("4");
            }
            if (i > 60)
            {

                i = 0;
                x1 = x2 = x3 = x4 = 25;
                v1 = v2 = v3 = v4 = 5;
                d1 = d2 = d3 = d4 = 30;
                
                // Đặt lại nhãn và màu đèn
                lblTay.Text = x1.ToString();
                lblDong.Text = x3.ToString();
                lblNam.Text = d2.ToString();
                lblBac.Text = d4.ToString();

                picWestGreen.BackColor = Color.Green;
                picWestYellow.BackColor = Color.White;
                picWestRed.BackColor = Color.White;

                picEastGreen.BackColor = Color.Green;
                picEastYellow.BackColor = Color.White;
                picEastRed.BackColor = Color.White;

                picSouthGreen.BackColor = Color.White;
                picSouthYellow.BackColor = Color.White;
                picSouthRed.BackColor = Color.Red;

                picNorthGreen.BackColor = Color.White;
                picNorthYellow.BackColor = Color.White;
                picNorthRed.BackColor = Color.Red;
            }
        }

        private void btnCheDo2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            // Đặt chế độ ưu tiên cho hướng Đông (East)
            lblDong.Text = "";
            picEastGreen.BackColor = Color.Green;
            picEastYellow.BackColor = Color.White;
            picEastRed.BackColor = Color.White;

            lblTay.Text = "";
            picWestGreen.BackColor = Color.White;
            picWestYellow.BackColor = Color.White;
            picWestRed.BackColor = Color.Red;

            lblNam.Text = "";
            picSouthGreen.BackColor = Color.White;
            picSouthYellow.BackColor = Color.White;
            picSouthRed.BackColor = Color.Red;

            lblBac.Text = "";
            picNorthGreen.BackColor = Color.White;
            picNorthYellow.BackColor = Color.White;
            picNorthRed.BackColor = Color.Red;

            lblTrangThai.Text = "Ưu Tiên Đông";
            lblTrangThai.ForeColor = Color.Red;

            // Gửi tín hiệu chế độ ưu tiên qua Serial
            serialPort1.Write("5");

            // Khởi động timer để thoát chế độ ưu tiên sau 15 giây
            Timer priorityTimer = new Timer();
            priorityTimer.Interval = 15000; //15 giây
            priorityTimer.Tick += (s, ev) =>
            {
                // Trở về chế độ bình thường
                btnCheDo1_Click(null, null);
                lblTrangThai.Text = "Chế độ bình thường";
                lblTrangThai.ForeColor = Color.Green;

                priorityTimer.Stop();
                priorityTimer.Dispose();
            };
            priorityTimer.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            if (i <= 25 )
            {
/*                lblTay.Text = d1.ToString();*/
                picWestGreen.BackColor = Color.White;
                picWestYellow.BackColor = Color.White;
                picWestRed.BackColor = Color.Red;

/*                lblDong.Text = x3.ToString();*/
                picEastGreen.BackColor = Color.Green;
                picEastYellow.BackColor = Color.White;
                picEastRed.BackColor = Color.White;
/*
                lblNam.Text = d2.ToString();*/
                picSouthGreen.BackColor = Color.White;
                picSouthYellow.BackColor = Color.White;
                picSouthRed.BackColor = Color.Red;
/*
                lblBac.Text = d4.ToString();*/
                picNorthGreen.BackColor = Color.White;
                picNorthYellow.BackColor = Color.White;
                picNorthRed.BackColor = Color.Red;

                serialPort1.Write("5"); // Chế độ ưu tiên
            }
            else
            {
                // Dừng timer khi chế độ ưu tiên kết thúc
                timer2.Stop();
                btnCheDo1_Click(null, null); // Quay lại chế độ bình thường
            }
        }

         private void btnExit_Click(object sender, EventArgs e)
         {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Thông Báo!",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
