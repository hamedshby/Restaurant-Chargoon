using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Infrastructure.EF.Context;

namespace RestaurantChargoon.Services.CommonServices
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly RestaurantDbContext _context;
		public IFactorDetailRepository FactorDetail { get; }

		public IUserRepository User { get; }

		public IRestaurantRepository Restaurant { get; }

		public IFactorRepository Factor { get; }

		public IFoodRepository Food { get; }

		public UnitOfWork(IFactorDetailRepository factorDetail, RestaurantDbContext context, IUserRepository user, IRestaurantRepository restaurant, 
			IFactorRepository factor, IFoodRepository food)
		{
			FactorDetail = factorDetail;
			_context = context;
			User = user;
			Restaurant = restaurant;
			Factor = factor;
			Food = food;
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
