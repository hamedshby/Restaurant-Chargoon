using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	public partial class UserInfoForm : Form
	{
		private readonly IUnitOfWork _unit;
		public UserInfoForm(IUnitOfWork unit)
		{
			InitializeComponent();
			_unit = unit;
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
		}

		private async void SaveButton_Click(object sender, EventArgs e)
		{
			var user = GetUser();
			if (!user.CheckModelState())
				return;

			var editResult = await _unit.User.UpdateAsync(user);
			editResult.PrintResultMessages();
			if (editResult.IsSuccess)
				ChangeEnableStatus(false);
		}

		#endregion


		#region Methods
		private void FillTextBox()
		{
			var user = _unit.User.GetById(Program.userLogin.Id);
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

		public User GetUser()
		{
			User user = _unit.User.GetById(Program.userLogin.Id);
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
