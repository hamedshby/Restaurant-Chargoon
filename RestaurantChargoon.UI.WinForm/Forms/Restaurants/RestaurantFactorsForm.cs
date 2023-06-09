using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Services.Factors;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Forms.Users;
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

namespace RestaurantChargoon.UI.WinForm.Forms.Restaurants
{
    public partial class RestaurantFactorsForm : Form
    {
        private readonly FactorService factorService;
        private readonly FactorDetailService factorDetailService;
        private readonly RestaurantService restaurantService;
        private readonly UserService userService;

        public RestaurantFactorsForm()
        {
            InitializeComponent();
            factorService = new FactorService();
            this.restaurantService = new RestaurantService();
            this.factorDetailService = new FactorDetailService();
            this.userService = new UserService();
        }

        private void RestaurantFactorsForm_Load(object sender, EventArgs e)
        {
            nameof(RestaurantDashboardForm).HideParentForm();
            FillGridView();

        }

        private void RestaurantFactorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            nameof(RestaurantDashboardForm).ShowParentForm();
        }

        public void FillGridView()
        {
            var factors = factorService.Get(c => c.RestaurantId == Program.RestaurantId)
            .Select(c => new
            {
                c.Id,
                UserName = userService.GetById(c.UserId).Name,
                RestaurantName = restaurantService.GetById(c.RestaurantId).Name,
                TotalPrice = factorDetailService.SumOfFactor(c.Id)
            })
                .OrderByDescending(c => c.Id)
                .ToList();
            if (factors.Any())
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = factors;
                UserFactorDataGridView.DataSource = bindingSource;
                UserFactorDataGridView.AddBottonColumn("مشاهده ی جزییات");
            }
        }

        private void UserFactorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == UserFactorDataGridView.Columns["مشاهده ی جزییات"].Index)
            {
                DataGridViewRow row = UserFactorDataGridView.Rows[e.RowIndex];
                foreach (DataGridViewColumn itm in UserFactorDataGridView.Columns)
                {
                    if (itm.DataPropertyName == "Id")
                    {
                        int.TryParse(row.Cells[itm.Index].Value.ToString(), out int factorId);
                        UserFactorDetailForm form = new UserFactorDetailForm(factorId);
                        form.ShowDialog();
                        break;
                    }
                }
            }
        }
    }
}
