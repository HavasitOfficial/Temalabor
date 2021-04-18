using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace CovidApp.Converter
{
    class ColumnColorConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                var sv = 0; ;
                Int32.TryParse(value.ToString(), out sv);
                new Windows.UI.Popups.MessageDialog(sv.ToString() + "    height").ShowAsync();
                if (sv > 20)
                {
                    return new SolidColorBrush(Colors.LightBlue);
                }
                else
                {
                    return new SolidColorBrush(Colors.Yellow);
                }
            }
            return new SolidColorBrush(Colors.Green);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}

