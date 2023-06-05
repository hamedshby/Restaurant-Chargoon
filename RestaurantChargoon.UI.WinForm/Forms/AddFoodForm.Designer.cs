namespace RestaurantChargoon.UI.WinForm.Forms
{
	partial class AddFoodForm
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
			label3 = new Label();
			PricetextBox = new TextBox();
			label2 = new Label();
			FoodTypeComboBox = new ComboBox();
			SaveButton = new Button();
			NameTextBox = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(254, 159);
			label3.Name = "label3";
			label3.Size = new Size(31, 20);
			label3.TabIndex = 13;
			label3.Text = "نوع";
			// 
			// PricetextBox
			// 
			PricetextBox.Location = new Point(77, 87);
			PricetextBox.Name = "PricetextBox";
			PricetextBox.Size = new Size(151, 27);
			PricetextBox.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(254, 92);
			label2.Name = "label2";
			label2.Size = new Size(45, 20);
			label2.TabIndex = 11;
			label2.Text = "قیمت";
			// 
			// FoodTypeComboBox
			// 
			FoodTypeComboBox.FormattingEnabled = true;
			FoodTypeComboBox.Location = new Point(77, 156);
			FoodTypeComboBox.Name = "FoodTypeComboBox";
			FoodTypeComboBox.Size = new Size(151, 28);
			FoodTypeComboBox.TabIndex = 10;
			// 
			// SaveButton
			// 
			SaveButton.Location = new Point(77, 216);
			SaveButton.Name = "SaveButton";
			SaveButton.Size = new Size(151, 29);
			SaveButton.TabIndex = 11;
			SaveButton.Text = "ذخیره";
			SaveButton.UseVisualStyleBackColor = true;
			SaveButton.Click += SaveButton_Click;
			// 
			// NameTextBox
			// 
			NameTextBox.Location = new Point(77, 32);
			NameTextBox.Name = "NameTextBox";
			NameTextBox.Size = new Size(151, 27);
			NameTextBox.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(254, 37);
			label1.Name = "label1";
			label1.Size = new Size(27, 20);
			label1.TabIndex = 7;
			label1.Text = "نام";
			// 
			// AddFoodForm
			// 
			AcceptButton = SaveButton;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(324, 287);
			Controls.Add(label3);
			Controls.Add(PricetextBox);
			Controls.Add(label2);
			Controls.Add(FoodTypeComboBox);
			Controls.Add(SaveButton);
			Controls.Add(NameTextBox);
			Controls.Add(label1);
			Name = "AddFoodForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "افزودن منو";
			Load += AddFoodForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
		private TextBox PricetextBox;
		private Label label2;
		private ComboBox FoodTypeComboBox;
		private Button SaveButton;
		private TextBox NameTextBox;
		private Label label1;
	}
}