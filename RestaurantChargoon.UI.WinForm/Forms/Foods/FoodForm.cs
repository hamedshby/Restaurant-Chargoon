using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Foods;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class FoodForm : Form
	{
		private readonly FoodService foodService;
		private readonly RestaurantService restaurantService;

		private int cellCount = 0;
		public FoodForm()
		{
			InitializeComponent();
			this.foodService = new FoodService();
			this.restaurantService = new RestaurantService();
		}

		#region Events
		private void FoodForm_Load(object sender, EventArgs e)
		{
			var restaurantName = restaurantService.Get(c => c.Id == Program.RestaurantId).FirstOrDefault().Name;
			this.Text = restaurantName;
			nameof(RestaurantDashboardForm).HideParentForm();
			FillgridView();
		}

		private void AddFoodButton_Click(object sender, EventArgs e)
		{
			AddFoodForm addFoodForm = new AddFoodForm();
			addFoodForm.ShowDialog();
		}

		public void RefreshButton_Click(object sender, EventArgs e)
		{
			FillgridView();
		}

		private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(RestaurantDashboardForm).ShowParentForm();
		}

		private void FoodDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//if (e.ColumnIndex == FoodDataGridView.Columns["مشاهده منو"].Index)
			//{
			//    //Do something with your button.
			//}
		}

		#endregion



		#region Methods
		public void FillgridView()
		{
			FoodDataGridView.Rows.Clear();
			var foods = foodService.Get(c => c.RestaurantId == Program.RestaurantId)
				.Select(c => new { c.Name, c.Id, c.Price, FoodType = c.FoodType.GetDisplayName() })
				.ToList();
			if (foods.Any())
			{
				BindingSource bindingSource = new BindingSource();
				bindingSource.DataSource = foods;
				FoodDataGridView.DataSource = bindingSource;
			}
		}


		#endregion

		private void FoodForm_VisibleChanged(object sender, EventArgs e)
		{
			FillgridView();
		}
	}
}
