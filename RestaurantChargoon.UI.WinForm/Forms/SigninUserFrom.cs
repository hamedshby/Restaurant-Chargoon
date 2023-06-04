using RestaurantChargoon.Services.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class SigninUserFrom : Form
	{
		private readonly UserService userService;
		public SigninUserFrom()
		{
			InitializeComponent();
			this.userService = new UserService();
		}

		private void enter_Click(object sender, EventArgs e)
		{
			var user = userService.GetByNationalCode(NationalCodeTextBox.Text.Trim());
			if (user == null) 
			{
				MessageBox.Show("نام کاربری و پسورد وجود ندارد");
				return;
			}
			RestaurantDashboardForm restaurantDashboardForm = new RestaurantDashboardForm();
			this.Hide();
			restaurantDashboardForm.ShowDialog();			
		}
	}
}
