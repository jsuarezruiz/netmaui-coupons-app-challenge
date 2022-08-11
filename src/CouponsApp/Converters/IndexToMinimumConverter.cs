﻿using System.Globalization;

namespace CouponsApp.Converters
{
    public class IndexToMinimumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int offset = 200;

            int itemHeight = 160;
            int index = (int)value - 1;

            return offset +  itemHeight * index;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
