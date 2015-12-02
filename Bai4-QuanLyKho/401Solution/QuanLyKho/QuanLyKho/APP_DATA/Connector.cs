using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace QUANLYKHOTTN.APP_DATA
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
