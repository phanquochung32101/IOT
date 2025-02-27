namespace IoT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTay = new System.Windows.Forms.Label();
            this.picWestGreen = new System.Windows.Forms.PictureBox();
            this.picWestYellow = new System.Windows.Forms.PictureBox();
            this.picWestRed = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDong = new System.Windows.Forms.Label();
            this.picEastRed = new System.Windows.Forms.PictureBox();
            this.picEastYellow = new System.Windows.Forms.PictureBox();
            this.picEastGreen = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picSouthYellow = new System.Windows.Forms.PictureBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.picSouthGreen = new System.Windows.Forms.PictureBox();
            this.picSouthRed = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBac = new System.Windows.Forms.Label();
            this.picNorthRed = new System.Windows.Forms.PictureBox();
            this.picNorthYellow = new System.Windows.Forms.PictureBox();
            this.picNorthGreen = new System.Windows.Forms.PictureBox();
            this.btnCheDo1 = new System.Windows.Forms.Button();
            this.btnCheDo2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWestGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWestYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWestRed)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEastRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEastYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEastGreen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSouthYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSouthGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSouthRed)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNorthRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNorthYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNorthGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTay);
            this.panel1.Controls.Add(this.picWestGreen);
            this.panel1.Controls.Add(this.picWestYellow);
            this.panel1.Controls.Add(this.picWestRed);
            this.panel1.Location = new System.Drawing.Point(14, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 87);
            this.panel1.TabIndex = 3;
            // 
            // lblTay
            // 
            this.lblTay.AutoSize = true;
            this.lblTay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTay.Location = new System.Drawing.Point(88, 32);
            this.lblTay.Name = "lblTay";
            this.lblTay.Size = new System.Drawing.Size(30, 32);
            this.lblTay.TabIndex = 3;
            this.lblTay.Text = "0";
            // 
            // picWestGreen
            // 
            this.picWestGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWestGreen.BackColor = System.Drawing.Color.Lime;
            this.picWestGreen.Location = new System.Drawing.Point(142, 61);
            this.picWestGreen.Name = "picWestGreen";
            this.picWestGreen.Size = new System.Drawing.Size(26, 23);
            this.picWestGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWestGreen.TabIndex = 2;
            this.picWestGreen.TabStop = false;
            // 
            // picWestYellow
            // 
            this.picWestYellow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWestYellow.BackColor = System.Drawing.Color.Yellow;
            this.picWestYellow.Location = new System.Drawing.Point(142, 32);
            this.picWestYellow.Name = "picWestYellow";
            this.picWestYellow.Size = new System.Drawing.Size(26, 23);
            this.picWestYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWestYellow.TabIndex = 1;
            this.picWestYellow.TabStop = false;
            // 
            // picWestRed
            // 
            this.picWestRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWestRed.BackColor = System.Drawing.Color.Red;
            this.picWestRed.Location = new System.Drawing.Point(142, 3);
            this.picWestRed.Name = "picWestRed";
            this.picWestRed.Size = new System.Drawing.Size(26, 23);
            this.picWestRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWestRed.TabIndex = 0;
            this.picWestRed.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDong);
            this.panel3.Controls.Add(this.picEastRed);
            this.panel3.Controls.Add(this.picEastYellow);
            this.panel3.Controls.Add(this.picEastGreen);
            this.panel3.Location = new System.Drawing.Point(380, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 108);
            this.panel3.TabIndex = 3;
            // 
            // lblDong
            // 
            this.lblDong.AutoSize = true;
            this.lblDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDong.Location = new System.Drawing.Point(57, 46);
            this.lblDong.Name = "lblDong";
            this.lblDong.Size = new System.Drawing.Size(30, 32);
            this.lblDong.TabIndex = 4;
            this.lblDong.Text = "0";
            // 
            // picEastRed
            // 
            this.picEastRed.BackColor = System.Drawing.Color.Red;
            this.picEastRed.Location = new System.Drawing.Point(3, 75);
            this.picEastRed.Name = "picEastRed";
            this.picEastRed.Size = new System.Drawing.Size(25, 23);
            this.picEastRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEastRed.TabIndex = 3;
            this.picEastRed.TabStop = false;
            // 
            // picEastYellow
            // 
            this.picEastYellow.BackColor = System.Drawing.Color.Yellow;
            this.picEastYellow.Location = new System.Drawing.Point(3, 46);
            this.picEastYellow.Name = "picEastYellow";
            this.picEastYellow.Size = new System.Drawing.Size(25, 23);
            this.picEastYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEastYellow.TabIndex = 2;
            this.picEastYellow.TabStop = false;
            // 
            // picEastGreen
            // 
            this.picEastGreen.BackColor = System.Drawing.Color.Lime;
            this.picEastGreen.Location = new System.Drawing.Point(3, 17);
            this.picEastGreen.Name = "picEastGreen";
            this.picEastGreen.Size = new System.Drawing.Size(25, 23);
            this.picEastGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEastGreen.TabIndex = 1;
            this.picEastGreen.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picSouthYellow);
            this.panel2.Controls.Add(this.lblNam);
            this.panel2.Controls.Add(this.picSouthGreen);
            this.panel2.Controls.Add(this.picSouthRed);
            this.panel2.Location = new System.Drawing.Point(285, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 109);
            this.panel2.TabIndex = 3;
            // 
            // picSouthYellow
            // 
            this.picSouthYellow.BackColor = System.Drawing.Color.Yellow;
            this.picSouthYellow.Location = new System.Drawing.Point(34, 14);
            this.picSouthYellow.Name = "picSouthYellow";
            this.picSouthYellow.Size = new System.Drawing.Size(25, 23);
            this.picSouthYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSouthYellow.TabIndex = 10;
            this.picSouthYellow.TabStop = false;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(29, 68);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(30, 32);
            this.lblNam.TabIndex = 4;
            this.lblNam.Text = "0";
            // 
            // picSouthGreen
            // 
            this.picSouthGreen.BackColor = System.Drawing.Color.Lime;
            this.picSouthGreen.Location = new System.Drawing.Point(65, 14);
            this.picSouthGreen.Name = "picSouthGreen";
            this.picSouthGreen.Size = new System.Drawing.Size(25, 23);
            this.picSouthGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSouthGreen.TabIndex = 3;
            this.picSouthGreen.TabStop = false;
            // 
            // picSouthRed
            // 
            this.picSouthRed.BackColor = System.Drawing.Color.Red;
            this.picSouthRed.Location = new System.Drawing.Point(3, 14);
            this.picSouthRed.Name = "picSouthRed";
            this.picSouthRed.Size = new System.Drawing.Size(25, 23);
            this.picSouthRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSouthRed.TabIndex = 2;
            this.picSouthRed.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblBac);
            this.panel4.Controls.Add(this.picNorthRed);
            this.panel4.Controls.Add(this.picNorthYellow);
            this.panel4.Controls.Add(this.picNorthGreen);
            this.panel4.Location = new System.Drawing.Point(126, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 99);
            this.panel4.TabIndex = 3;
            // 
            // lblBac
            // 
            this.lblBac.AutoSize = true;
            this.lblBac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBac.Location = new System.Drawing.Point(86, 20);
            this.lblBac.Name = "lblBac";
            this.lblBac.Size = new System.Drawing.Size(30, 32);
            this.lblBac.TabIndex = 4;
            this.lblBac.Text = "0";
            // 
            // picNorthRed
            // 
            this.picNorthRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picNorthRed.BackColor = System.Drawing.Color.Red;
            this.picNorthRed.Location = new System.Drawing.Point(123, 73);
            this.picNorthRed.Name = "picNorthRed";
            this.picNorthRed.Size = new System.Drawing.Size(25, 23);
            this.picNorthRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNorthRed.TabIndex = 1;
            this.picNorthRed.TabStop = false;
            // 
            // picNorthYellow
            // 
            this.picNorthYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picNorthYellow.BackColor = System.Drawing.Color.Yellow;
            this.picNorthYellow.Location = new System.Drawing.Point(92, 73);
            this.picNorthYellow.Name = "picNorthYellow";
            this.picNorthYellow.Size = new System.Drawing.Size(25, 23);
            this.picNorthYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNorthYellow.TabIndex = 2;
            this.picNorthYellow.TabStop = false;
            // 
            // picNorthGreen
            // 
            this.picNorthGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picNorthGreen.BackColor = System.Drawing.Color.Lime;
            this.picNorthGreen.Location = new System.Drawing.Point(61, 73);
            this.picNorthGreen.Name = "picNorthGreen";
            this.picNorthGreen.Size = new System.Drawing.Size(25, 23);
            this.picNorthGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNorthGreen.TabIndex = 3;
            this.picNorthGreen.TabStop = false;
            // 
            // btnCheDo1
            // 
            this.btnCheDo1.BackColor = System.Drawing.Color.White;
            this.btnCheDo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheDo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheDo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheDo1.Location = new System.Drawing.Point(21, 414);
            this.btnCheDo1.Name = "btnCheDo1";
            this.btnCheDo1.Size = new System.Drawing.Size(119, 48);
            this.btnCheDo1.TabIndex = 4;
            this.btnCheDo1.Text = "Chế độ 1";
            this.btnCheDo1.UseVisualStyleBackColor = false;
            this.btnCheDo1.Click += new System.EventHandler(this.btnCheDo1_Click);
            // 
            // btnCheDo2
            // 
            this.btnCheDo2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheDo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheDo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheDo2.Location = new System.Drawing.Point(206, 414);
            this.btnCheDo2.Name = "btnCheDo2";
            this.btnCheDo2.Size = new System.Drawing.Size(119, 48);
            this.btnCheDo2.TabIndex = 5;
            this.btnCheDo2.Text = "Chế Độ 2";
            this.btnCheDo2.UseVisualStyleBackColor = false;
            this.btnCheDo2.Click += new System.EventHandler(this.btnCheDo2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(206, 508);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 48);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Trạng Thái: ";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lblTrangThai.Location = new System.Drawing.Point(173, 367);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(104, 22);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Đang tắt...";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(389, 414);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 48);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 568);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheDo2);
            this.Controls.Add(this.btnCheDo1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWestGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWestYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWestRed)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEastRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEastYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEastGreen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSouthYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSouthGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSouthRed)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNorthRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNorthYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNorthGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picWestGreen;
        private System.Windows.Forms.PictureBox picWestYellow;
        private System.Windows.Forms.PictureBox picWestRed;
        private System.Windows.Forms.PictureBox picEastRed;
        private System.Windows.Forms.PictureBox picEastYellow;
        private System.Windows.Forms.PictureBox picEastGreen;
        private System.Windows.Forms.PictureBox picSouthGreen;
        private System.Windows.Forms.PictureBox picSouthRed;
        private System.Windows.Forms.PictureBox picNorthGreen;
        private System.Windows.Forms.PictureBox picNorthYellow;
        private System.Windows.Forms.PictureBox picNorthRed;
        private System.Windows.Forms.Label lblTay;
        private System.Windows.Forms.Label lblDong;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblBac;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheDo1;
        private System.Windows.Forms.Button btnCheDo2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTrangThai;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picSouthYellow;
        private System.Windows.Forms.Timer timer2;
    }
}

