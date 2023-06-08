using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;

namespace RestaurantChargoon.Services.Carts
{
	public class CartService //: InMemoryRepository<Cart>
	{
		Cart cart;
		public CartService()
		{
			cart = new Cart();
		}

		public Cart GetfakeCart()
		{
			var f1 = new List<FactorDetail>{
				new FactorDetail {Id=1, FoodName = "food1", Price = 10, FoodType = FoodType.Salad }
			};

			Cart cart2 = new Cart()
			{
				RestaurantId = 1,
				UserId = 1,
				FactorDetails= f1
			};
			
				
			cart2.FactorDetails.Add(new FactorDetail {Id=2, FoodName = "food2", Price = 20, FoodType = FoodType.Appetizer });
			return cart2;
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

		public Cart RemoveFactorDetail(Cart cart,int factorDetailId)
		{
			FactorDetail factorDetail = cart.FactorDetails.FirstOrDefault(c => c.Id == factorDetailId);
			cart.FactorDetails.Remove(factorDetail);
			return cart;
		}

		public Cart Get()
		{
			return cart;
		}
	}
}
