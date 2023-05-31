using FluentResults;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Infrastructure.EF.Repositories;

namespace RestaurantChargoon.Services.Users
{
	public class UserService
	{
		private GenericRepository<User> repository;

		public UserService()
		{
			this.repository = new GenericRepository<User>();
		}

		public void Add(User user)
		{
			repository.Create(user);
		}

		public async Task<Result<int>> Save()
		{
			return await repository.Save();
		}
	}
}
