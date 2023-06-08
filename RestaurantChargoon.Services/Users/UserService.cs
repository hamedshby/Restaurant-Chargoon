using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.CommonServices;

namespace RestaurantChargoon.Services.Users
{
	public class UserService: BaseService<User>
	{
		
		public User GetByNationalCode(string nationalCode)
		{
			var user = repository.Get(c => c.NationalCode.Equals(nationalCode)).FirstOrDefault();
			return user;
		}

		public User CheckUserPassword(string nationalCode,string password)
		{
			var user = repository.Get(c => c.NationalCode.Equals(nationalCode)& c.Password.Equals(password)).FirstOrDefault();
			return user;
		}
	}
}
