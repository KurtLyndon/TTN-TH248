using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTHPT.APP_DATA
{
   public class CONNECT
    {
       public CONNECT() { }
       public String getconnect()
       {
           return (@"Data Source=QUAN-PC\QUAN;Initial Catalog=QL_HOCSINH_GIAOVIEN;Integrated Security=True");
       }
    }
}
