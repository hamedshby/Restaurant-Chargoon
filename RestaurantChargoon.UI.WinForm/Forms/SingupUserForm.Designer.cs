namespace RestaurantChargoon.UI.WinForm.Forms
{
	partial class SingupUserForm
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			RestaurantManagerCheckBox = new CheckBox();
			NameTetxtBox = new TextBox();
			LastNameTetxtBox = new TextBox();
			NationalCodeTetxtBox = new TextBox();
			PasswordTetxtBox = new TextBox();
			AddressTetxtBox = new TextBox();
			singup = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(321, 31);
			label1.Name = "label1";
			label1.Size = new Size(21, 15);
			label1.TabIndex = 0;
			label1.Text = "نام";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(321, 78);
			label2.Name = "label2";
			label2.Size = new Size(69, 15);
			label2.TabIndex = 1;
			label2.Text = "نام خانوادگی";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(321, 134);
			label3.Name = "label3";
			label3.Size = new Size(43, 15);
			label3.TabIndex = 2;
			label3.Text = "کد ملی";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(321, 186);
			label4.Name = "label4";
			label4.Size = new Size(37, 15);
			label4.TabIndex = 3;
			label4.Text = "پسورد";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(321, 233);
			label5.Name = "label5";
			label5.Size = new Size(34, 15);
			label5.TabIndex = 4;
			label5.Text = "آدرس";
			// 
			// RestaurantManagerCheckBox
			// 
			RestaurantManagerCheckBox.AutoSize = true;
			RestaurantManagerCheckBox.Location = new Point(200, 280);
			RestaurantManagerCheckBox.Margin = new Padding(3, 2, 3, 2);
			RestaurantManagerCheckBox.Name = "RestaurantManagerCheckBox";
			RestaurantManagerCheckBox.RightToLeft = RightToLeft.Yes;
			RestaurantManagerCheckBox.Size = new Size(90, 19);
			RestaurantManagerCheckBox.TabIndex = 7;
			RestaurantManagerCheckBox.Text = "مدیر رستوران";
			RestaurantManagerCheckBox.UseVisualStyleBackColor = true;
			// 
			// NameTetxtBox
			// 
			NameTetxtBox.Location = new Point(88, 31);
			NameTetxtBox.Margin = new Padding(3, 2, 3, 2);
			NameTetxtBox.Name = "NameTetxtBox";
			NameTetxtBox.Size = new Size(212, 23);
			NameTetxtBox.TabIndex = 8;
			// 
			// LastNameTetxtBox
			// 
			LastNameTetxtBox.Location = new Point(88, 78);
			LastNameTetxtBox.Margin = new Padding(3, 2, 3, 2);
			LastNameTetxtBox.Name = "LastNameTetxtBox";
			LastNameTetxtBox.Size = new Size(212, 23);
			LastNameTetxtBox.TabIndex = 9;
			// 
			// NationalCodeTetxtBox
			// 
			NationalCodeTetxtBox.Location = new Point(88, 129);
			NationalCodeTetxtBox.Margin = new Padding(3, 2, 3, 2);
			NationalCodeTetxtBox.Name = "NationalCodeTetxtBox";
			NationalCodeTetxtBox.Size = new Size(212, 23);
			NationalCodeTetxtBox.TabIndex = 10;
			// 
			// PasswordTetxtBox
			// 
			PasswordTetxtBox.Location = new Point(88, 186);
			PasswordTetxtBox.Margin = new Padding(3, 2, 3, 2);
			PasswordTetxtBox.Name = "PasswordTetxtBox";
			PasswordTetxtBox.Size = new Size(212, 23);
			PasswordTetxtBox.TabIndex = 11;
			// 
			// AddressTetxtBox
			// 
			AddressTetxtBox.Location = new Point(88, 233);
			AddressTetxtBox.Margin = new Padding(3, 2, 3, 2);
			AddressTetxtBox.Name = "AddressTetxtBox";
			AddressTetxtBox.Size = new Size(212, 23);
			AddressTetxtBox.TabIndex = 12;
			// 
			// singup
			// 
			singup.Location = new Point(136, 320);
			singup.Margin = new Padding(3, 2, 3, 2);
			singup.Name = "singup";
			singup.Size = new Size(130, 35);
			singup.TabIndex = 13;
			singup.Text = "ثبت نام";
			singup.UseVisualStyleBackColor = true;
			singup.Click += singup_Click;
			// 
			// SingupUserForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(424, 364);
			Controls.Add(singup);
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
			Margin = new Padding(3, 2, 3, 2);
			Name = "SingupUserForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "فرم ثبت نام کاربر";
			FormClosed += SingupUserForm_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private CheckBox RestaurantManagerCheckBox;
		private TextBox NameTetxtBox;
		private TextBox LastNameTetxtBox;
		private TextBox NationalCodeTetxtBox;
		private TextBox PasswordTetxtBox;
		private TextBox AddressTetxtBox;
		private Button singup;
	}
}