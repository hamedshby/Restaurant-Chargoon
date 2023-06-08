namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	partial class UserInfoForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			AddressTetxtBox = new TextBox();
			PasswordTetxtBox = new TextBox();
			NationalCodeTetxtBox = new TextBox();
			LastNameTetxtBox = new TextBox();
			NameTetxtBox = new TextBox();
			RestaurantManagerCheckBox = new CheckBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			EditButton = new Button();
			CancelButton = new Button();
			SaveButton = new Button();
			SuspendLayout();
			// 
			// AddressTetxtBox
			// 
			AddressTetxtBox.Location = new Point(51, 288);
			AddressTetxtBox.Name = "AddressTetxtBox";
			AddressTetxtBox.RightToLeft = RightToLeft.Yes;
			AddressTetxtBox.Size = new Size(242, 27);
			AddressTetxtBox.TabIndex = 23;
			// 
			// PasswordTetxtBox
			// 
			PasswordTetxtBox.Location = new Point(51, 225);
			PasswordTetxtBox.Name = "PasswordTetxtBox";
			PasswordTetxtBox.PasswordChar = '*';
			PasswordTetxtBox.Size = new Size(242, 27);
			PasswordTetxtBox.TabIndex = 22;
			// 
			// NationalCodeTetxtBox
			// 
			NationalCodeTetxtBox.Location = new Point(51, 149);
			NationalCodeTetxtBox.Name = "NationalCodeTetxtBox";
			NationalCodeTetxtBox.Size = new Size(242, 27);
			NationalCodeTetxtBox.TabIndex = 21;
			// 
			// LastNameTetxtBox
			// 
			LastNameTetxtBox.Location = new Point(51, 81);
			LastNameTetxtBox.Name = "LastNameTetxtBox";
			LastNameTetxtBox.RightToLeft = RightToLeft.Yes;
			LastNameTetxtBox.Size = new Size(242, 27);
			LastNameTetxtBox.TabIndex = 20;
			// 
			// NameTetxtBox
			// 
			NameTetxtBox.Location = new Point(51, 18);
			NameTetxtBox.Name = "NameTetxtBox";
			NameTetxtBox.RightToLeft = RightToLeft.Yes;
			NameTetxtBox.Size = new Size(242, 27);
			NameTetxtBox.TabIndex = 19;
			// 
			// RestaurantManagerCheckBox
			// 
			RestaurantManagerCheckBox.AutoSize = true;
			RestaurantManagerCheckBox.Enabled = false;
			RestaurantManagerCheckBox.Location = new Point(179, 350);
			RestaurantManagerCheckBox.Name = "RestaurantManagerCheckBox";
			RestaurantManagerCheckBox.RightToLeft = RightToLeft.Yes;
			RestaurantManagerCheckBox.Size = new Size(113, 24);
			RestaurantManagerCheckBox.TabIndex = 18;
			RestaurantManagerCheckBox.Text = "مدیر رستوران";
			RestaurantManagerCheckBox.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(317, 288);
			label5.Name = "label5";
			label5.Size = new Size(44, 20);
			label5.TabIndex = 17;
			label5.Text = "آدرس";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(317, 225);
			label4.Name = "label4";
			label4.Size = new Size(48, 20);
			label4.TabIndex = 16;
			label4.Text = "پسورد";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(317, 156);
			label3.Name = "label3";
			label3.Size = new Size(56, 20);
			label3.TabIndex = 15;
			label3.Text = "کد ملی";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(317, 81);
			label2.Name = "label2";
			label2.Size = new Size(90, 20);
			label2.TabIndex = 14;
			label2.Text = "نام خانوادگی";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(317, 18);
			label1.Name = "label1";
			label1.Size = new Size(27, 20);
			label1.TabIndex = 13;
			label1.Text = "نام";
			// 
			// EditButton
			// 
			EditButton.Location = new Point(293, 404);
			EditButton.Name = "EditButton";
			EditButton.Size = new Size(94, 29);
			EditButton.TabIndex = 24;
			EditButton.Text = "ویرایش";
			EditButton.UseVisualStyleBackColor = true;
			EditButton.Click += EditButton_Click;
			// 
			// CancelButton
			// 
			CancelButton.Location = new Point(165, 404);
			CancelButton.Name = "CancelButton";
			CancelButton.Size = new Size(94, 29);
			CancelButton.TabIndex = 25;
			CancelButton.Text = "انصراف";
			CancelButton.UseVisualStyleBackColor = true;
			CancelButton.Click += CancelButton_Click;
			// 
			// SaveButton
			// 
			SaveButton.Location = new Point(37, 404);
			SaveButton.Name = "SaveButton";
			SaveButton.Size = new Size(94, 29);
			SaveButton.TabIndex = 26;
			SaveButton.Text = "ذخیره";
			SaveButton.UseVisualStyleBackColor = true;
			SaveButton.Click += SaveButton_Click;
			// 
			// UserInfoForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(425, 472);
			Controls.Add(SaveButton);
			Controls.Add(CancelButton);
			Controls.Add(EditButton);
			Controls.Add(AddressTetxtBox);
			Controls.Add(PasswordTetxtBox);
			Controls.Add(NationalCodeTetxtBox);
			Controls.Add(LastNameTetxtBox);
			Controls.Add(NameTetxtBox);
			Controls.Add(RestaurantManagerCheckBox);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			MaximumSize = new Size(443, 519);
			MinimumSize = new Size(443, 519);
			Name = "UserInfoForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "اطلاعات کاربر";
			FormClosed += UserInfoForm_FormClosed;
			Load += UserInfoForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox AddressTetxtBox;
		private TextBox PasswordTetxtBox;
		private TextBox NationalCodeTetxtBox;
		private TextBox LastNameTetxtBox;
		private TextBox NameTetxtBox;
		private CheckBox RestaurantManagerCheckBox;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button EditButton;
		private Button CancelButton;
		private Button SaveButton;
	}
}