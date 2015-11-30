using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTHPT
{
    public partial class frm_Start : Form
    {
        public frm_Start()
        {
            InitializeComponent();
        }

        private void frm_Start_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOPDATA.frmLop frm = new LOPDATA.frmLop();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOCSINHDATA.frmHocSinh frm = new HOCSINHDATA.frmHocSinh();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GIAOVIENDATA.frmGiaoVien frm = new GIAOVIENDATA.frmGiaoVien();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HUONGDAN.frmHuongDan frm = new HUONGDAN.frmHuongDan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

       
    }
}
