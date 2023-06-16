using RestaurantChargoon.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantChargoon.Domain.DataModels
{
	public class FactorDetail : BaseEntity
	{
		public int FactorId { get; set; }
		public Factor Factor { get; set; }

		[Column(TypeName = "nvarchar(50)")]
		public string FoodName { get; set; }

		public int FoodId { get; set; }

		public decimal Price { get; set; }
		public FoodType FoodType { get; set; }
		public int Count { get; set; }
	}
}
