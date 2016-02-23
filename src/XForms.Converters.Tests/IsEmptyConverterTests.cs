using System;
using NUnit.Framework;
using System.Globalization;

namespace XForms.Converters.Tests
{
	[TestFixture]
	public class IsEmptyConverterTests
	{
		private IsEmptyConverter _converter;

		[SetUp]
		public void SetUp()
		{
			_converter = new IsEmptyConverter();
		}

		[TestCase("", true)]
		[TestCase(null, true)]
		[TestCase("asd", false)]
		public void ConvertTest(object value, object correctValue)
		{
			var resultValue = _converter.Convert(value, value?.GetType(), null, CultureInfo.CurrentCulture);

			Assert.AreEqual(correctValue, resultValue);
		}

		[TestCase("", true)]
		[TestCase(null, true)]
		[TestCase("asd", false)]
		public void ConvertBackTest(object value, object correctValue)
		{
			var resultValue = _converter.ConvertBack(value, value?.GetType(), null, CultureInfo.CurrentCulture);

			Assert.AreEqual(correctValue, resultValue);
		}
	}
}

