using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Factors;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Forms.Users;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms.Restaurants
{
	public partial class RestaurantFactorsForm : Form
	{
		private readonly FactorService factorService;
		private readonly FactorDetailService factorDetailService;
		private readonly RestaurantService restaurantService;
		private readonly UserService userService;

		public RestaurantFactorsForm()
		{
			InitializeComponent();
			factorService = new FactorService();
			this.restaurantService = new RestaurantService();
			this.factorDetailService = new FactorDetailService();
			this.userService = new UserService();
		}

		private void RestaurantFactorsForm_Load(object sender, EventArgs e)
		{
			nameof(RestaurantDashboardForm).HideParentForm();
			FillGridView();
		}

		private void RestaurantFactorsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
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

		public void FillGridView()
		{
			var factors = factorService.Get(c => c.RestaurantId == Program.RestaurantId)
			.Select(c => new
			{
				c.Id,
				UserName = userService.GetById(c.UserId).Name,
				RestaurantName = restaurantService.GetById(c.RestaurantId).Name,
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
	}
}
