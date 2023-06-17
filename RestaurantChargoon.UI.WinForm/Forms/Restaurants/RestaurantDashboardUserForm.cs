using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Forms.Foods;
using RestaurantChargoon.UI.WinForm.Forms.Users;
using RestaurantChargoon.UI.WinForm.Resources;
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
			nameof(RestaurantDashboardForm).HideParentForm();
			FillGridView();
		}

		private void RestaurantDashboardUserForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(UserDashboardForm).ShowParentForm();
			nameof(RestaurantDashboardForm).ShowParentForm();

		}

		private void RestaurantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == RestaurantDataGridView.Columns[Resource.Select].Index)
			{
				Program.RestaurantId = RestaurantDataGridView.GetRowClickedIdValue(e);
				Restaurant restaurant=restaurantService.GetById(Program.RestaurantId);
				bool isTimeToOrder = restaurant.CheckTimeToOrder();
				if(!isTimeToOrder) 
				{
					FormService.ShowErrorMessageBox("در حال حاضر در ساعت کاری رستوران قرار نداریم. لطفا رستوران دیگری انتخاب کنید");
					return;
				}
				typeof(FoodDashboardUserForm).ShowDialog();
			}
		}
		#endregion

		#region Methods
		public void FillGridView()
		{
			var factordetails = restaurantService.GetAll()
				.Select(c => new { c.Id, c.Name, c.StartTime, c.EndTime, c.Address })
				.ToList();
			if (factordetails.Any())
			{
				RestaurantDataGridView.Fill(factordetails);
			}
		}

		#endregion
	}
}
