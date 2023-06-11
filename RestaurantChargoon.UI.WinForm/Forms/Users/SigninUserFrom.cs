using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Forms.Users;
using RestaurantChargoon.UI.WinForm.Services;

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

		#region Events
		private void enter_Click(object sender, EventArgs e)
		{
			var user = userService.CheckUserPassword(NationalCodeTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
			if (user == null)
			{
				FormService.ShowErrorMessageBox("نام کاربری و پسورد وجود ندارد");
				return;
			}
			Program.userLogin = user;
			if (user.UserType == UserType.RestaurantManager)
			{
				typeof(RestaurantDashboardForm).ShowDialog();
			}
			else if (user.UserType == UserType.User)
			{
				typeof(UserDashboardForm).ShowDialog();				
			}
		}

		private void SigninUserFrom_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(MainForm).ShowParentForm();
		}

		private void SigninUserFrom_Load(object sender, EventArgs e)
		{
			nameof(MainForm).HideParentForm();
		}

		#endregion
	}
}
