using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.ExtensionMethods;
using RestaurantChargoon.Services.Foods;
using RestaurantChargoon.Services.Restaurants;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class FoodForm : Form
    {
        private readonly FoodService foodService;
        private readonly RestaurantService restaurantService;

        private int cellCount = 0;
        public FoodForm()
        {
            InitializeComponent();
            this.foodService = new FoodService();
            this.restaurantService = new RestaurantService();
        }

        #region Events
        private void FoodForm_Load(object sender, EventArgs e)
        {
            var restaurantName = restaurantService.Get(c => c.Id == Program.RestaurantId).FirstOrDefault().Name;
            this.Text = restaurantName;
            RestaurantDashboardForm restaurantDashboardForm = Application.OpenForms["RestaurantDashboardForm"] as RestaurantDashboardForm;
            if (restaurantDashboardForm != null)
            {
                restaurantDashboardForm.Hide();
            }
            FillgridView();
        }

        private void AddFoodButton_Click(object sender, EventArgs e)
        {
            AddFoodForm addFoodForm = new AddFoodForm();
            addFoodForm.ShowDialog();
        }
        private void FoodDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (cellCount == 1)
                return;
            cellCount += 1;
            //FormService.AddBottonToGrid("ویرایش رستوران", 4, FoodDataGridView);
            //FormService.AddBottonToGrid("مشاهده منو", 4, FoodDataGridView);
        }

        public void RefreshButton_Click(object sender, EventArgs e)
        {
            FillgridView();
        }

        private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RestaurantDashboardForm restaurantDashboardForm = Application.OpenForms["RestaurantDashboardForm"] as RestaurantDashboardForm;
            if (restaurantDashboardForm != null)
            {
                restaurantDashboardForm.Show();
            }
            else
            {
                RestaurantDashboardForm restaurantForm=new RestaurantDashboardForm();
                restaurantForm.Show();
            }
        }

        private void FoodDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == FoodDataGridView.Columns["مشاهده منو"].Index)
            //{
            //    //Do something with your button.
            //}
        }

        #endregion



        #region Methods
        public void FillgridView()
        {
            var foods = foodService.Get(c => c.RestaurantId == Program.RestaurantId)
                .Select(c => new { c.Name, c.Id, c.Price, FoodType = c.FoodType.GetDisplayName() })
                .ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = foods;
            FoodDataGridView.DataSource = bindingSource;
        }


        #endregion
    }
}
