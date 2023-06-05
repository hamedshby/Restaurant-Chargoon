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
			label1.Location = new Point(367, 41);
			label1.Name = "label1";
			label1.Size = new Size(27, 20);
			label1.TabIndex = 0;
			label1.Text = "نام";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(367, 104);
			label2.Name = "label2";
			label2.Size = new Size(90, 20);
			label2.TabIndex = 1;
			label2.Text = "نام خانوادگی";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(367, 179);
			label3.Name = "label3";
			label3.Size = new Size(56, 20);
			label3.TabIndex = 2;
			label3.Text = "کد ملی";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(367, 248);
			label4.Name = "label4";
			label4.Size = new Size(48, 20);
			label4.TabIndex = 3;
			label4.Text = "پسورد";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(367, 311);
			label5.Name = "label5";
			label5.Size = new Size(44, 20);
			label5.TabIndex = 4;
			label5.Text = "آدرس";
			// 
			// RestaurantManagerCheckBox
			// 
			RestaurantManagerCheckBox.AutoSize = true;
			RestaurantManagerCheckBox.Location = new Point(229, 373);
			RestaurantManagerCheckBox.Name = "RestaurantManagerCheckBox";
			RestaurantManagerCheckBox.RightToLeft = RightToLeft.Yes;
			RestaurantManagerCheckBox.Size = new Size(113, 24);
			RestaurantManagerCheckBox.TabIndex = 7;
			RestaurantManagerCheckBox.Text = "مدیر رستوران";
			RestaurantManagerCheckBox.UseVisualStyleBackColor = true;
			// 
			// NameTetxtBox
			// 
			NameTetxtBox.Location = new Point(101, 41);
			NameTetxtBox.Name = "NameTetxtBox";
			NameTetxtBox.Size = new Size(242, 27);
			NameTetxtBox.TabIndex = 8;
			// 
			// LastNameTetxtBox
			// 
			LastNameTetxtBox.Location = new Point(101, 104);
			LastNameTetxtBox.Name = "LastNameTetxtBox";
			LastNameTetxtBox.Size = new Size(242, 27);
			LastNameTetxtBox.TabIndex = 9;
			// 
			// NationalCodeTetxtBox
			// 
			NationalCodeTetxtBox.Location = new Point(101, 172);
			NationalCodeTetxtBox.Name = "NationalCodeTetxtBox";
			NationalCodeTetxtBox.Size = new Size(242, 27);
			NationalCodeTetxtBox.TabIndex = 10;
			// 
			// PasswordTetxtBox
			// 
			PasswordTetxtBox.Location = new Point(101, 248);
			PasswordTetxtBox.Name = "PasswordTetxtBox";
			PasswordTetxtBox.Size = new Size(242, 27);
			PasswordTetxtBox.TabIndex = 11;
			// 
			// AddressTetxtBox
			// 
			AddressTetxtBox.Location = new Point(101, 311);
			AddressTetxtBox.Name = "AddressTetxtBox";
			AddressTetxtBox.Size = new Size(242, 27);
			AddressTetxtBox.TabIndex = 12;
			// 
			// singup
			// 
			singup.Location = new Point(155, 427);
			singup.Name = "singup";
			singup.Size = new Size(149, 47);
			singup.TabIndex = 13;
			singup.Text = "ثبت نام";
			singup.UseVisualStyleBackColor = true;
			singup.Click += singup_Click;
			// 
			// SingupUserForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(485, 485);
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