using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNT_B6_QuanLiSieuThi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            this.Hide();
            nv.ShowDialog();
            this.ShowDialog();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa hh = new frmHangHoa();
            this.Hide();
            hh.ShowDialog();
            this.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }
    }
}
