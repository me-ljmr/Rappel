using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
namespace RemindKitty
{
    
    public enum AlarmRepeatType
    {
        [Description("None")]
        None=0,
        [Description("Every Day")]
        EveryDay=1,
        [Description("Every Week")]
        EveryWeek=2,
        [Description("Every 2 Weeks")]
        Every2Weeks=3,
        [Description("Every Month")]
        EveryMonth=4,
        [Description("Every Year")]
        EveryYear=5
    }
    public enum Priority
    {
        Low, Medium, High
    }
    
    public static class EnumExtensions
    {
        
        public static string Description(this Enum value)
        {
            var enumType = value.GetType();
            var field = enumType.GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute),
                                                       false);
            return attributes.Length == 0
                ? value.ToString()
                : ((DescriptionAttribute)attributes[0]).Description;
        }
    }
    public class EnumToStringUsingDescription : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType.Equals(typeof(Enum)));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return (destinationType.Equals(typeof(String)));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (!destinationType.Equals(typeof(String)))
            {
                throw new ArgumentException("Can only convert to string.", "destinationType");
            }

            if (!value.GetType().BaseType.Equals(typeof(Enum)))
            {
                throw new ArgumentException("Can only convert an instance of enum.", "value");
            }

            string name = value.ToString();
            object[] attrs =
                value.GetType().GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attrs.Length > 0) ? ((DescriptionAttribute)attrs[0]).Description : name;
        }
    }

}
