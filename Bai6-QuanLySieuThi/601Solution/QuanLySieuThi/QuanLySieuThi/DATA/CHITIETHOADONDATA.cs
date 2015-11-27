using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DATA
{
    class CHITIETHOADONDATA : QuanLySieuThi.APP_DATA.DATA
    {
        public CHITIETHOADONDATA()
        {
            base.path = "select *from CHITIETHOADON";
        }
        public void SHOW_CTHD(string ID)
        {
            base.path = "select *from CHITIETHOADON as A where A.ID_HoaDon LIKE '" + ID +"'";
        }
        public void GAN_CTHD(List<String> CTHD)
        {
            cmd.Parameters.AddWithValue("@ID", CTHD[0]);
            cmd.Parameters.AddWithValue("@IDHH", CTHD[1]);
            cmd.Parameters.AddWithValue("@GIA", CTHD[2]);
           

        }

        public void InsertCTHD(List<string> CTHD)
        {
            CHECK = 0;
            base.sql = "INSERTCTHOADON";
            SP_DATA();
            GAN_CTHD(CTHD);
            check();

        }
        public void UpdateCTHD(List<String> CTHD)
        {
            CHECK = 0;
            base.sql = "UPDATECTHOADON";
            SP_DATA();
            GAN_CTHD(CTHD);
            check();

        }
        public void DeleteCTHD(string ID)
        {
            base.sql = "DELETECTHOADON";
            SP_DATA();
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
