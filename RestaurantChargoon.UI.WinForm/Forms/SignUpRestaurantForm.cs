using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
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
		private async void RegisterRestaurant_Click(object sender, EventArgs e)
		{
			Restaurant restaurant = new Restaurant()
			{
				Address = AddressTextBox.Text,
				RestaurantName = ResturantNameTextBox.Text,
				StartTime = FromTimeTextbox.Text,
				EndTime = ToTimeTextbox.Text,
				UserId = Program.userLogin.Id
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

			//test
		}
	}
}
