using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Restaurants;
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

		private void RestaurantDashboardUserForm_Load(object sender, EventArgs e)
		{
			SigninUserFrom signinUserFrom = Application.OpenForms["SigninUserFrom"] as SigninUserFrom;
			if (signinUserFrom != null)
			{
				signinUserFrom.Hide();
			}
			FillgridView();
		}

		public void FillgridView()
		{
			var factordetails = restaurantService.GetAll()
				.Select(c => new { c.Id, c.Name, c.StartTime, c.EndTime, c.Address })
				.ToList();
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = factordetails;
			RestaurantDataGridView.DataSource = bindingSource;
			RestaurantDataGridView.AddBottonColumn("انتخاب");
		}

		private void RestaurantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == RestaurantDataGridView.Columns["انتخاب"].Index)
			{
				DataGridViewRow row = RestaurantDataGridView.Rows[e.RowIndex];
				foreach (DataGridViewColumn itm in RestaurantDataGridView.Columns)
				{
					if (itm.DataPropertyName == "Id")
					{
						int.TryParse(row.Cells[itm.Index].Value.ToString(), out Program.RestaurantId);
						
						break;
					}
				}
			}
		}

		private void RestaurantDashboardUserForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SigninUserFrom signinUserFrom = Application.OpenForms["SigninUserFrom"] as SigninUserFrom;
			if (signinUserFrom != null)
			{
				signinUserFrom.Show();
			}
		}
	}
}
