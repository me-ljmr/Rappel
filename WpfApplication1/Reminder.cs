using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemindKitty
{
    public class Reminder
    {
        public long ReminderID { get; set; }
        public string ReminderDescription { get; set; }
        public string ReminderType { get; set; }

    }
    public class RemsGroups
    {
        public string RemGroupID { get; set; }
        public string sType { get; set; }
        public string RemTitle { get; set; }
        public string GroupType { get; set; }
    }

}
