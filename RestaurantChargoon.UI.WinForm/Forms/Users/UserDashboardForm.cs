using RestaurantChargoon.UI.WinForm.Forms.Restaurants;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	public partial class UserDashboardForm : Form
	{
		public UserDashboardForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			typeof(RestaurantDashboardUserForm).ShowDialog();
		}

		private void UserDashboardForm_Load(object sender, EventArgs e)
		{
			nameof(SigninUserFrom).HideParentForm();
		}

		private void UserDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(SigninUserFrom).ShowParentForm();
		}

		private void ShowOrdersButton_Click(object sender, EventArgs e)
		{
			typeof(UserFactorsForm).ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			typeof(UserInfoForm).ShowDialog();
		}
	}
}
