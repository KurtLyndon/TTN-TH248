using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QUANLYKHOTTN
{
  public  class PHIEUNHAPDATA:APP_DATA.DATA
    {
           public PHIEUNHAPDATA()
        {
            base.path = "select *from phieu ";
        }
        public void GAN_PHIEU(List<String> PHIEU)
        {
            cmd.Parameters.AddWithValue("@ID", PHIEU[0]);
            cmd.Parameters.AddWithValue("@DATE", PHIEU[1]);
            cmd.Parameters.AddWithValue("@TYPE", PHIEU[2]);
            
                    }

        public void InsertPHIEU(List<string> PHIEU)
        {
            CHECK = 0;
            base.sql = "INSERTPHIEU";
            SP_DATA();
            GAN_PHIEU(PHIEU);
            check();

        }
        public void UpdatePHIEU(List<String> PHIEU)
        {
            CHECK = 0;
            base.sql = "UPDATEPHIEU";
            SP_DATA();
            GAN_PHIEU(PHIEU);
            check();

        }
        public void DeletePHIEU(string ID)
        {
            base.sql = "DELETEPHIEU";
            SP_DATA();
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

    }
}
