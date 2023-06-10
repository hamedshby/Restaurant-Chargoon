using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Forms.Foods;
using RestaurantChargoon.UI.WinForm.Forms.Users;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms.Restaurants
{
	public partial class RestaurantDashboardUserForm : Form
	{
		private readonly RestaurantService restaurantService;

		public RestaurantDashboardUserForm()
		{
			InitializeComponent();
			this.restaurantService = new RestaurantService();
		}

		#region Events
		private void RestaurantDashboardUserForm_Load(object sender, EventArgs e)
		{
			nameof(UserDashboardForm).HideParentForm();
			FillGridView();
		}

		private void RestaurantDashboardUserForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(UserDashboardForm).ShowParentForm();
		}

		private void RestaurantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == RestaurantDataGridView.Columns["انتخاب"].Index)
			{
				Program.RestaurantId = RestaurantDataGridView.GetRowClickedIdValue(e);
				FoodDashboardUserForm foodDashboardUserForm = new FoodDashboardUserForm();
				foodDashboardUserForm.ShowDialog();
			}
		}
		#endregion

		#region Methods
		public void FillGridView()
		{
			var factordetails = restaurantService.GetAll()
				.Select(c => new { c.Id, c.Name, c.StartTime, c.EndTime, c.Address })
				.ToList();
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = factordetails;
			RestaurantDataGridView.DataSource = bindingSource;
			RestaurantDataGridView.AddBottonColumn("انتخاب");
		}

		#endregion
	}
}
