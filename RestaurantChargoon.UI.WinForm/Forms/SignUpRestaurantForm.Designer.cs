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
            this.RegisterRestaurant = new System.Windows.Forms.Button();
            this.ResturantNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // RegisterRestaurant
            // 
            this.RegisterRestaurant.Location = new System.Drawing.Point(222, 256);
            this.RegisterRestaurant.Name = "RegisterRestaurant";
            this.RegisterRestaurant.Size = new System.Drawing.Size(75, 23);
            this.RegisterRestaurant.TabIndex = 0;
            this.RegisterRestaurant.Text = "ثبت نام";
            this.RegisterRestaurant.UseVisualStyleBackColor = true;
            this.RegisterRestaurant.Click += new System.EventHandler(this.RegisterRestaurant_Click);
            // 
            // ResturantNameTextBox
            // 
            this.ResturantNameTextBox.Location = new System.Drawing.Point(194, 19);
            this.ResturantNameTextBox.Name = "ResturantNameTextBox";
            this.ResturantNameTextBox.Size = new System.Drawing.Size(146, 23);
            this.ResturantNameTextBox.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(32, 177);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(308, 52);
            this.AddressTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام رستوران";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "از ساعت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "تا ساعت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "آدرس رستوران";
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.CustomFormat = "HH:mm";
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromTimePicker.Location = new System.Drawing.Point(194, 68);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.ShowUpDown = true;
            this.FromTimePicker.Size = new System.Drawing.Size(146, 23);
            this.FromTimePicker.TabIndex = 13;
            this.FromTimePicker.Value = new System.DateTime(2029, 12, 25, 0, 0, 0, 0);
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.CustomFormat = "HH:mm";
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToTimePicker.Location = new System.Drawing.Point(194, 133);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.ShowUpDown = true;
            this.ToTimePicker.Size = new System.Drawing.Size(146, 23);
            this.ToTimePicker.TabIndex = 14;
            this.ToTimePicker.Value = new System.DateTime(2029, 12, 25, 0, 0, 0, 0);
            // 
            // SignUpRestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 295);
            this.Controls.Add(this.ToTimePicker);
            this.Controls.Add(this.FromTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.ResturantNameTextBox);
            this.Controls.Add(this.RegisterRestaurant);
            this.Name = "SignUpRestaurantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت نام رستوران";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}