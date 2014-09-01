using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
namespace Rappel.DataAccess
{
    public class ReminderActivities
    {
        public bool DeleteReminders(long taskid)
        {
            try
            {
                string sqltext = "Delete from Task where task_id=@p1";
                OleDbParameter[] sqlparam = new OleDbParameter[1];
                sqlparam[0] = new OleDbParameter("@p1", taskid);
                DatabaseLibrary.ExecSQLStatement(sqltext, sqlparam);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SaveReminders( string tasktitle, DateTime taskdate, bool remindme, DateTime remindondate, Enums.AlarmRepeatType repeattype, long listedin, Enums.Priority priority, string notes, bool iscompleted,string tasktype)
        {
            try
            {
                string maxorderquery = "select iif(isnull(max(sort_order)),1,max(sort_order)+1) from task";
                long  maxorder = long.Parse(DatabaseLibrary.GetData(maxorderquery, null));

                string sqltext = "insert into Task (task_title,remind_me,repeat_type,listed_in,priority,notes,is_completed,sort_order,task_date,remind_ondate,task_type) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
                OleDbParameter[] sqlparam = new OleDbParameter[11];
                sqlparam[0] = new OleDbParameter("@p1", tasktitle);
                sqlparam[1] = new OleDbParameter("@p2", remindme);
                sqlparam[2] = new OleDbParameter("@p3", repeattype);//(remindme?repeattype:0));
                sqlparam[3] = new OleDbParameter("@p4", listedin);
                sqlparam[4] = new OleDbParameter("@p5", priority);
                sqlparam[5] = new OleDbParameter("@p6", notes.ToString());
                sqlparam[6] = new OleDbParameter("@p7", iscompleted);
                sqlparam[7] = new OleDbParameter("@p8", maxorder);
                sqlparam[8] = new OleDbParameter("@p9",taskdate.ToString());
                sqlparam[9] = new OleDbParameter("@p10", remindondate.ToString());//(remindme?remindondate:DateTime.Parse("00:00:00")));
                sqlparam[10] = new OleDbParameter("@p11",tasktype);
                DatabaseLibrary.ExecSQLStatement(sqltext, sqlparam);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SaveReminders(long taskid,string tasktitle,DateTime taskdate,bool remindme,DateTime remindondate,Enums.AlarmRepeatType repeattype,long listedin,Enums.Priority priority,string notes,bool iscompleted,DateTime completeddate, long sortorder,string tasktype)
        {
            try
            {
                string sqltext = "update Task set task_title= @p1,task_Date=@p2,remind_me=@p3,remind_ondate=@p4,repeat_type=@p5,listed_in=@p6,priority=@p7,notes=@p8,is_completed=@p9,completed_ondate=@p10,sort_order=@p11,task_type=@p12 where task_id=@q1";
                OleDbParameter[] sqlparam = new OleDbParameter[13];
                sqlparam[0] = new OleDbParameter("@p1", tasktitle);
                sqlparam[1] = new OleDbParameter("@p2", taskdate.ToString());
                sqlparam[2] = new OleDbParameter("@p3", remindme);
                sqlparam[3] = new OleDbParameter("@p4", remindondate.ToString());
                sqlparam[4] = new OleDbParameter("@p5", repeattype);
                sqlparam[5] = new OleDbParameter("@p6", listedin);
                sqlparam[6] = new OleDbParameter("@p7", priority);
                sqlparam[7] = new OleDbParameter("@p8", notes);
                sqlparam[8] = new OleDbParameter("@p9", iscompleted);
                sqlparam[9] = new OleDbParameter("@p10", completeddate.ToString());
                sqlparam[10] = new OleDbParameter("@p11", sortorder);
                sqlparam[11] = new OleDbParameter("@p12", tasktype);
                sqlparam[12] = new OleDbParameter("@q1", taskid);
                DatabaseLibrary.ExecSQLStatement(sqltext, sqlparam);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetRemindersByDate(DateTime TheDate)
        {
            string sqltext = string.Empty;
            sqltext = "select * from ViewREMALL where format(remind_ondate,@p1) =@p2 and remind_me=Yes order by remind_ondate desc";
            OleDbParameter[] sqlparam = new OleDbParameter[2];
            sqlparam[0] = new OleDbParameter("@p1", string.Format(Tools.Settings.ShortDateFormat, DateTime.Today));
            sqlparam[1] = new OleDbParameter("@p2", string.Format("{0:" + Tools.Settings.ShortDateFormat + "}", TheDate ));
            return DatabaseLibrary.GetRecordset(sqltext, sqlparam);
        }
        public bool SaveCompletionStatus(long taskid, bool iscompleted,DateTime completeddate)
        {
            try
            {
                string sqltext = "update Task set is_completed= @p1,completed_ondate=@p2  where task_id=@q1";
                OleDbParameter[] sqlparam = new OleDbParameter[3];
                sqlparam[0] = new OleDbParameter("@p1", iscompleted);
                sqlparam[1] = new OleDbParameter("@p2", completeddate.ToString());
                sqlparam[2] = new OleDbParameter("@q1", taskid);
                DatabaseLibrary.ExecSQLStatement(sqltext, sqlparam);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCategorizedData(string schedulename,string listaction,object eParam)
        {
            string sqltext = string.Empty;
            sqltext = "select * from View" + schedulename + listaction;
            OleDbParameter[] oparam = new OleDbParameter[0];
            
            if (listaction == "DATE")
            {
                oparam = new OleDbParameter[1];
                oparam[0] = new OleDbParameter("@date",(DateTime)eParam);    
            }
            else if (listaction == "REMINDERGROUP")
            {
                oparam = new OleDbParameter[1];
                oparam[0] = new OleDbParameter("@remid", (long)eParam);
            }
            else
            {
                oparam = null;
            }
            return DatabaseLibrary.GetRecordset(sqltext, oparam);
        }
        public DataTable GetTodaysReminders()
        {
            string sqltext = string.Empty;
            sqltext = "select * from ViewREMALL where format(remind_ondate,@p1) =@p2 and remind_me=Yes order by remind_ondate desc";
            OleDbParameter[] sqlparam = new OleDbParameter[2];
            sqlparam[0] = new OleDbParameter("@p1",Tools.Settings.ShortDateFormat);
            sqlparam[1] = new OleDbParameter("@p2", string.Format("{0:" + Tools.Settings.ShortDateFormat + "}", DateTime.Today));
            return DatabaseLibrary.GetRecordset(sqltext, sqlparam);
        }
        public DataTable GetCompletedReminders()
        {
            string sqltext = string.Empty;
            sqltext = "select * from task where is_completed=true order by completed_ondate desc";
            return DatabaseLibrary.GetRecordset(sqltext, null);
        }
        public DataTable GetRemindableTasks(DateTime timematch)
        {
            string sqltext = string.Empty;
            DataTable result;

            sqltext = "select * from ViewREMALL where remind_me=Yes and is_completed=No";//and format(remind_ondate,@p1) =@p2 and
            //OleDbParameter[] sqlparam = new OleDbParameter[2];
            //sqlparam[0] = new OleDbParameter("@p1", Tools.Settings.DateAndTime);
            //sqlparam[1] = new OleDbParameter("@p2", string.Format("{0:" + Tools.Settings.DateAndTime + "}", DateTime.Now));
            result = DatabaseLibrary.GetRecordset(sqltext, null);

            return result;
        }

        public DataTable GetReminders(long listid)
        {
            string sqltext = string.Empty;
            DataTable result;

            sqltext = "select * from ViewREMALL where listed_in=@p1 order by task_title";
            OleDbParameter[] sqlparam = new OleDbParameter[1];
            sqlparam[0] = new OleDbParameter("@p1", listid);
            result = DatabaseLibrary.GetRecordset(sqltext, sqlparam);

            return result;
        }
        public DataTable GetAllReminders()
        {
            string sqltext = string.Empty;
            DataTable result;

            sqltext = "select * from ViewREMALL where is_completed=No order by remind_ondate, rem_desc";

            result = DatabaseLibrary.GetRecordset(sqltext, null);

            return result;
        }

        public DataTable GetTomorrowsReminders()
        {
            string sqltext = string.Empty;
            sqltext = "select * from ViewREMALL where int(remind_ondate) =@p1 and remind_me=Yes order by remind_ondate desc";
            OleDbParameter[] sqlparam = new OleDbParameter[1];
            sqlparam[0] = new OleDbParameter("@p1", string.Format("{0:dd/MM/yyyy}", DateTime.Today.AddDays(1)));
            return DatabaseLibrary.GetRecordset(sqltext, sqlparam);
        }
        public DataTable GetNextWeeksReminders()
        {
            string sqltext = string.Empty;
            sqltext = "select * from ViewREMALL where DatePart('ww',remind_ondate) = DatePart('ww',Date())+1 and remind_me=Yes order by task_date desc";
            
            return DatabaseLibrary.GetRecordset(sqltext, null);
        }

        public DataTable GetReminderInfo(long taskid)
        {
            string sqltext = string.Empty;
            sqltext = "select * from ViewREMALL where task_id=@p1 ";
            OleDbParameter[] sqlparam = new OleDbParameter[1];
            sqlparam[0] = new OleDbParameter("@p1", taskid);
            return DatabaseLibrary.GetRecordset(sqltext, sqlparam);
        }
        public DateTime[] GetTaskReminderDates()
        {
            string sqltext = string.Empty;
            DataTable result;

            sqltext = "select distinct remind_ondate from ViewREMALL where remind_me=Yes";
            result = DatabaseLibrary.GetRecordset(sqltext, null);
            DateTime[] dt= Tools.Converter.ConvertToFormattedDateTimeArray(result,"remind_ondate");
            
            return dt;
        }
    }
}
