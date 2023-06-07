using System.ComponentModel.DataAnnotations;

namespace RestaurantChargoon.Domain.Enums
{
	public enum FoodType
	{
        [Display(Name = "غذای اصلی")]
        MainCource =1,
		[Display(Name = "پیش غذا")]
		Appetizer = 2,
		[Display(Name = "نوشیدنی")]
		Beverage = 3,
		[Display(Name = "سالاد")]
		Salad = 4,
		[Display(Name = "دسر")]
		Dessert = 5
	}
}