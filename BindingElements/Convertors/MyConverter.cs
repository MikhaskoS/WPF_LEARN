using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;    // <-------------

namespace BindingElements.Sample
{
    // https://metanit.com/sharp/wpf/11.3.php

    // указываем из какоготипа в какой конвертируем (VS будет помогать при отобр доступных конвертеров)
    [ValueConversion (typeof(string), typeof(string))]   
    class MyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CultureInfo cultureInfo = new CultureInfo("en-US");

            // получем рубли, переводим в баксы
            decimal k = 62;
            decimal price = System.Convert.ToDecimal(value) / k;
            return price.ToString("C", cultureInfo);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // получаем баксы, переводим в рубли
            decimal k = 62;
            //decimal price = System.Convert.ChangeType(value, targetType);
            decimal price = System.Convert.ToDecimal(value) * k;
            return price.ToString();
        }
    }
}
