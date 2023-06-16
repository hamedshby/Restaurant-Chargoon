using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.UI.WinForm.Forms.Users;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms.Restaurants
{
	public partial class RestaurantFactorsForm : Form
	{
		private readonly IUnitOfWork _unit;

		public RestaurantFactorsForm(IUnitOfWork unit)
		{
			InitializeComponent();
			_unit = unit;
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
				UserFactorDetailForm form = new UserFactorDetailForm(factorId, _unit);
				form.ShowDialog();
			}
		}

		public void FillGridView()
		{
			var factors = _unit.Factor.Get(c => c.RestaurantId == Program.RestaurantId)
			.Select(c => new
			{
				c.Id,
				UserName = _unit.User.GetById(c.UserId).Name,
				RestaurantName = _unit.Restaurant.GetById(c.RestaurantId).Name,
				OrderDate = c.CreateDate.ToPersianDate(),
				TotalPrice = _unit.FactorDetail.SumOfFactor(c)
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
