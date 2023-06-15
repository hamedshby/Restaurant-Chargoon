using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;

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

		public static string ToPersianDate(this DateTime date)
		{
			PersianCalendar pc = new PersianCalendar();
			string persiandate =
				pc.GetHour(date).ToString("00") + ":" + pc.GetMinute(date).ToString("00") + " " +
				pc.GetYear(date).ToString() + "/" +
				pc.GetMonth(date).ToString("00") + "/" + pc.GetDayOfMonth(date).ToString("00");
				
			return persiandate;
		}
	}
}
