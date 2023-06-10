using FluentResults;
using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
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
            var UserResult = GetUserResult();
            if (UserResult.IsFailed)
            {
                UserResult.PrintResultMessages();
                return;
            }
            var result = await userService.AddAsync(UserResult.Value);
            result.PrintResultMessages();
            if (result.IsSuccess)
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
        #endregion


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

       
    }
}
