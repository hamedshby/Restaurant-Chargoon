using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Foods;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class FoodForm : Form
	{
		private readonly FoodService foodService;

		public FoodForm()
		{
			InitializeComponent();
			this.foodService = new FoodService();
			FillgridView();
		}

		private void FoodForm_Load(object sender, EventArgs e)
		{

		}

		private void AddFoodButton_Click(object sender, EventArgs e)
		{
			AddFoodForm addFoodForm = new AddFoodForm();
			addFoodForm.ShowDialog();
		}

		public void FillgridView()
		{
			var foods = foodService.Get(c => c.RestaurantId == Program.RestaurantId)
				.Select(c => new { c.Name, c.Id, c.Price, FoodType = c.FoodType.GetDisplayName() })
				.ToList();
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
