namespace QuanLyNhanSu
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Mục Đích");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("GIỚI THIỆU CHUNG", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Form Chính");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Form Đề Án");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Form Đơn Vị");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Form Hướng Dẫn");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Form Nhân Viên");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Form Phân Công");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Form Thân Nhân");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("GIAO DIỆN CÁC FORM", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHuongDan));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node13";
            treeNode1.Text = "Nhóm Thực Hiện";
            treeNode2.Name = "Node14";
            treeNode2.Text = "Mục Đích";
            treeNode3.Name = "Node0";
            treeNode3.Text = "GIỚI THIỆU CHUNG";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Form Chính";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Form Đề Án";
            treeNode6.Name = "Node8";
            treeNode6.Text = "Form Đơn Vị";
            treeNode7.Name = "Node9";
            treeNode7.Text = "Form Hướng Dẫn";
            treeNode8.Name = "Node10";
            treeNode8.Text = "Form Nhân Viên";
            treeNode9.Name = "Node11";
            treeNode9.Text = "Form Phân Công";
            treeNode10.Name = "Node12";
            treeNode10.Text = "Form Thân Nhân";
            treeNode11.Name = "Node3";
            treeNode11.Text = "GIAO DIỆN CÁC FORM";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(192, 462);
            this.treeView1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(212, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(610, 462);
            this.webBrowser1.TabIndex = 1;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 487);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHuongDan";
            this.Text = "Hướng dẫn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}