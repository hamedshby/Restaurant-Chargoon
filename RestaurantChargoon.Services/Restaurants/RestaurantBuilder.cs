using FluentResults;
using RestaurantChargoon.Domain.Entities;

namespace RestaurantChargoon.Services.Restaurants
{
	public class RestaurantBuilder
	{
		private readonly Result<Restaurant> RestaurantResult = new Result<Restaurant>();
		private readonly Restaurant restaurant = new Restaurant();
		public RestaurantBuilder GetName(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				RestaurantResult.WithError("لطفا نام را وراد کنید");
			}
			else
				restaurant.Name = name;
			return this;
		}

		public RestaurantBuilder GetStartTime(string startTime)
		{
			if (string.IsNullOrEmpty(startTime))
			{
				RestaurantResult.WithError("لطفا ساعت شروع فعالیت را وراد کنید");
			}
			else
				restaurant.StartTime = startTime;
			return this;
		}
		public RestaurantBuilder GetEndTime(string endTime)
		{
			if (string.IsNullOrEmpty(endTime))
			{
				RestaurantResult.WithError("لطفا ساعت پایان فعالیت را وراد کنید");
			}
			else
				restaurant.EndTime = endTime;
			return this;
		}
		public RestaurantBuilder GetAddress(string address)
		{
			if (string.IsNullOrEmpty(address))
			{
				RestaurantResult.WithError("لطفا آدرس فروشگاه را وراد کنید");
			}
			else
				restaurant.Address = address;
			return this;
		}
		public Result<Restaurant> Build()
		{
			if (RestaurantResult.IsSuccess)
				RestaurantResult.WithValue(restaurant);
			return RestaurantResult;
		}
	}
}
