using RestaurantChargoon.Domain.DataModels;

namespace RestaurantChargoon.Domain.Contracts
{
	public interface IFactorDetailRepository : IGenericRepository<FactorDetail>
	{
		decimal SumOfFactor(Factor factor);
	}
}
