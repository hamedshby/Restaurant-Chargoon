using Microsoft.EntityFrameworkCore;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Repositories;
using RestaurantChargoon.Infrastructure.EF.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantChargoon.Infrastructure.EF.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
	{
		private readonly RestaurantDbContext _context;

		public GenericRepository(RestaurantDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			var result = await _context.Set<T>().ToListAsync();
			return result;
		}

		public async Task<T> GetByIdAsync(int id)
		{
			var result = await _context.Set<T>().FindAsync(id);
			return result;
		}


		public async Task<int> GetCountAsync()
		{
			var result = await _context.Set<T>().CountAsync();
			return result;
		}

		public async Task CreateAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
		}


		public void Update(T entity)
		{
			_context.Set<T>().Update(entity);
		}


		public void Delete(T entity)
		{
			_context.Set<T>().Remove(entity);
		}

	}
}
