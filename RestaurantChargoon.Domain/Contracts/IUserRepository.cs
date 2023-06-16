using RestaurantChargoon.Domain.DataModels;

namespace RestaurantChargoon.Domain.Contracts
{
	public interface IUserRepository : IGenericRepository<User>
	{
		User GetByNationalCode(string nationalCode);
		User CheckUserPassword(string nationalCode, string password);
	}
}
