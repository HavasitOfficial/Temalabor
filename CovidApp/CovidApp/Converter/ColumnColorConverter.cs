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
                var sv = 0;
                Int32.TryParse(value.ToString(), out sv);
                if (sv <= 20)
                {
                    return new SolidColorBrush(Colors.LightBlue);
                }
                else if(sv>20 && sv <=40)
                {
                    return new SolidColorBrush(Colors.Yellow);
                }else if( sv>40 && sv <= 60)
                {
                    return new SolidColorBrush(Colors.Purple);
                }
                else
                {
                    return new SolidColorBrush(Colors.Red);
                }
                
            }
            return new SolidColorBrush(Colors.White);

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}

