using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using FluentResults;
using System.Xml.Linq;
using System.Diagnostics;

namespace RestaurantChargoon.Services.Foods
{
	public class FoodBuilder
	{
		private readonly Result<Food> foodResult = new Result<Food>();
		private readonly Food food = new Food();

		public FoodBuilder GetName(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				foodResult.WithError("لطفا نام را وراد کنید");
			}
			else
				food.Name = name;
			return this;
		}

		public FoodBuilder GetPrice(string price)
		{
			if (string.IsNullOrEmpty(price))
				foodResult.WithError("لطفا مبلغ را وراد کنید");
			else
				food.Price = decimal.Parse(price);
			return this;
		}

		public FoodBuilder GetFoodType(FoodType foodType)
		{
			if (foodType == 0)
				foodResult.WithError("لطفا نوع غذا را وراد کنید");
			else
				food.FoodType = foodType;
			return this;
		}

		public Result<Food> Build()
		{
			if (foodResult.IsSuccess)
				foodResult.WithValue(food);
			return foodResult;
		}
	}


}
