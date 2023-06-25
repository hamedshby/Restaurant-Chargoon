using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;

namespace RestaurantChargoon.Infrastructure.EF.Repositories
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {

    }
}
