using RestaurantChargoon.Domain.Enums;

namespace RestaurantChargoon.Domain.Entities
{
	public class FactorDetail:BaseEntity
	{
		public int FactorId { get; set;}
        public Factor Factor { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
		public FoodType FoodType { get; set; }
        public int count { get; set; }
    }
}
