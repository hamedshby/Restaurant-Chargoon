using FluentResults;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Infrastructure.EF.Repositories;
 
namespace RestaurantChargoon.Services.Restaurants
{
    public class RestaurantService
    {
        private GenericRepository<RestaurantChargoon.Domain.Entities.Restaurant> repository;
        public RestaurantService()
        {
            this.repository = new GenericRepository<RestaurantChargoon.Domain.Entities.Restaurant>();
        }
        public async Task<Result<int>> Add(Restaurant restaurant)
        {
            repository.Create(restaurant);
			var result = await Save();
			return result;
		}

        public async Task<Result<int>> Save()
        {
            return await repository.Save();
        }
    }
}
