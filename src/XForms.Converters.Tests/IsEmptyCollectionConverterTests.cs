using System;
using NUnit.Framework;
using System.Globalization;
using System.Collections.Generic;
using System.Collections;

namespace XForms.Converters.Tests
{
	[TestFixture]
	public class IsEmptyCollectionConverterTests
	{
		private IsEmptyCollectionConverter _converter;
		private IList _emptyList;
		private IList _fillList;

		[SetUp]
		public void SetUp()
		{
			_converter = new IsEmptyCollectionConverter();

			_emptyList = new List<string>();
			_fillList = new List<string>{ "a", "b" };
		}

		public void ConvertEmptyCollectionTest()
		{
			var resultValue = _converter.Convert(_emptyList, typeof(IList), null, CultureInfo.CurrentCulture);

			Assert.AreEqual(true, resultValue);
		}

		public void ConvertFillCollectionTest()
		{
			var resultValue = _converter.Convert(_fillList, typeof(IList), null, CultureInfo.CurrentCulture);

			Assert.AreEqual(false, resultValue);
		}


		public void ConvertBackEmptyCollectionTest()
		{
			var resultValue = _converter.ConvertBack(_emptyList, typeof(IList), null, CultureInfo.CurrentCulture);

			Assert.AreEqual(true, resultValue);
		}

		public void ConvertBackFillCollectionTest()
		{
			var resultValue = _converter.ConvertBack(_fillList, typeof(IList), null, CultureInfo.CurrentCulture);

			Assert.AreEqual(false, resultValue);
		}
	}
}

