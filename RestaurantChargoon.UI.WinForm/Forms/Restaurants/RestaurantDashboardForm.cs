using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class RestaurantDashboardForm : Form
	{
		private readonly RestaurantService restaurantService;
		private int cellCount = 0;
		public RestaurantDashboardForm()
		{
			InitializeComponent();
			this.restaurantService = new RestaurantService();
		}

		#region Events
		private void AddRestaurantButton_Click(object sender, EventArgs e)
		{
			SignUpRestaurantForm signUpRestaurantForm = new SignUpRestaurantForm();
			signUpRestaurantForm.ShowDialog();

		}

		private void RestaurantDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SigninUserFrom signinUserFrom = Application.OpenForms["SigninUserFrom"] as SigninUserFrom;
			if (signinUserFrom != null)
			{
				signinUserFrom.Close();
			}
			MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
			if (mainForm != null)
			{
				mainForm.Show();
			}
		}

		private void RestaurantDashboardForm_Load(object sender, EventArgs e)
		{
			SigninUserFrom signinUserFrom = Application.OpenForms["SigninUserFrom"] as SigninUserFrom;
			if (signinUserFrom != null)
			{
				signinUserFrom.Hide();
			}
			FillgridView();
		}

		private void RestaurantDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (cellCount == 1)
				return;
			cellCount += 1;
			FormService.AddBottonToGrid("ویرایش رستوران", 5, RestaurantDataGridView);
			FormService.AddBottonToGrid("مشاهده منو", 6, RestaurantDataGridView);
		}

		private void RestaurantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == RestaurantDataGridView.Columns["مشاهده منو"].Index)
			{
				DataGridViewRow row = RestaurantDataGridView.Rows[e.RowIndex];
				int.TryParse(row.Cells[2].Value.ToString(), out Program.RestaurantId);
				string restaurantName = row.Cells[3].Value.ToString();
				FoodForm foodForm = new FoodForm();
				foodForm.ShowDialog();
			}
		}

		#endregion


		#region Methods
		public void FillgridView()
		{
			var foods = restaurantService.Get(r => r.UserId == Program.userLogin.Id).Select(c =>
			new
			{
				c.Id,
				c.Name,
				c.StartTime,
				c.EndTime,
				c.Address
			});
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = foods;
			RestaurantDataGridView.DataSource = bindingSource;
		}


		private int GetRowIdSelected()
		{
			if (RestaurantDataGridView.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = RestaurantDataGridView.SelectedRows[0];
				int.TryParse(selectedRow.Cells[0].Value.ToString(), out int restaurantId);
				Program.RestaurantId = restaurantId;
				return restaurantId;
			}
			return 0;
		}
		#endregion
	}

}
