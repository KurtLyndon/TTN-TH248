namespace QuanLyKhachSan
{
    partial class FormDoDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoDung));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.radView = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.butFree = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(455, 361);
            this.panel5.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(213, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 361);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Information";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textSearch);
            this.panel4.Controls.Add(this.butSearch);
            this.panel4.Controls.Add(this.butDel);
            this.panel4.Controls.Add(this.radAdd);
            this.panel4.Controls.Add(this.radEdit);
            this.panel4.Controls.Add(this.radView);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.butFree);
            this.panel4.Location = new System.Drawing.Point(43, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 163);
            this.panel4.TabIndex = 12;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(20, 108);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(131, 20);
            this.textSearch.TabIndex = 7;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(20, 134);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(131, 23);
            this.butSearch.TabIndex = 6;
            this.butSearch.Text = "Search Mode";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(84, 72);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(67, 30);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Delete";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radAdd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdd.Location = new System.Drawing.Point(20, 57);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(46, 20);
            this.radAdd.TabIndex = 4;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = false;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radEdit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEdit.Location = new System.Drawing.Point(20, 80);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(47, 20);
            this.radEdit.TabIndex = 4;
            this.radEdit.Text = "Edit";
            this.radEdit.UseVisualStyleBackColor = false;
            this.radEdit.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // radView
            // 
            this.radView.AutoSize = true;
            this.radView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radView.Checked = true;
            this.radView.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radView.Location = new System.Drawing.Point(20, 34);
            this.radView.Name = "radView";
            this.radView.Size = new System.Drawing.Size(50, 20);
            this.radView.TabIndex = 2;
            this.radView.TabStop = true;
            this.radView.Text = "View";
            this.radView.UseVisualStyleBackColor = false;
            this.radView.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mode";
            // 
            // butFree
            // 
            this.butFree.Enabled = false;
            this.butFree.Location = new System.Drawing.Point(84, 36);
            this.butFree.Name = "butFree";
            this.butFree.Size = new System.Drawing.Size(67, 30);
            this.butFree.TabIndex = 0;
            this.butFree.Text = "View";
            this.butFree.UseVisualStyleBackColor = true;
            this.butFree.Click += new System.EventHandler(this.butFree_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Price";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(102, 139);
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(110, 20);
            this.textPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(102, 97);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(110, 20);
            this.textName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(102, 55);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(110, 20);
            this.textID.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 361);
            this.panel3.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(455, 361);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 145;
            // 
            // FormDoDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 361);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(471, 399);
            this.MinimumSize = new System.Drawing.Size(471, 399);
            this.Name = "FormDoDung";
            this.Text = "Trang Thiết Bị";
            this.Load += new System.EventHandler(this.FormDoDung_Load);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.RadioButton radView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butFree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}