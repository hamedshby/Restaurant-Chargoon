namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	partial class UserDashboardForm
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
			button1 = new Button();
			ShowOrdersButton = new Button();
			button3 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(47, 28);
			button1.Name = "button1";
			button1.Size = new Size(161, 29);
			button1.TabIndex = 0;
			button1.Text = "لیست رستورانها";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ShowOrdersButton
			// 
			ShowOrdersButton.Location = new Point(47, 83);
			ShowOrdersButton.Name = "ShowOrdersButton";
			ShowOrdersButton.Size = new Size(161, 29);
			ShowOrdersButton.TabIndex = 1;
			ShowOrdersButton.Text = "تاریخچه سفارشها";
			ShowOrdersButton.UseVisualStyleBackColor = true;
			ShowOrdersButton.Click += ShowOrdersButton_Click;
			// 
			// button3
			// 
			button3.Location = new Point(47, 138);
			button3.Name = "button3";
			button3.Size = new Size(161, 29);
			button3.TabIndex = 2;
			button3.Text = "اطلاعات کاربر";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// UserDashboardForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(250, 224);
			Controls.Add(button3);
			Controls.Add(ShowOrdersButton);
			Controls.Add(button1);
			MaximumSize = new Size(268, 271);
			MinimumSize = new Size(268, 271);
			Name = "UserDashboardForm";
			StartPosition = FormStartPosition.CenterScreen;
			FormClosed += UserDashboardForm_FormClosed;
			Load += UserDashboardForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
		private Button ShowOrdersButton;
		private Button button3;
	}
}