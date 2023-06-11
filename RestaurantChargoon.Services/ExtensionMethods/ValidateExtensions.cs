using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace RestaurantChargoon.Services.ExtensionMethods
{
	public static class ValidateExtensions
	{
		public static void CheckMinLength<T>(this T obj)
		{
			Type type = typeof(T);
			var prop = type.GetProperties();
			foreach (var property in prop)
			{
				MinLengthAttribute? propertyLength = property.GetCustomAttribute(typeof(MinLengthAttribute)) as MinLengthAttribute;

				if (propertyLength != null)
				{
					int len = ((string)property.GetValue(obj)).Length;
					if(len<propertyLength.Length)
					{
						string msg = propertyLength.ErrorMessage;
						msg= msg.Replace("{0}",propertyLength.Length.ToString());
					}
				}
			}
		}

		public static void CheckMaxLength<T>(this T obj)
		{
			Type type = typeof(T);
			var prop = type.GetProperties();
			foreach (var property in prop)
			{
				MaxLengthAttribute? propertyLength = property.GetCustomAttribute(typeof(MaxLengthAttribute)) as MaxLengthAttribute;

				if (propertyLength != null)
				{
					int len = ((string)property.GetValue(obj)).Length;


				}
			}
		}
	}
}
