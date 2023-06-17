using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Factors;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	public partial class UserFactorsForm : Form
	{
		private readonly FactorService factorService;
		private readonly FactorDetailService factorDetailService;
		private readonly RestaurantService restaurantService;

		public UserFactorsForm()
		{
			InitializeComponent();
			factorService = new FactorService();
			this.restaurantService = new RestaurantService();
			this.factorDetailService = new FactorDetailService();
		}

		#region Events
		private void UserOrdersForm_Load(object sender, EventArgs e)
		{
			nameof(UserDashboardForm).HideParentForm();
			nameof(RestaurantDashboardForm).HideParentForm();
			FillGridView();
		}

		private void UserOrdersForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(UserDashboardForm).ShowParentForm();
			nameof(RestaurantDashboardForm).ShowParentForm();
		}


		private void UserFactorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == UserFactorDataGridView.Columns[Resource.Detail].Index)
			{
				int factorId = UserFactorDataGridView.GetRowClickedIdValue(e);
				UserFactorDetailForm form = new UserFactorDetailForm(factorId);
				form.ShowDialog();
			}
		}

		#endregion

		#region Methods
		public void FillGridView()
		{
			var factors = factorService.Get(c => c.UserId == Program.userLogin.Id)
				.Select(c => new
				{
					c.Id,
					c.RestaurantName,
					OrderDate = c.CreateDate.ToPersianDate(),
					TotalPrice = factorDetailService.SumOfFactor(c)
				})
				.OrderByDescending(c => c.Id)
				.ToList();
			if (factors.Any())
			{
				UserFactorDataGridView.Fill(factors);
			}
		}
		#endregion
	}
}
