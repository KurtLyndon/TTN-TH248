using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class frm_Start : Form
    {
        public frm_Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYSIEUTHI frmQLST = new QUANLYSIEUTHI();
            frmQLST.ShowDialog();
            this.Close();
           this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HUONGDAN frmQLST = new HUONGDAN();
            frmQLST.ShowDialog();
        }
    }
}
