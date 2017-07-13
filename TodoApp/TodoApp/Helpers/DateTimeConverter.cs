﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace TodoApp.Helpers
{
    public class DateTimeConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var date = (DateTime)value;
            return date.ToString("dd/MM/yyyy hh:mm:ss");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
