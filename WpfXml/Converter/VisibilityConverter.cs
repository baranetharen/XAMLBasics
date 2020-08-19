using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfXml.Converter
{
    public class VisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool result =false;
            if (value is bool)
            {
                result = (bool)value;
            }
            else if(value is Nullable<bool>)
            {
                if(value!=null)
                {
                    result = (bool)value;
                }
            }
            return result ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visible = (Visibility)Enum.Parse(typeof(Visibility), value.ToString());
            return visible == Visibility.Visible ? true : false;
        }
    }
}
