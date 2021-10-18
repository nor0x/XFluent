using System;
using System.Globalization;
using Xamarin.Forms;

namespace XFluent
{
    public class RandomColorConverter : IValueConverter
    {
        static Random Generator = new Random();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.FromHex(String.Format("#{0:X6}", Generator.Next(0x1000000)));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

