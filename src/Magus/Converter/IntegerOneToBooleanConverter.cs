using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Magus.Converter {
    class IntegerOneToBooleanConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (int.Parse(value.ToString()) <= 1)
                return false;
            else
                return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (value is bool) {
                if ((bool)value == true)
                    return 2;
                else
                    return 1;
            }
            return 0;
        }

    }
}
