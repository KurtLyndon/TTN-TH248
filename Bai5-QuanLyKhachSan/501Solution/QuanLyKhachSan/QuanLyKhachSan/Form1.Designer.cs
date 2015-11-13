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
            this.SuspendLayout();
            // 
            // butQLDichVu
            // 
            this.butQLDichVu.Location = new System.Drawing.Point(422, 225);
            this.butQLDichVu.Name = "butQLDichVu";
            this.butQLDichVu.Size = new System.Drawing.Size(118, 23);
            this.butQLDichVu.TabIndex = 0;
            this.butQLDichVu.Text = "QuanLyDichVu";
            this.butQLDichVu.UseVisualStyleBackColor = true;
            this.butQLDichVu.Visible = false;
            this.butQLDichVu.Click += new System.EventHandler(this.butQLDichVu_Click);
            // 
            // butLogIn
            // 
            this.butLogIn.Location = new System.Drawing.Point(614, 99);
            this.butLogIn.Name = "butLogIn";
            this.butLogIn.Size = new System.Drawing.Size(75, 23);
            this.butLogIn.TabIndex = 1;
            this.butLogIn.Text = "Log In";
            this.butLogIn.UseVisualStyleBackColor = true;
            this.butLogIn.Click += new System.EventHandler(this.butLogIn_Click);
            // 
            // butDoDung
            // 
            this.butDoDung.Location = new System.Drawing.Point(422, 138);
            this.butDoDung.Name = "butDoDung";
            this.butDoDung.Size = new System.Drawing.Size(118, 23);
            this.butDoDung.TabIndex = 1;
            this.butDoDung.Text = "DoDung";
            this.butDoDung.UseVisualStyleBackColor = true;
            this.butDoDung.Visible = false;
            this.butDoDung.Click += new System.EventHandler(this.butDoDung_Click);
            // 
            // butKhachHang
            // 
            this.butKhachHang.Location = new System.Drawing.Point(422, 109);
            this.butKhachHang.Name = "butKhachHang";
            this.butKhachHang.Size = new System.Drawing.Size(118, 23);
            this.butKhachHang.TabIndex = 1;
            this.butKhachHang.Text = "KhachHang";
            this.butKhachHang.UseVisualStyleBackColor = true;
            this.butKhachHang.Visible = false;
            this.butKhachHang.Click += new System.EventHandler(this.butKhachHang_Click);
            // 
            // butDichVu
            // 
            this.butDichVu.Location = new System.Drawing.Point(422, 167);
            this.butDichVu.Name = "butDichVu";
            this.butDichVu.Size = new System.Drawing.Size(118, 23);
            this.butDichVu.TabIndex = 1;
            this.butDichVu.Text = "DichVu";
            this.butDichVu.UseVisualStyleBackColor = true;
            this.butDichVu.Visible = false;
            this.butDichVu.Click += new System.EventHandler(this.butDichVu_Click);
            // 
            // butPhong
            // 
            this.butPhong.Location = new System.Drawing.Point(422, 196);
            this.butPhong.Name = "butPhong";
            this.butPhong.Size = new System.Drawing.Size(118, 23);
            this.butPhong.TabIndex = 1;
            this.butPhong.Text = "Phong";
            this.butPhong.UseVisualStyleBackColor = true;
            this.butPhong.Visible = false;
            this.butPhong.Click += new System.EventHandler(this.butPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(638, 52);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 3;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(638, 73);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(100, 20);
            this.textPass.TabIndex = 3;
            // 
            // butQLDoDung
            // 
            this.butQLDoDung.Location = new System.Drawing.Point(422, 254);
            this.butQLDoDung.Name = "butQLDoDung";
            this.butQLDoDung.Size = new System.Drawing.Size(118, 23);
            this.butQLDoDung.TabIndex = 0;
            this.butQLDoDung.Text = "QuanLyDoDung";
            this.butQLDoDung.UseVisualStyleBackColor = true;
            this.butQLDoDung.Visible = false;
            this.butQLDoDung.Click += new System.EventHandler(this.butQLDoDung_Click);
            // 
            // butQLPhong
            // 
            this.butQLPhong.Location = new System.Drawing.Point(422, 283);
            this.butQLPhong.Name = "butQLPhong";
            this.butQLPhong.Size = new System.Drawing.Size(118, 23);
            this.butQLPhong.TabIndex = 0;
            this.butQLPhong.Text = "QuanLyPhong";
            this.butQLPhong.UseVisualStyleBackColor = true;
            this.butQLPhong.Visible = false;
            this.butQLPhong.Click += new System.EventHandler(this.butQLPhong_Click);
            // 
            // butLogOut
            // 
            this.butLogOut.Location = new System.Drawing.Point(446, 71);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(75, 23);
            this.butLogOut.TabIndex = 1;
            this.butLogOut.Text = "Log Out";
            this.butLogOut.UseVisualStyleBackColor = true;
            this.butLogOut.Visible = false;
            this.butLogOut.Click += new System.EventHandler(this.butLogOut_Click);
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.QLKS;
            this.ClientSize = new System.Drawing.Size(794, 432);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butPhong);
            this.Controls.Add(this.butDichVu);
            this.Controls.Add(this.butKhachHang);
            this.Controls.Add(this.butDoDung);
            this.Controls.Add(this.butLogOut);
            this.Controls.Add(this.butLogIn);
            this.Controls.Add(this.butQLPhong);
            this.Controls.Add(this.butQLDoDung);
            this.Controls.Add(this.butQLDichVu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Start";
            this.Text = "Quản Lý Khách Sạn";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

