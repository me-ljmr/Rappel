using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Rappel.BusinessLogic
{
    public class AppointmentLogic
    {
        private double _mininterval = 15; 
        public List<string> Times(string startfrom)
        {
            List<string> tms = new List<string>();
            startfrom = string.Format("{0:hh:mm tt}", DateTime.Parse(startfrom).AddMinutes(_mininterval));
            DateTime dt = DateTime.Parse(startfrom);
            while (dt <= DateTime.Parse("23:45"))
            {
                tms.Add(string.Format("{0:hh:mm tt}", dt));
                dt = dt.AddMinutes(_mininterval);
            }

            if (DateTime.Parse(startfrom).Hour != 0 && DateTime.Parse(startfrom).Minute != 0)
            {
                dt = DateTime.Parse("00:00");
                while (dt < DateTime.Parse(startfrom).AddMinutes(0-_mininterval))
                {
                    tms.Add(string.Format("{0:hh:mm tt}", dt));
                    dt = dt.AddMinutes(_mininterval);
                }
            }
            return tms;
        }
        public List<string> Times()
        {
            List<string> tms = new List<string>();
            DateTime dt = DateTime.Parse("00:00");
            while (dt <= DateTime.Parse("23:45"))
            {
                tms.Add(string.Format("{0:hh:mm tt}",dt));
                dt = dt.AddMinutes(_mininterval);
            }
            return tms;
        }
        Rappel.DataAccess.AppointmentActivities aact= new DataAccess.AppointmentActivities();
        public bool SaveAppointments(DataStructure.Appointment appinfo)
        {
            return aact.SaveAppointments(appinfo.AppointmentID,appinfo.AppointmentTitle,appinfo.StartDay,appinfo.EndDay,appinfo.StartTime,appinfo.EndTime, appinfo.WithWhom,appinfo.Location,appinfo.Notes,appinfo.RemindBefore,appinfo.RemindBeforeType,appinfo.SortOrder,appinfo.ListedIn,appinfo.MarkAsDone);
        }
        public bool SaveNewAppointments(DataStructure.Appointment appinfo)
        {
            return aact.SaveAppointments(appinfo.AppointmentTitle, appinfo.StartDay, appinfo.EndDay, appinfo.StartTime, appinfo.EndTime, appinfo.WithWhom, appinfo.Location,appinfo.Notes, appinfo.RemindBefore, appinfo.RemindBeforeType, appinfo.ListedIn);
        }
        public DataTable GetCategorizedData(string schedulename, string listaction,object eparam)
        {
            return aact.GetCategorizedData(schedulename, listaction, eparam);
        }
        public bool MarkAsDone(long appid)
        {
            return aact.SaveDoneStatus(appid, true);
        }
        public bool MarkAsUndone(long appid)
        {
            return aact.SaveDoneStatus(appid,false);
        }
        public DataTable GetRemindableAppointments(DateTime timematch)
        {
            return aact.GetRemindableAppointments(timematch);
        }
    }
}
