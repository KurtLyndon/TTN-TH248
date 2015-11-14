namespace TNT_B6_QuanLiSieuThi
{
    partial class frmKhachHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butLoad = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.butFind = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butFix = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT_KH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCMND_KH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen_KH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID_KH = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(466, 107);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.butLoad);
            this.panel2.Controls.Add(this.butBack);
            this.panel2.Controls.Add(this.txtFind);
            this.panel2.Controls.Add(this.butFind);
            this.panel2.Controls.Add(this.butOK);
            this.panel2.Controls.Add(this.butDel);
            this.panel2.Controls.Add(this.butFix);
            this.panel2.Controls.Add(this.butAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 72);
            this.panel2.TabIndex = 12;
            // 
            // butLoad
            // 
            this.butLoad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLoad.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLoad.ForeColor = System.Drawing.Color.Black;
            this.butLoad.Location = new System.Drawing.Point(12, 37);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(100, 25);
            this.butLoad.TabIndex = 7;
            this.butLoad.Text = "Danh Sách";
            this.butLoad.UseVisualStyleBackColor = false;
            this.butLoad.Click += new System.EventHandler(this.butLoad_Click);
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBack.ForeColor = System.Drawing.Color.Black;
            this.butBack.Location = new System.Drawing.Point(147, 6);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(100, 25);
            this.butBack.TabIndex = 6;
            this.butBack.Text = "Quay Lại";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Visible = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(359, 9);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 5;
            // 
            // butFind
            // 
            this.butFind.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFind.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFind.ForeColor = System.Drawing.Color.Black;
            this.butFind.Location = new System.Drawing.Point(253, 7);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(100, 25);
            this.butFind.TabIndex = 4;
            this.butFind.Text = "Tìm Kiếm";
            this.butFind.UseVisualStyleBackColor = false;
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // butOK
            // 
            this.butOK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOK.ForeColor = System.Drawing.Color.Black;
            this.butOK.Location = new System.Drawing.Point(30, 6);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(100, 25);
            this.butOK.TabIndex = 3;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = false;
            this.butOK.Visible = false;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butDel
            // 
            this.butDel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butDel.Enabled = false;
            this.butDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.ForeColor = System.Drawing.Color.Black;
            this.butDel.Location = new System.Drawing.Point(136, 39);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(100, 25);
            this.butDel.TabIndex = 2;
            this.butDel.Text = "Xóa";
            this.butDel.UseVisualStyleBackColor = false;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butFix
            // 
            this.butFix.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butFix.Enabled = false;
            this.butFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFix.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFix.ForeColor = System.Drawing.Color.Black;
            this.butFix.Location = new System.Drawing.Point(136, 6);
            this.butFix.Name = "butFix";
            this.butFix.Size = new System.Drawing.Size(100, 25);
            this.butFix.TabIndex = 1;
            this.butFix.Text = "Sửa";
            this.butFix.UseVisualStyleBackColor = false;
            this.butFix.Click += new System.EventHandler(this.butFix_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.Black;
            this.butAdd.Location = new System.Drawing.Point(12, 6);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(100, 25);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "Thêm";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSDT_KH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCMND_KH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTen_KH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtID_KH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 83);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMND";
            // 
            // txtSDT_KH
            // 
            this.txtSDT_KH.Location = new System.Drawing.Point(333, 45);
            this.txtSDT_KH.Name = "txtSDT_KH";
            this.txtSDT_KH.Size = new System.Drawing.Size(100, 20);
            this.txtSDT_KH.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Khách Hàng";
            // 
            // txtCMND_KH
            // 
            this.txtCMND_KH.Location = new System.Drawing.Point(333, 15);
            this.txtCMND_KH.Name = "txtCMND_KH";
            this.txtCMND_KH.Size = new System.Drawing.Size(100, 20);
            this.txtCMND_KH.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // txtTen_KH
            // 
            this.txtTen_KH.Location = new System.Drawing.Point(110, 45);
            this.txtTen_KH.Name = "txtTen_KH";
            this.txtTen_KH.Size = new System.Drawing.Size(100, 20);
            this.txtTen_KH.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT";
            // 
            // txtID_KH
            // 
            this.txtID_KH.Location = new System.Drawing.Point(110, 11);
            this.txtID_KH.Name = "txtID_KH";
            this.txtID_KH.Size = new System.Drawing.Size(100, 20);
            this.txtID_KH.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_KhachHang";
            this.Column1.HeaderText = "ID_Khách Hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKhachHang";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "SĐT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CMND";
            this.Column4.HeaderText = "CMND";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butFix;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT_KH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCMND_KH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen_KH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}