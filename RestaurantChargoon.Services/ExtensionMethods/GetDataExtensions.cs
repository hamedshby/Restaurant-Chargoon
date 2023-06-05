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
	}
}
