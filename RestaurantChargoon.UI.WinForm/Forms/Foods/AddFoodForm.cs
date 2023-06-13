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
            var food = GetFood();
			if (!food.CheckModelState())
				return;

            food.RestaurantId = Program.RestaurantId;
            var result = await foodService.AddAsync(food);
            result.PrintResultMessages();
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

        private Food GetFood()
        {
            var food = new Food();
            food.Name = NameTextBox.Text.Trim();
            food.Price = decimal.Parse(PricetextBox.Text.Trim());
            food.FoodType = (FoodType)FoodTypeComboBox.SelectedIndex + 1;
            return food;
        }

        #endregion

       
    }
}
