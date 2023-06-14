using RestaurantChargoon.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace RestaurantChargoon.Domain.Entities
{
	public class Food : BaseEntity, IDataModel
	{
		[Display(Name = "")]
		[MaxLength(50, ErrorMessage = "تعداد کاراکترهای {1} باید حداکثر {0} حرف باشد")]
		[MinLength(2, ErrorMessage = "تعداد کاراکترهای {1} باید حداقل {0} حرف باشد")]
		public string Name { get; set; }

[Display(Name = "")]
		public decimal Price { get; set; }
		public FoodType FoodType { get; set; }
		public int RestaurantId { get; set; }
		public Restaurant Restaurant { get; set; }
		public bool IsDeleted { get; set; }
	}

}