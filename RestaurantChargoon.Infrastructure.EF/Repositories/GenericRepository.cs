using FluentResults;
using Microsoft.Data.SqlClient;
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

		public IEnumerable<T> Get(Func<T, bool> predicate = null)
		{
			var query = _context.Set<T>().AsQueryable();
			if (predicate != null)
			{
				query = query.Where(predicate).AsQueryable();
			}
			var result = query.ToList();
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

		public async Task<Result<int>> Create(T entity)
		{
			_context.Set<T>().Add(entity);
			var result = await Save();
			return result;
		}


		public async Task<Result<int>> Update(T entity)
		{
			_context.Set<T>().Update(entity);
			var result = await Save();
			return result;
		}


		public async Task<Result<int>> Delete(T entity)
		{
			_context.Set<T>().Remove(entity);
			var result = await Save();
			return result;
		}

		public async Task<Result<int>> Save()
		{
			Result<int> result = new Result<int>();
			try
			{
				result = await _context.SaveChangesAsync();
				result.WithSuccess("عملیات با موفقیت انجام گردید");
				return result;
			}
			catch (SqlException ex)
			{
				return result.WithError("عملیات با خطا مواجه گردید");
			}
		}
	}
}
