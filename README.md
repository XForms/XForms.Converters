# XForms.Converters
Converters for Xamarin.Forms

| Name            | Input type | Output type |
|:---------------|:----------------:|:---------:|
| InverseBoolConverter | `bool` | `bool` |
| IsEmptyConverter | `string` | `bool` |
| IsEmptyCollectionConverter | `ICollection` | `bool` |

## How to use

Add namespace on your page:
```
xmlns:converters="clr-namespace:XForms.Converters;assembly=XForms.Converters"
```

Add converters to resources:
```xml
<ResourceDictionary>

	<!-- Converters -->
	<converters:InverseBoolConverter x:Key="InverseBool" />
	<!-- ... -->
	
</ResourceDictionary>
```

Use on page:
```xml
<Label IsVisible="{Binding IsEnabled, Converter={StaticResource InverseBool}}" Text="XForms" />
```

---

&copy; 2016 Yauheni Pakala | MIT
