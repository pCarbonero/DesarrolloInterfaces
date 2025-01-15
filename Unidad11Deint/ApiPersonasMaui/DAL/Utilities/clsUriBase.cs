using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DAL.Utilities
{
    public class clsUriBase
    {
        public static string getUriBase()
        {
           return "https://pablocarboneroasp1.azurewebsites.net/api";
           //return "http://localhost:5067/api";
        }
    }
}
