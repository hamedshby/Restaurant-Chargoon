using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;
using System.Linq;

namespace RestaurantChargoon.Infrastructure.EF.Repositories
{
    public class FactorDetailRepository : GenericRepository<FactorDetail>, IFactorDetailRepository
    {
        public decimal SumOfFactor(Factor factor)
        {
            var factorDetails = Get(c => c.FactorId == factor.Id).ToList();
            var totalPrice = factorDetails.Sum(c => c.Price * c.Count);
            return totalPrice;
        }
    }
}
