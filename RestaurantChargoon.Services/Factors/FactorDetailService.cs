using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.CommonServices;

namespace RestaurantChargoon.Services.Factors
{
	public class FactorDetailService : BaseService<FactorDetail>
	{
		public decimal SumOfFactor(int facotrId)
		{
			var totalPrice = repository.Get(c => c.FactorId == facotrId).Sum(c => c.Price);
			return totalPrice;
		}
	}
}
