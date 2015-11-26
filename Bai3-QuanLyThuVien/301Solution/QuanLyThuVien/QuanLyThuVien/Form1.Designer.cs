namespace QuanLyThuVien
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
            this.butBanDoc = new System.Windows.Forms.Button();
            this.butSach = new System.Windows.Forms.Button();
            this.butNXB = new System.Windows.Forms.Button();
            this.butPhieuMuon = new System.Windows.Forms.Button();
            this.butLogIn = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butHuongDan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butBanDoc
            // 
            this.butBanDoc.Enabled = false;
            this.butBanDoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butBanDoc.Image = global::QuanLyThuVien.Properties.Resources.Reader;
            this.butBanDoc.Location = new System.Drawing.Point(3, 12);
            this.butBanDoc.Name = "butBanDoc";
            this.butBanDoc.Size = new System.Drawing.Size(130, 149);
            this.butBanDoc.TabIndex = 0;
            this.butBanDoc.Text = "Bạn Đọc";
            this.butBanDoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butBanDoc.UseVisualStyleBackColor = true;
            this.butBanDoc.Visible = false;
            this.butBanDoc.Click += new System.EventHandler(this.butBanDoc_Click);
            // 
            // butSach
            // 
            this.butSach.Enabled = false;
            this.butSach.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butSach.Image = global::QuanLyThuVien.Properties.Resources.Book;
            this.butSach.Location = new System.Drawing.Point(154, 12);
            this.butSach.Name = "butSach";
            this.butSach.Size = new System.Drawing.Size(130, 149);
            this.butSach.TabIndex = 0;
            this.butSach.Text = "Sách";
            this.butSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butSach.UseVisualStyleBackColor = true;
            this.butSach.Visible = false;
            this.butSach.Click += new System.EventHandler(this.butSach_Click);
            // 
            // butNXB
            // 
            this.butNXB.Enabled = false;
            this.butNXB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butNXB.Image = global::QuanLyThuVien.Properties.Resources.Publisher;
            this.butNXB.Location = new System.Drawing.Point(301, 12);
            this.butNXB.Name = "butNXB";
            this.butNXB.Size = new System.Drawing.Size(130, 149);
            this.butNXB.TabIndex = 0;
            this.butNXB.Text = "Nhà xuất bản \r\nThể loại";
            this.butNXB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butNXB.UseVisualStyleBackColor = true;
            this.butNXB.Visible = false;
            this.butNXB.Click += new System.EventHandler(this.butNXB_Click);
            // 
            // butPhieuMuon
            // 
            this.butPhieuMuon.Enabled = false;
            this.butPhieuMuon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butPhieuMuon.Image = global::QuanLyThuVien.Properties.Resources.Phieu_Muon;
            this.butPhieuMuon.Location = new System.Drawing.Point(456, 12);
            this.butPhieuMuon.Name = "butPhieuMuon";
            this.butPhieuMuon.Size = new System.Drawing.Size(130, 149);
            this.butPhieuMuon.TabIndex = 0;
            this.butPhieuMuon.Text = "Phiếu Mượn";
            this.butPhieuMuon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butPhieuMuon.UseVisualStyleBackColor = true;
            this.butPhieuMuon.Visible = false;
            this.butPhieuMuon.Click += new System.EventHandler(this.butPhieuMuon_Click);
            // 
            // butLogIn
            // 
            this.butLogIn.Font = new System.Drawing.Font("VNI-Fato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogIn.ForeColor = System.Drawing.Color.Maroon;
            this.butLogIn.Location = new System.Drawing.Point(59, 64);
            this.butLogIn.Name = "butLogIn";
            this.butLogIn.Size = new System.Drawing.Size(81, 33);
            this.butLogIn.TabIndex = 0;
            this.butLogIn.Text = "Log In";
            this.butLogIn.UseVisualStyleBackColor = true;
            this.butLogIn.Click += new System.EventHandler(this.butLogIn_Click);
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textID.Location = new System.Drawing.Point(59, 10);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(128, 20);
            this.textID.TabIndex = 1;
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textPass.Location = new System.Drawing.Point(59, 36);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(128, 20);
            this.textPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pass";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textID);
            this.panel1.Controls.Add(this.butLogIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textPass);
            this.panel1.Location = new System.Drawing.Point(270, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // butHuongDan
            // 
            this.butHuongDan.Enabled = false;
            this.butHuongDan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butHuongDan.Image = global::QuanLyThuVien.Properties.Resources.guide;
            this.butHuongDan.Location = new System.Drawing.Point(602, 12);
            this.butHuongDan.Name = "butHuongDan";
            this.butHuongDan.Size = new System.Drawing.Size(130, 149);
            this.butHuongDan.TabIndex = 6;
            this.butHuongDan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butHuongDan.UseVisualStyleBackColor = true;
            this.butHuongDan.Visible = false;
            this.butHuongDan.Click += new System.EventHandler(this.butHuongDan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.butLogOut);
            this.panel2.Location = new System.Drawing.Point(273, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // butLogOut
            // 
            this.butLogOut.Font = new System.Drawing.Font("VNI-Fato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogOut.ForeColor = System.Drawing.Color.Maroon;
            this.butLogOut.Location = new System.Drawing.Point(59, 36);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(81, 33);
            this.butLogOut.TabIndex = 0;
            this.butLogOut.Text = "Log Out";
            this.butLogOut.UseVisualStyleBackColor = true;
            this.butLogOut.Click += new System.EventHandler(this.butLogOut_Click);
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources.QLTV;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.butHuongDan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butPhieuMuon);
            this.Controls.Add(this.butNXB);
            this.Controls.Add(this.butSach);
            this.Controls.Add(this.butBanDoc);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "frm_Start";
            this.Text = "Quản Lý Thư Viện";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butBanDoc;
        private System.Windows.Forms.Button butSach;
        private System.Windows.Forms.Button butNXB;
        private System.Windows.Forms.Button butPhieuMuon;
        private System.Windows.Forms.Button butLogIn;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butHuongDan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butLogOut;
    }
}

