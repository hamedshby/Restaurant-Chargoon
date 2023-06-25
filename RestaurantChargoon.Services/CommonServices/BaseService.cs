using FluentResults;
using RestaurantChargoon.Domain.DataModels;
using RestaurantChargoon.Infrastructure.EF.Repositories;

namespace RestaurantChargoon.Services.CommonServices
{
    public class BaseService<T> where T : BaseEntity
	{
		protected GenericRepository<T> repository;

		public BaseService()
		{
			repository = new GenericRepository<T>();
		}


		public async Task<Result<int>> AddAsync(T entity)
		{
			var result = await repository.CreateAsync(entity);
			return result;
		}

		public async Task<Result<int>> UpdateAsync(T entity)
		{
			var result = await repository.UpdateAsync(entity);
			return result;
		}
		//public async Task<Result<int>> DeleteAsync(T entity)
		//{
		//	var result = await repository.Delete(entity);
		//	return result;
		//}
		public IEnumerable<T> GetAll()
		{
			return repository.GetAll();
		}

		public T GetById(int id)
		{
			return repository.GetById(id);
		}

		public IEnumerable<T> Get(Func<T, bool> predicate = null)
		{
			return repository.Get(predicate);
		}
	}
}
