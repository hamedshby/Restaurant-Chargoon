using RestaurantChargoon.Domain.Entities;
using FluentResults;

namespace RestaurantChargoon.Domain.Repositories
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		IEnumerable<T> GetAll();
		IEnumerable<T> Get(Func<T, bool> predicate);
		T GetById(int id);
		int GetCount();
		Task<Result<int>> Create(T entity);
		Task<Result<int>> Update(T entity);
		Task<Result<int>> Delete(T entity);
		Task<Result<int>> Save();
	}
}
