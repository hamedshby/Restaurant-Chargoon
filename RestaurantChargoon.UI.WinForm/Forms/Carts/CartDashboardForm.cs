using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.Services.Users;

namespace RestaurantChargoon.UI.WinForm.Forms.Carts
{
	public partial class CartDashboardForm : Form
	{
		private readonly RestaurantService restaurantService;
		private readonly UserService userService;
		private readonly Cart cart;
		public CartDashboardForm(Cart cart, UserService userService)
		{
			InitializeComponent();
			this.restaurantService = new RestaurantService();
			this.cart = cart;
			this.userService = userService;
		}

		private void CartDashboardForm_Load(object sender, EventArgs e)
		{
			string restaurantName = restaurantService.GetById(cart.RestaurantId).Name;
			string userName = userService.GetById(cart.RestaurantId).Name;
			RestaurantNametextBox.Text = restaurantName;
			UserNameTextBox.Text = userName;

		}

		public void FillgridView()
		{
			var factordetails = cart.FactorDetails;
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = factordetails;
			factorDetailsDataGridView.DataSource = bindingSource;
		}
	}
}
