using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Factors;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Services;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	public partial class UserFactorsForm : Form
	{
		private readonly FactorService factorService;
		private readonly RestaurantService restaurantService;

		public UserFactorsForm()
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
				.OrderByDescending(c => c.Id)
				.ToList();
			if (factors.Any())
			{
				BindingSource bindingSource = new BindingSource();
				bindingSource.DataSource = factors;
				UserFactorDataGridView.DataSource = bindingSource;
				UserFactorDataGridView.AddBottonColumn("مشاهده ی جزییات");
			}
		}

		private void UserFactorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == UserFactorDataGridView.Columns["مشاهده ی جزییات"].Index)
			{
				DataGridViewRow row = UserFactorDataGridView.Rows[e.RowIndex];
				foreach (DataGridViewColumn itm in UserFactorDataGridView.Columns)
				{
					if (itm.DataPropertyName == "Id")
					{
						int.TryParse(row.Cells[itm.Index].Value.ToString(), out int factorId);
						UserFactorDetailForm form = new UserFactorDetailForm(factorId);
						form.ShowDialog();
						break;
					}
				}
			}
		}
	}
}
