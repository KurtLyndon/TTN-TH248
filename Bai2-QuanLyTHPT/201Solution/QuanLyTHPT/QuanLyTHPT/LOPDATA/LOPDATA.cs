using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTHPT.LOPDATA
{
    class LOPDATA:APP_DATA.DATA
    {
       public LOPDATA() { base.path = "select *from LOP"; }
       public void GAN_LOP(List<String> CLASS)
       {
     
           cmd.Parameters.AddWithValue("@CLASSNAME", CLASS[1]);
           cmd.Parameters.AddWithValue("@CLASSID", CLASS[0]);
           cmd.Parameters.AddWithValue("@IDGV", CLASS[2]);
           cmd.Parameters.AddWithValue("@DVHT", CLASS[3]);
        
          
       }

       public void InsertClass(List<String> CLASS)
       {
           base.sql = "INSERTLOP";
           SP_DATA();
           GAN_LOP(CLASS);
           check();

       }
       public void UpdateClass(List<String> CLASS)
       {
           base.sql = "UPDATELOP";
           SP_DATA();
           GAN_LOP(CLASS);
           check();

       }
       public void DeleteClass(string CLASS)
       {
           base.sql = "DELETELOP";
           SP_DATA();
           cmd.Parameters.AddWithValue("@CLASSID", CLASS);
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       public DataTable LISTSV_CLASS(string LISTSV)
       {
           base.sql = "LISTSV_CLASS";
           
           SqlDataAdapter sql1 = new SqlDataAdapter(sql, con);
           sql1.SelectCommand.CommandType=CommandType.StoredProcedure;
           sql1.SelectCommand.Parameters.AddWithValue("@MA", LISTSV);
           sql1.SelectCommand.Parameters.Add("@CHECK", SqlDbType.Int).Direction=ParameterDirection.Output;
           sql1.SelectCommand.ExecuteNonQuery();
           CHECK = Convert.ToInt16(sql1.SelectCommand.Parameters["@CHECK"].Value);
           DataTable dt = new DataTable();
           sql1.Fill(dt);
           sql1.Dispose();
           return dt;
           
        
       }
    }
}
