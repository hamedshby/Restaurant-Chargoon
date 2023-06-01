using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Restaurant;
using RestaurantChargoon.Services.Users;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class SignUpRestaurantForm : Form
    {
        private readonly UserService userService;
        private readonly RestaurantService  restaurantService;

        public SignUpRestaurantForm()
        {
            InitializeComponent();
            this.userService = new UserService();
            this.restaurantService = new RestaurantService();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
           // userService
            Restaurant restaurant = new Restaurant()
            {
                Address =AddressTextBox.Text,
                RestaurantName=ResturantNameTextBox.Text,
                StartTime=TimefromTextbox.Text,
                EndTime=ToTimeTextbox.Text,
                ManagerNationalCode=NationalCodeTextBox.Text,
            };
            restaurantService.Add(restaurant);
            var result = await Task.Run(() =>
            {
                var result = userService.Save();
                return result;
            });
            if (result.IsFailed)
                MessageBox.Show(result.Errors[0].Message);
            else
                MessageBox.Show("اطلاعات با موفقیت ثبت گردید");

            RestaurantDashboard restaurantDashboard = new RestaurantDashboard();
            restaurantDashboard.ShowDialog();
        }
    }
}
