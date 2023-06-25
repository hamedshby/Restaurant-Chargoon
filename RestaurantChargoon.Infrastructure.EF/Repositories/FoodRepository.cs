using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;

namespace RestaurantChargoon.Infrastructure.EF.Repositories
{
    public class FoodRepository : GenericRepository<Food>, IFoodRepository
    {

    }
}
