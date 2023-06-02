using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Restaurant;
using RestaurantChargoon.Services.Users;

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
        public string MyValue
        {
            get { return NationalCodeTextBox.Text; }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant()
            {
                Address = AddressTextBox.Text,
                RestaurantName = ResturantNameTextBox.Text,
                StartTime = TimefromTextbox.Text,
                EndTime = ToTimeTextbox.Text,
                ManagerNationalCode = NationalCodeTextBox.Text,
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

            User user = new User();
            user = userService.GetUsers().Where(u => u.NationalCode == NationalCodeTextBox.Text).FirstOrDefault();
            if (user != null)
            {
                user.UserType = UserType.RestaurantManager;
                userService.Update(user);
                var updateResult = await Task.Run(() =>
                {
                    var updateResult = userService.Save();
                    return updateResult;
                });
                if (updateResult.IsFailed)
                    MessageBox.Show(updateResult.Errors[0].Message);
                else
                    MessageBox.Show("اطلاعات با موفقیت ثبت گردید");

            }
            else
            {
                MessageBox.Show("لطفا اطلاعات حساب کاربری خود را ذخیره بفرمائید.");
                SingupUserForm userFrom = new SingupUserForm(NationalCodeTextBox.Text);
                
                 
                userFrom.ShowDialog();
               
            }

            RestaurantDashboard restaurantDashboard = new RestaurantDashboard();
            restaurantDashboard.ShowDialog();
        }
    }
}
