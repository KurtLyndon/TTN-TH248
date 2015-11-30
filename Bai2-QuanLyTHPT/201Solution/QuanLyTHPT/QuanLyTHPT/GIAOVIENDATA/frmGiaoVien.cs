using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTHPT.GIAOVIENDATA
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        GIAOVIENDATA teacher = new GIAOVIENDATA();
        List<string> TEACHER = new List<string>();
        DataTable dt =new DataTable();
        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
        private void LOADGV()
        {
            dt = teacher.SHOWDATA();
            DGVGV.DataSource = dt;
            DGVGV.AutoResizeColumns();
        }

        private void GIAOVIEN_Load(object sender, EventArgs e)
        {
            LOADGV();
                    }

        private void panelEx2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            them();
        }
        private void them()
        {
            //  DGVClass.BeginEdit(true);
            ADD_LIST();

            //     LOADCLASS();
            DataRow row = dt.NewRow();
            row[0] = TEACHER[0];
            row[1] = TEACHER[1];
            row[2] = TEACHER[2];
            row[3] = TEACHER[3];
            row[4] = TEACHER[4];
            row[5] = TEACHER[5];
            row[6] = TEACHER[6];
            row[7] = TEACHER[7];
            //  cell.Value = CLASS[0];
            //row.Cells.Add(cell);

            //       DGVClass.EndEdit();
            teacher.InsertGV (TEACHER);
            if (CHECK_ERROR() == 0)
                dt.Rows.Add(row);

        }
        private void chon()
        {

            tbx_SDT.Text = DGVGV.SelectedRows[0].Cells[3].Value.ToString();
            tbx_NAME.Text = DGVGV.SelectedRows[0].Cells[2].Value.ToString();
            tbx_DATE.Text = DGVGV.SelectedRows[0].Cells[8].Value.ToString();
            tbx_ID.Text = DGVGV.SelectedRows[0].Cells[1].Value.ToString();
            tbx_EMAIL.Text = DGVGV.SelectedRows[0].Cells[4].Value.ToString();
            tbx_SEX.Text = DGVGV.SelectedRows[0].Cells[5].Value.ToString();
            tbx_HH.Text = DGVGV.SelectedRows[0].Cells[6].Value.ToString();
            tbx_HV.Text = DGVGV.SelectedRows[0].Cells[7].Value.ToString();

        }
        private void sua()
        {
            ADD_LIST();
            teacher.UpdateGV(TEACHER);
            if (CHECK_ERROR() == 0)
            {
                for (int i = 1; i < DGVGV.ColumnCount; i++)
                {
                    DGVGV.SelectedRows[0].Cells[i].Value = TEACHER[i - 1];
                }
            }
            TEACHER.Clear();
        }
        private void ADD_LIST()
        {
            TEACHER.Clear();

            TEACHER.Add(tbx_ID .Text.Trim());
            TEACHER.Add(tbx_NAME.Text.Trim());
            TEACHER.Add(tbx_SDT.Text.Trim());
            TEACHER.Add(tbx_EMAIL.Text.Trim());
            TEACHER.Add(tbx_SEX.Text.Trim());
            TEACHER.Add(tbx_HH.Text.Trim());
            TEACHER.Add(tbx_HV.Text.Trim());
            TEACHER.Add(tbx_DATE.Text.Trim());

            //  sinhvien.InsertSV(SV);

        }
        private int CHECK_ERROR()
        {
            if (teacher.CHECK == 1) { MessageBox.Show("MÃ GIÁO VIÊN ĐÃ TỒN TẠI", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); return 1; }
            
            return 0;
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void btn_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Start frm = new frm_Start();
            frm.ShowDialog();
            this.Close();
        }
        private void xoa()
        {
            int dem = 0;
            for (int i = 0; i < DGVGV.Rows.Count; i++)
            {
                if (Convert.ToBoolean(DGVGV.Rows[i].Cells[0].Value) == true)
                {
                    string ID = DGVGV.Rows[i].Cells[1].Value.ToString();
                    DGVGV.Rows.RemoveAt(i);


                    teacher.DeleteGV(ID);
                    TEACHER.Clear();
                    dem++;
                    i--;
                }
            }
            if (dem == 0)
            {
                MessageBox.Show("CHỌN DÒNG CẦN XÓA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DGVGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chon();
        }

        private void btn_FIX_Click(object sender, EventArgs e)
        {
            sua();
        }


    }
}
