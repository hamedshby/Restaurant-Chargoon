using FluentResults;
using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
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
        public AddFoodForm()
        {
            InitializeComponent();
            this.foodService = new FoodService();
        }

        #region Events
        private void AddFoodForm_Load(object sender, EventArgs e)
        {
           nameof(FoodForm).HideParentForm();
            SetFoodTypeComboBox();
        }

        private void AddFoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			nameof(FoodForm).ShowParentForm();
		}

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var foodResult = GetFoodResult();
            if (foodResult.IsFailed)
            {
                foodResult.PrintResultMessages();
                return;
            }
            var food = foodResult.Value;
            food.RestaurantId = Program.RestaurantId;
            var result = await foodService.AddAsync(food);
            result.PrintResultMessages();           
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

        private Result<Food> GetFoodResult()
        {
            var foodResult = new FoodBuilder()
                .GetName(NameTextBox.Text)
                .GetPrice(PricetextBox.Text)
            .GetFoodType((FoodType)FoodTypeComboBox.SelectedIndex + 1)
            .Build();
            return foodResult;
        }
        #endregion

       
    }
}
