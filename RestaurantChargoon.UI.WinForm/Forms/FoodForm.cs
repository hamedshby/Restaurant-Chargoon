using RestaurantChargoon.Services.Foods;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class FoodForm : Form
	{
		private readonly FoodService foodService;
		private int restaurantId;
		public FoodForm(int restaurantId)
		{
			InitializeComponent();
			this.foodService = new FoodService();
			FillgridView();
			this.restaurantId = restaurantId;
		}

		private void FoodForm_Load(object sender, EventArgs e)
		{

		}

		private void AddFoodButton_Click(object sender, EventArgs e)
		{
			AddFoodForm addFoodForm = new AddFoodForm(restaurantId);
			addFoodForm.ShowDialog();
		}

		public void FillgridView()
		{
			var foods = foodService.Get(c => c.RestaurantId == restaurantId).ToList();
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = foods;
			FoodDataGridView.DataSource = bindingSource;
		}

		public void RefreshButton_Click(object sender, EventArgs e)
		{
			FillgridView();
		}

		private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			RestaurantDashboardForm restaurantDashboardForm = new RestaurantDashboardForm();
			restaurantDashboardForm.Show();
		}
	}
}
