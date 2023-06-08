using RestaurantChargoon.Domain.Enums;

namespace RestaurantChargoon.Domain.ModelDto.Factors
{
	public class FactorDto
	{
		public int RestaurantId { get; set; }
		public int UserId { get; set; }
		public string FoodName { get; set; }
		public decimal Price { get; set; }
		public FoodType FoodType { get; set; }
	}
}
