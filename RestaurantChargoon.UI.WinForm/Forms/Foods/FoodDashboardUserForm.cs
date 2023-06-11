using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Carts;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Foods;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Forms.Carts;
using RestaurantChargoon.UI.WinForm.Forms.Restaurants;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms.Foods
{
	public partial class FoodDashboardUserForm : Form
	{
		private readonly FoodService foodService;
		private readonly RestaurantService restaurantService;
		private readonly CartService cartService;

		public FoodDashboardUserForm()
		{
			InitializeComponent();
			foodService = new FoodService();
			restaurantService = new RestaurantService();
			cartService = new CartService();
		}

		private void FoodDashboardUserForm_Load(object sender, EventArgs e)
		{
			nameof(RestaurantDashboardUserForm).HideParentForm();
			string restaurantName = restaurantService.GetById(Program.RestaurantId).Name;
			this.Text = " منوی رستوران" + restaurantName;
			FillGridView();
		}

		private void FoodDashboardUserForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(RestaurantDashboardUserForm).ShowParentForm();
		}


		private void showcartButton_Click(object sender, EventArgs e)
		{
			var cart = cartService.Get();
			CartDashboardForm form = new CartDashboardForm(cart);
			form.ShowDialog();
		}

		private void FoodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == FoodDataGridView.Columns[Resource.AddToCart].Index)
			{
				int foodId = FoodDataGridView.GetRowClickedIdValue(e);
				var cart = cartService.CreateUserCart(foodId, Program.userLogin.Id, Program.RestaurantId);
				cartService.Add(cart);
			}
		}


		public void FillGridView()
		{
			var factordetails = foodService.Get(c => c.RestaurantId == Program.RestaurantId)
				.Select(c => new { c.Id, c.Name, c.Price, FoodType = c.FoodType.GetDisplayName() })
				.ToList();
			if (factordetails.Any())
			{
				FoodDataGridView.Fill(factordetails);
			}
		}

	}
}
