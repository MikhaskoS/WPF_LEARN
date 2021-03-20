using System;
using System.Globalization;
using System.Windows.Data;
using System.Diagnostics;


namespace BindingElements.Convertors
{
    // Этот конвертер полезен для контроля значений в поле
    class DebugConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
