namespace RestaurantChargoon.UI.WinForm.Forms
{
	partial class SignUpRestaurantForm
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
			ToTimePicker = new DateTimePicker();
			FromTimePicker = new DateTimePicker();
			RegisterRestaurant = new Button();
			ResturantNameTextBox = new TextBox();
			AddressTextBox = new TextBox();
			label1 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			groupBox1 = new GroupBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// ToTimePicker
			// 
			ToTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			ToTimePicker.CustomFormat = "HH:mm";
			ToTimePicker.Format = DateTimePickerFormat.Custom;
			ToTimePicker.ImeMode = ImeMode.NoControl;
			ToTimePicker.Location = new Point(84, 26);
			ToTimePicker.Name = "ToTimePicker";
			ToTimePicker.ShowUpDown = true;
			ToTimePicker.Size = new Size(80, 27);
			ToTimePicker.TabIndex = 12;
			ToTimePicker.Value = new DateTime(2029, 6, 5, 0, 0, 0, 0);
			// 
			// FromTimePicker
			// 
			FromTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			FromTimePicker.CustomFormat = "HH:mm";
			FromTimePicker.Format = DateTimePickerFormat.Custom;
			FromTimePicker.ImeMode = ImeMode.NoControl;
			FromTimePicker.Location = new Point(249, 26);
			FromTimePicker.Name = "FromTimePicker";
			FromTimePicker.ShowUpDown = true;
			FromTimePicker.Size = new Size(80, 27);
			FromTimePicker.TabIndex = 11;
			FromTimePicker.Value = new DateTime(2023, 6, 5, 0, 0, 0, 0);
			// 
			// RegisterRestaurant
			// 
			RegisterRestaurant.Location = new Point(199, 279);
			RegisterRestaurant.Margin = new Padding(3, 4, 3, 4);
			RegisterRestaurant.Name = "RegisterRestaurant";
			RegisterRestaurant.Size = new Size(137, 31);
			RegisterRestaurant.TabIndex = 6;
			RegisterRestaurant.Text = "ذخیره";
			RegisterRestaurant.UseVisualStyleBackColor = true;
			RegisterRestaurant.Click += RegisterRestaurant_Click;
			// 
			// ResturantNameTextBox
			// 
			ResturantNameTextBox.Location = new Point(120, 25);
			ResturantNameTextBox.Margin = new Padding(3, 4, 3, 4);
			ResturantNameTextBox.Name = "ResturantNameTextBox";
			ResturantNameTextBox.RightToLeft = RightToLeft.Yes;
			ResturantNameTextBox.Size = new Size(245, 27);
			ResturantNameTextBox.TabIndex = 1;
			// 
			// AddressTextBox
			// 
			AddressTextBox.Location = new Point(36, 185);
			AddressTextBox.Margin = new Padding(3, 4, 3, 4);
			AddressTextBox.Multiline = true;
			AddressTextBox.Name = "AddressTextBox";
			AddressTextBox.RightToLeft = RightToLeft.Yes;
			AddressTextBox.Size = new Size(329, 68);
			AddressTextBox.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(380, 28);
			label1.Name = "label1";
			label1.Size = new Size(81, 20);
			label1.TabIndex = 6;
			label1.Text = "نام رستوران";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Location = new Point(344, 31);
			label3.Name = "label3";
			label3.Size = new Size(63, 20);
			label3.TabIndex = 8;
			label3.Text = "از ساعت";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label4.AutoSize = true;
			label4.Location = new Point(163, 29);
			label4.Name = "label4";
			label4.Size = new Size(62, 20);
			label4.TabIndex = 9;
			label4.Text = "تا ساعت";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(380, 185);
			label5.Name = "label5";
			label5.Size = new Size(98, 20);
			label5.TabIndex = 10;
			label5.Text = "آدرس رستوران";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(FromTimePicker);
			groupBox1.Controls.Add(ToTimePicker);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label4);
			groupBox1.Location = new Point(36, 83);
			groupBox1.Name = "groupBox1";
			groupBox1.RightToLeft = RightToLeft.Yes;
			groupBox1.Size = new Size(442, 73);
			groupBox1.TabIndex = 13;
			groupBox1.TabStop = false;
			groupBox1.Text = "ساعت کاری";
			// 
			// SignUpRestaurantForm
			// 
			AcceptButton = RegisterRestaurant;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(525, 323);
			Controls.Add(groupBox1);
			Controls.Add(label5);
			Controls.Add(label1);
			Controls.Add(AddressTextBox);
			Controls.Add(ResturantNameTextBox);
			Controls.Add(RegisterRestaurant);
			Margin = new Padding(3, 4, 3, 4);
			MaximumSize = new Size(543, 370);
			MinimumSize = new Size(543, 370);
			Name = "SignUpRestaurantForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "ثبت رستوران";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button RegisterRestaurant;
		private TextBox ResturantNameTextBox;
		private TextBox AddressTextBox;
		private Label label1;
		private Label label3;
		private Label label4;
		private Label label5;
		private DateTimePicker FromTimePicker;
		private DateTimePicker ToTimePicker;
		private GroupBox groupBox1;
	}
}