using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DATA
{
   public class KHACHHANGDATA:QuanLySieuThi.APP_DATA.DATA
    {
         public KHACHHANGDATA()
        {
            base.path = "select *from KHACHHANG ";
        }
        public void GAN_KH(List<String> KH)
        {
            cmd.Parameters.AddWithValue("@ID", KH[0]);
            cmd.Parameters.AddWithValue("@NAME", KH[1]);
            cmd.Parameters.AddWithValue("@CMTND", KH[2]);
            cmd.Parameters.AddWithValue("@SDT", KH[3]);
            
        }

        public void InsertKH(List<string> KH)
        {
            CHECK = 0;
            base.sql = "INSERTKHACHHANG";
            SP_DATA();
            GAN_KH(KH);
            check();

        }
        public void UpdateKH(List<String> KH)
        {
            CHECK = 0;
            base.sql = "UPDATEKHACHHANG";
            SP_DATA();
            GAN_KH(KH);
            check();

        }
        public void DeleteKH(string ID)
        {
            base.sql = "DELETEKHACHHANG";
            SP_DATA();
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

       
        
    }
}
