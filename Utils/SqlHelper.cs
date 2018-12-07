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
            String filter = String.Empty;
            alias = (alias == String.Empty)? String.Empty : alias + ".";
            if (value != String.Empty)
            {

                filter += "and " + alias + columnName + " = " + "@" + columnName + " ";
                command.Parameters.AddWithValue("@" + columnName, value);
            }
            return filter;
        }

        public static String AddFilterFullLikeThan(String alias, String columnName, String value, SqlCommand command)
        {
            String filter = String.Empty;
            alias = (alias == String.Empty) ? String.Empty : alias + ".";
            if (value != String.Empty)
            {

                filter += "and " + alias + columnName + " LIKE " + "@" + columnName + " ";
                command.Parameters.AddWithValue("@" + columnName, "%" + value + "%");
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
