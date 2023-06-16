using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.UI.WinForm.Forms.Foods;
using RestaurantChargoon.UI.WinForm.Forms.Restaurants;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms.Carts
{
	public partial class CartDashboardForm : Form
	{
		private readonly IUnitOfWork _unit;
		private Cart cart;

		public CartDashboardForm(Cart cart, IUnitOfWork unit)
		{
			InitializeComponent();
			this.cart = cart;
			_unit = unit;
		}

		#region Events
		private void CartDashboardForm_Load(object sender, EventArgs e)
		{
			nameof(FoodDashboardUserForm).HideParentForm();
			FillTextBox();
			FillgridView();
		}
		private void CartDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(FoodDashboardUserForm).ShowParentForm();
		}

		private void factorDetailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == factorDetailsDataGridView.Columns[Resource.Delete].Index)
			{
				int factorDetailId = factorDetailsDataGridView.GetRowClickedIdValue(e);
				cart = _unit.Cart.RemoveFactorDetail(cart, factorDetailId);
				factorDetailsDataGridView.Rows.RemoveAt(e.RowIndex);
			}
		}

		private async void SaveFactorButton_Click(object sender, EventArgs e)
		{
			cart.RestaurantName = _unit.Restaurant.GetById(cart.RestaurantId).Name;
			var result = await _unit.Factor.CreateAsync(cart);
			result.PrintResultMessages();
			if (result.IsSuccess)
			{
				nameof(FoodDashboardUserForm).CloseParentForm();
				nameof(RestaurantDashboardUserForm).ShowParentForm();
				this.Close();
			}
		}

		#endregion


		#region Methods
		private void FillTextBox()
		{
			string restaurantName = _unit.Restaurant.GetById(cart.RestaurantId).Name;
			string userName = _unit.User.GetById(cart.UserId).Name;
			var total = cart.FactorDetails.Sum(c => c.Price * c.Count);
			RestaurantNametextBox.Text = restaurantName;
			UserNameTextBox.Text = userName;
			TotalTextBox.Text = total.ToString();
		}

		public void FillgridView()
		{
			var factordetails = cart.FactorDetails.Select(c => new { c.Id, c.FoodName, c.Price, c.Count, FoodType = c.FoodType.GetDisplayName() }).ToList();
			if (factordetails.Any())
			{
				factorDetailsDataGridView.Fill(factordetails);
			}
		}
		#endregion

	}
}
