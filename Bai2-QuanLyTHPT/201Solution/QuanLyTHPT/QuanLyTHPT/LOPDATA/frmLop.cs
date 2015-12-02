using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTHPT.LOPDATA
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
          InitializeComponent();
        }
        DataTable dt = new DataTable();
        LOPDATA lop = new LOPDATA();
        List<string> CLASS;
      //  DataRow row = DGVClass.NewRowIndex();
        private void them()
        {
          //  DGVClass.BeginEdit(true);
           ADD_LIST();

      //     LOADCLASS();
           DataRow row = dt.NewRow();
           row[0] = CLASS[0];
           row[1] = CLASS[1];
           row[2] = CLASS[2];
           row[3] = CLASS[3];
           
             //  cell.Value = CLASS[0];
               //row.Cells.Add(cell);
         
        //       DGVClass.EndEdit();
           lop.InsertClass(CLASS);
           if(CHECK_ERROR()==0)
           dt.Rows.Add(row);
         
         }
        private void chon()
        {

            tbx_CLASSID.Text = DGVClass.SelectedRows[0].Cells[1].Value.ToString();
            tbx_NAME.Text = DGVClass.SelectedRows[0].Cells[2].Value.ToString();
            tbx_GV.Text = DGVClass.SelectedRows[0].Cells[3].Value.ToString();
            tbx_DVHT.Text = DGVClass.SelectedRows[0].Cells[4].Value.ToString();

        }
        private void sua()
        {
            ADD_LIST();
            lop.UpdateClass(CLASS);
            if (CHECK_ERROR() == 0)
            {
                for (int i = 1; i < DGVClass.ColumnCount; i++)
                {
                    DGVClass.SelectedRows[0].Cells[i].Value = CLASS[i - 1];
                }
            }
            CLASS.Clear();
        }
        private void ADD_LIST()
        {
            CLASS.Clear();

            CLASS.Add(tbx_CLASSID.Text.Trim());
            CLASS.Add(tbx_NAME.Text.Trim());
            CLASS.Add(tbx_GV.Text.Trim());
            CLASS.Add(tbx_DVHT.Text.Trim());
            
            //  sinhvien.InsertSV(SV);

        }
        private int CHECK_ERROR()
        {
            if (lop.CHECK == 1) { MessageBox.Show("MÃ LỚP NÀY ĐÃ CÓ,NHẬP LẠI MÃ LỚP", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); return 1; }
            if (lop.CHECK == 2) { MessageBox.Show("KHÔNG CÓ GIÁO VIÊN NÀY", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); return 2; }
            if (lop.CHECK == 3) { MessageBox.Show("GIÁO VIÊN NÀY ĐÃ CHỦ NHIỆM LỚP KHÁC", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); return 3; }
            return 0;
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            them();
        }

        private void LOP_Load(object sender, EventArgs e)
        {
            LOADCLASS();
            //DGVClass.BeginEdit(true);
            CLASS = new List<string>();
            for (int i = 1; i < DGVClass.ColumnCount; i++)
            {
                DGVClass.Columns[i].ReadOnly = true;
            }
        }
        private void LOADCLASS()
        {
           
            dt = lop.SHOWDATA();
            DGVClass.DataSource = dt;
            DGVClass.AutoResizeColumns();
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
            for (int i = 0; i < DGVClass.Rows.Count; i++)
            {
                if (Convert.ToBoolean(DGVClass.Rows[i].Cells[0].Value) == true)
                {
                    string ID = DGVClass.Rows[i].Cells[1].Value.ToString();
                    DGVClass.Rows.RemoveAt(i);


                    lop.DeleteClass(ID);
                    CLASS.Clear();
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

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void DGVClass_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chon();
        }

        private void btn_FIX_Click(object sender, EventArgs e)
        {
            sua();
        }
    }
}
