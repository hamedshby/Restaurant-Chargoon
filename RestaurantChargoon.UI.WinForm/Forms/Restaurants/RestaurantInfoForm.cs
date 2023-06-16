using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms.Restaurants
{
	public partial class RestaurantInfoForm : Form
	{
		private readonly IUnitOfWork _unit;
		public RestaurantInfoForm(IUnitOfWork unit)
		{
			InitializeComponent();
			_unit = unit;
		}

		#region Events
		private void RestaurantInfoForm_Load(object sender, EventArgs e)
		{
			nameof(RestaurantDashboardForm).HideParentForm();
			FillTextBox();
			EnableTextBox(false);
		}

		private void RestaurantInfoForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			nameof(RestaurantDashboardForm).ShowParentForm();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			EnableTextBox(false);
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			EnableTextBox(true);
		}

		private async void SaveButton_Click(object sender, EventArgs e)
		{
			var restaurant = GetRestaurant();
			if (!restaurant.CheckModelState())
				return;
			restaurant.UserId = Program.userLogin.Id;
			restaurant.Id = Program.RestaurantId;

			var editResult = await _unit.Restaurant.UpdateAsync(restaurant);
			editResult.PrintResultMessages();
			if (editResult.IsSuccess)
				EnableTextBox(false);
		}
		#endregion

		#region Methods
		private void FillTextBox()
		{
			var restaurant = _unit.Restaurant.Get(c => c.Id == Program.RestaurantId).FirstOrDefault();

			if (restaurant != null)
			{
				ResturantNameTextBox.Text = restaurant.Name;
				FromTimePicker.Text = restaurant.StartTime;
				ToTimePicker.Text = restaurant.EndTime;
				AddressTextBox.Text = restaurant.Address;
			}
		}

		private Restaurant GetRes()
		{
			var restaurant = _unit.Restaurant.Get(c => c.Id == Program.RestaurantId).FirstOrDefault();
			if (restaurant != null)
			{
				restaurant.Name = ResturantNameTextBox.Text;
				restaurant.StartTime = FromTimePicker.Text;
				restaurant.EndTime = ToTimePicker.Text;
				restaurant.Address = AddressTextBox.Text;
			}
			return restaurant;
		}

		private void EnableTextBox(bool enableTextBox)
		{
			ResturantNameTextBox.Enabled = enableTextBox;
			FromTimePicker.Enabled = enableTextBox;
			ToTimePicker.Enabled = enableTextBox;
			AddressTextBox.Enabled = enableTextBox;
		}

		private Restaurant GetRestaurant()
		{
			Restaurant restaurant = new Restaurant();
			restaurant.Name = ResturantNameTextBox.Text.Trim();
			restaurant.Address = AddressTextBox.Text.Trim();
			restaurant.StartTime = FromTimePicker.Text.Trim();
			restaurant.EndTime = ToTimePicker.Text.Trim();
			return restaurant;
		}
		#endregion
	}
}
