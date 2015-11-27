namespace QuanLySieuThi
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.butLogOut = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butLogIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textID);
            this.panel1.Controls.Add(this.butLogOut);
            this.panel1.Controls.Add(this.textPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.butLogIn);
            this.panel1.Location = new System.Drawing.Point(496, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 113);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(91, 19);
            this.textID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(154, 20);
            this.textID.TabIndex = 8;
            // 
            // butLogOut
            // 
            this.butLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butLogOut.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogOut.Location = new System.Drawing.Point(169, 69);
            this.butLogOut.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(74, 33);
            this.butLogOut.TabIndex = 5;
            this.butLogOut.Text = "Log Out";
            this.butLogOut.UseVisualStyleBackColor = false;
            this.butLogOut.Visible = false;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(91, 43);
            this.textPass.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(154, 20);
            this.textPass.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // butLogIn
            // 
            this.butLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butLogIn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogIn.Location = new System.Drawing.Point(89, 69);
            this.butLogIn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butLogIn.Name = "butLogIn";
            this.butLogIn.Size = new System.Drawing.Size(74, 33);
            this.butLogIn.TabIndex = 4;
            this.butLogIn.Text = "Log In";
            this.butLogIn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLySieuThi.Properties.Resources.shopping_cart;
            this.button1.Location = new System.Drawing.Point(496, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 130);
            this.button1.TabIndex = 12;
            this.button1.Text = "Quản Lý Siêu Thị";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::QuanLySieuThi.Properties.Resources.guide;
            this.button2.Location = new System.Drawing.Point(632, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 130);
            this.button2.TabIndex = 13;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySieuThi.Properties.Resources.QLST;
            this.ClientSize = new System.Drawing.Size(784, 466);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Start";
            this.Text = "Quản Lý Siêu Thị";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button butLogOut;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butLogIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

