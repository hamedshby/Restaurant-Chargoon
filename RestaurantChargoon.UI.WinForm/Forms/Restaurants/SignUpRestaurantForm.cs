using FluentResults;
using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class SignUpRestaurantForm : Form
    {
        private readonly RestaurantService restaurantService;

        public SignUpRestaurantForm()
        {
            InitializeComponent();
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
            var result = await restaurantService.AddAsync(restaurant);
            result.PrintResultMessages();
            if (result.IsSuccess)
                this.Close();
        }

        private void SignUpRestaurantForm_Load(object sender, EventArgs e)
        {
            RestaurantDashboardForm restaurantDashboardForm = Application.OpenForms["RestaurantDashboardForm"] as RestaurantDashboardForm;
            if (restaurantDashboardForm != null)
            {
                restaurantDashboardForm.Hide();
            }
        }

        private void SignUpRestaurantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RestaurantDashboardForm restaurantDashboardForm = new RestaurantDashboardForm();
            restaurantDashboardForm.Show();
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
