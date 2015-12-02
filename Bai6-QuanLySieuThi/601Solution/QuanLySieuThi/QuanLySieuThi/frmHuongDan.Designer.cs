namespace QuanLySieuThi
{
    partial class frmHuongDan
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Hàng Hóa");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Hóa Đơn");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nhân Viên");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Hướng Dẫn", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHuongDan));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
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
            treeNode6.Name = "HD_HH";
            treeNode6.Text = "Hàng Hóa";
            treeNode7.Name = "HD_HD";
            treeNode7.Text = "Hóa Đơn";
            treeNode8.Name = "HD_NV";
            treeNode8.Text = "Nhân Viên";
            treeNode9.Name = "HD";
            treeNode9.Text = "Hướng Dẫn";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(166, 537);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(184, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(848, 537);
            this.webBrowser1.TabIndex = 1;
            // 
            // HUONGDAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1050, 600);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "HUONGDAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng Dẫn";
            this.Load += new System.EventHandler(this.HUONGDAN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}