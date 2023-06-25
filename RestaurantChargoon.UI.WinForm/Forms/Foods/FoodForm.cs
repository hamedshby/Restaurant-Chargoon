using FluentResults;
using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.UI.WinForm.Forms.Foods;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class FoodForm : Form
    {
        private readonly IUnitOfWork _unit;

        private int cellCount = 0;
        public FoodForm(IUnitOfWork unit)
        {
            InitializeComponent();
            _unit = unit;
        }

        #region Events
        private void FoodForm_Load(object sender, EventArgs e)
        {
            var restaurantName = _unit.Restaurant.Get(c => c.Id == Program.RestaurantId).FirstOrDefault();
            this.Text = restaurantName == null ? string.Empty : restaurantName.Name;
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

        private async void FoodDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int foodid = FoodDataGridView.GetRowClickedIdValue(e);

            if (e.ColumnIndex == FoodDataGridView.Columns[Resource.Edit].Index)
            {
                EditFoodForm editFoodForm = new EditFoodForm(foodid,_unit);
                editFoodForm.ShowDialog();
            }
            if (e.ColumnIndex == FoodDataGridView.Columns[Resource.Delete].Index)
            {
                DialogResult dialogResult = MessageBox.Show("آیا از حذف این مورد مطمئن هستید؟ ", "هشدار ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Result<int> result = await DeleteFoodAsync(foodid);
                    if (result.IsSuccess)
                        FoodDataGridView.Rows.RemoveAt(e.RowIndex);
                    result.PrintResultMessages();
                }
            }
        }

        #endregion



        #region Methods
        public void FillgridView()
        {
            var foods = _unit.Food.Get(c => c.RestaurantId == Program.RestaurantId)
                .Select(c => new { c.Name, c.Id, c.Price, FoodType = c.FoodType.GetDisplayName() })
                .ToList();
            if (foods.Any())
            {
                FoodDataGridView.Fill(foods);
            }
        }
        public async Task<Result<int>> DeleteFoodAsync(int foodid)
        {
            var food = _unit.Food.GetById(foodid);
            food.IsDeleted = true;
            var result = await _unit.Food.UpdateAsync(food);
            return result;
        }

        #endregion




    }
}
