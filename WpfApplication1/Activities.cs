using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections.ObjectModel;
namespace RemindKitty.DataAccess
{

    public class TaskActivities
    {
        public static AlarmRepeatType GetRepeatType(int RepeatType)
        {
            AlarmRepeatType rt = AlarmRepeatType.EveryDay;
            foreach (AlarmRepeatType art in Enum.GetValues(typeof(AlarmRepeatType)))
            {
                if ((int)art == RepeatType)
                {
                    rt = art;
                    break;
                }
            }
            return rt;
        }

        public DataTable GetBuiltInGroups()
        {
            string sqltext = string.Empty;
            sqltext = "select * from builtingroups order by sort_order";
            return DataAccess.DatabaseLibrary.GetRecordset(sqltext, null);
        }
        
        
        public DataTable GetTodaysTasks()
        {
            string sqltext = string.Empty;
            sqltext = "select * from task where int(task_date) =#@p1#";
            OleDbParameter[] sqlparam = new OleDbParameter[1];
            sqlparam[0] = new OleDbParameter("@p1", DateTime.Today);
            return DataAccess.DatabaseLibrary.GetRecordset(sqltext, sqlparam);
        }
        public DataTable GetCompletedTasks()
        {
            string sqltext = string.Empty;
            sqltext = "select * from task where is_completed=1";
            
            return DataAccess.DatabaseLibrary.GetRecordset(sqltext, null);
        }
        public DataTable GetTasks(long reminderID)
        {
            string sqltext = string.Empty;
            DataTable result;
            
            sqltext = "select * from Task where listed_in=@p1";
            OleDbParameter[] sqlparam = new OleDbParameter[1];
            sqlparam[0] = new OleDbParameter("@p1", reminderID);
            result = DataAccess.DatabaseLibrary.GetRecordset(sqltext, sqlparam);
            
            return result;
        }

        public DataTable GetTaskInfo(string taskid)
        {
            string sqltext = string.Empty;
            sqltext = "select * from Task where task_id=@p1";
            OleDbParameter[] sqlparam = new OleDbParameter[1];
            sqlparam[0] = new OleDbParameter("@p1", taskid);
            return DataAccess.DatabaseLibrary.GetRecordset(sqltext, sqlparam);
        }
        
    }
    public class ReminderActivities
    {

        
        public List<Reminder> ReminderList()
        {
            List<Reminder> remcol = new List<Reminder>();
            foreach (DataRow dr in GetReminders().Rows)
            {
                remcol.Add(new Reminder { 
                    ReminderID= long.Parse(dr["rem_id"].ToString()),
                     ReminderDescription=dr["rem_desc"].ToString(),
                     ReminderType=dr["rem_type"].ToString()
                });
            }
            return remcol;
        }
        public DataTable GetReminders()
        {
            string sqltext = string.Empty;
            sqltext = "select * from Reminder order by sort_order";
            return DataAccess.DatabaseLibrary.GetRecordset(sqltext, null);
        }

                
        public DataTable GetGroupsAndReminders()
        {
            string sqltext = string.Empty;
            sqltext = "select * from qryremsgroups";
            return DataAccess.DatabaseLibrary.GetRecordset(sqltext, null);
        }
    }
}
