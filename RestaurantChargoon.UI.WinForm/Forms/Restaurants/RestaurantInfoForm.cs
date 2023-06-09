using FluentResults;
using Microsoft.VisualBasic.ApplicationServices;
using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.Restaurants;
using RestaurantChargoon.Services.Users;
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
    public partial class RestaurantInfoForm : Form
    {
        private readonly RestaurantService restaurantService;
        public RestaurantInfoForm()
        {
            InitializeComponent();
            this.restaurantService = new RestaurantService();


        }
        private void RestaurantInfoForm_Load(object sender, EventArgs e)
        {
            nameof(RestaurantDashboardForm).HideParentForm();

            FillTextBox();
            EnableTextBox(false);
        }

        private void FillTextBox()
        {
            var restaurant = restaurantService.Get(c => c.Id == Program.RestaurantId).FirstOrDefault();

            if (restaurant != null)
            {
                ResturantNameTextBox.Text = restaurant.Name;
                FromTimePicker.Text = restaurant.StartTime;
                ToTimePicker.Text = restaurant.EndTime;
                AddressTextBox.Text = restaurant.Address;
            }
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
            var ResResult = GetResResult();
            if (ResResult.IsFailed)
            {
                ResResult.PrintResultMessages();
                return;
            }
            var restaurant = GetRes();
            var result = await restaurantService.UpdateAsync(restaurant);
            result.PrintResultMessages();
            if (ResResult.IsSuccess)
                EnableTextBox(false);
        }

        private Restaurant GetRes()
        {
            var restaurant = restaurantService.Get(c => c.Id == Program.RestaurantId).FirstOrDefault();
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
        public Result<Restaurant> GetResResult()
        {
            var result = new RestaurantBuilder()
              .GetName(ResturantNameTextBox.Text)
              .GetStartTime(FromTimePicker.Text)
              .GetEndTime(ToTimePicker.Text)
              .GetAddress(AddressTextBox.Text)
              .Build();
            return result;
        }

        private void RestaurantInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            nameof(RestaurantDashboardForm).ShowParentForm();
        }

       
    }
}
