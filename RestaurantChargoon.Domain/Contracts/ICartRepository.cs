using RestaurantChargoon.Domain.Entities;

namespace RestaurantChargoon.Domain.Contracts
{
	public interface ICartRepository
	{
		Cart CreateUserCart(int foodId, int userId, int restaurantId);
		void Add(Cart newCart);
		Cart RemoveFactorDetail(Cart cart, int factorDetailId);
		Cart Get();
	}

}


