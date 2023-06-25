
namespace RestaurantChargoon.Domain.Contracts
{
	public interface IUnitOfWork : IDisposable
	{
		IFactorDetailRepository FactorDetail { get; }
		IUserRepository User { get; }
		IRestaurantRepository Restaurant { get; }
		IFactorRepository Factor { get; }
		IFoodRepository Food { get; }

	}
}
