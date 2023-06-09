using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Forms.Restaurants;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class RestaurantDashboardForm : Form
    {
        private readonly RestaurantService restaurantService;
        private int cellCount = 0;
        public RestaurantDashboardForm()
        {
            InitializeComponent();
            this.restaurantService = new RestaurantService();
        }

        #region Events
        private void AddRestaurantButton_Click(object sender, EventArgs e)
        {
            SignUpRestaurantForm signUpRestaurantForm = new SignUpRestaurantForm();
            signUpRestaurantForm.ShowDialog();

        }

        private void RestaurantDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            nameof(SigninUserFrom).ShowParentForm();
        }

        private void RestaurantDashboardForm_Load(object sender, EventArgs e)
        {
            nameof(SigninUserFrom).HideParentForm();
            FillGridView();
        }

        private void RestaurantDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (cellCount == 1)
            //	return;
            //cellCount += 1;
            //FormService.AddBottonToGrid("ویرایش رستوران", 5, RestaurantDataGridView);
            //FormService.AddBottonToGrid("مشاهده منو", 6, RestaurantDataGridView);
        }

        private void RestaurantDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == RestaurantDataGridView.Columns["مشاهده منو"].Index)
            {
                foreach (DataGridViewColumn itm in RestaurantDataGridView.Columns)
                {
                    if (itm.DataPropertyName == "Id")
                    {
                        DataGridViewRow row = RestaurantDataGridView.Rows[e.RowIndex];
                        int.TryParse(row.Cells[itm.Index].Value.ToString(), out Program.RestaurantId);
                        FoodForm foodForm = new FoodForm();
                        foodForm.ShowDialog();
                        break;
                    }
                }
            }
            if (e.ColumnIndex == RestaurantDataGridView.Columns["ویرایش رستوران"].Index)
            {
                foreach (DataGridViewColumn itm in RestaurantDataGridView.Columns)
                {
                    if (itm.DataPropertyName == "Id")
                    {
                        DataGridViewRow row = RestaurantDataGridView.Rows[e.RowIndex];
                        int.TryParse(row.Cells[itm.Index].Value.ToString(), out Program.RestaurantId);
                        RestaurantInfoForm restaurantInfoForm = new RestaurantInfoForm();
                        restaurantInfoForm.ShowDialog();
                        break;
                    }
                }
            }
        }
        private void RestaurantDashboardForm_VisibleChanged(object sender, EventArgs e)
        {
            FillGridView();
        }


        #endregion


        #region Methods
        public void FillGridView()
        {
            var foods = restaurantService.Get(r => r.UserId == Program.userLogin.Id).ToList()
                .Select(c => new { c.Id, c.Name, c.StartTime, c.EndTime, c.Address });
            if (foods.Any())
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = foods;
                RestaurantDataGridView.DataSource = bindingSource;
                RestaurantDataGridView.AddBottonColumn("ویرایش رستوران");
                RestaurantDataGridView.AddBottonColumn("مشاهده منو");
            }
        }

        #endregion


    }

}
