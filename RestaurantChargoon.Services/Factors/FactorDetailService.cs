using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.CommonServices;

namespace RestaurantChargoon.Services.Factors
{
	public class FactorDetailService : BaseService<FactorDetail>
	{
		public decimal SumOfFactor(Factor factor)
		{
			var factorDetails=repository.Get(c=>c.FactorId==factor.Id).ToList();
			var totalPrice = factorDetails.Sum(c => c.Price * c.Count);
			return totalPrice;
		}
	}
}
