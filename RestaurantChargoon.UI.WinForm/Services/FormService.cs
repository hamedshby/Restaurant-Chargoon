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

		public static void PrintResultMessages<T>(this Result<T> result)
		{
			string messages = string.Empty;
			foreach (var error in result.Reasons)
			{
				messages += error.Message + Environment.NewLine;
			}
			if (result.IsFailed)
				ShowErrorMessageBox(messages);
			else
				ShowInfoMessageBox(messages);
		}

        public static void AddBottonToGrid(string name, int columnIndex, DataGridView dataGridView)
        {
            DataGridViewButtonColumn startbtn = new DataGridViewButtonColumn();
            startbtn.Name = name;
            startbtn.Text = name;
            startbtn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Insert(columnIndex, startbtn);
        }
    }
}
