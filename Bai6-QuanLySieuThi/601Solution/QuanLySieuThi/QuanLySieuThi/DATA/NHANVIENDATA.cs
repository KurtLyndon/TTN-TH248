using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DATA
{
    public class NHANVIENDATA : QuanLySieuThi.APP_DATA.DATA
    {
        public NHANVIENDATA()
        {
            base.path = "select *from NHANVIEN ";
        }
        public void GAN_NV(List<String> NV)
        {
            cmd.Parameters.AddWithValue("@ID", NV[0]);
            cmd.Parameters.AddWithValue("@NAME", NV[1]);
            cmd.Parameters.AddWithValue("@CMTND", NV[2]);
            cmd.Parameters.AddWithValue("@SDT", NV[3]);

        }

        public void InsertNV(List<string> NV)
        {
            CHECK = 0;
            base.sql = "INSERTNHANVIEN";
            SP_DATA();
            GAN_NV(NV);
            check();

        }
        public void UpdateNV(List<String> NV)
        {
            CHECK = 0;
            base.sql = "UPDATENHANVIEN";
            SP_DATA();
            GAN_NV(NV);
            check();

        }
        public void DeleteNV(string ID)
        {
            base.sql = "DELETENHANVIEN";
            SP_DATA();
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }



    }
}
