using System;
using System.Globalization;
using Xamarin.Forms;

namespace XForms.Converters.Tests.Mocks
{
	public class MockConverter : IValueConverter
	{
		public const string Tag = "Mock";

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return Tag + value.ToString();
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
