using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTHPT.APP_DATA
{
   public class DATA
    {
       public int CHECK;
       public string sql;
       public string path;
       
       public SqlConnection con;
       public SqlCommand cmd;
       //public string sql;
       Connector cn=new Connector();
       public DataTable SHOWDATA()
       {

            con=new SqlConnection(cn.getconnect());
            con.Open();
       //    con.ConnectionString=;
           SqlDataAdapter sql=new SqlDataAdapter(path,con);

           DataTable dt=new DataTable();
           sql.Fill(dt);
           return dt;


       }
       public void check()
       {
           CHECK = 0;
           cmd.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.Output;
           cmd.ExecuteNonQuery();
           CHECK = Convert.ToInt16(cmd.Parameters["@CHECK"].Value);
           cmd.Dispose();
           con.Close();
       }
       public void SP_DATA()
       {

            con = new SqlConnection(cn.getconnect());
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
       }
    }
    }

