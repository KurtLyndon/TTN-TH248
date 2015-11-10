using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TNT_B6_QuanLiSieuThi
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        KetNoi con = new KetNoi();
        public string sqlstr = @"select * from NHANVIEN";
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            con.KhoiTao(dataGridView1, sqlstr);
        }
        private bool CheckAdd()
        {
            bool check = false;
            if (txtID_NV.Text == "" || txtTen_NV.Text == "" || txtSDT_NV.Text == "" || txtCMND_NV.Text == "") check = false;
            else check = true;
            int i = 0;
            while (i < dataGridView1.Rows.Count)
            {
                if (txtID_NV.Text == Convert.ToString(dataGridView1.Rows[i].Cells[0].Value))
                {
                    check = false;
                    break;
                }
                else check = true;
                i++;
            }
            char[] ch = new char[txtID_NV.Text.Length];
            ch = txtID_NV.Text.ToCharArray();
            for (int j = 0; j < 4; j++)
            {
                if (ch[j] == 32)
                {
                    check = false;
                    break;
                }
                else check = true;
            }
            return check;
        }
        private bool CheckFix()
        {
            bool check = false;
            if (txtID_NV.Text == "" || txtTen_NV.Text == "" || txtSDT_NV.Text == "" || txtCMND_NV.Text == "") check = false;
            else check = true;
            return check;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (butOK.Visible == false) butDel.Enabled = butFix.Enabled = true;
            txtID_NV.ReadOnly = true;
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtID_NV.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtTen_NV.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtSDT_NV.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtCMND_NV.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            }
            else return;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            butOK.Visible = true;
            txtID_NV.Text = txtTen_NV.Text = txtSDT_NV.Text = txtCMND_NV.Text = string.Empty;
            butAdd.Visible = false;
            txtID_NV.ReadOnly = false;
            butDel.Enabled = butFix.Enabled = false;
            butBack.Visible = true;
            dataGridView1.Enabled = false;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (CheckAdd() == true)
            {
                con.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("AddNV", con.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.Add("@id_nv", txtID_NV.Text);
                sqlcm.Parameters.Add("@ten_nv", txtTen_NV.Text);
                sqlcm.Parameters.Add("@cmnd", txtCMND_NV.Text);
                sqlcm.Parameters.Add("@sdt", txtSDT_NV.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Them du lieu thanh cong");
                    con.KhoiTao(dataGridView1, @"select * from NHANVIEN");
                    txtID_NV.Text = txtTen_NV.Text = txtSDT_NV.Text = txtCMND_NV.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("Co loi. thu lai");
                }
                con.DongKetNoi();
                butOK.Visible = false;
                butAdd.Visible = true;
                butBack.Visible = false;
                dataGridView1.Enabled = true;
            }
        }

        private void butFix_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CheckFix() == true)
                {
                    con.MoKetNoi();
                    SqlCommand sqlcm = new SqlCommand("FixNV", con.conn);
                    sqlcm.CommandType = CommandType.StoredProcedure;
                    sqlcm.Parameters.Add("@id_nv", txtID_NV.Text);
                    sqlcm.Parameters.Add("@ten_nv", txtTen_NV.Text);
                    sqlcm.Parameters.Add("@cmnd", txtCMND_NV.Text);
                    sqlcm.Parameters.Add("@sdt", txtSDT_NV.Text);
                    int check = sqlcm.ExecuteNonQuery();
                    if (check > 0)
                    {
                        MessageBox.Show("Sua du lieu thanh cong");
                        con.KhoiTao(dataGridView1, @"select * from NHANVIEN");
                        txtID_NV.Text = txtTen_NV.Text = txtSDT_NV.Text = txtCMND_NV.Text = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show("Co loi. thu lai");
                    }
                    con.DongKetNoi();
                }
                else MessageBox.Show("Du lieu khong hop le");
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa khong", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                con.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("DelNV", con.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.Add("@id_nv", txtID_NV.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                    con.KhoiTao(dataGridView1, @"Select * from NHANVIEN");
                    txtID_NV.Text = txtTen_NV.Text = txtSDT_NV.Text = txtCMND_NV.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Co loi, khong the xoa du lieu");
                }
                con.DongKetNoi();
            }
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            con.MoKetNoi();
            int a;
            SqlCommand cm = new SqlCommand("FindNV", con.conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@id_nv", txtFind.Text);
            cm.Parameters.Add("@ten_nv", txtFind.Text);
            cm.Parameters.Add("@cmnd", txtFind.Text);
            if (int.TryParse(txtFind.Text, out a) == true)
            {
                cm.Parameters.Add("@sdt", txtFind.Text);
            }
            else cm.Parameters.Add("@sdt", "1234");
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            txtFind.Text = string.Empty;
            con.DongKetNoi();
        }

        private void butLoad_Click(object sender, EventArgs e)
        {
            con.KhoiTao(dataGridView1, sqlstr);
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            butBack.Visible = butOK.Visible = false;
            butAdd.Visible = true;
            dataGridView1.Enabled = true;
        }
    }
}
