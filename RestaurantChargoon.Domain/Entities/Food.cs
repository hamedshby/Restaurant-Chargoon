using RestaurantChargoon.Domain.Enums;

namespace RestaurantChargoon.Domain.Entities
{
	public class Food : BaseEntity
	{
        public string Name { get; set; }
        public decimal Price { get; set; }
        public FoodType FoodType { get; set; }
		public Restaurant Restaurant { get; set; }
	}

}