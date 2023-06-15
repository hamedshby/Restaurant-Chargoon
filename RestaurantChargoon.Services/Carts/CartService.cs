using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Foods;
using RestaurantChargoon.Services.Restaurants;

namespace RestaurantChargoon.Services.Carts
{
    public class CartService
    {
        private readonly FoodService foodService;
        private readonly RestaurantService restaurantService;
        Cart cart;
        public CartService()
        {
            cart = new Cart();
            foodService = new FoodService();
            this.restaurantService = new RestaurantService();
        }

        public Cart CreateUserCart(int foodId, int userId, int restaurantId)
        {
            Food food = foodService.GetById(foodId);
            string restaurantName = restaurantService.GetById(restaurantId).Name;
            int count = 1;
            if (cart.FactorDetails != null)
            {
                var factordetail = cart.FactorDetails.FirstOrDefault(c => c.FoodId.Equals(foodId));
                if(factordetail != null) 
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
