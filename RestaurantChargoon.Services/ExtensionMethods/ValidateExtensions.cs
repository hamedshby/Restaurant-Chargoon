using FluentResults;
using RestaurantChargoon.Domain.DataModels;
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
			Type type = typeof(T);
			var prop = type.GetProperties();
			foreach (var property in prop)
			{
				var attrResult = obj.CheckRequired(property);
				if (attrResult.IsFailed)
					result.WithErrors(attrResult.Errors);

				if (attrResult.IsSuccess)
				{
					attrResult = obj.CheckMinLength(property);
					if (attrResult.IsFailed)
						result.WithErrors(attrResult.Errors);

					attrResult = obj.CheckMaxLength(property);
					if (attrResult.IsFailed)
						result.WithErrors(attrResult.Errors);
				}
				attrResult = obj.CheckRegex(property);
				if (attrResult.IsFailed)
					result.WithErrors(attrResult.Errors);
			}
			return result;
		}

		private static Result<T> CheckMinLength<T>(this T obj, PropertyInfo property) where T : class
		{
			Result<T> result = new Result<T>();

			DisplayAttribute? display = property.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
			string displayName = string.Empty;
			if (display != null)
			{
				displayName = display.Name;
			}

			MinLengthAttribute? propertyLength = property.GetCustomAttribute(typeof(MinLengthAttribute)) as MinLengthAttribute;
			if (propertyLength != null)
			{
				string value = ((string)property.GetValue(obj));
				int? len = ((string)property.GetValue(obj))?.Length;
				if (!string.IsNullOrEmpty(value) & len < propertyLength.Length)
				{
					string msg = propertyLength.ErrorMessage;
					msg = msg.Replace("{0}", propertyLength.Length.ToString());
					msg = msg.Replace("{1}", displayName);
					result.WithError(msg);
				}
			}
			return result;
		}

		private static Result<T> CheckMaxLength<T>(this T obj, PropertyInfo property)
		{
			Result<T> result = new Result<T>();

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
			return result;
		}

		private static Result<T> CheckRegex<T>(this T obj, PropertyInfo property)
		{
			Result<T> result = new Result<T>();

			RegularExpressionAttribute? entityProperty = property.GetCustomAttribute(typeof(RegularExpressionAttribute)) as RegularExpressionAttribute;

			if (entityProperty != null)
			{
				string? text = ((string)property.GetValue(obj)) ?? string.Empty;
				if (!string.IsNullOrEmpty(text) & !(Regex.IsMatch(text, entityProperty.Pattern)))
				{
					string msg = entityProperty.ErrorMessage;
					result.WithError(msg);
				}
			}
			return result;
		}

		private static Result<T> CheckRequired<T>(this T obj, PropertyInfo property)
		{
			Result<T> result = new Result<T>();
			RequiredAttribute? propertyLength = property.GetCustomAttribute(typeof(RequiredAttribute)) as RequiredAttribute;

			if (propertyLength != null)
			{
				DisplayAttribute? display = property.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;

				string displayName = property.Name;
				if (display != null)
					displayName = display.Name;

				string value = (property.GetValue(obj).ToString());
				if (string.IsNullOrEmpty(value) || value == "0")
				{
					string msg = propertyLength.ErrorMessage;
					msg = msg.Replace("{0}", displayName);
					result.WithError(msg);
				}
			}
			return result;
		}


		public static bool CheckTimeToOrder(this Restaurant restaurant)
		{
			int.TryParse(restaurant.StartTime.Replace(":", ""), out int startTime);
			int.TryParse(restaurant.EndTime.Replace(":", ""), out int endTime);
			int nowTime = int.Parse(DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00"));
			if (startTime == 0 && endTime == 0)
				return true;
			if (nowTime > startTime & nowTime < endTime)
				return true;
			return false;
		}
	}
}
