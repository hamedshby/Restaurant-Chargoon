using FluentResults;
using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	public partial class UserInfoForm : Form
	{
		private readonly UserService userService;
		public UserInfoForm()
		{
			InitializeComponent();
			this.userService = new UserService();
		}

		#region Events
		private void UserInfoForm_Load(object sender, EventArgs e)
		{
			nameof(UserDashboardForm).HideParentForm();
			FillTextBox();
			EnableTextBox(false);
		}

		private void UserInfoForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(UserDashboardForm).ShowParentForm();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			EnableTextBox(true);
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			EnableTextBox(false);
		}

		private async void SaveButton_Click(object sender, EventArgs e)
		{
			var UserResult = GetUserResult();
			if (UserResult.IsFailed)
			{
				UserResult.PrintResultMessages();
				return;
			}
			var user = GetUser();
			var result = await userService.UpdateAsync(user);
			result.PrintResultMessages();
			if (UserResult.IsSuccess)
				EnableTextBox(false);
		}

		#endregion


		#region Methods
		private void FillTextBox()
		{
			var user = userService.GetById(Program.userLogin.Id);
			if (user != null)
			{
				NameTetxtBox.Text = user.Name;
				LastNameTetxtBox.Text = user.LastName;
				AddressTetxtBox.Text = user.Address;
				NationalCodeTetxtBox.Text = user.NationalCode;
				PasswordTetxtBox.Text = user.Password;
				RestaurantManagerCheckBox.Checked = user.UserType == UserType.RestaurantManager ? true : false;
			}
		}

		private void EnableTextBox(bool enableTextBox)
		{
			NameTetxtBox.Enabled = enableTextBox;
			LastNameTetxtBox.Enabled = enableTextBox;
			AddressTetxtBox.Enabled = enableTextBox;
			NationalCodeTetxtBox.Enabled = enableTextBox;
			PasswordTetxtBox.Enabled = enableTextBox;
		}

		public Result<User> GetUserResult()
		{
			UserType userStatus = RestaurantManagerCheckBox.Checked ? UserType.RestaurantManager : UserType.User;
			var result = new UserBuilder()
				.GetName(NameTetxtBox.Text)
				.GetFamily(LastNameTetxtBox.Text)
				.GetAddress(AddressTetxtBox.Text)
				.GetPassword(PasswordTetxtBox.Text)
				.GetNationalCode(NationalCodeTetxtBox.Text)
				.GetUserType(userStatus)
				.Build();

			return result;
		}

		public User GetUser()
		{
			User user = userService.GetById(Program.userLogin.Id);
			user.Name = NameTetxtBox.Text;
			user.LastName = LastNameTetxtBox.Text;
			user.Address = AddressTetxtBox.Text;
			user.NationalCode = NationalCodeTetxtBox.Text;
			user.Password = PasswordTetxtBox.Text;

			return user;
		}

		#endregion
	}
}
