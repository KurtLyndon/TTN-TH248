namespace QuanLyKhachSan
{
    partial class FormHuongDan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nhóm Thực Hiện");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sản Phẩm");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Giới Thiệu Chung", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quản Lý Chung");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Khách Hàng");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Phòng");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Trang Thiết Bị");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Dịch Vụ");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Quản Lý Dịch Vụ");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Quản Lý Phòng");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Quản Lý TTB");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Hướng Dẫn Sử Dụng", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHuongDan));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "GT_NTH";
            treeNode1.Text = "Nhóm Thực Hiện";
            treeNode2.Name = "GT_SP";
            treeNode2.Text = "Sản Phẩm";
            treeNode3.Name = "GT";
            treeNode3.Text = "Giới Thiệu Chung";
            treeNode4.Name = "HD_QLC";
            treeNode4.Text = "Quản Lý Chung";
            treeNode5.Name = "HD_KH";
            treeNode5.Text = "Khách Hàng";
            treeNode6.Name = "HD_Phong";
            treeNode6.Text = "Phòng";
            treeNode7.Name = "HD_TTB";
            treeNode7.Text = "Trang Thiết Bị";
            treeNode8.Name = "HD_DV";
            treeNode8.Text = "Dịch Vụ";
            treeNode9.Name = "HD_QLDV";
            treeNode9.Text = "Quản Lý Dịch Vụ";
            treeNode10.Name = "HD_QLP";
            treeNode10.Text = "Quản Lý Phòng";
            treeNode11.Name = "HD_QLTTB";
            treeNode11.Text = "Quản Lý TTB";
            treeNode12.Name = "HD";
            treeNode12.Text = "Hướng Dẫn Sử Dụng";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(176, 586);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(196, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 586);
            this.webBrowser1.TabIndex = 1;
            // 
            // FormHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FormHuongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng Dẫn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}