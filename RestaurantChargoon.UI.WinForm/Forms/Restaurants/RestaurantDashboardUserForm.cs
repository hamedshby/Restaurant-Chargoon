﻿using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Forms.Foods;
using RestaurantChargoon.UI.WinForm.Forms.Users;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms.Restaurants
{
	public partial class RestaurantDashboardUserForm : Form
	{
		private readonly RestaurantService restaurantService;

		public RestaurantDashboardUserForm()
		{
			InitializeComponent();
			this.restaurantService = new RestaurantService();
		}

		private void RestaurantDashboardUserForm_Load(object sender, EventArgs e)
		{
			UserDashboardForm userDashboardForm = Application.OpenForms["UserDashboardForm"] as UserDashboardForm;
			if (userDashboardForm != null)
			{
				userDashboardForm.Hide();
			}
			FillGridView();
		}

		private void RestaurantDashboardUserForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			UserDashboardForm userDashboardForm = Application.OpenForms["UserDashboardForm"] as UserDashboardForm;
			if (userDashboardForm != null)
			{
				userDashboardForm.Show();
			}
		}

		public void FillGridView()
		{
			var factordetails = restaurantService.GetAll()
				.Select(c => new { c.Id, c.Name, c.StartTime, c.EndTime, c.Address })
				.ToList();
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = factordetails;
			RestaurantDataGridView.DataSource = bindingSource;
			RestaurantDataGridView.AddBottonColumn("انتخاب");
		}

		private void RestaurantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == RestaurantDataGridView.Columns["انتخاب"].Index)
			{
				DataGridViewRow row = RestaurantDataGridView.Rows[e.RowIndex];
				foreach (DataGridViewColumn itm in RestaurantDataGridView.Columns)
				{
					if (itm.DataPropertyName == "Id")
					{
						int.TryParse(row.Cells[itm.Index].Value.ToString(), out Program.RestaurantId);
						FoodDashboardUserForm foodDashboardUserForm = new FoodDashboardUserForm();
						foodDashboardUserForm.ShowDialog();
						break;
					}
				}
			}
		}

		
	}
}
