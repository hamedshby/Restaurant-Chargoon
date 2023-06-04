using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using FluentResults;

namespace RestaurantChargoon.Services.Foods
{
    public class FoodBuilder
    {
        private readonly Result<Food> foodResult ;
        private readonly Food food=new Food();

		public FoodBuilder GetName(string name)
        {         
            if(string.IsNullOrEmpty(name))
            {
                foodResult.WithError("نام را وراد کنید");
            }
            food.Name = name;
            return this;
        }

        public FoodBuilder GetPrice(string price)
        {
            food.Price=decimal.Parse(price);
            return this;
        }

        public FoodBuilder GetFoodType(FoodType foodType)
        {
            food.FoodType =foodType;
            return this;
        }
                
        public Result<Food> Build()
        {            
            return food;
        }
    }


}
