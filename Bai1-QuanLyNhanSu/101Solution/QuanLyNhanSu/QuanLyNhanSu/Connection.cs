using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    class Connection
    {
        private string str = ConfigurationManager.ConnectionStrings["Conn"].ToString();
        private SqlConnection con;
        private SqlDataAdapter da;
        private DataTable table;
        private SqlCommand com;

        public Connection()
        {
            con = new SqlConnection(str);
        }
        public Connection(string STR)
        {
            str = STR;
            con = new SqlConnection(str);
        }
        public void CloseConnect()
        {
            con.Close();
            con.Dispose();
        }
        public bool TryConnect()
        {
            bool check = false;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    check = true;
                }
                else
                {
                    throw new Exception("Connection crashed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return check;
        }

        public DataTable LoadData(string i)
        {
            if (TryConnect())
            {
                com = new SqlCommand("OutputTable " + i, con);
                com.CommandType = CommandType.Text;
                da = new SqlDataAdapter(com);
                table = new DataTable();
                da.Fill(table);
            }
            CloseConnect();
            return table;
        }
        

        public bool InsertUpdateObject(string path, string core, string id1, string id2, string id3, string name, string place,string date,string gender,string relate,string salary,string time)
        {
            bool check = false;
            if (TryConnect())
            {
                com = new SqlCommand(path, con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@core", core);
                com.Parameters.AddWithValue("@ID1", id1);
                com.Parameters.AddWithValue("@ID2", id2);
                com.Parameters.AddWithValue("@ID3", id3);
                com.Parameters.AddWithValue("@Name", name);
                com.Parameters.AddWithValue("@Place", place);
                com.Parameters.AddWithValue("@DoB", Convert.ToDateTime(date));
                com.Parameters.AddWithValue("@Gender", gender);
                com.Parameters.AddWithValue("@Relate", relate);
                com.Parameters.AddWithValue("@Salary", salary);
                com.Parameters.AddWithValue("@Time", time);
                com.ExecuteNonQuery();
                check = true;
            }
            CloseConnect();
            return check;
        }

        public bool DeleteObject(string core, string id1, string id2)
        {
            bool check = false;
            if (TryConnect())
            {
                com = new SqlCommand("DeleteObject", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@core", core);
                com.Parameters.AddWithValue("@ID1", id1);
                com.Parameters.AddWithValue("@ID2", id2);
                com.ExecuteNonQuery();
                check = true;
            }
            CloseConnect();
            return check;
        }

        public DataTable FindObject(string core,string part)
        {
            if (TryConnect())
            {
                com = new SqlCommand("FindObject", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@core", core);
                com.Parameters.AddWithValue("@Part", part);
                da = new SqlDataAdapter(com);
                table = new DataTable();
                da.Fill(table);
            }
            CloseConnect();
            return table;
        }
    }
}
