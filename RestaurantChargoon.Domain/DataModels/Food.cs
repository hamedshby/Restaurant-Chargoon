using RestaurantChargoon.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantChargoon.Domain.DataModels
{
	public class Food : BaseEntity, IDataModel
	{
		[Display(Name = "")]
		[MaxLength(50, ErrorMessage = "تعداد کاراکترهای {1} باید حداکثر {0} حرف باشد")]
		[MinLength(2, ErrorMessage = "تعداد کاراکترهای {1} باید حداقل {0} حرف باشد")]
		public string Name { get; set; }

		[Column(TypeName = "decimal(18,0)")]
		[Display(Name = "مبلغ")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
		public decimal Price { get; set; }

		[Column(TypeName = "nvarchar(50)")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
		public FoodType FoodType { get; set; }
		public int RestaurantId { get; set; }
		public Restaurant Restaurant { get; set; }
		public bool IsDeleted { get; set; }
	}

}