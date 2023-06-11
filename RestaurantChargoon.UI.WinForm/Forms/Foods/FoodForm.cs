using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Foods;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Forms.Foods;
using RestaurantChargoon.UI.WinForm.Resources;
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
		}

		private void AddFoodButton_Click(object sender, EventArgs e)
		{
			typeof(AddFoodForm).ShowDialog();
		}

		private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(RestaurantDashboardForm).ShowParentForm();
		}

		private void FoodForm_VisibleChanged(object sender, EventArgs e)
		{
			FillgridView();
		}

		private void FoodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int foodid = FoodDataGridView.GetRowClickedIdValue(e);

			if (e.ColumnIndex == FoodDataGridView.Columns[Resource.Edit].Index)
			{
				EditFoodForm editFoodForm = new EditFoodForm(foodid);
				editFoodForm.ShowDialog();
			}
			if (e.ColumnIndex == FoodDataGridView.Columns[Resource.Delete].Index)
			{

			}
		}

		#endregion



		#region Methods
		public void FillgridView()
		{
			var foods = foodService.Get(c => c.RestaurantId == Program.RestaurantId)
				.Select(c => new { c.Name, c.Id, c.Price, FoodType = c.FoodType.GetDisplayName() })
				.ToList();
			if (foods.Any())
			{
				FoodDataGridView.Fill(foods);
			}
		}


		#endregion



		
	}
}
