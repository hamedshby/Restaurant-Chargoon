using FluentResults;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Infrastructure.EF.Repositories;
 
namespace RestaurantChargoon.Services.Restaurant
{
    public class RestaurantService
    {
        private GenericRepository<RestaurantChargoon.Domain.Entities.Restaurant> repository;
        public RestaurantService()
        {
            this.repository = new GenericRepository<RestaurantChargoon.Domain.Entities.Restaurant>();
        }
        public void Add(RestaurantChargoon.Domain.Entities.Restaurant restaurant)
        {
            repository.Create(restaurant);
        }

        public async Task<Result<int>> Save()
        {
            return await repository.Save();
        }
    }
}
