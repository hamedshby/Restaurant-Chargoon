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
			RegisterRestaurant = new Button();
			ResturantNameTextBox = new TextBox();
			NationalCodeTextBox = new TextBox();
			AddressTextBox = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			FromTimeTextbox = new MaskedTextBox();
			ToTimeTextbox = new MaskedTextBox();
			SuspendLayout();
			// 
			// RegisterRestaurant
			// 
			RegisterRestaurant.Location = new Point(222, 256);
			RegisterRestaurant.Name = "RegisterRestaurant";
			RegisterRestaurant.Size = new Size(75, 23);
			RegisterRestaurant.TabIndex = 0;
			RegisterRestaurant.Text = "ثبت نام";
			RegisterRestaurant.UseVisualStyleBackColor = true;
			RegisterRestaurant.Click += RegisterRestaurant_Click;
			// 
			// ResturantNameTextBox
			// 
			ResturantNameTextBox.Location = new Point(194, 19);
			ResturantNameTextBox.Name = "ResturantNameTextBox";
			ResturantNameTextBox.Size = new Size(146, 23);
			ResturantNameTextBox.TabIndex = 1;
			// 
			// NationalCodeTextBox
			// 
			NationalCodeTextBox.Location = new Point(194, 61);
			NationalCodeTextBox.Name = "NationalCodeTextBox";
			NationalCodeTextBox.Size = new Size(146, 23);
			NationalCodeTextBox.TabIndex = 2;
			// 
			// AddressTextBox
			// 
			AddressTextBox.Location = new Point(32, 177);
			AddressTextBox.Multiline = true;
			AddressTextBox.Name = "AddressTextBox";
			AddressTextBox.Size = new Size(308, 52);
			AddressTextBox.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(353, 23);
			label1.Name = "label1";
			label1.Size = new Size(63, 15);
			label1.TabIndex = 6;
			label1.Text = "نام رستوران";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(353, 74);
			label2.Name = "label2";
			label2.Size = new Size(121, 15);
			label2.TabIndex = 7;
			label2.Text = "کد ملی صاحب رستوران";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(353, 126);
			label3.Name = "label3";
			label3.Size = new Size(49, 15);
			label3.TabIndex = 8;
			label3.Text = "از ساعت";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(136, 124);
			label4.Name = "label4";
			label4.Size = new Size(48, 15);
			label4.TabIndex = 9;
			label4.Text = "تا ساعت";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(353, 179);
			label5.Name = "label5";
			label5.Size = new Size(76, 15);
			label5.TabIndex = 10;
			label5.Text = "آدرس رستوران";
			// 
			// FromTimeTextbox
			// 
			FromTimeTextbox.Location = new Point(240, 122);
			FromTimeTextbox.Mask = "12:00";
			FromTimeTextbox.Name = "FromTimeTextbox";
			FromTimeTextbox.Size = new Size(100, 23);
			FromTimeTextbox.TabIndex = 11;
			FromTimeTextbox.ValidatingType = typeof(DateTime);
			// 
			// ToTimeTextbox
			// 
			ToTimeTextbox.Location = new Point(32, 122);
			ToTimeTextbox.Mask = "23:00";
			ToTimeTextbox.Name = "ToTimeTextbox";
			ToTimeTextbox.Size = new Size(100, 23);
			ToTimeTextbox.TabIndex = 12;
			ToTimeTextbox.ValidatingType = typeof(DateTime);
			// 
			// SignUpRestaurantForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(503, 295);
			Controls.Add(ToTimeTextbox);
			Controls.Add(FromTimeTextbox);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(AddressTextBox);
			Controls.Add(NationalCodeTextBox);
			Controls.Add(ResturantNameTextBox);
			Controls.Add(RegisterRestaurant);
			Name = "SignUpRestaurantForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "ثبت نام رستوران";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button RegisterRestaurant;
		private TextBox ResturantNameTextBox;
		private TextBox NationalCodeTextBox;
		private TextBox AddressTextBox;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private MaskedTextBox FromTimeTextbox;
		private MaskedTextBox ToTimeTextbox;
	}
}