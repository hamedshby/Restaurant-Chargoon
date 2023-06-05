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
        public SignUpRestaurantForm(string NationalCode)
        {
            InitializeComponent();
            this.userService = new UserService();
            this.restaurantService = new RestaurantService();
            this.NationalCodeTextBox.Text = NationalCode;
            this.NationalCodeTextBox.ReadOnly = true;

        }
        public string MyValue
        {
            get { return NationalCodeTextBox.Text; }
        }
        private async void RegisterRestaurant_Click(object sender, EventArgs e)
        {
            var ResResult = GetRestaurantResult();
            if (ResResult.IsFailed)
            {
                ResResult.PrintResultMessages();
                return;
            }
            else
            {
                var restaurant = ResResult.Value;
                restaurant.UserId = userService.GetByNationalCode(NationalCodeTextBox.Text).Id;
                var result = await restaurantService.Add(restaurant);
                result.PrintResultMessages();
                RestaurantDashboardForm restaurantDashboard = new RestaurantDashboardForm();
                restaurantDashboard.ShowDialog();
            }


            //test
        }
        public Result<Restaurant> GetRestaurantResult()
        {
            var result = new RestaurantBuilder()
                .GetName(ResturantNameTextBox.Text)
                .GetAddress(AddressTextBox.Text)
                .GetStartTime(FromTimeTextbox.Text)
                .GetEndTime(ToTimeTextbox.Text)
                .Build();
            return result;
        }
    }
}
