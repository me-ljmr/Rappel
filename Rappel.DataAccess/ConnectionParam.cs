using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
namespace Rappel.DataAccess
{
    public class ConnectionParam
    {
        public static string GetConnectionString()
        {
            string connstring="";
            Rappel.Tools.DatabaseSettingFileManager fm = new Tools.DatabaseSettingFileManager();
            if (!fm.IsDBSettingsFileExists())
            {
                fm.SaveData("Microsoft.Jet.OLEDB.4.0;","admin","",Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\data.mdb;");
            }
            fm.FetchData();
            connstring = "Provider={0};Data Source={1};User id={2};Password={3};";
            connstring = string.Format(connstring,fm.Provider,fm.DataSource,fm.DBUser,fm.UserPassword );
            fm = null;
            return connstring;
            //return ConfigurationSettings.AppSettings.Get("ConnectionString");
        }
    }
}
