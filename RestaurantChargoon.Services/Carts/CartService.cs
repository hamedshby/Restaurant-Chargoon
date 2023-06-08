using RestaurantChargoon.Domain.Entities;

namespace RestaurantChargoon.Services.Carts
{
	public class CartService //: InMemoryRepository<Cart>
	{
		Cart cart;
		public CartService()
		{
			cart = new Cart();
		}

		public void Add(Cart newCart)
		{
			if (cart.UserId == 0)
			{
				cart.RestaurantId = newCart.RestaurantId;
				cart.UserId = newCart.UserId;
			}
			cart.FactorDetails.Add(newCart.FactorDetails.Single());
		}

		public Cart Get()
		{
			return cart;
		}
	}
}
