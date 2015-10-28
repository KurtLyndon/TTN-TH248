using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frm_Start : Form
    {
        public frm_Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmThanNhan frm = new frmThanNhan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDeAn frm = new frmDeAn();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDonVi frm = new frmDonVi();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void frm_Start_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPhanCong frm = new frmPhanCong();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
    }
}
