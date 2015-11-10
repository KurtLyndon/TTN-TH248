using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace TNT_B6_QuanLiSieuThi
{
   public  class KetNoi
    {
        public SqlConnection conn = new SqlConnection();
        public string connstr = @"Data Source=KHUONGHOANG-PC\KHUONGHOANG;Initial Catalog=QUAN_LY_SIEU_THI;Integrated Security=True";
        //    public string sqlcm = @"select * from TheTv";

        public void MoKetNoi()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.ConnectionString = connstr;
                conn.Open();
            }
        }

        public void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                //conn.ConnectionString = connstr;
                conn.Close();
            }
        }

        public void KhoiTao(DataGridView dtgv, string sqlcm)
        {
            MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(sqlcm, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dtgv.DataSource = dv;
            DongKetNoi();
        }
    }
}
