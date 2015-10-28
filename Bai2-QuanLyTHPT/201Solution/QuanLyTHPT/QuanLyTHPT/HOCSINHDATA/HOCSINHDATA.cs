using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.ProviderBase;
namespace QuanLyTHPT.HOCSINHDATA
{
    public class HOCSINHDATA:APP_DATA.DATA
    {

        public HOCSINHDATA()
        {
            base.path = "select *from HOCSINH ";
        }
        public void GAN_HS(List<String> HS)
        {
            cmd.Parameters.AddWithValue("@ID", HS[0]);
            cmd.Parameters.AddWithValue("@NAME", HS[1]);
            cmd.Parameters.AddWithValue("@CLASSID", HS[5]);
            DateTime a = Convert.ToDateTime(HS[3]);
            cmd.Parameters.AddWithValue("@DATE", a);
            cmd.Parameters.AddWithValue("@SEX", HS[3]);
            cmd.Parameters.AddWithValue("@DIACHI", HS[4]);
            
        }

        public void InsertHS(List<string> HS)
        {
            CHECK = 0;
            base.sql = "INSERTHOCSINH";
            SP_DATA();
            GAN_HS(HS);
            check();

        }
        public void UpdateHS(List<String> HS)
        {
            CHECK = 0;
            base.sql = "UPDATEHOCSINH";
            SP_DATA();
            GAN_HS(HS);
            check();

        }
        public void DeleteHS(string ID)
        {
            base.sql = "DELETEHOCSINH";
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
        public DataTable TK_THONGTIN_TEN(string LISTHS)
        {
            base.sql = "TK_THONGTIN_TEN";

            SqlDataAdapter sql1 = new SqlDataAdapter(sql, con);
            sql1.SelectCommand.CommandType = CommandType.StoredProcedure;
            sql1.SelectCommand.Parameters.AddWithValue("@NAME", LISTHS);
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
