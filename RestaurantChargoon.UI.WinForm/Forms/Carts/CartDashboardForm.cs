﻿using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Carts;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Factors;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Forms.Foods;
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
			FillRestaurantNameUserNameTextBox();
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
			}
			var result = await factorService.AddAsync(cart);
			result.PrintResultMessages();
			if (result.IsSuccess)
			{
				nameof(FoodDashboardUserForm).ShowParentForm();
				this.Close();
			}
		}

		#endregion


		#region Methods
		private void FillRestaurantNameUserNameTextBox()
		{
			string restaurantName = restaurantService.GetById(cart.RestaurantId).Name;
			string userName = userService.GetById(cart.RestaurantId).Name;
			RestaurantNametextBox.Text = restaurantName;
			UserNameTextBox.Text = userName;
		}

		public void FillgridView()
		{
			var factordetails = cart.FactorDetails.Select(c => new { c.Id, c.FoodName, c.Price, FoodType = c.FoodType.GetDisplayName() }).ToList();
			if (factordetails.Any())
			{
				factorDetailsDataGridView.Fill(factordetails);
			}
		}

		#endregion

	}
}
