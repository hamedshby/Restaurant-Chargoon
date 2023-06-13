using FluentResults;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.RegularExpressions;

namespace RestaurantChargoon.Services.ExtensionMethods
{
	public static class ValidateExtensions
	{
		public static Result<T> ModelState<T>(this T obj) where T : class
		{
			Result<T> result = new Result<T>();
			var attrresult = CheckMinLength(obj);
			if (attrresult.IsFailed)
			result.WithErrors(attrresult.Errors);			
			

			attrresult = CheckMaxLength(obj);
			if (attrresult.IsFailed)
				result.WithErrors(attrresult.Errors);

			attrresult = CheckRegex(obj);
			if (attrresult.IsFailed)
				result.WithErrors(attrresult.Errors);

			return result;
		}
		public static Result<T> CheckMinLength<T>(T obj) where T : class
		{
			Result<T> result = new Result<T>();
			Type type = typeof(T);
			var prop = type.GetProperties();
			foreach (var property in prop)
			{
				DisplayAttribute? display = property.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
				string displayName = string.Empty;
				if (display != null)
				{
					displayName = display.Name;
				}

				MinLengthAttribute? propertyLength = property.GetCustomAttribute(typeof(MinLengthAttribute)) as MinLengthAttribute;
				if (propertyLength != null)
				{
					int? len = ((string)property.GetValue(obj))?.Length;
					if (len < propertyLength.Length)
					{
						string msg = propertyLength.ErrorMessage;
						msg = msg.Replace("{0}", propertyLength.Length.ToString());
						msg = msg.Replace("{1}", displayName);
						result.WithError(msg);
					}
				}
			}
			return result;
		}

		public static Result<T> CheckMaxLength<T>(T obj)
		{
			Result<T> result = new Result<T>();
			Type type = typeof(T);
			var prop = type.GetProperties();
			foreach (var property in prop)
			{
				MaxLengthAttribute? propertyLength = property.GetCustomAttribute(typeof(MaxLengthAttribute)) as MaxLengthAttribute;

				if (propertyLength != null)
				{
					DisplayAttribute? display = property.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
					string displayName = string.Empty;
					if (display != null)
					{
						displayName = display.Name;
					}

					int? len = ((string)property.GetValue(obj))?.Length;
					if (len > propertyLength.Length)
					{
						string msg = propertyLength.ErrorMessage;
						msg = msg.Replace("{0}", propertyLength.Length.ToString());
						msg = msg.Replace("{1}", displayName);
						result.WithError(msg);
					}

				}
			}
			return result;
		}

		public static Result<T> CheckRegex<T>(T obj)
		{
			Result<T> result = new Result<T>();
			Type type = typeof(T);
			var prop = type.GetProperties();
			foreach (var property in prop)
			{
				RegularExpressionAttribute? entityProperty = property.GetCustomAttribute(typeof(RegularExpressionAttribute)) as RegularExpressionAttribute;

				if (entityProperty != null)
				{
					string? text = ((string)property.GetValue(obj)) ?? string.Empty;
					if (!(Regex.IsMatch(text, entityProperty.Pattern)))
					{
						string msg = entityProperty.ErrorMessage;
						result.WithError(msg);
					}
				}
			}
			return result;
		}
	}
}
