namespace QuanLyKhachSan
{
    partial class frm_Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Start));
            this.butQLDichVu = new System.Windows.Forms.Button();
            this.butLogIn = new System.Windows.Forms.Button();
            this.butDoDung = new System.Windows.Forms.Button();
            this.butKhachHang = new System.Windows.Forms.Button();
            this.butDichVu = new System.Windows.Forms.Button();
            this.butPhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.butQLDoDung = new System.Windows.Forms.Button();
            this.butQLPhong = new System.Windows.Forms.Button();
            this.butLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // butQLDichVu
            // 
            this.butQLDichVu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQLDichVu.Image = global::QuanLyKhachSan.Properties.Resources.Service_manage;
            this.butQLDichVu.Location = new System.Drawing.Point(2, 0);
            this.butQLDichVu.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butQLDichVu.Name = "butQLDichVu";
            this.butQLDichVu.Size = new System.Drawing.Size(128, 138);
            this.butQLDichVu.TabIndex = 0;
            this.butQLDichVu.Text = "Quản Lý\r\nDịch Vụ\r\n";
            this.butQLDichVu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butQLDichVu.UseVisualStyleBackColor = true;
            this.butQLDichVu.Visible = false;
            this.butQLDichVu.Click += new System.EventHandler(this.butQLDichVu_Click);
            // 
            // butLogIn
            // 
            this.butLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butLogIn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogIn.Location = new System.Drawing.Point(346, 80);
            this.butLogIn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butLogIn.Name = "butLogIn";
            this.butLogIn.Size = new System.Drawing.Size(74, 33);
            this.butLogIn.TabIndex = 1;
            this.butLogIn.Text = "Log In";
            this.butLogIn.UseVisualStyleBackColor = false;
            this.butLogIn.Click += new System.EventHandler(this.butLogIn_Click);
            // 
            // butDoDung
            // 
            this.butDoDung.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDoDung.Image = global::QuanLyKhachSan.Properties.Resources.furniture;
            this.butDoDung.Location = new System.Drawing.Point(2, 273);
            this.butDoDung.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butDoDung.Name = "butDoDung";
            this.butDoDung.Size = new System.Drawing.Size(128, 138);
            this.butDoDung.TabIndex = 1;
            this.butDoDung.Text = "Trang Thiết Bị";
            this.butDoDung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butDoDung.UseVisualStyleBackColor = true;
            this.butDoDung.Visible = false;
            this.butDoDung.Click += new System.EventHandler(this.butDoDung_Click);
            // 
            // butKhachHang
            // 
            this.butKhachHang.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butKhachHang.Image = global::QuanLyKhachSan.Properties.Resources.Customers;
            this.butKhachHang.Location = new System.Drawing.Point(2, 4);
            this.butKhachHang.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butKhachHang.Name = "butKhachHang";
            this.butKhachHang.Size = new System.Drawing.Size(128, 138);
            this.butKhachHang.TabIndex = 1;
            this.butKhachHang.Text = "Khách Hàng";
            this.butKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butKhachHang.UseVisualStyleBackColor = true;
            this.butKhachHang.Visible = false;
            this.butKhachHang.Click += new System.EventHandler(this.butKhachHang_Click);
            // 
            // butDichVu
            // 
            this.butDichVu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDichVu.Image = global::QuanLyKhachSan.Properties.Resources.Service;
            this.butDichVu.Location = new System.Drawing.Point(2, 406);
            this.butDichVu.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butDichVu.Name = "butDichVu";
            this.butDichVu.Size = new System.Drawing.Size(128, 138);
            this.butDichVu.TabIndex = 1;
            this.butDichVu.Text = "Dịch Vụ";
            this.butDichVu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butDichVu.UseVisualStyleBackColor = true;
            this.butDichVu.Visible = false;
            this.butDichVu.Click += new System.EventHandler(this.butDichVu_Click);
            // 
            // butPhong
            // 
            this.butPhong.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPhong.Image = global::QuanLyKhachSan.Properties.Resources.Room;
            this.butPhong.Location = new System.Drawing.Point(2, 139);
            this.butPhong.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butPhong.Name = "butPhong";
            this.butPhong.Size = new System.Drawing.Size(128, 138);
            this.butPhong.TabIndex = 1;
            this.butPhong.Text = "Phòng";
            this.butPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butPhong.UseVisualStyleBackColor = true;
            this.butPhong.Visible = false;
            this.butPhong.Click += new System.EventHandler(this.butPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(276, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(276, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(348, 30);
            this.textID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(154, 20);
            this.textID.TabIndex = 3;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(348, 54);
            this.textPass.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(154, 20);
            this.textPass.TabIndex = 3;
            // 
            // butQLDoDung
            // 
            this.butQLDoDung.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQLDoDung.Image = global::QuanLyKhachSan.Properties.Resources.Furniture_manage;
            this.butQLDoDung.Location = new System.Drawing.Point(2, 269);
            this.butQLDoDung.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butQLDoDung.Name = "butQLDoDung";
            this.butQLDoDung.Size = new System.Drawing.Size(128, 138);
            this.butQLDoDung.TabIndex = 0;
            this.butQLDoDung.Text = "Quản Lý\r\nTrang Thiết Bị\r\n";
            this.butQLDoDung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butQLDoDung.UseVisualStyleBackColor = true;
            this.butQLDoDung.Visible = false;
            this.butQLDoDung.Click += new System.EventHandler(this.butQLDoDung_Click);
            // 
            // butQLPhong
            // 
            this.butQLPhong.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQLPhong.Image = global::QuanLyKhachSan.Properties.Resources.room_manager;
            this.butQLPhong.Location = new System.Drawing.Point(2, 135);
            this.butQLPhong.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butQLPhong.Name = "butQLPhong";
            this.butQLPhong.Size = new System.Drawing.Size(128, 138);
            this.butQLPhong.TabIndex = 0;
            this.butQLPhong.Text = "Quản Lý Phòng";
            this.butQLPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butQLPhong.UseVisualStyleBackColor = true;
            this.butQLPhong.Visible = false;
            this.butQLPhong.Click += new System.EventHandler(this.butQLPhong_Click);
            // 
            // butLogOut
            // 
            this.butLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butLogOut.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogOut.Location = new System.Drawing.Point(426, 80);
            this.butLogOut.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(74, 33);
            this.butLogOut.TabIndex = 1;
            this.butLogOut.Text = "Log Out";
            this.butLogOut.UseVisualStyleBackColor = false;
            this.butLogOut.Visible = false;
            this.butLogOut.Click += new System.EventHandler(this.butLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.textID);
            this.panel1.Controls.Add(this.textPass);
            this.panel1.Controls.Add(this.butLogIn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.butLogOut);
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 136);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyKhachSan.Properties.Resources.guide;
            this.button1.Location = new System.Drawing.Point(2, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 138);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hướng Dẫn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.butDoDung);
            this.panel2.Controls.Add(this.butKhachHang);
            this.panel2.Controls.Add(this.butPhong);
            this.panel2.Controls.Add(this.butDichVu);
            this.panel2.Location = new System.Drawing.Point(0, -6);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 554);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.butQLPhong);
            this.panel3.Controls.Add(this.butQLDichVu);
            this.panel3.Controls.Add(this.butQLDoDung);
            this.panel3.Location = new System.Drawing.Point(662, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 554);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.QLKS;
            this.ClientSize = new System.Drawing.Size(794, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximumSize = new System.Drawing.Size(810, 579);
            this.MinimumSize = new System.Drawing.Size(810, 579);
            this.Name = "frm_Start";
            this.Text = "Quản Lý Khách Sạn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butQLDichVu;
        private System.Windows.Forms.Button butLogIn;
        private System.Windows.Forms.Button butDoDung;
        private System.Windows.Forms.Button butKhachHang;
        private System.Windows.Forms.Button butDichVu;
        private System.Windows.Forms.Button butPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button butQLDoDung;
        private System.Windows.Forms.Button butQLPhong;
        private System.Windows.Forms.Button butLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

