using RestaurantChargoon.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantChargoon.Domain.Entities
{
	public class User : BaseEntity, IDataModel
	{

		[MaxLength(50, ErrorMessage = "تعداد کاراکترهای ورودی باید حداکثر {0} حرف باشد")]
		[MinLength(2, ErrorMessage = "تعداد کاراکترهای ورودی باید حداقل {0} حرف باشد")]
		public string Name { get; set; }

		[MinLength(2, ErrorMessage = "تعداد کاراکترهای ورودی باید حداقل {0} حرف باشد")]
		[MaxLength(50, ErrorMessage = "تعداد کاراکترهای ورودی باید حداکثر {0} حرف باشد")]
		public string LastName { get; set; }

		[MinLength(2, ErrorMessage = "تعداد کاراکترهای ورودی باید حداقل {0} حرف باشد")]
		[MaxLength(50, ErrorMessage = "تعداد کاراکترهای ورودی باید حداکثر {0} حرف باشد")]
		public string NationalCode { get; set; }

[MinLength(2,ErrorMessage = "تعداد کاراکترهای ورودی باید حداقل {0} حرف باشد")]
		public string Address { get; set; }

		[RegularExpression(@"^[a-zA-Z0-9]{5,}$", ErrorMessage ="رمز عبور باید حداقل 5 کاراکتر و شامل حرف و عدد باشد")]
		public string Password { get; set; }
		public bool IsDeleted { get; set; }
		public UserType UserType { get; set; }
	}

}