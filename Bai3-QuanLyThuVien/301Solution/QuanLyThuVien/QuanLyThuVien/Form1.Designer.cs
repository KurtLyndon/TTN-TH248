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
            this.SuspendLayout();
            // 
            // butBanDoc
            // 
            this.butBanDoc.Enabled = false;
            this.butBanDoc.Location = new System.Drawing.Point(310, 122);
            this.butBanDoc.Name = "butBanDoc";
            this.butBanDoc.Size = new System.Drawing.Size(75, 23);
            this.butBanDoc.TabIndex = 0;
            this.butBanDoc.Text = "BanDoc";
            this.butBanDoc.UseVisualStyleBackColor = true;
            this.butBanDoc.Click += new System.EventHandler(this.butBanDoc_Click);
            // 
            // butSach
            // 
            this.butSach.Enabled = false;
            this.butSach.Location = new System.Drawing.Point(310, 163);
            this.butSach.Name = "butSach";
            this.butSach.Size = new System.Drawing.Size(75, 23);
            this.butSach.TabIndex = 0;
            this.butSach.Text = "Sach";
            this.butSach.UseVisualStyleBackColor = true;
            this.butSach.Click += new System.EventHandler(this.butSach_Click);
            // 
            // butNXB
            // 
            this.butNXB.Enabled = false;
            this.butNXB.Location = new System.Drawing.Point(310, 204);
            this.butNXB.Name = "butNXB";
            this.butNXB.Size = new System.Drawing.Size(75, 23);
            this.butNXB.TabIndex = 0;
            this.butNXB.Text = "NXB TL";
            this.butNXB.UseVisualStyleBackColor = true;
            this.butNXB.Click += new System.EventHandler(this.butNXB_Click);
            // 
            // butPhieuMuon
            // 
            this.butPhieuMuon.Enabled = false;
            this.butPhieuMuon.Location = new System.Drawing.Point(310, 250);
            this.butPhieuMuon.Name = "butPhieuMuon";
            this.butPhieuMuon.Size = new System.Drawing.Size(75, 23);
            this.butPhieuMuon.TabIndex = 0;
            this.butPhieuMuon.Text = "PhieuMuon";
            this.butPhieuMuon.UseVisualStyleBackColor = true;
            this.butPhieuMuon.Click += new System.EventHandler(this.butPhieuMuon_Click);
            // 
            // butLogIn
            // 
            this.butLogIn.Location = new System.Drawing.Point(526, 204);
            this.butLogIn.Name = "butLogIn";
            this.butLogIn.Size = new System.Drawing.Size(75, 23);
            this.butLogIn.TabIndex = 0;
            this.butLogIn.Text = "Log In";
            this.butLogIn.UseVisualStyleBackColor = true;
            this.butLogIn.Click += new System.EventHandler(this.butLogIn_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(556, 136);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 1;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(556, 160);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(100, 20);
            this.textPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pass";
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources.QLTV;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.butLogIn);
            this.Controls.Add(this.butPhieuMuon);
            this.Controls.Add(this.butNXB);
            this.Controls.Add(this.butSach);
            this.Controls.Add(this.butBanDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Start";
            this.Text = "Quản Lý Thư Viện";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

