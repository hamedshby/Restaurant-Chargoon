using FluentResults;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Repositories;
using RestaurantChargoon.Infrastructure.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantChargoon.Infrastructure.EF.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
	{
		private RestaurantDbContext _context;

		public GenericRepository()
		{
			_context = new RestaurantDbContext();
		}

		public IEnumerable<T> GetAll()
		{
			var result = _context.Set<T>().ToList();
			return result;
		}

		public T GetById(int id)
		{
			var result = _context.Set<T>().Find(id);
			return result;
		}


		public int GetCount()
		{
			var result = _context.Set<T>().Count();
			return result;
		}

		public void Create(T entity)
		{
			_context.Set<T>().Add(entity);
		}


		public void Update(T entity)
		{
			_context.Set<T>().Update(entity);
		}


		public void Delete(T entity)
		{
			_context.Set<T>().Remove(entity);
		}

		public async Task<Result<int>> Save()
		{
			Result<int> result=new Result<int>();
			try
			{
				result =await _context.SaveChangesAsync();
				return result;
			}
			catch(Exception ex)
			{
				return result.WithError(ex.Message);
			}
		}
	}
}
