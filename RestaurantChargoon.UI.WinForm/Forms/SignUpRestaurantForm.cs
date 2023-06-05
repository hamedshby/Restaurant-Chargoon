using FluentResults;
using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class SignUpRestaurantForm : Form
    {
        private readonly UserService userService;
        private readonly RestaurantService restaurantService;

        public SignUpRestaurantForm()
        {
            InitializeComponent();
            this.userService = new UserService();
            this.restaurantService = new RestaurantService();

        }


        private async void RegisterRestaurant_Click(object sender, EventArgs e)
        {
            var ResResult = GetRestaurantResult();
            if (ResResult.IsFailed)
            {
                ResResult.PrintResultMessages();
                return;
            }

            var restaurant = ResResult.Value;
            restaurant.UserId = Program.userLogin.Id;
            var result = await restaurantService.Add(restaurant);
            result.PrintResultMessages();
            if (result.IsSuccess)
            {
                RestaurantDashboardForm restaurantDashboard = new RestaurantDashboardForm();
                restaurantDashboard.Show();
                this.Close();

            }

        }
        public Result<Restaurant> GetRestaurantResult()
        {
            var result = new RestaurantBuilder()
                .GetName(ResturantNameTextBox.Text)
                .GetAddress(AddressTextBox.Text)
                .GetStartTime(FromTimePicker.Text)
                .GetEndTime(ToTimePicker.Text)
                .Build();
            return result;
        }
    }
}
