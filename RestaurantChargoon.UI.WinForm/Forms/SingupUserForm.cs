using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using RestaurantChargoon.Services.Users;

namespace RestaurantChargoon.UI.WinForm.Forms
{
	public partial class SingupUserForm : Form
	{
		private readonly UserService userService;

		public SingupUserForm()
		{
			InitializeComponent();
			this.userService = new UserService();

		}

		public SingupUserForm(string NationalCode)
		{
			InitializeComponent();
			this.userService = new UserService();
			NationalCodeTetxtBox.Text = NationalCode;
		}


		private async void singup_Click(object sender, EventArgs e)
		{
			// Check User Status 
			UserType userStatus = RestaurantManagerCheckBox.Checked ? UserType.RestaurantManager : UserType.User;
			// Check Text of All of TextBox Is empty or not
			bool hasEpmty = false;
			foreach (Control control in this.Controls)
			{
				if (control is TextBox)
				{
					if (string.IsNullOrEmpty(((TextBox)control).Text))
					{
						hasEpmty = true;
						break;
					}

				}
			}
			if (hasEpmty)
			{
				MessageBox.Show("پر کردن تمامی موارد اجباری است");
			}
			else
			{
				// For Check Duplicate Natonal Code
				var checkUser = userService.Get(u => u.NationalCode == NationalCodeTetxtBox.Text).FirstOrDefault();
				if (checkUser != null)
				{
					MessageBox.Show("این کاربر وجود دارد");
				}
				else
				{
					User user = new User()
					{
						Name = NameTetxtBox.Text,
						LastName = LastNameTetxtBox.Text,
						NationalCode = NationalCodeTetxtBox.Text,
						Address = AddressTetxtBox.Text,
						Password = PasswordTetxtBox.Text,
						UserType = userStatus
					};

					var result = await userService.Add(user);
					if (result.IsFailed)
					{
						string errors = string.Empty;
						foreach (var error in result.Errors)
						{
							errors += error.Message + Environment.NewLine;
						}
						MessageBox.Show(errors);
					}
					else
					{
						MessageBox.Show("اطلاعات با موفقیت ثبت گردید");
						if (userStatus == UserType.RestaurantManager)
						{
							SignUpRestaurantForm signUpRestaurantForm = new SignUpRestaurantForm();
							signUpRestaurantForm.ShowDialog();
						}
					}
				}
			}
		}
	}
}
