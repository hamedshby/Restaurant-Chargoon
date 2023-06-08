using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Factors;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	public partial class UserFactorDetailForm : Form
	{
		private readonly FactorDetailService factorDetailService;
		private int factorId;
		public UserFactorDetailForm(int factorId)
		{
			InitializeComponent();
			factorDetailService = new FactorDetailService();
			this.factorId = factorId;
		}

		private void UserFactorDetailForm_Load(object sender, EventArgs e)
		{
			UserFactorsForm userFactorsForm = Application.OpenForms["UserFactorsForm"] as UserFactorsForm;
			if (userFactorsForm != null)
			{
				userFactorsForm.Hide();
			}
			FillGridView();
		}

		private void UserFactorDetailForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			UserFactorsForm userFactorsForm = Application.OpenForms["UserFactorsForm"] as UserFactorsForm;
			if (userFactorsForm != null)
			{
				userFactorsForm.Show();
			}
		}

		public void FillGridView()
		{
			var factorDetails = factorDetailService.Get(c => c.FactorId == factorId)
				.Select(c => new { c.FoodName, c.Price, FoodType = c.FoodType.GetDisplayName() })
				.ToList();
			if (factorDetails.Any())
			{
				BindingSource bindingSource = new BindingSource();
				bindingSource.DataSource = factorDetails;
				FactcorDetailDataGridView.DataSource = bindingSource;
			}
		}
	}
}
