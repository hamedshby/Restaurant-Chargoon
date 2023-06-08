using FluentResults;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Infrastructure.EF.Repositories;
using RestaurantChargoon.Services.CommonServices;

namespace RestaurantChargoon.Services.Factors
{
	public class FactorService : BaseService<Factor>
	{
		protected GenericRepository<Factor> factorRepository;
		protected GenericRepository<FactorDetail> factorDetailRepository;

		public FactorService()
		{
			factorRepository = new GenericRepository<Factor>();
			factorDetailRepository = new GenericRepository<FactorDetail>();
		}



	}
}
