using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.Services.Users;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class SignUpRestaurantForm : Form
	{
		private readonly UserService userService;
		private readonly RestaurantService restaurantService;

		public SignUpRestaurantForm()
		{
			InitializeComponent();
			this.userService = new UserService();
			this.restaurantService = new RestaurantService();

		}
		public string MyValue
		{
			get { return NationalCodeTextBox.Text; }
		}
		private async void button1_Click(object sender, EventArgs e)
		{
			Restaurant restaurant = new Restaurant()
			{
				Address = AddressTextBox.Text,
				RestaurantName = ResturantNameTextBox.Text,
				StartTime = FromTimeTextbox.Text,
				EndTime = ToTimeTextbox.Text,
				ManagerNationalCode = NationalCodeTextBox.Text,
			};
			var result = await restaurantService.Add(restaurant);
			if (result.IsFailed)
			{
				string errors = string.Empty;
				foreach (var error in result.Errors)
				{
					errors += error.Message + Environment.NewLine;
				}
				MessageBox.Show(errors);
			}
			else
				MessageBox.Show("اطلاعات با موفقیت ثبت گردید");

			var user = userService.Get(u => u.NationalCode == NationalCodeTextBox.Text).FirstOrDefault();
			if (user != null)
			{
				user.UserType = UserType.RestaurantManager;
				var updateResult = await userService.Update(user);

				if (updateResult.IsFailed)
				{
					string errors = string.Empty;
					foreach (var error in result.Errors)
					{
						errors += error.Message + Environment.NewLine;
					}
					MessageBox.Show(errors);
				}
				else
					MessageBox.Show("اطلاعات با موفقیت ثبت گردید");
			}
			else
			{
				MessageBox.Show("لطفا اطلاعات حساب کاربری خود را ذخیره بفرمائید.");
				SingupUserForm userFrom = new SingupUserForm(NationalCodeTextBox.Text);
				userFrom.ShowDialog();
			}

			RestaurantDashboardForm restaurantDashboard = new RestaurantDashboardForm();
			restaurantDashboard.ShowDialog();
		}
	}
}
