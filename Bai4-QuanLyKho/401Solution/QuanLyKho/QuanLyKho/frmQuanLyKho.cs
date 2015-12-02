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
    public partial class frmQuanLyKho : Form
    {
        public frmQuanLyKho()
        {
            InitializeComponent();
        }
        NHASANXUATDATA NSX;
        HANGHOADATA HH;
        PHIEUNHAPDATA PHIEU;
        DataTable db_NSX;
        DataTable db_HH;
        DataTable db_PHIEU;
        List<string> list_HH;
        List<string> list_NSX;
        List<string> list_PHIEU;
        private void QUANLYKHO_Load(object sender, EventArgs e)
        {
             list_HH = new List<string>();
             list_NSX = new List<string>();
             list_PHIEU = new List<string>();
            NSX = new NHASANXUATDATA();
            db_NSX = new DataTable();
            db_NSX = NSX.SHOWDATA();
            dgv_NSX.DataSource = db_NSX;
            HH = new HANGHOADATA();
            db_HH = new DataTable();
            db_HH = HH.SHOWDATA();
            dgv_HH.DataSource = db_HH;
            PHIEU = new PHIEUNHAPDATA();
            db_PHIEU = new DataTable();
            db_PHIEU = PHIEU.SHOWDATA();
            dgv_PHIEU.DataSource = db_PHIEU;
            
        }
        void ADD_LISTHH()
        {
            list_HH.Clear();
            list_HH.Add(txt_ID.Text.ToString());
            list_HH.Add(txt_NAME.Text.ToString());
            list_HH.Add(txt_COST.Text.ToString());
            list_HH.Add(txt_NSX.Text.ToString());
            
        }
        void ADD_LISTNSX()
        {
            list_NSX.Clear();
            list_NSX.Add( txt_IDNSX .Text.ToString());
            list_NSX.Add( txt_NAMENSX .Text.ToString());
            list_NSX.Add(txt_SDT.Text.ToString());
            list_NSX.Add(txt_MAIL.Text.ToString());
            list_NSX.Add(txt_DIACHI.Text.ToString());

        }
        void ADD_LISTPHIEU()
        {
            list_PHIEU.Clear();
            list_PHIEU.Add(txt_IDPHIEU.Text.ToString());
            list_PHIEU.Add(txt_DATEPHIEU.Text.ToString());
            list_PHIEU.Add(txt_TYPEPHIEU.Text.ToString());
            

        }
        int CHECK_ERRORNSX()
        {
            if (HH.CHECK == 1) { MessageBox.Show("NHÀ SX ĐÃ TỒN TẠI", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); return 1; }
            return 0;
        }
        int CHECK_ERRORHH()
        {
            if (HH.CHECK == 1) { MessageBox.Show("MÃ HÀNG ĐÃ TỒN TẠI", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); return 1; }
            if (HH.CHECK == 2) { MessageBox.Show("KHÔNG CÓ NSX NÀY", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); return 1; }
               return 0;
        }
        int CHECK_ERRORPHIEU()
        {
            if (HH.CHECK == 1) { MessageBox.Show("MÃ PHIẾU ĐÃ TỒN TẠI", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); return 1; }
            return 0;
        }
        private void INSERT_HH_Click(object sender, EventArgs e)
        {
            //  DGVClass.BeginEdit(true);
            ADD_LISTHH();

            //     LOADCLASS();
            DataRow row = db_HH .NewRow();
            row[0] = list_HH[0];
            row[1] = list_HH[1];
            row[2] = list_HH[2];
            row[3] = list_HH[3];
            

            //  cell.Value = CLASS[0];
            //row.Cells.Add(cell);

            //       DGVClass.EndEdit();
            HH.InsertHH(list_HH);
            if (CHECK_ERRORHH() == 0)
                db_HH.Rows.Add(row);
        }

        private void labelX30_Click(object sender, EventArgs e)
        {

        }

        private void DELETE_HH_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < dgv_HH.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_HH.Rows[i].Cells[0].Value) == true)
                {
                    string ID = dgv_HH.Rows[i].Cells[1].Value.ToString();
                    dgv_HH.Rows.RemoveAt(i);


                    HH.DeleteHH(ID);
                    list_HH.Clear();
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

        private void UPDATE_HH_Click(object sender, EventArgs e)
        {
            ADD_LISTHH();
            HH.UpdateHH(list_HH);
            if (CHECK_ERRORHH() == 0)
            {
                for (int i = 1; i < dgv_HH.ColumnCount; i++)
                {
                    dgv_HH.SelectedRows[0].Cells[i].Value = list_HH[i - 1];
                }
            }
            list_HH.Clear();
        }

        private void BACK_HH_Click(object sender, EventArgs e)
        {
            
        }

        private void INSERT_NSX_Click(object sender, EventArgs e)
        {
            //  DGVClass.BeginEdit(true);
            ADD_LISTNSX();

            //     LOADCLASS();
            DataRow row = db_NSX.NewRow();
            row[0] = list_NSX[0];
            row[1] = list_NSX[1];
            row[2] = list_NSX[2];
            row[3] = list_NSX[3];
            row[4] = list_NSX[4];


            //  cell.Value = CLASS[0];
            //row.Cells.Add(cell);

            //       DGVClass.EndEdit();
            NSX.InsertNSX(list_NSX);
            if (CHECK_ERRORNSX() == 0)
                db_NSX.Rows.Add(row);
        }

        private void DELETE_NSX_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < dgv_NSX.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_NSX.Rows[i].Cells[0].Value) == true)
                {
                    string ID = dgv_NSX.Rows[i].Cells[1].Value.ToString();
                    dgv_NSX.Rows.RemoveAt(i);


                    NSX.DeleteNSX(ID);
                    list_NSX.Clear();
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

        private void UPDATE_NSX_Click(object sender, EventArgs e)
        {
            ADD_LISTNSX();
            HH.UpdateHH(list_NSX);
            if (CHECK_ERRORNSX() == 0)
            {
                for (int i = 1; i < dgv_NSX.ColumnCount; i++)
                {
                    dgv_NSX.SelectedRows[0].Cells[i].Value = list_NSX[i - 1];
                }
            }
            list_NSX.Clear();

        }

        private void INSERT_PHIEU_Click(object sender, EventArgs e)
        {
            //  DGVClass.BeginEdit(true);
            ADD_LISTPHIEU();

            //     LOADCLASS();
            DataRow row = db_PHIEU.NewRow();
            row[0] = list_PHIEU[0];
            row[1] = list_PHIEU[1];
            row[2] = list_PHIEU[2];
            

            //  cell.Value = CLASS[0];
            //row.Cells.Add(cell);

            //       DGVClass.EndEdit();
            PHIEU.InsertPHIEU(list_PHIEU);
            if (CHECK_ERRORPHIEU() == 0)
                db_PHIEU.Rows.Add(row);

        }

        private void DELETE_PHIEU_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < dgv_PHIEU.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_PHIEU.Rows[i].Cells[0].Value) == true)
                {
                    string ID = dgv_PHIEU.Rows[i].Cells[1].Value.ToString();
                    dgv_PHIEU.Rows.RemoveAt(i);


                    PHIEU.DeletePHIEU(ID);
                    list_PHIEU.Clear();
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

        private void UPDATE_PHIEU_Click(object sender, EventArgs e)
        {
            ADD_LISTPHIEU();
            HH.UpdateHH(list_PHIEU);
            if (CHECK_ERRORPHIEU() == 0)
            {
                for (int i = 1; i < dgv_PHIEU.ColumnCount; i++)
                {
                    dgv_PHIEU.SelectedRows[0].Cells[i].Value = list_PHIEU[i - 1];
                }
            }
            list_PHIEU.Clear();


        }

        

      

     
    }
}
