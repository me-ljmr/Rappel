using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Rappel.DataStructure;
namespace Rappel.DataAccess
{
    public class ListsActivities
    {
        private List<Lists> _rem=new List<Lists>();
        public List<Lists> ListCollection { get { return _rem; } }
        
        public ListsActivities()
        {
            _rem.Clear();

            foreach (DataRow dr in GetLists().Rows)
            {
                _rem.Add(new Lists
                {
                    ReminderID = long.Parse(dr["rem_id"].ToString()),
                    ReminderDescription = dr["rem_desc"].ToString(),
                    ReminderType = dr["rem_type"].ToString()
                });
            }
           
        }

        public DataTable GetLists()
        {
            string sqltext = string.Empty;
            sqltext = "select * from Lists order by sort_order";
            return DatabaseLibrary.GetRecordset(sqltext, null);
        }
        public bool SaveLists(long listid,long sort_order, string listtitle) {
            try
            {
                string sqltext =  "update Lists set rem_desc= @p1,sort_order=@p2 where rem_id=@q1";
                OleDbParameter[] sqlparam = new OleDbParameter[3];
                sqlparam[0] = new OleDbParameter("@p1", listtitle);
                sqlparam[1] = new OleDbParameter("@p2", sort_order);
                sqlparam[2] = new OleDbParameter("@q1", listid);
                DatabaseLibrary.ExecSQLStatement(sqltext, sqlparam);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool SaveLists(string listtitle)
        {
            try
            {
                string maxorderquery = "select iif(isnull(max(sort_order)),1,max(sort_order)+1) from Lists";
                string maxorder = DatabaseLibrary.GetData(maxorderquery,null);
                string sqltext = string.Empty;
                sqltext = "Insert into Lists (rem_desc,sort_order) values(@p1,@p2)";
                OleDbParameter[] sqlparam = new OleDbParameter[2];
                sqlparam[0] = new OleDbParameter("@p1", listtitle);
                sqlparam[1] = new OleDbParameter("@p2", maxorder);
                DatabaseLibrary.ExecSQLStatement(sqltext, sqlparam);
               
                return true;
            }
            catch (Exception ex) {
                throw ex;
            }
            
        }
        //insert into reminder (SELECT "Test",IIf(IsNull(Max(sort_order)),1,Max(sort_order)+1) FROM reminder)
        
    }
    
}
