using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHOTTN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butLogIn_Click(object sender, EventArgs e)
        {

        }

        private void butLogOut_Click(object sender, EventArgs e)
        {

        }

        private void butHuongDan_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butQuanLyKho_Click(object sender, EventArgs e)
        {
            frmQuanLyKho frm = new frmQuanLyKho();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
    }
}
