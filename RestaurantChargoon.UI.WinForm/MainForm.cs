using RestaurantChargoon.UI.WinForm.Forms;

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
			SigninUserFrom signinUser = new SigninUserFrom();
			this.Hide();
			signinUser.ShowDialog();

		}

		private void signupRestaurant_Click(object sender, EventArgs e)
		{
			SignUpRestaurantForm signUpRestaurant = new SignUpRestaurantForm();
			signUpRestaurant.ShowDialog();
			this.Hide();
		}

		private void signupUserBtn_Click_1(object sender, EventArgs e)
		{
			SingupUserForm singupUserForm = new SingupUserForm();
			this.Hide();
			singupUserForm.ShowDialog();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}