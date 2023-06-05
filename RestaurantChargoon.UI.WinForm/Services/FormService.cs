using FluentResults;

namespace RestaurantChargoon.UI.WinForm.Services
{
	public static class FormService
	{

		public static void ShowErrorMessageBox(string message)
		{
			MessageBox.Show(message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void ShowInfoMessageBox(string message)
		{
			MessageBox.Show(message, "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void PrintResultErrors<T>(this Result<T> result)
		{
			string errors = string.Empty;
			foreach (var error in result.Errors)
			{
				errors += error.Message + Environment.NewLine;
			}
			ShowErrorMessageBox(errors);
		}
	}
}
