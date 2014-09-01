using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace RemindKitty
{
    
    public class Task
    {
        public long TaskID { get; set; }
        public string TaskTitle { get; set; }
        public DateTime TaskDate { get; set; }
        public bool RemindMe { get; set; }
        public DateTime RemindOn { get; set; }
        public AlarmRepeatType RepeatType { get; set; }
        public long ReminderID { get; set; }
        public Priority TaskPriority { get; set; }
        public string Notes { get; set; }
        public bool IsCompleted { get; set; }
    }
}
