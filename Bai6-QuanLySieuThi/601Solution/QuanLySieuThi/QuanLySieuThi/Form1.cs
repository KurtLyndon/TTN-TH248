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
            frmQuanLySieuThi frm = new frmQuanLySieuThi();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
    }
}
