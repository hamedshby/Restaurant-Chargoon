using System.ComponentModel.DataAnnotations;

namespace RestaurantChargoon.Domain.Enums
{
	public enum FoodType
	{
		[Display(Name = "پیش غذا")]
		Appetizer = 1,
		[Display(Name = "نوشیدنی")]
		Beverage = 2,
		[Display(Name = "سالاد")]
		Salad = 3,
		[Display(Name = "دسر")]
		Dessert = 4
	}
}