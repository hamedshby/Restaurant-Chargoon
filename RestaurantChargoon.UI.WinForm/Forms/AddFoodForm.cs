using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Foods;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class AddFoodForm : Form
	{
		private readonly FoodService foodService;
		public int restaurantId;
		public AddFoodForm()
		{
			InitializeComponent();
			this.foodService = new FoodService();
		}

		#region Events
		private void AddFoodForm_Load(object sender, EventArgs e)
		{
			SetFoodTypeComboBox();
		}
				
		private async void SaveButton_Click(object sender, EventArgs e)
		{
			var food = new FoodBuilder()
				.GetName(NameTextBox.Text)
				.GetPrice(PricetextBox.Text)
			.GetFoodType((FoodType)FoodTypeComboBox.SelectedIndex + 1)
			.Build();

			var result = await foodService.Add(food.Value);

			MessageBox.Show(result.Reasons[0].Message);
			FoodForm foodForm = new FoodForm();
			foodForm.FoodDataGridView.Refresh();
			this.Close();	
		}

		#endregion


		#region Methods
		private void SetFoodTypeComboBox()
		{
			var foodTypes = Enum.GetValues(typeof(FoodType)).Cast<FoodType>();
			foreach (var foodType in foodTypes)
			{
				FoodTypeComboBox.Items.Add(foodType.GetDisplayName());
			}
		}
		#endregion
	}
}
