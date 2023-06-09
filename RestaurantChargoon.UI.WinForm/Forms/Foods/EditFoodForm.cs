using FluentResults;
using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Foods;
using RestaurantChargoon.UI.WinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantChargoon.UI.WinForm.Forms.Foods
{
    public partial class EditFoodForm : Form
    {
        private readonly FoodService foodService;
        private Food food = new Food();
        public EditFoodForm(int rowId)
        {
            InitializeComponent();
            this.foodService = new FoodService();
            food = foodService.GetById(rowId);
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
            var result = await foodService.UpdateAsync(food);
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
            FoodTypeComboBox.SelectedValue = food.FoodType;
        }

        private void EditFoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            nameof(FoodForm).ShowParentForm();

        }
    }
}
