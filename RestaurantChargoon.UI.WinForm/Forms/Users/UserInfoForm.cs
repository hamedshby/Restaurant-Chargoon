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
			ChangeEnableStatus(false);
		}

		private void UserInfoForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(UserDashboardForm).ShowParentForm();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			ChangeEnableStatus(true);
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			ChangeEnableStatus(false);
			this.Close();
		}

		private async void SaveButton_Click(object sender, EventArgs e)
		{
			var user = GetUser();
			if (!user.CheckModelState())
				return;

			var editResult = await userService.UpdateAsync(user);
			editResult.PrintResultMessages();
			if (editResult.IsSuccess)
				ChangeEnableStatus(false);
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

		private void ChangeEnableStatus(bool enable)
		{
			NameTetxtBox.Enabled = enable;
			LastNameTetxtBox.Enabled = enable;
			AddressTetxtBox.Enabled = enable;
			NationalCodeTetxtBox.Enabled = enable;
			PasswordTetxtBox.Enabled = enable;
			RestaurantManagerCheckBox.Enabled = enable;
		}


		//public Result<User> GetUserResult()
		//{
		//	UserType userStatus = RestaurantManagerCheckBox.Checked ? UserType.RestaurantManager : UserType.User;
		//	var result = new UserBuilder()
		//		.GetName(NameTetxtBox.Text)
		//		.GetFamily(LastNameTetxtBox.Text)
		//		.GetAddress(AddressTetxtBox.Text)
		//		.GetPassword(PasswordTetxtBox.Text)
		//		.GetNationalCode(NationalCodeTetxtBox.Text)
		//		.GetUserType(userStatus)
		//		.Build();

		//	return result;
		//}

		public User GetUser()
		{
			User user = userService.GetById(Program.userLogin.Id);
			user.Name = NameTetxtBox.Text;
			user.LastName = LastNameTetxtBox.Text;
			user.Address = AddressTetxtBox.Text;
			user.NationalCode = NationalCodeTetxtBox.Text;
			user.Password = PasswordTetxtBox.Text;
			user.UserType = RestaurantManagerCheckBox.Checked ? UserType.RestaurantManager : UserType.User;
			return user;
		}

		#endregion
	}
}
