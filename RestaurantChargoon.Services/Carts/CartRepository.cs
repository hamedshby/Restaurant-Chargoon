using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;
using RestaurantChargoon.Domain.Entities;

namespace RestaurantChargoon.Services.Carts
{
    public class CartRepository : ICartRepository
	{
		private readonly IUnitOfWork _unit;
		Cart cart;
		public CartRepository(IUnitOfWork unit)
		{
			cart = new Cart();
			_unit = unit;
		}

		public Cart CreateUserCart(int foodId, int userId, int restaurantId)
		{
			Food food = _unit.Food.GetById(foodId);
			string restaurantName = _unit.Restaurant.GetById(restaurantId).Name;
			int count = 1;
			if (cart.FactorDetails != null)
			{
				var factordetail = cart.FactorDetails.FirstOrDefault(c => c.FoodId.Equals(foodId));
				if (factordetail != null)
					count = factordetail.Count;
			}

			var factorDetails = new List<FactorDetail>()
			{
				new FactorDetail() {
				FoodName = food.Name,
				FoodId = food.Id,
				Price = food.Price,
				FoodType = food.FoodType,
				Count=count
				}
			};
			Cart newcart = new Cart()
			{
				UserId = userId,
				RestaurantId = restaurantId,
				FactorDetails = factorDetails,
				RestaurantName = restaurantName
			};
			return newcart;
		}


		public void Add(Cart newCart)
		{
			var factorDetail = newCart.FactorDetails.Single();
			if (cart.UserId == 0)
			{
				cart.RestaurantId = newCart.RestaurantId;
				cart.UserId = newCart.UserId;
				factorDetail.Count = 1;
				cart.FactorDetails = new List<FactorDetail>() { factorDetail };
			}
			else
			{
				foreach (FactorDetail fd in cart.FactorDetails)
				{
					if (fd.FoodId == factorDetail.FoodId)
					{
						factorDetail.Count += 1;
						cart.FactorDetails.Remove(fd);
						break;
					}

				}
				cart.FactorDetails.Add(factorDetail);

			}
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
