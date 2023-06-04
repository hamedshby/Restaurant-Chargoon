using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.BaseServices;

namespace RestaurantChargoon.Services.Users
{
	public class UserService: BaseService<User>
	{
		
		public User GetByNationalCode(string nationalCode)
		{
			var user = repository.Get(c => c.NationalCode.Equals(nationalCode)).FirstOrDefault();
			return user;
		}
	}
}
