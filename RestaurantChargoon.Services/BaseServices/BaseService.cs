using FluentResults;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Infrastructure.EF.Repositories;
using System.ComponentModel.DataAnnotations;

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
			repository.Create(entity);
			var result = await Save();
			return result;
		}

		public async Task<Result<int>> Update(T entity)
		{
			repository.Update(entity);
			var result = await Save();
			return result;
		}

		public async Task<Result<int>> Save()
		{
			return await repository.Save();
		}
		
		public IEnumerable<T> GetAll()
		{
			return repository.GetAll();
		}

		public IEnumerable<T> Get(Func<T, bool> predicate = null)
		{
			return repository.Get(predicate);
		}

		public T GetById(int id)
		{
			return repository.GetById(id);
		}
	}
}
