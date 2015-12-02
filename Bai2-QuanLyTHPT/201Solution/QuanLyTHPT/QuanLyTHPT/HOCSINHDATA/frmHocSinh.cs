using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTHPT.HOCSINHDATA
{
    public partial class frmHocSinh : Form
    {
        List<string> HS;
        HOCSINHDATA hocsinh = new HOCSINHDATA();
        DataTable dt = new DataTable();
        public frmHocSinh()
        {
            InitializeComponent();

        }
        private void ADD_LIST()
        {
            HS.Clear();
            HS.Add(tbx_ID.Text.Trim());
            HS.Add(tbx_NAME.Text.Trim());
            HS.Add(tbx_CLASSID.Text.Trim());
            HS.Add(tbx_DATE.Text.Trim());
            HS.Add(tbx_SEX.Text.Trim());
            HS.Add(tbx_HOME.Text.Trim());
        }
        private void LOADHS()
        {
            dt = hocsinh.SHOWDATA();
            DGVHS.DataSource = dt;
            DGVHS.AutoResizeColumns();
        }

        private void HOCSINH_Load(object sender, EventArgs e)
        {
            HS = new List<string>();

            LOADHS();

            for (int i = 1; i < DGVHS.ColumnCount; i++)
            {
                DGVHS.Columns[i].ReadOnly = true;
            }
        }
        private void xoa()
        {
            int dem = 0;
            for (int i = 0; i < DGVHS.Rows.Count; i++)
            {
                if (Convert.ToBoolean(DGVHS.Rows[i].Cells[0].Value) == true)
                {
                    string ID = DGVHS.Rows[i].Cells[1].Value.ToString();
                    DGVHS.Rows.RemoveAt(i);


                    hocsinh.DeleteHS(ID);
                    HS.Clear();
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
        private void sua()
        {
            ADD_LIST();
            hocsinh.UpdateHS(HS);
            if (CHECK_ERROR() == 0)
            {
                for (int i = 1; i < DGVHS.ColumnCount; i++)
                {
                    DGVHS.SelectedRows[0].Cells[i].Value = HS[i - 1];
                }
            }
            HS.Clear();
        }
        private void btn_ADD_Click(object sender, EventArgs e)
        {


            //  DGVClass.BeginEdit(true);
            ADD_LIST();

            //     LOADCLASS();
            DataRow row = dt.NewRow();
            row[0] = HS[0];
            row[1] = HS[1];
            row[2] = HS[2];
            row[3] = HS[3];
            row[4] = HS[4];
            row[5] = HS[5];

            //  cell.Value = CLASS[0];
            //row.Cells.Add(cell);

            //       DGVClass.EndEdit();
            hocsinh.InsertHS(HS);
            if (CHECK_ERROR() == 0)
                dt.Rows.Add(row);

        }
        private int CHECK_ERROR()
        {
            if (hocsinh.CHECK == 1) { MessageBox.Show("MÃ HOC SINH ĐÃ TỒN TẠI", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); return 1; }

            return 0;
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void btn_FIX_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void btn_BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Start frm = new frm_Start();
            frm.ShowDialog();
            this.Close();
        }

       
        private void chon()
        {
            tbx_ID.Text = DGVHS.SelectedRows[0].Cells[1].Value.ToString();
            tbx_NAME.Text= DGVHS.SelectedRows[0].Cells[2].Value.ToString();
            tbx_CLASSID.Text= DGVHS.SelectedRows[0].Cells[3].Value.ToString();
            tbx_DATE.Text= DGVHS.SelectedRows[0].Cells[4].Value.ToString();
            tbx_SEX.Text= DGVHS.SelectedRows[0].Cells[5].Value.ToString();
            tbx_HOME.Text= DGVHS.SelectedRows[0].Cells[6].Value.ToString();

        
        }

        private void DGVHS_DoubleClick(object sender, EventArgs e)
        {
            chon();
        }

    }
}
        

