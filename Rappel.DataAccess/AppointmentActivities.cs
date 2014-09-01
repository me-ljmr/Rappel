using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
namespace Rappel.DataAccess
{
    public class AppointmentActivities
    {
        public bool SaveAppointments(long appid,string appointmenttitle, DateTime startday,DateTime endday, string starttime, string endtime, string withwhom, string location, string notes,int remindbefore, Enums.DateParts remindbeforetype,long sortorder,long listedin,bool markasdone)
        {
            try
            {

                string sqltext = "update Appointments set app_title=@p1,with_whom=@p2,location=@p3,app_startdate=@p4,app_enddate=@p5,app_starttime=@p6,app_endtime=@p7,remind_before=@p8,remind_before_type=@p9,listed_in=@p10,is_done=@p11,notes=@p12 where app_id=@q1";
                OleDbParameter[] sqlparam = new OleDbParameter[13];
                sqlparam[0] = new OleDbParameter("@p1", appointmenttitle);
                sqlparam[1] = new OleDbParameter("@p2", withwhom);
                sqlparam[2] = new OleDbParameter("@p3", location);//(remindme?repeattype:0));
                sqlparam[3] = new OleDbParameter("@p4", startday.ToString(Rappel.Tools.Settings.ShortDateFormat));
                sqlparam[4] = new OleDbParameter("@p5", endday.ToString(Rappel.Tools.Settings.ShortDateFormat));
                sqlparam[5] = new OleDbParameter("@p6", starttime);
                sqlparam[6] = new OleDbParameter("@p7", endtime);
                sqlparam[7] = new OleDbParameter("@p8", remindbefore);
                sqlparam[8] = new OleDbParameter("@p9", remindbeforetype);
                sqlparam[9] = new OleDbParameter("@p10", listedin);
                sqlparam[10]= new OleDbParameter("@p11", markasdone);
                sqlparam[11]= new OleDbParameter("@p12", notes);
                sqlparam[12] = new OleDbParameter("@q1", appid);
                DatabaseLibrary.ExecSQLStatement(sqltext, sqlparam);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SaveAppointments(string appointmenttitle, DateTime startday, DateTime endday, string starttime, string endtime, string withwhom, string location, string notes,int remindbefore, Enums.DateParts remindbeforetype, long listedin)
        {
            try
            {
                //string maxorderquery = "select iif(isnull(max(sort_order)),1,max(sort_order)+1) from appointments";
                //long maxorder = long.Parse(DatabaseLibrary.GetData(maxorderquery, null));

                string sqltext = "insert into Appointments (app_title,with_whom,location,app_startdate,app_enddate,app_starttime,app_endtime,remind_before,remind_before_type,is_done,listed_in,notes)" +
                        " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)";
                OleDbParameter[] sqlparam = new OleDbParameter[12];
                sqlparam[0] = new OleDbParameter("@p1", appointmenttitle);
                sqlparam[1] = new OleDbParameter("@p2", withwhom);
                sqlparam[2] = new OleDbParameter("@p3", location);//(remindme?repeattype:0));
                sqlparam[3] = new OleDbParameter("@p4", startday.ToString( Rappel.Tools.Settings.ShortDateFormat ));
                sqlparam[4] = new OleDbParameter("@p5", endday.ToString(Rappel.Tools.Settings.ShortDateFormat));
                sqlparam[5] = new OleDbParameter("@p6", starttime);
                sqlparam[6] = new OleDbParameter("@p7", endtime);
                sqlparam[7] = new OleDbParameter("@p8", remindbefore);
                sqlparam[8] = new OleDbParameter("@p9", remindbeforetype);
                sqlparam[9] = new OleDbParameter("@p10", false);
                sqlparam[10] = new OleDbParameter("@p11", listedin);
                sqlparam[11] = new OleDbParameter("@p12", notes);
                DatabaseLibrary.ExecSQLStatement(sqltext, sqlparam);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SaveDoneStatus(long appid, bool markasdone)
        {
            try
            {
                string sqltext = "update Appointments set is_done= @p1 where app_id=@q1";
                OleDbParameter[] sqlparam = new OleDbParameter[2];
                sqlparam[0] = new OleDbParameter("@p1", markasdone);
                sqlparam[1] = new OleDbParameter("@q1", appid);
                DatabaseLibrary.ExecSQLStatement(sqltext, sqlparam);
                return true;
            }
            catch (Exception ex)
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
                oparam[0] = new OleDbParameter("@listid", (long)eParam);
            }
            else
            {
                oparam = null;
            }
            return DatabaseLibrary.GetRecordset(sqltext, oparam);
        }

        public DataTable GetRemindableAppointments(DateTime timematch)
        {
            string sqltext = string.Empty;
            DataTable result;

            sqltext = "select * from ViewAPPALL where is_done=No and remind_before_type>0";//and format(remind_ondate,@p1) =@p2 and
            //OleDbParameter[] sqlparam = new OleDbParameter[2];
            //sqlparam[0] = new OleDbParameter("@p1", Tools.Settings.DateAndTime);
            //sqlparam[1] = new OleDbParameter("@p2", string.Format("{0:" + Tools.Settings.DateAndTime + "}", DateTime.Now));
            result = DatabaseLibrary.GetRecordset(sqltext, null);

            return result;
        }


    }
}
