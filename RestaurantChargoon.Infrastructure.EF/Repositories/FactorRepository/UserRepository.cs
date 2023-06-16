using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;
using System.Linq;

namespace RestaurantChargoon.Infrastructure.EF.Repositories
{
	public class UserRepository : GenericRepository<User>, IUserRepository
	{
		public User GetByNationalCode(string nationalCode)
		{
			var user = Get(c => c.NationalCode.Equals(nationalCode)).FirstOrDefault();
			return user;
		}

		public User CheckUserPassword(string nationalCode, string password)
		{
			var user = Get(c => c.NationalCode.Equals(nationalCode) & c.Password.Equals(password)).FirstOrDefault();
			return user;
		}
	}
}
