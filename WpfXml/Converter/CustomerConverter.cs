using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using WpfXml.Model;

namespace WpfXml.Converter
{
    public class CustomerConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
         {
            if (value is string inputString)
            {
                var objs = inputString.Split(',');
                return new Customer()
                {
                    FirstName = objs[0],
                    LastName = objs[1],
                    IsDeveloper = bool.Parse(objs[2])
                };
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
