using Restaurant_Chargoon.UI.WinForm;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class RestaurantDashboardForm : Form
	{
		public RestaurantDashboardForm()
		{
			InitializeComponent();
		}

		private void AddRestaurantButton_Click(object sender, EventArgs e)
		{
			SignUpRestaurantForm signUpRestaurantForm = new SignUpRestaurantForm();
			signUpRestaurantForm.ShowDialog();
		}

		private void RestaurantDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
