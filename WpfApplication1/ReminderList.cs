using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
namespace RemindKitty
{
    public class ReminderList
    {
        private ObservableCollection<RemsGroups> _rem;
        public ObservableCollection<RemsGroups> ReminderCollection
        {
            get
            {
                return _rem;
            }
        }
        DataAccess.ReminderActivities act = new DataAccess.ReminderActivities();
        public ReminderList()
        {
            _rem = new ObservableCollection<RemsGroups>();
            foreach (DataRow dr in act.GetGroupsAndReminders().Rows)
            {

                _rem.Add(new RemsGroups
                {
                    RemGroupID = string.Format("{0}{1}", dr["type"].ToString(), dr["bgroup_id"].ToString()),
                    RemTitle = dr["group_title"].ToString(),
                    GroupType = dr["group_type"].ToString(),
                    sType = dr["type"].ToString()

                });
                //if (dr["sort_order"].ToString() == "-1")
                //{
                //    _rem.Add(new Reminder { ReminderID = 0, ReminderDescription = "Reminders", ReminderType = "GROUP" });
                //}
            }

        }
    }
}
