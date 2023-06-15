using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Factors;
using RestaurantChargoon.UI.WinForm.Services;
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

		#region Events
		private void UserFactorDetailForm_Load(object sender, EventArgs e)
		{
			nameof(UserFactorsForm).HideParentForm();
			FillGridView();
		}

		private void UserFactorDetailForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(UserFactorsForm).ShowParentForm();
		}
		#endregion


		#region Methods
		public void FillGridView()
		{
			var factorDetails = factorDetailService.Get(c => c.FactorId == factorId)
				.Select(c => new { c.FoodName, c.Count, c.Price, FoodType = c.FoodType.GetDisplayName(),Sum=c.Count*c.Price })
				.ToList(); ;
			if (factorDetails.Any())
			{
				FactcorDetailDataGridView.Fill(factorDetails);
			}
		}

		#endregion
	}
}
