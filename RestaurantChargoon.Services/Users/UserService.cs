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
        public void Update(User user)
        {
            repository.Update(user);
        }

        public async Task<Result<int>> Save()
        {
            return await repository.Save();
        }
        public IEnumerable<User> GetUsers() { return repository.GetAll(); }
        public User GetUser(int id)
        {
            return repository.GetById(id);
        }
    }
}
