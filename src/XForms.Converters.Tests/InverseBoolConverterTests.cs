using System;
using System.Globalization;
using NUnit.Framework;

namespace XForms.Converters.Tests
{
	[TestFixture]
	public class InverseBoolConverterTests
	{
		private InverseBoolConverter _converter;

		[SetUp]
		public void SetUp()
		{
			_converter = new InverseBoolConverter();
		}

		[TestCase(true, false)]
		[TestCase(false, true)]
		public void ConvertTest(object value, object correctValue)
		{
			var resultValue = _converter.Convert(value, value.GetType(), null, CultureInfo.CurrentCulture);

			Assert.AreEqual(correctValue, resultValue);
		}

		[TestCase(true, false)]
		[TestCase(false, true)]
		public void ConvertBackTest(object value, object correctValue)
		{
			var resultValue = _converter.ConvertBack(value, value.GetType(), null, CultureInfo.CurrentCulture);

			Assert.AreEqual(correctValue, resultValue);
		}
	}
}

