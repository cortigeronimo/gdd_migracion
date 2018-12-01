using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace PalcoNet.Config
{
    public static class SystemDate
    {
        public static DateTime GetDate()
        {
            return Convert.ToDateTime(ConfigurationManager.AppSettings["systemDate"]);
        }
    }
}
