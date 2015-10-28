using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace QuanLyTHPT.GIAOVIENDATA
{
   public class GIAOVIENDATA:APP_DATA.DATA
    {
         public GIAOVIENDATA()
        {
            base.path = "select *from GIAOVIEN ";
        }
        public void GAN_GV(List<String> GV)
        {
            cmd.Parameters.AddWithValue("@ID", GV[0]);
            cmd.Parameters.AddWithValue("@NAME", GV[1]);
            cmd.Parameters.AddWithValue("@SDT", GV[2]);
            cmd.Parameters.AddWithValue("@EMAIL", GV[3]);
            cmd.Parameters.AddWithValue("@SEX", GV[4]);
            cmd.Parameters.AddWithValue("@HOCHAM", GV[5]);
            cmd.Parameters.AddWithValue("@HOCVI", GV[6]);
            DateTime a=Convert.ToDateTime(GV[7]);
            cmd.Parameters.AddWithValue("@DATE",a);
        }

        public void InsertGV(List<string> GV)
        {
            CHECK = 0;
            base.sql = "INSERTGIAOVIEN";
            SP_DATA();
            GAN_GV(GV);
            check();

        }
        public void UpdateGV(List<String> GV)
        {
            CHECK = 0;
            base.sql = "UPDATEGIAOVIEN";
            SP_DATA();
            GAN_GV(GV);
            check();

        }
        public void DeleteGV(string ID)
        {
            base.sql = "DELETEGIAOVIEN";
            SP_DATA();
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

       
        public DataTable TK_THONGTIN_MA(string LISTHS)
        {
            base.sql = "TK_THONGTIN_MA";

            SqlDataAdapter sql1 = new SqlDataAdapter(sql, con);
            sql1.SelectCommand.CommandType = CommandType.StoredProcedure;
            sql1.SelectCommand.Parameters.AddWithValue("@ID", LISTHS);
            sql1.SelectCommand.Parameters.Add("@CHECK", SqlDbType.Int).Direction = ParameterDirection.Output;
            sql1.SelectCommand.ExecuteNonQuery();
            CHECK = Convert.ToInt16(sql1.SelectCommand.Parameters["@CHECK"].Value);
            DataTable dt = new DataTable();
            sql1.Fill(dt);
            sql1.Dispose();
            return dt;


        }
        public DataTable TK_THONGTIN_TEN(string LISTGV)
        {
            base.sql = "TK_THONGTIN_TEN";

            SqlDataAdapter sql1 = new SqlDataAdapter(sql, con);
            sql1.SelectCommand.CommandType = CommandType.StoredProcedure;
            sql1.SelectCommand.Parameters.AddWithValue("@NAME", LISTGV);
            sql1.SelectCommand.Parameters.Add("@CHECK", SqlDbType.Int).Direction = ParameterDirection.Output;
            sql1.SelectCommand.ExecuteNonQuery();
            CHECK = Convert.ToInt16(sql1.SelectCommand.Parameters["@CHECK"].Value);
            DataTable dt = new DataTable();
            sql1.Fill(dt);
            sql1.Dispose();
            return dt;

    }
}
}