using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QuanLyKhachSan
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

        public bool Auto()
        {
            bool check = false;
            if (TryConnect())
            {
                com = new SqlCommand("AutoCounting", con);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                check = true;
            }
            CloseConnect();
            return check;
        }

        public bool InsertUpdateObject(string path, string core, string id1, string id2, string string1,string date1, string date2, string num)
        {
            bool check = false;
            if (TryConnect())
            {
                com = new SqlCommand(path, con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@core", core);
                com.Parameters.AddWithValue("@ID1", id1);
                com.Parameters.AddWithValue("@ID2", id2);
                com.Parameters.AddWithValue("@String", string1);
                com.Parameters.AddWithValue("@Date1", Convert.ToDateTime(date1));
                com.Parameters.AddWithValue("@Date2", Convert.ToDateTime(date2));
                com.Parameters.AddWithValue("@Num", num);
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

        public DataTable FindObject(string core, string part)
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
