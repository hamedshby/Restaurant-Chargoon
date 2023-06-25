using FluentResults;
using RestaurantChargoon.Domain.DataModels;

namespace RestaurantChargoon.Domain.Contracts
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Func<T, bool> predicate);
        T GetById(int id);
        int GetCount();
        Task<Result<int>> CreateAsync(T entity);
        Task<Result<int>> UpdateAsync(T entity);
        Task<Result<int>> Delete(T entity);
        Task<Result<int>> Save();
    }
}
