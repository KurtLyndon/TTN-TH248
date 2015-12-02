using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace QuanLyTHPT.APP_DATA
{
   public class Connector
    {
       public Connector() { }
       public String getconnect()
       {
           return (ConfigurationManager.ConnectionStrings["Conn"].ToString());
       }
    }
}
