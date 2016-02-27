using System.Globalization;
using NUnit.Framework;
using XForms.Converters.Tests.Mocks;

namespace XForms.Converters.Tests
{
	[TestFixture]
	public class ValueConverterGroupTests
	{
		[TestCase("Value")]
		public void ConvertTest(object value)
		{
			var converterGroup = new ValueConverterGroup();

			converterGroup.Add(new MockConverter());
			converterGroup.Add(new MockConverter());
			converterGroup.Add(new MockConverter());

			var result = converterGroup.Convert(value, typeof(string), null, CultureInfo.CurrentCulture);

			var correctValue = $"{MockConverter.Tag}{MockConverter.Tag}{MockConverter.Tag}{value.ToString()}";

			Assert.AreEqual(correctValue, result);
		}
	}
}
