using RestaurantChargoon.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantChargoon.Domain.Entities
{
	public class User : BaseEntity, IDataModel
	{
		[DisplayName("نام")]
		[MaxLength(50,ErrorMessage = "تعداد کاراکترهای ورودی باید حداکثر {0} حرف باشد")]
		[MinLength(2,ErrorMessage = "تعداد کاراکترهای ورودی باید حداقل {0} حرف باشد")]
		public string Name { get; set; }
		public string LastName { get; set; }
		public string NationalCode { get; set; }
		public string Address { get; set; }
		public string Password { get; set; }
		public bool IsDeleted { get; set; }
		public UserType UserType { get; set; }
	}

}