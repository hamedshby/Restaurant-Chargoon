using System.ComponentModel.DataAnnotations;
using System.Reflection;
using FluentResults;

namespace RestaurantChargoon.Services.ExtensionMethods
{
	public static class GetDataExtensions
	{
		public static string GetDisplayName(this Enum enumValue)
		{
			return enumValue.GetType()
							.GetMember(enumValue.ToString())
							.FirstOrDefault()?
							.GetCustomAttribute<DisplayAttribute>()
							?.GetName() ?? enumValue.ToString();
		}

		public static string GetResultErrors<T>(this Result<T> result)
		{
			string errors = string.Empty;
			foreach (var error in result.Errors)
			{
				errors += error.Message + Environment.NewLine;
			}
			return errors;
		}

	}
}
