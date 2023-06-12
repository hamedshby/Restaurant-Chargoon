using FluentResults;
using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Forms.Restaurants;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class RestaurantDashboardForm : Form
    {
        private readonly RestaurantService restaurantService;
        public RestaurantDashboardForm()
        {
            InitializeComponent();
            this.restaurantService = new RestaurantService();
        }

        #region Events
        private void AddRestaurantButton_Click(object sender, EventArgs e)
        {
            typeof(SignUpRestaurantForm).ShowDialog();
        }

        private void RestaurantDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            nameof(SigninUserFrom).ShowParentForm();
        }

        private void RestaurantDashboardForm_Load(object sender, EventArgs e)
        {
            nameof(SigninUserFrom).HideParentForm();
        }

        private async void RestaurantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.RestaurantId = RestaurantDataGridView.GetRowClickedIdValue(e);
            int restaurantid = RestaurantDataGridView.GetRowClickedIdValue(e);
            if (e.ColumnIndex == RestaurantDataGridView.Columns[Resource.ShowMenu].Index)
            {
                typeof(FoodForm).ShowDialog();
            }
            else if (e.ColumnIndex == RestaurantDataGridView.Columns[Resource.Edit].Index)
            {
                typeof(RestaurantInfoForm).ShowDialog();
            }
            else if (e.ColumnIndex == RestaurantDataGridView.Columns[Resource.ShowFactors].Index)
            {
                typeof(RestaurantFactorsForm).ShowDialog();
            }
            else if (e.ColumnIndex == RestaurantDataGridView.Columns[Resource.Delete].Index)
            {
                DialogResult dialogResult = MessageBox.Show("آیا از حذف این مورد مطمئن هستید؟ ", "هشدار ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Result<int> result = await DeleteRestaurantAsync(restaurantid);
                    if (result.IsSuccess)
                        RestaurantDataGridView.Rows.RemoveAt(e.RowIndex);
                    result.PrintResultMessages();
                }
            }
        }
        private void RestaurantDashboardForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                FillGridView();
        }


        #endregion


        #region Methods
        public void FillGridView()
        {
            var foods = restaurantService.Get(r => r.UserId == Program.userLogin.Id)
                .Select(c => new { c.Id, c.Name, c.StartTime, c.EndTime, c.Address })
                .ToList();
            if (foods.Any())
            {
                RestaurantDataGridView.Fill(foods);
            }
        }
        public async Task<Result<int>> DeleteRestaurantAsync(int restaurantid)
        {
            var restaurant = restaurantService.GetById(restaurantid);
            restaurant.IsDeleted = true;
            var result = await restaurantService.UpdateAsync(restaurant);
            return result;
        }

        #endregion


    }

}
