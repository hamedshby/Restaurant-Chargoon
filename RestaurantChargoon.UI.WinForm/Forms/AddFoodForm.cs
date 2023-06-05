using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Foods;
using RestaurantChargoon.UI.WinForm.Services;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class AddFoodForm : Form
	{
		private readonly FoodService foodService;
		private int restaurantId;

		public AddFoodForm(int restaurantId)
		{
			InitializeComponent();
			this.foodService = new FoodService();
			this.restaurantId = restaurantId;
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

			if (food.IsFailed)
			{
				string errorMessage = food.GetResultErrors();
				FormService.ShowErrorMessageBox(errorMessage);
				return;
			}

			var result = await foodService.Add(food.Value);
			FormService.ShowErrorMessageBox(result.Reasons[0].Message);
			if (result.IsSuccess)
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
