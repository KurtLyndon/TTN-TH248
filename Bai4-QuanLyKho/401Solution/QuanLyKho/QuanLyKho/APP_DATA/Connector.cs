using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHOTTN.APP_DATA
{
   public class Connector
    {
       public Connector() { }
       public String getconnect()
       {
           return (@"Data Source=QUAN-PC\QUAN;Initial Catalog=QUAN_LY_KHO;Integrated Security=True");
       }
    }
}
