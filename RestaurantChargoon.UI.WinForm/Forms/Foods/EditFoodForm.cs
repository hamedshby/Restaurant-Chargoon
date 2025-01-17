﻿using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.UI.WinForm.Services;
using System.Data;

namespace RestaurantChargoon.UI.WinForm.Forms.Foods
{
    public partial class EditFoodForm : Form
    {
        private readonly IUnitOfWork _unit;
        private int foodid;

        public EditFoodForm(int FoodId, IUnitOfWork unit)
        {
            InitializeComponent();
            foodid = FoodId;
            _unit = unit;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var food = GetFood();
            if (!food.CheckModelState())
                return;
            var result = await _unit.Food.UpdateAsync(food);
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


        private Food GetFood()
        {
            var food = _unit.Food.GetById(foodid);
            food.Name = NameTextBox.Text.Trim();
            food.Price = decimal.Parse(PricetextBox.Text.Trim());
            food.FoodType = (FoodType)FoodTypeComboBox.SelectedIndex + 1;
            return food;
        }
        private void EditFoodForm_Load(object sender, EventArgs e)
        {
            Food food = _unit.Food.GetById(foodid);
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

        private void PricetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
