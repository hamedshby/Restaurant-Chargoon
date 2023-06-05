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
            this.NationalCodeTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FromTimeTextbox = new System.Windows.Forms.MaskedTextBox();
            this.ToTimeTextbox = new System.Windows.Forms.MaskedTextBox();
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
            // NationalCodeTextBox
            // 
            this.NationalCodeTextBox.Location = new System.Drawing.Point(194, 61);
            this.NationalCodeTextBox.Name = "NationalCodeTextBox";
            this.NationalCodeTextBox.Size = new System.Drawing.Size(146, 23);
            this.NationalCodeTextBox.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "کد ملی صاحب رستوران";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "از ساعت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 124);
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
            // FromTimeTextbox
            // 
            this.FromTimeTextbox.Location = new System.Drawing.Point(240, 122);
            this.FromTimeTextbox.Mask = "90:00";
            this.FromTimeTextbox.Name = "FromTimeTextbox";
            this.FromTimeTextbox.Size = new System.Drawing.Size(100, 23);
            this.FromTimeTextbox.TabIndex = 11;
            // 
            // ToTimeTextbox
            // 
            this.ToTimeTextbox.Location = new System.Drawing.Point(32, 122);
            this.ToTimeTextbox.Mask = "90:00";
            this.ToTimeTextbox.Name = "ToTimeTextbox";
            this.ToTimeTextbox.Size = new System.Drawing.Size(100, 23);
            this.ToTimeTextbox.TabIndex = 12;
            this.ToTimeTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // SignUpRestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 295);
            this.Controls.Add(this.ToTimeTextbox);
            this.Controls.Add(this.FromTimeTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.NationalCodeTextBox);
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