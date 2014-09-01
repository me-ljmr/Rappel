using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rappel.Enums
{
    public enum DateParts
    {
        [EnumDescription("None")]
        None=0,
        [EnumDescription("Seconds")]
        Seconds=1,
        [EnumDescription("Minutes")]
        Minutes=2,
        [EnumDescription("Hours")]
        Hours=3,
        [EnumDescription("Days")]
        Days=4,
        [EnumDescription("Weeks")]
        Weeks=5,
        [EnumDescription("Months")]
        Months=6,
        [EnumDescription("Years")]
        Years=7
    }
        public enum AlarmRepeatType
        {
            [EnumDescription("Never")]
            None = 0,
            [EnumDescription("Every Day")]
            EveryDay = 1,
            [EnumDescription("Every Week")]
            EveryWeek = 2,
            [EnumDescription("Every 2 Weeks")]
            Every2Weeks = 3,
            [EnumDescription("Every Month")]
            EveryMonth = 4,
            [EnumDescription("Every Year")]
            EveryYear = 5
        }
        public enum Priority
        {   
            
            Low, Medium, High
        }
    
}
