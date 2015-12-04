using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DATA
{
    public class HOADONDATA : QuanLySieuThi.APP_DATA.DATA
    {
        public HOADONDATA()
        {
            base.path = "select *from HOADON ";
        }
        public void GAN_HD(List<String> HD)
        {
            cmd.Parameters.AddWithValue("@ID", HD[0]);
            cmd.Parameters.AddWithValue("@ID_NV", HD[1]);
            cmd.Parameters.AddWithValue("@ID_KH", HD[2]);
            DateTime a = Convert.ToDateTime(HD[3]);
            cmd.Parameters.AddWithValue("@DATE", a);
        }

        public void InsertHD(List<string> HD)
        {
            CHECK = 0;
            base.sql = "INSERTHOADON";
            SP_DATA();
            GAN_HD(HD);
            check();

        }
        public void UpdateHD(List<String> HD)
        {
            CHECK = 0;
            base.sql = "UPDATEHOADON";
            SP_DATA();
            GAN_HD(HD);
            check();

        }
        public void DeleteHD(string ID)
        {
            base.sql = "DELETEHOADON";
            SP_DATA();
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }



    }
}
