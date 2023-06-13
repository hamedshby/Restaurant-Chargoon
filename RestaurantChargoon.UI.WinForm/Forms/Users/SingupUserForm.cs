using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Services;

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

		#region Events
		private async void singup_Click(object sender, EventArgs e)
		{
			var user = GetUser();			
			if (!user.CheckModelState())
				return;

			var addResult = await userService.AddAsync(user);
			addResult.PrintResultMessages();
			if (addResult.IsSuccess)
			{
				this.Close();
			}
		}

		private void SingupUserForm_Load(object sender, EventArgs e)
		{
			nameof(MainForm).HideParentForm();
		}
		private void SingupUserForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(MainForm).ShowParentForm();
		}

		private void NationalCodeTetxtBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		#endregion


		private User GetUser()
		{
			User user = new User()
			{
				Name = NameTetxtBox.Text.Trim(),
				LastName = LastNameTetxtBox.Text.Trim(),
				NationalCode = NationalCodeTetxtBox.Text.Trim(),
				Password = PasswordTetxtBox.Text.Trim(),
				Address = AddressTetxtBox.Text.Trim()
			};
			return user;
		}
	}
}
