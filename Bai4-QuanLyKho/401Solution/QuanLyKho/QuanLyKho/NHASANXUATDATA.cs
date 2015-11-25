using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHOTTN
{
   public class NHASANXUATDATA:APP_DATA.DATA
    {
           public NHASANXUATDATA()
        {
            base.path = "select *from NHACUNGCAP ";
        }
        public void GAN_NSX(List<String> NSX)
        {
            cmd.Parameters.AddWithValue("@ID", NSX[0]);
            cmd.Parameters.AddWithValue("@NAME", NSX[1]);
            cmd.Parameters.AddWithValue("@SDT", NSX[2]);
            cmd.Parameters.AddWithValue("@EMAIL", NSX[3]);
            cmd.Parameters.AddWithValue("@ADDRESS", NSX[4]);
          //  cmd.Parameters.AddWithValue("@WEB", NSX[5]);
           }

        public void InsertNSX(List<string> NSX)
        {
            CHECK = 0;
            base.sql = "INSERTNHACUNGCAP";
            SP_DATA();
            GAN_NSX(NSX);
            check();

        }
        public void UpdateNSX(List<String> NSX)
        {
            CHECK = 0;
            base.sql = "UPDATENHACUNGCAP";
            SP_DATA();
            GAN_NSX(NSX);
            check();

        }
        public void DeleteNSX(string ID)
        {
            base.sql = "DELETENHACUNGCAP";
            SP_DATA();
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

    }
}
