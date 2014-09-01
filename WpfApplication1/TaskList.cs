using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
namespace RemindKitty
{
    public class TaskList
    {

        private ObservableCollection<Task> _tsk;
        public ObservableCollection<Task> TaskCollection
        {
            get
            {
                return _tsk;
            }
        }
        DataAccess.TaskActivities act = new DataAccess.TaskActivities();
        public TaskList(long ReminderID)
        {
            _tsk = new ObservableCollection<Task>();
            foreach (DataRow dr in act.GetTasks(ReminderID).Rows)
            {

                _tsk.Add(new Task
                {
                    TaskID = long.Parse(dr["task_id"].ToString()),
                    TaskTitle = dr["task_title"].ToString(),
                    RemindMe =bool.Parse(dr["remind_me"].ToString()),
                    RemindOn = DateTime.Parse(dr["remind_ondate"].ToString()),
                    Notes = dr["notes"].ToString(),
                    ReminderID = long.Parse(dr["listed_in"].ToString())
                    
                });
            }
    }
    }
}