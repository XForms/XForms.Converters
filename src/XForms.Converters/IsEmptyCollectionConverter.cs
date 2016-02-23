using System.Collections;

namespace XForms.Converters
{
	public class IsEmptyCollectionConverter : IsEmptyConverter
	{
		protected override bool IsEmpty(object value)
		{
			var collection = value as ICollection;
			return collection?.Count > 0;
		}
	}
}
