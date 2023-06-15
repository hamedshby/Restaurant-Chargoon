using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Carts;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Factors;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Forms.Foods;
using RestaurantChargoon.UI.WinForm.Forms.Restaurants;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms.Carts
{
	public partial class CartDashboardForm : Form
	{
		private readonly RestaurantService restaurantService;
		private readonly UserService userService;
		private readonly CartService cartService;
		private readonly FactorService factorService;
		private Cart cart;

		public CartDashboardForm(Cart cart)
		{
			InitializeComponent();
			this.restaurantService = new RestaurantService();
			this.cart = cart;
			this.userService = new UserService();
			this.cartService = new CartService();
			factorService = new FactorService();
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
				cart = cartService.RemoveFactorDetail(cart, factorDetailId);
				factorDetailsDataGridView.Rows.RemoveAt(e.RowIndex);
			}
		}

		private async void SaveFactorButton_Click(object sender, EventArgs e)
		{
			foreach (var factorDetail in cart.FactorDetails)
			{
				factorDetail.Id = 0;
				var price = Math.Round(factorDetail.Price, 0); ;
				factorDetail.Price = price;
			}
			cart.RestaurantName = restaurantService.GetById(cart.RestaurantId).Name;
			var result = await factorService.AddAsync(cart);
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
			string restaurantName = restaurantService.GetById(cart.RestaurantId).Name;
			string userName = userService.GetById(cart.UserId).Name;
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
