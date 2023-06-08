using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Factors;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Services;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	public partial class UserOrdersForm : Form
	{
		private readonly FactorService factorService;
		private readonly RestaurantService restaurantService;

		public UserOrdersForm()
		{
			InitializeComponent();
			factorService = new FactorService();
			this.restaurantService = new RestaurantService();
		}

		private void UserOrdersForm_Load(object sender, EventArgs e)
		{
			UserDashboardForm userDashboardForm = Application.OpenForms["UserDashboardForm"] as UserDashboardForm;
			if (userDashboardForm != null)
			{
				userDashboardForm.Hide();
			}
			FillGridView();
		}

		private void UserOrdersForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			UserDashboardForm userDashboardForm = Application.OpenForms["UserDashboardForm"] as UserDashboardForm;
			if (userDashboardForm != null)
			{
				userDashboardForm.Show();
			}
		}

		public void FillGridView()
		{
			var factors = factorService.Get(c => c.UserId == Program.userLogin.Id)
				.Select(c => new
				{
					c.Id,
					RestaurantName = restaurantService.GetById(c.RestaurantId).Name
				})
				.ToList();
			if (factors.Any())
			{
				BindingSource bindingSource = new BindingSource();
				bindingSource.DataSource = factors;
				UserFactorDataGridView.DataSource = bindingSource;
				UserFactorDataGridView.AddBottonColumn("مشاهده ی جزییات");
			}
		}
	}
}
