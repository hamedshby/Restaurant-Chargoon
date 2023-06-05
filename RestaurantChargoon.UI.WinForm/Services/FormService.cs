namespace RestaurantChargoon.UI.WinForm.Services
{
	public class FormService
	{

		public static void ShowErrorMessageBox(string message)
		{
			MessageBox.Show("خطا", message, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
