using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Globalization;
namespace Rappel.Tools
{
    public class Settings
    {
        public static string DateAndTime
        {
            get
            {
                return ConfigurationSettings.AppSettings.Get("dateandtime");
            }
        }
        public static string ShortDateFormat
        {
            get
            {
                return ConfigurationSettings.AppSettings.Get("shortdateformat");
            }
        }
        public static string TimeFormat
        {
            get
            {
                return ConfigurationSettings.AppSettings.Get("timeformat");
            }
        }
        public static string LongDateFormat
        {
            get
            {
                return ConfigurationSettings.AppSettings.Get("longdateformat");
            }
        }
        public static string AlertSoundFile
        {
            get
            {
                return ConfigurationSettings.AppSettings.Get("alertsoundfile");
            }
        }
        public static int ReloadInterval
        {
            get
            {
                return int.Parse(ConfigurationSettings.AppSettings.Get("reloadinterval"));
            }
        }

    }
    public class Converter
    {
        public static DateTime[] ConvertToFormattedDateTimeArray(DataTable dtSource, string columnName)
        {
            List<DateTime> list = new List<DateTime>();
            if (dtSource.Rows.Count > 0)
            {
                foreach (DataRow dr in dtSource.Rows)
                {

                    if (dr[columnName].ToString() == string.Empty || dr[columnName] == DBNull.Value)
                    {
                        list.Add(DateTime.MinValue);
                    }
                    else
                    {
                        list.Add(Convert.ToDateTime(dr[columnName].ToString(), new CultureInfo("en-GB")));
                    }
                }
            }
            else
            {
                list.Add(DateTime.MinValue);
            }
            return list.ToArray();
        }
    }
}
