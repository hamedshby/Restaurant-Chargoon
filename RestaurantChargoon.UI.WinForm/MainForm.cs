using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Forms;
using RestaurantChargoon.UI.WinForm.Services;

namespace Restaurant_Chargoon.UI.WinForm
{
	public partial class MainForm : Form
	{
		private readonly UserService userService;
		public MainForm()
		{
			InitializeComponent();
			this.userService = new UserService();
		}

		private void signinUser_Click(object sender, EventArgs e)
		{
			typeof(SigninUserFrom).ShowDialog();
		}

		private void signupRestaurant_Click(object sender, EventArgs e)
		{
			typeof(SignUpRestaurantForm).ShowDialog();
		}

		private void signupUserBtn_Click_1(object sender, EventArgs e)
		{
			typeof(SingupUserForm).ShowDialog();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//var user = userService.Get(c => c.UserType == UserType.User).FirstOrDefault();			
		}

		private void TestAttr()
		{
			User user = new User();
			user.Name = "h";
			user.NationalCode = "sss";
			user.Password = "Password";
			var res= user.ModelState();
		}
	}
}