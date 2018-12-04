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
        public static readonly DateTime actualDate 
            = Convert.ToDateTime(ConfigurationManager.AppSettings["systemDate"]);

        public static DateTime GetDate()
        {
            return actualDate;
        }
    }
}
