using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHOTTN
{
 public   class HANGHOADATA:APP_DATA.DATA
    {
     public HANGHOADATA()
     {
         base.path = "select * from HANGHOA";
     }
     public void GAN_HH(List<String> HH)
     {
         cmd.Parameters.AddWithValue("@ID", HH[0]);
         cmd.Parameters.AddWithValue("@NAME", HH[1]);
         cmd.Parameters.AddWithValue("@GIA", HH[2]);
         cmd.Parameters.AddWithValue("@IDNSX", HH[3]);
         
     }

     public void InsertHH(List<string> HH)
     {
         CHECK = 0;
         base.sql = "INSERTHANGHOA";
         SP_DATA();
         GAN_HH(HH);
         check();

     }
     public void UpdateHH(List<String> HH)
     {
         CHECK = 0;
         base.sql = "UPDATEHANGHOA";
         SP_DATA();
         GAN_HH(HH);
         check();

     }
     public void DeleteHH(string ID)
     {
         base.sql = "DELETEHANGHOA";
         SP_DATA();
         cmd.Parameters.AddWithValue("@ID", ID);
         cmd.ExecuteNonQuery();
         cmd.Dispose();
         con.Close();
     }
    }
}
