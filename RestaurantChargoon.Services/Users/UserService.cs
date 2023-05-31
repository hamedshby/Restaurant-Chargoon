using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Repositories;
using RestaurantChargoon.Infrastructure.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantChargoon.Services.Users
{
	public class UserService
	{
		private readonly IGenericRepository<User> repository;

		public UserService(IGenericRepository<User> repository)
		{
			this.repository = repository;
		}

		public void Add(User user)
		{
			repository.CreateAsync(user).Wait();
		}
	}
}
