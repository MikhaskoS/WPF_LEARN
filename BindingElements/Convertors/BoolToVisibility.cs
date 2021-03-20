using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;


namespace BindingElements.Convertors
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    class BoolToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var bool_value = System.Convert.ToBoolean(value);
            if (bool_value)
                return Visibility.Visible;
            else
                return Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var visibility = (Visibility)System.Convert.ChangeType(value, typeof(Visibility));
            switch (visibility)
            {
                case Visibility.Visible:
                    return true;
                case Visibility.Hidden:
                    return false;
                default:
                    throw new NotImplementedException($"Значение {visibility} не поддерживается");
            }
        }
    }
}
