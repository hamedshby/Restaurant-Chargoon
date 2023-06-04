namespace RestaurantChargoon.UI.WinForm.Forms
{
	partial class RestaurantDashboardForm
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
			AddRestaurantButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(688, 97);
			label1.Name = "label1";
			label1.Size = new Size(118, 20);
			label1.TabIndex = 0;
			label1.Text = "داشبورد رستوران ";
			// 
			// AddRestaurantButton
			// 
			AddRestaurantButton.Location = new Point(318, 43);
			AddRestaurantButton.Name = "AddRestaurantButton";
			AddRestaurantButton.Size = new Size(171, 44);
			AddRestaurantButton.TabIndex = 1;
			AddRestaurantButton.Text = "ثبت رستوران";
			AddRestaurantButton.UseVisualStyleBackColor = true;
			AddRestaurantButton.Click += AddRestaurantButton_Click;
			// 
			// RestaurantDashboardForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(AddRestaurantButton);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "RestaurantDashboardForm";
			Text = "RestaurantDashboard";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button AddRestaurantButton;
	}
}