using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Magus.Converter {
    class ReadableindexToProgrammingindexConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            int val = int.Parse(value.ToString());
            return val - 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            int val = int.Parse(value.ToString());
            return val + 1;
        }
    }
}
