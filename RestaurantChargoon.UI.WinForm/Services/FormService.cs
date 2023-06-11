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

		public static void AddBottonColumn(this DataGridView dataGridView, string name)
		{
			bool columnExist = false;
			foreach (DataGridViewColumn column in dataGridView.Columns)
			{
				if (column.Name == name)
					columnExist = true;
			}
			if (!columnExist)
			{
				DataGridViewButtonColumn newColumn = new DataGridViewButtonColumn();
				newColumn.Name = name;
				newColumn.Text = name;
				newColumn.UseColumnTextForButtonValue = true;
				dataGridView.Columns.Add(newColumn);
			}
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

		public static int GetRowClickedIdValue(this DataGridView dataGridView, DataGridViewCellEventArgs e, string columnName = "Id")
		{
			try
			{
				DataGridViewRow row1 = dataGridView.Rows[e.RowIndex];
				string? cellValue = row1.Cells[columnName].Value.ToString();
				int.TryParse(cellValue, out int value);
				return value;
			}
			catch (Exception ex)
			{
				return 0;
			}
		}

		public static void Fill(this DataGridView dataGridView, object dataSource)
		{
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataSource;
			dataGridView.DataSource = bindingSource;
		}

		public static void ShowDialog(this Type formType)
		{
			Form form = (Form)Activator.CreateInstance(formType);
			form.ShowDialog();
		}

	}
}
