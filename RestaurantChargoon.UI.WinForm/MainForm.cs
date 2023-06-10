using RestaurantChargoon.UI.WinForm.Forms;
using RestaurantChargoon.UI.WinForm.Services;

namespace Restaurant_Chargoon.UI.WinForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void signinUser_Click(object sender, EventArgs e)
		{
			typeof(SigninUserFrom).ShowDialog();
		}

		private void signupRestaurant_Click(object sender, EventArgs e)
		{
			SignUpRestaurantForm signUpRestaurant = new SignUpRestaurantForm();
			signUpRestaurant.ShowDialog();
		}

		private void signupUserBtn_Click_1(object sender, EventArgs e)
		{
			SingupUserForm singupUserForm = new SingupUserForm();
			singupUserForm.ShowDialog();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}