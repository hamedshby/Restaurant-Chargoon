using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Users;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class SingupUserForm : Form
	{
		private readonly UserService userService;
		public SingupUserForm()
		{
			InitializeComponent();
			this.userService = new UserService();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void singup_Click(object sender, EventArgs e)
		{

		}

		private async void singup_Click_1(object sender, EventArgs e)
		{
			User user = new User()
			{
				Name = NameTetxtBox.Text,
				LastName = LastNameTetxtBox.Text,
				NationalCode = NationalCodeTetxtBox.Text,
				Address = AddressTetxtBox.Text,
				Password= PasswordTetxtBox.Text,
				UserType=UserType.User
			};

			userService.Add(user);
			var result = await Task.Run(() =>
			{
				var result = userService.Save();
				return result;
			});

			if (result.IsFailed)
			MessageBox.Show(result.Errors[0].Message);
			else
				MessageBox.Show("اطلاعات با موفقیت ثبت گردید");

		}
	}
}
