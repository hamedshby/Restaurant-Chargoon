using RestaurantChargoon.Domain.Entities;

namespace RestaurantChargoon.Domain.Repositories
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		Task<IEnumerable<T>> GetAllAsync();

		Task<T> GetByIdAsync(int id);

		Task<int> GetCountAsync();

		Task CreateAsync(T entity);

		void Update(T entity);
		void Delete(T entity);
	}
}
