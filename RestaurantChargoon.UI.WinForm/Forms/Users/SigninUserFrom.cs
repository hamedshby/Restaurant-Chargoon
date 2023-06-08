using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Forms.Restaurants;
using RestaurantChargoon.UI.WinForm.Forms.Users;

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

		#region Events
		private void enter_Click(object sender, EventArgs e)
		{
			var user = userService.CheckUserPassword(NationalCodeTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
			if (user == null)
			{
				MessageBox.Show("نام کاربری و پسورد وجود ندارد");
				return;
			}
			Program.userLogin = user;
			if (user.UserType == UserType.RestaurantManager)
			{
				RestaurantDashboardForm restaurantDashboardForm = new RestaurantDashboardForm();
				restaurantDashboardForm.ShowDialog();
			}
			else if (user.UserType == UserType.User)
			{
				UserDashboardForm userDashboardForm = new UserDashboardForm();
				userDashboardForm.ShowDialog();
			}
		}

		private void SigninUserFrom_FormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
			if (mainForm != null)
			{
				mainForm.Show();
			}

		}

		private void SigninUserFrom_Load(object sender, EventArgs e)
		{
			MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
			if (mainForm != null)
			{
				mainForm.Hide();
			}
		}

		#endregion
	}
}
