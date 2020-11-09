using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BookLib
{
    public class StringUpperConverter : IValueConverter
    {
        string text;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            text = (string)value;
            return text.ToUpper();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return text;
        }
    }
}
