using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class SignUpRestaurantForm : Form
    {
        private readonly IUnitOfWork _unit;

        public SignUpRestaurantForm(IUnitOfWork unit)
        {
            InitializeComponent();
            _unit = unit;
        }

        #region Events
        private async void RegisterRestaurant_Click(object sender, EventArgs e)
        {
            var restaurant = GetRestaurant();
            if (!restaurant.CheckModelState())
                return;

            restaurant.UserId = Program.userLogin.Id;
            var addResult = await _unit.Restaurant.CreateAsync(restaurant);
            addResult.PrintResultMessages();
            if (addResult.IsSuccess)
                this.Close();
        }

        private void SignUpRestaurantForm_Load(object sender, EventArgs e)
        {
            nameof(RestaurantDashboardForm).HideParentForm();

        }

        private void SignUpRestaurantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            nameof(RestaurantDashboardForm).ShowParentForm();
        }

        #endregion

        #region Methods
        private Restaurant GetRestaurant()
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Name = ResturantNameTextBox.Text.Trim();
            restaurant.Address = AddressTextBox.Text.Trim();
            restaurant.StartTime = FromTimePicker.Text.Trim();
            restaurant.EndTime = ToTimePicker.Text.Trim();
            return restaurant;
        }

        public override bool Equals(object? obj)
        {
            return obj is SignUpRestaurantForm form &&
                   EqualityComparer<IUnitOfWork>.Default.Equals(_unit, form._unit);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_unit);
        }


        #endregion
    }
}
