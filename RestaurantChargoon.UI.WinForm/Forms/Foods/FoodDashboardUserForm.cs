using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Carts;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Foods;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Forms.Carts;
using RestaurantChargoon.UI.WinForm.Forms.Restaurants;
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
			RestaurantDashboardUserForm restaurantDashboard = Application.OpenForms["RestaurantDashboardUserForm"] as RestaurantDashboardUserForm;
			if (restaurantDashboard != null)
			{
				restaurantDashboard.Hide();
			}
			string restaurantName = restaurantService.GetById(Program.RestaurantId).Name;
			this.Text = " منوی رستوران" + restaurantName;
			FillGridView();
		}

		private void FoodDashboardUserForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			RestaurantDashboardUserForm restaurantDashboard = Application.OpenForms["RestaurantDashboardUserForm"] as RestaurantDashboardUserForm;
			if (restaurantDashboard != null)
			{
				restaurantDashboard.Show();
			}
		}

		public void FillGridView()
		{
			var factordetails = foodService.Get(c => c.RestaurantId == Program.RestaurantId)
				.Select(c => new { c.Id, c.Name, c.Price, FoodType = c.FoodType.GetDisplayName() })
				.ToList();
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = factordetails;
			FoodDataGridView.DataSource = bindingSource;
			FoodDataGridView.AddBottonColumn("افزودن به سبد خرید");
		}

		private void showcartButton_Click(object sender, EventArgs e)
		{
			var cart = cartService.Get();
			CartDashboardForm cartDashboardForm = new CartDashboardForm(cart);
			cartDashboardForm.Show();
		}

		private void FoodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == FoodDataGridView.Columns["افزودن به سبد خرید"].Index)
			{
				DataGridViewRow row = FoodDataGridView.Rows[e.RowIndex];
				foreach (DataGridViewColumn itm in FoodDataGridView.Columns)
				{
					if (itm.DataPropertyName == "Id")
					{
						int.TryParse(row.Cells[itm.Index].Value.ToString(), out int foodId);
						var cart = cartService.CreateUserCart(foodId, Program.userLogin.Id, Program.RestaurantId);
						cartService.Add(cart);
						break;
					}
				}
			}
		}


	}
}
