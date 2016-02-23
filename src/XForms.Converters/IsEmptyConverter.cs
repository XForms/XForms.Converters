using System;
using System.Globalization;
using Xamarin.Forms;

namespace XForms.Converters
{
	public class IsEmptyConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return IsEmpty(value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return IsEmpty(value);
		}

		protected virtual bool IsEmpty(object value)
		{
			return string.IsNullOrEmpty(value as string);
		}
	}
}
