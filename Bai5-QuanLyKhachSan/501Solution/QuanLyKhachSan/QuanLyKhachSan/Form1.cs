using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_Start : Form
    {
        public frm_Start()
        {
            InitializeComponent();
        }

        private void butKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang frm = new FormKhachHang();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private Connection connector = new Connection();
        private DataTable table;
        private void butLogIn_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            table = connector.LoadData("8");
            int p = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (textID.Text.Trim() == table.Rows[i][0].ToString().Trim() && textPass.Text.Trim() == table.Rows[i][1].ToString().Trim())
                {
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Wrong password or ID", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Welcome to QuanLyThuVien project", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                butKhachHang.Visible = butDichVu.Visible = butDoDung.Visible = butPhong.Visible = butQLDichVu.Visible = butQLDoDung.Visible = butQLPhong.Visible = butLogOut.Visible = true;
                butLogIn.Visible = textID.Visible = textPass.Visible = label1.Visible = label2.Visible = false;
                panel2.Visible = panel3.Visible = true;
            }
            
        }

        private void butPhong_Click(object sender, EventArgs e)
        {
            FormPhong frm = new FormPhong();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butDoDung_Click(object sender, EventArgs e)
        {
            FormDoDung frm = new FormDoDung();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butDichVu_Click(object sender, EventArgs e)
        {
            FormDichVu frm = new FormDichVu();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butQLDichVu_Click(object sender, EventArgs e)
        {
            FormQLDichVu frm = new FormQLDichVu();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butQLDoDung_Click(object sender, EventArgs e)
        {
            FormQLDoDung frm = new FormQLDoDung();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butQLPhong_Click(object sender, EventArgs e)
        {
            FormQLPhong frm = new FormQLPhong();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using QuanLyThuVien project", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            butKhachHang.Visible = butDichVu.Visible = butDoDung.Visible = butPhong.Visible = butQLDichVu.Visible = butQLDoDung.Visible = butQLPhong.Visible = butLogOut.Visible = false;
            butLogIn.Visible = textID.Visible = textPass.Visible = label1.Visible = label2.Visible = true;
            panel2.Visible = panel3.Visible = false;
            textID.Text = textPass.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHuongDan frm = new FormHuongDan();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
    }
}
