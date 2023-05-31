using RestaurantChargoon.UI.WinForm.Forms;

namespace Restaurant_Chargoon.UI.WinForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void signupUserBtn_Click(object sender, EventArgs e)
		{
			SingupUserForm singupUserForm = new SingupUserForm();
			singupUserForm.ShowDialog();
		}
	}
}