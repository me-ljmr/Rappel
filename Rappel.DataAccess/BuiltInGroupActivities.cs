using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Rappel.DataStructure;
namespace Rappel.DataAccess
{
    public class BuiltInGroupActivities
    {
        private List<BuiltInGroups> _grp = new List<BuiltInGroups>();
        public List<BuiltInGroups> BuiltInGroupCollection { get { return _grp; } }
        public BuiltInGroupActivities()
        {
            _grp.Clear();

            foreach (DataRow dr in GetBuiltInGroups().Rows)
            {
                _grp.Add(new BuiltInGroups
                {
                    RemGroupID = dr["bgroup_id"].ToString(),
                    sType = dr["group_type"].ToString(),
                    RemTitle = dr["group_title"].ToString(),
                    GroupType = dr["group_type"].ToString()
                });
            }
           
        }
        public DataTable GetBuiltInGroups()
        {
            string sqltext = string.Empty;
            sqltext = "select * from builtingroups where show=Yes order by sort_order";
            return DatabaseLibrary.GetRecordset(sqltext, null);
        }
    }
}
