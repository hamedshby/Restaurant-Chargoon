﻿using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Restaurants;
using System.Windows.Forms;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class RestaurantDashboardForm : Form
	{
		private readonly RestaurantService restaurantService;
		public RestaurantDashboardForm()
		{
			InitializeComponent();
			this.restaurantService = new RestaurantService();
		}

		#region Events
		private void AddRestaurantButton_Click(object sender, EventArgs e)
		{
			SignUpRestaurantForm signUpRestaurantForm = new SignUpRestaurantForm();
			signUpRestaurantForm.ShowDialog();
		}

		private void RestaurantDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void RestaurantDashboardForm_Load(object sender, EventArgs e)
		{
			FillgridView();
		}
		#endregion


		#region Methods
		public void FillgridView()
		{
			var foods = restaurantService.GetAll().Select(c =>
			new
			{
				c.Id,
				c.RestaurantName,
				c.StartTime,
				c.EndTime,
				c.Address
			});
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = foods;
			RestaurantDataGridView.DataSource = bindingSource;
		}


		private int GetRowIdSelected()
		{
			if (RestaurantDataGridView.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = RestaurantDataGridView.SelectedRows[0];
				int.TryParse(selectedRow.Cells[0].Value.ToString(), out int result);
				return result;
			}
			return 0;
		}

		private void MenuButton_Click(object sender, EventArgs e)
		{
			Program.RestaurantId = GetRowIdSelected();
			FoodForm foodForm = new FoodForm();
			this.Hide();
			foodForm.ShowDialog();
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			FillgridView();
		}
	}
	#endregion
}
