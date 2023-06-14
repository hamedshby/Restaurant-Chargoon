﻿using Restaurant_Chargoon.UI.WinForm;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.Users;
using RestaurantChargoon.UI.WinForm.Forms.Users;
using RestaurantChargoon.UI.WinForm.Services;

namespace RestaurantChargoon.UI.WinForm.Forms
{
    public partial class SigninUserFrom : Form
    {
        private readonly UserService userService;
        public SigninUserFrom()
        {
            InitializeComponent();
            this.userService = new UserService();
        }

        #region Events
        private void enter_Click(object sender, EventArgs e)
        {
            var user = userService.CheckUserPassword(NationalCodeTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
            if (user == null)
            {
                FormService.ShowErrorMessageBox("نام کاربری یا پسورد اشتباه هست");
                return;
            }
            Program.userLogin = user;
            if (user.UserType == UserType.RestaurantManager)
            {
                typeof(RestaurantDashboardForm).ShowDialog();
            }
            else if (user.UserType == UserType.User)
            {
                typeof(UserDashboardForm).ShowDialog();
            }
        }

        private void SigninUserFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            nameof(MainForm).ShowParentForm();
        }

        private void SigninUserFrom_Load(object sender, EventArgs e)
        {
            nameof(MainForm).HideParentForm();
            FillTextBox();
        }

        #endregion

        private void NationalCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FillTextBox()
        {
            var sysname = System.Environment.MachineName;
            if (sysname == "DESKTOP-12BF9LQ")
            {
                var user = userService.Get(c => c.UserType == UserType.RestaurantManager).FirstOrDefault();
                if (user != null)
                {
                    NationalCodeTextBox.Text = user.NationalCode;
                    PasswordTextBox.Text = user.Password;
                }
            }
        }
    }
}
