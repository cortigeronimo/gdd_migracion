using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PalcoNet.Utils
{
    class SqlHelper
    {
        public static String AddFilterEqualsThan(String alias, String columnName, String value, SqlCommand command)
        {
            String filter = "";
            if (value != "")
            {

                filter += "and " + alias + "." + columnName + " = " + "@" + columnName + " ";
                command.Parameters.AddWithValue("@" + columnName, value);
            }
            return filter;
        }

        public static String AddFilterLessOrEqualsThan(String alias, String columnName, String value, SqlCommand command)
        {
            String filter = "";
            if (value != "")
            {

                filter += "and " + alias + "." + columnName + " <= " + "@" + columnName + " ";
                command.Parameters.AddWithValue("@" + columnName, value);
            }
            return filter;
        }
    }
}
