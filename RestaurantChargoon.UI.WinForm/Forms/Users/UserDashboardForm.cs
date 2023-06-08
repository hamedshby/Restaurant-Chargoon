using RestaurantChargoon.UI.WinForm.Forms.Restaurants;

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
			RestaurantDashboardUserForm restaurantDashboardUserForm = new RestaurantDashboardUserForm();
			restaurantDashboardUserForm.ShowDialog();
		}

		private void UserDashboardForm_Load(object sender, EventArgs e)
		{
			SigninUserFrom signinUserFrom = Application.OpenForms["SigninUserFrom"] as SigninUserFrom;
			if (signinUserFrom != null)
			{
				signinUserFrom.Hide();
			}
		}

		private void UserDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SigninUserFrom signinUserFrom = Application.OpenForms["SigninUserFrom"] as SigninUserFrom;
			if (signinUserFrom != null)
			{
				signinUserFrom.Show();
			}
		}
	}
}
