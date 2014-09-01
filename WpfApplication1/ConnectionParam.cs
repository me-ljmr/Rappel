using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
namespace RemindKitty.DataAccess
{
    public class ConnectionParam
    {
        public static string GetConnectionString()
        {
            return ConfigurationSettings.AppSettings.Get("ConnectionString");
        }
    }
}
