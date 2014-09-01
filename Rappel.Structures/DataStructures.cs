using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rappel.Enums;


namespace Rappel.DataStructure
{
    public class Appointment
    {
        public long AppointmentID { get; set; }
        public string AppointmentTitle { get; set; }
        public string WithWhom { get; set; }
        public string Location { get; set; }
        public bool IsWholeDay { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int RemindBefore { get; set; }
        public DateParts RemindBeforeType { get; set; } // Hour / Minute / Second / Day / Week / Month / Year
        public bool MarkAsDone { get; set; }
        public long ListedIn { get; set; }
        public long SortOrder { get; set; }
        public string Notes { get; set; }


    }
    public class Lists
    {
        public long ReminderID { get; set; }
        public string ReminderDescription { get; set; }
        public string ReminderType { get; set; }

    }
    public class BuiltInGroups
    {
        public string RemGroupID { get; set; }
        public string sType { get; set; }
        public string RemTitle { get; set; }
        public string GroupType { get; set; }
    }

    public class Reminders
    {
        public string TaskType { get; set; }
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
        public DateTime CompletedDate { get; set; }
        public long SortOrder { get; set; }
    }
}
