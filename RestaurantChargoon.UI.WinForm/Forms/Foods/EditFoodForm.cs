using FluentResults;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Foods;
using RestaurantChargoon.UI.WinForm.Services;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms.Foods
{
	public partial class EditFoodForm : Form
	{
		private readonly FoodService foodService;
		private int foodid;
		private Food food;
		public EditFoodForm(int FoodId)
		{
			InitializeComponent();
			this.foodService = new FoodService();
			foodid = FoodId;
			food = foodService.GetById(foodid);
		}

		private async void SaveButton_Click(object sender, EventArgs e)
		{
			var foodResult = GetFoodResult();
			if (foodResult.IsFailed)
			{
				foodResult.PrintResultMessages();
				return;
			}
			var food2 = foodService.GetById(foodid);
			food2.Name = NameTextBox.Text;
			food2.FoodType = (FoodType)FoodTypeComboBox.SelectedIndex + 1;
			food2.Price = Convert.ToDecimal(PricetextBox.Text);
			var result = await foodService.UpdateAsync(food2);
			result.PrintResultMessages();
		}
		private void SetFoodTypeComboBox()
		{
			var foodTypes = Enum.GetValues(typeof(FoodType)).Cast<FoodType>();
			foreach (var foodType in foodTypes)
			{
				FoodTypeComboBox.Items.Add(foodType.GetDisplayName());
			}
		}
		private Result<Food> GetFoodResult()
		{
			var foodResult = new FoodBuilder()
				.GetName(NameTextBox.Text)
				.GetPrice(PricetextBox.Text)
			.GetFoodType((FoodType)FoodTypeComboBox.SelectedIndex + 1)
			.Build();
			return foodResult;
		}

		private void EditFoodForm_Load(object sender, EventArgs e)
		{
			nameof(FoodForm).HideParentForm();
			SetFoodTypeComboBox();
			NameTextBox.Text = food.Name;
			PricetextBox.Text = food.Price.ToString();
			FoodTypeComboBox.SelectedIndex = Convert.ToInt32(food.FoodType) - 1;
		}

		private void EditFoodForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(FoodForm).ShowParentForm();

		}
	}
}
