using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Config
{
    public static class LoggedInUser
    {
        public static int? ID { get; set; }
        public static String Username { get; set; }
        public static int? Rol { get; set; }

        public static void Initialize()
        {
            ID = null;
            Username = String.Empty;
            Rol = null;
        }
    }
}
