using RestaurantChargoon.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantChargoon.Domain.DataModels
{
	public class User : BaseEntity, IDataModel
	{
		[Display(Name = "نام")]
		[MaxLength(50, ErrorMessage = "تعداد کاراکترهای {1} باید حداکثر {0} حرف باشد")]
		[MinLength(2, ErrorMessage = "تعداد کاراکترهای {1} باید حداقل {0} حرف باشد")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
		public string Name { get; set; }

		[Display(Name = "نام خانوادگی")]
		[MinLength(2, ErrorMessage = "تعداد کاراکترهای {1} باید حداقل {0} حرف باشد")]
		[MaxLength(50, ErrorMessage = "تعداد کاراکترهای {1} باید حداکثر {0} حرف باشد")]
		public string LastName { get; set; }

		[Display(Name = "کدملی")]
		[MinLength(10, ErrorMessage = "تعداد کاراکترهای {1} باید  {0} حرف باشد")]
		[MaxLength(10, ErrorMessage = "تعداد کاراکترهای {1} باید  {0} حرف باشد")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
		public string NationalCode { get; set; }

		[Display(Name = "آدرس")]
		[MinLength(2, ErrorMessage = "تعداد کاراکترهای {1} باید حداقل {0} حرف باشد")]
		public string Address { get; set; }

		[Display(Name = "رمز ورود")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
		[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d).{5,}$", ErrorMessage = "رمز عبور باید حداقل 5 کاراکتر و شامل حرف و عدد باشد")]
		[Column(TypeName = "nvarchar(50)")]
		public string Password { get; set; }
		public bool IsDeleted { get; set; }
		[Column(TypeName = "nvarchar(50)")]
		public UserType UserType { get; set; }
	}

}