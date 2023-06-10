using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Forms.Restaurants;
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
			nameof(SigninUserFrom).ShowParentForm();
		}

		private void RestaurantDashboardForm_Load(object sender, EventArgs e)
		{
			nameof(SigninUserFrom).HideParentForm();
			FillGridView();
		}

		private void RestaurantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{			
			Program.RestaurantId = RestaurantDataGridView.GetRowClickedIdValue(e);
			if (e.ColumnIndex == RestaurantDataGridView.Columns[Resource.ShowMenu].Index)
			{
				FoodForm foodForm = new FoodForm();
				foodForm.ShowDialog();
			}
			if (e.ColumnIndex == RestaurantDataGridView.Columns[Resource.RestaurantEdit].Index)
			{
				RestaurantInfoForm restaurantInfoForm = new RestaurantInfoForm();
				restaurantInfoForm.ShowDialog();
			}
			if (e.ColumnIndex == RestaurantDataGridView.Columns[Resource.ShowFactor].Index)
			{
				RestaurantFactorsForm restaurantFactorForm = new RestaurantFactorsForm();
				restaurantFactorForm.ShowDialog();
			}
		}
		private void RestaurantDashboardForm_VisibleChanged(object sender, EventArgs e)
		{
			FillGridView();
		}


		#endregion


		#region Methods
		public void FillGridView()
		{
			var foods = restaurantService.Get(r => r.UserId == Program.userLogin.Id)
				.Select(c => new { c.Id, c.Name, c.StartTime, c.EndTime, c.Address })
				.ToList();
			if (foods.Any())
			{
				BindingSource bindingSource = new BindingSource();
				bindingSource.DataSource = foods;
				RestaurantDataGridView.DataSource = bindingSource;
				RestaurantDataGridView.AddBottonColumn(Resource.RestaurantEdit);
				RestaurantDataGridView.AddBottonColumn(Resource.ShowMenu);
				RestaurantDataGridView.AddBottonColumn(Resource.ShowFactor);
			}
		}

		#endregion


	}

}
