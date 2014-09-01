using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Rappel.DataStructure;
namespace Rappel.BusinessLogic
{
    public class ReminderLogic
    {
        Rappel.DataAccess.ReminderActivities ta= new DataAccess.ReminderActivities();

        public bool SaveReminders(long taskid, Reminders tk)
        {
            return ta.SaveReminders(taskid,tk.TaskTitle,tk.TaskDate,tk.RemindMe,tk.RemindOn,tk.RepeatType,tk.ReminderID,tk.TaskPriority,tk.Notes,tk.IsCompleted,tk.CompletedDate,tk.SortOrder,tk.TaskType);
        }
        public bool SaveReminders(Reminders tk)
        {
            return ta.SaveReminders(tk.TaskTitle, tk.TaskDate, tk.RemindMe, tk.RemindOn,tk.RepeatType, tk.ReminderID, tk.TaskPriority, tk.Notes, tk.IsCompleted,tk.TaskType);
        }
        public bool MarkAsComplete(long taskid,  DateTime completiondate)
        {
            return ta.SaveCompletionStatus(taskid,true,completiondate); 
        }
        public bool MarkAsIncomplete(long taskid,  DateTime completiondate)
        {
            return ta.SaveCompletionStatus(taskid,false,completiondate); 
        }
        public bool DeleteReminders(long taskid)
        {
            return ta.DeleteReminders(taskid);
        }
        public DateTime[] GetTaskReminderDates()
        {
            return ta.GetTaskReminderDates();
        }
        public DataTable GetAllReminders()
        {
            return ta.GetAllReminders();
        }
        public DataTable GetCategorizedData(string schedulename,string listaction,object eParam)
        {
            return ta.GetCategorizedData(schedulename,listaction,eParam);
        }
        public DataTable GetReminders(DateTime TheDate)
        {
            return ta.GetRemindersByDate(TheDate);
        }
        public DataTable GetTodaysReminders()
        {
            return ta.GetTodaysReminders();
        }
        public DataTable GetTomorrowsReminders()
        {
            return ta.GetTomorrowsReminders();
        }
        public DataTable GetNextWeeksReminders()
        {
            return ta.GetNextWeeksReminders();
        }
        public DataTable GetCompletedReminders()
        {
            return ta.GetCompletedReminders();
        }
        public DataTable GetReminderInfo(long taskid)
        {
            return ta.GetReminderInfo(taskid);
        }
        public DataTable GetReminders(long ReminderID)
        {
            return ta.GetReminders(ReminderID);
        }
        public DataTable GetReminders(string ttype)
        {
            DataTable result=new DataTable();
            if (ttype == "COMPLETED")
            {
                result = ta.GetCompletedReminders();
            }
            else if (ttype == "TODAY")
            {
                result = ta.GetTodaysReminders();
            }
            else if (ttype == "NEXTWEEK")
            {
                result = ta.GetNextWeeksReminders();
            }
            else if (ttype == "TOMORROW")
            {
                result = ta.GetTomorrowsReminders();
            }
            else if (ttype == "EVENTS")
            {
                result = null;
                //result = ta.getEvents();
            }

            return result;
        }
        public DataTable GetRemindableTasks(DateTime timematch)
        {
            return ta.GetRemindableTasks(timematch);
        }

    }
}
