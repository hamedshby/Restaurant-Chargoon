using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Users;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class SigninUserFrom : Form
    {
        private readonly UserService userService;
        public SigninUserFrom()
        {
            InitializeComponent();
            this.userService = new UserService();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            var user = userService.CheckUserPassword(NationalCodeTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("نام کاربری و پسورد وجود ندارد");
                return;
            }
            Program.userLogin = user;
            RestaurantDashboardForm restaurantDashboardForm = new RestaurantDashboardForm();
            this.Hide();
            restaurantDashboardForm.ShowDialog();
        }

        private void SigninUserFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();

        }
    }
}
