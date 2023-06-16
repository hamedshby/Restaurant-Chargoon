using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.UI.WinForm.Forms;
using RestaurantChargoon.UI.WinForm.Services;

namespace Restaurant_Chargoon.UI.WinForm
{
	public partial class MainForm : Form
	{
		private readonly IUnitOfWork _unit;
		public MainForm(IUnitOfWork unit)
		{
			InitializeComponent();
			_unit = unit;
		}

		private void signinUser_Click(object sender, EventArgs e)
		{
			typeof(SigninUserFrom).ShowDialog(_unit);
		}

		private void signupUserBtn_Click_1(object sender, EventArgs e)
		{
			typeof(SingupUserForm).ShowDialog(_unit);
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}