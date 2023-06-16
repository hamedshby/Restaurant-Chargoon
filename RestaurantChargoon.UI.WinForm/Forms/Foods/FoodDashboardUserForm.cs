using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.UI.WinForm.Forms.Carts;
using RestaurantChargoon.UI.WinForm.Forms.Restaurants;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms.Foods
{
	public partial class FoodDashboardUserForm : Form
	{
		private readonly IUnitOfWork _unit;

		public FoodDashboardUserForm(IUnitOfWork unit)
		{
			InitializeComponent();
			_unit = unit;
		}

		private void FoodDashboardUserForm_Load(object sender, EventArgs e)
		{
			nameof(RestaurantDashboardUserForm).HideParentForm();
			string restaurantName = _unit.Restaurant.GetById(Program.RestaurantId).Name;
			this.Text = " منوی رستوران" + restaurantName;
			FillGridView();
		}

		private void FoodDashboardUserForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(RestaurantDashboardUserForm).ShowParentForm();
		}


		private void showcartButton_Click(object sender, EventArgs e)
		{
			var cart = _unit.Cart.Get();
			CartDashboardForm form = new CartDashboardForm(cart, _unit);
			form.ShowDialog();
		}

		private void FoodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == FoodDataGridView.Columns[Resource.AddToCart].Index)
			{
				int foodId = FoodDataGridView.GetRowClickedIdValue(e);
				var cart = _unit.Cart.CreateUserCart(foodId, Program.userLogin.Id, Program.RestaurantId);
				_unit.Cart.Add(cart);
			}
		}


		public void FillGridView()
		{
			var factordetails = _unit.Food.Get(c => c.RestaurantId == Program.RestaurantId)
				.Select(c => new { c.Id, c.Name, c.Price, FoodType = c.FoodType.GetDisplayName() })
				.ToList();
			if (factordetails.Any())
			{
				FoodDataGridView.Fill(factordetails);
			}
		}

	}
}
