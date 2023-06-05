using FluentResults;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Infrastructure.EF.Repositories;

namespace RestaurantChargoon.Services.BaseServices
{
	public class BaseService<T> where T : BaseEntity
	{
		protected GenericRepository<T> repository;

		public BaseService()
		{
			repository = new GenericRepository<T>();
		}


		public async Task<Result<int>> Add(T entity)
		{
			var result = await repository.Create(entity);
			return result;
		}

		public async Task<Result<int>> Update(T entity)
		{
			var result = await repository.Update(entity);
			return result;
		}

		public IEnumerable<T> GetAll()
		{
			return repository.GetAll();
		}

		public IEnumerable<T> Get(Func<T, bool> predicate = null)
		{
			return repository.Get(predicate);
		}
	}
}
