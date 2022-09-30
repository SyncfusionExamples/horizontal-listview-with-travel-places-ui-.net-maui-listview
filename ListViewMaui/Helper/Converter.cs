using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class BorderColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isSelected = (bool)value;
            if(isSelected)
            {
                return Color.FromArgb("#1899EF");
            }
            else
            {
                return Color.FromArgb("#FFFDFD");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
   
}
