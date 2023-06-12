using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.Foods;

namespace RestaurantChargoon.Services.Carts
{
	public class CartService //: InMemoryRepository<Cart>
	{
		private readonly FoodService foodService;
		Cart cart;
		public CartService()
		{
			cart = new Cart();
			foodService = new FoodService();
		}


		public Cart CreateUserCart(int foodId, int userId, int restaurantId)
		{
			Food food = foodService.GetById(foodId);
			var factorDetails = new List<FactorDetail>()
			{
				new FactorDetail() {
				FoodName = food.Name,
				Price = food.Price,
				FoodType = food.FoodType
				}
			};
			Cart cart = new Cart()
			{
				UserId = userId,
				RestaurantId = restaurantId,
				FactorDetails = factorDetails
			};
			return cart;
		}


		public void Add(Cart newCart)
		{
			var factorDetail = newCart.FactorDetails.Single();
			if (cart.UserId == 0)
			{
				cart.RestaurantId = newCart.RestaurantId;
				cart.UserId = newCart.UserId;
				cart.FactorDetails = new List<FactorDetail>() { factorDetail };
			}
			else
				cart.FactorDetails.Add(factorDetail);
		}

		public Cart RemoveFactorDetail(Cart cart, int factorDetailId)
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
