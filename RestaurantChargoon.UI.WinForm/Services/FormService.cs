using FluentResults;
using RestaurantChargoon.UI.WinForm.Forms.Users;
using System.Windows.Forms;

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
            DataGridViewButtonColumn newColumn = new DataGridViewButtonColumn();
            newColumn.Name = name;
            newColumn.Text = name;
            newColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(newColumn);
		}

		public static void AddBottonColumn(this DataGridView dataGridView, string name)
		{
			DataGridViewButtonColumn newColumn = new DataGridViewButtonColumn();
			newColumn.Name = name;
			newColumn.Text = name;
			newColumn.UseColumnTextForButtonValue = true;
			dataGridView.Columns.Add(newColumn);
		}

		public static void AddColumn(this DataGridView dataGridView, string name, string headerText,bool visible=true)
		{
			DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
			newColumn.HeaderText = headerText;
			newColumn.Name = name;
			newColumn.DataPropertyName = name;
			newColumn.Visible = visible;
			dataGridView.Columns.Add(newColumn);
		}

		public static void HideParentForm(this string formName)
		{
			Form formToShow = Application.OpenForms[formName];
			if (formToShow != null)
			{
				formToShow.Hide();
			}
		}
		public static void ShowParentForm(this string formName)
		{
			Form formToShow = Application.OpenForms[formName];
			if (formToShow != null)
			{
				formToShow.Show();
			}
		}

	}
}
