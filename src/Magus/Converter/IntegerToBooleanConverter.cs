using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Magus.Converter {
    class IntegerToBooleanConverter : IValueConverter{

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if(int.Parse(value.ToString())==0)
                return false;
            else
                return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (value is bool) {
                if ((bool)value == true)
                    return 1;
                else
                    return 0;
            }
            return 0;
        }
    }
}
