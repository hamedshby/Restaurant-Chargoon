namespace RestaurantChargoon.UI.WinForm.Forms
{
	partial class FoodForm
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
			FoodDataGridView = new DataGridView();
			NameColumn = new DataGridViewTextBoxColumn();
			IdColumn = new DataGridViewTextBoxColumn();
			PriceColumn = new DataGridViewTextBoxColumn();
			FoodTypeColumn = new DataGridViewTextBoxColumn();
			AddFoodButton = new Button();
			RefreshButton = new Button();
			((System.ComponentModel.ISupportInitialize)FoodDataGridView).BeginInit();
			SuspendLayout();
			// 
			// FoodDataGridView
			// 
			FoodDataGridView.AllowUserToAddRows = false;
			FoodDataGridView.AllowUserToDeleteRows = false;
			FoodDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			FoodDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, IdColumn, PriceColumn, FoodTypeColumn });
			FoodDataGridView.Dock = DockStyle.Bottom;
			FoodDataGridView.Location = new Point(0, 76);
			FoodDataGridView.Name = "FoodDataGridView";
			FoodDataGridView.ReadOnly = true;
			FoodDataGridView.RightToLeft = RightToLeft.Yes;
			FoodDataGridView.RowHeadersWidth = 51;
			FoodDataGridView.RowTemplate.Height = 29;
			FoodDataGridView.Size = new Size(603, 259);
			FoodDataGridView.TabIndex = 0;
			// 
			// NameColumn
			// 
			NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			NameColumn.DataPropertyName = "Name";
			NameColumn.HeaderText = "نام";
			NameColumn.MinimumWidth = 6;
			NameColumn.Name = "NameColumn";
			NameColumn.ReadOnly = true;
			// 
			// IdColumn
			// 
			IdColumn.DataPropertyName = "Id";
			IdColumn.HeaderText = "Id";
			IdColumn.MinimumWidth = 6;
			IdColumn.Name = "IdColumn";
			IdColumn.ReadOnly = true;
			IdColumn.Visible = false;
			IdColumn.Width = 125;
			// 
			// PriceColumn
			// 
			PriceColumn.DataPropertyName = "Price";
			PriceColumn.HeaderText = "قیمت";
			PriceColumn.MinimumWidth = 6;
			PriceColumn.Name = "PriceColumn";
			PriceColumn.ReadOnly = true;
			PriceColumn.Width = 125;
			// 
			// FoodTypeColumn
			// 
			FoodTypeColumn.DataPropertyName = "FoodType";
			FoodTypeColumn.HeaderText = "نوع";
			FoodTypeColumn.MinimumWidth = 6;
			FoodTypeColumn.Name = "FoodTypeColumn";
			FoodTypeColumn.ReadOnly = true;
			FoodTypeColumn.Width = 125;
			// 
			// AddFoodButton
			// 
			AddFoodButton.Location = new Point(28, 25);
			AddFoodButton.Name = "AddFoodButton";
			AddFoodButton.Size = new Size(124, 29);
			AddFoodButton.TabIndex = 1;
			AddFoodButton.Text = "افزودن";
			AddFoodButton.UseVisualStyleBackColor = true;
			AddFoodButton.Click += AddFoodButton_Click;
			// 
			// RefreshButton
			// 
			RefreshButton.Location = new Point(456, 25);
			RefreshButton.Name = "RefreshButton";
			RefreshButton.Size = new Size(124, 29);
			RefreshButton.TabIndex = 1;
			RefreshButton.Text = "تازه سازی";
			RefreshButton.UseVisualStyleBackColor = true;
			RefreshButton.Click += RefreshButton_Click;
			// 
			// FoodForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(603, 335);
			Controls.Add(RefreshButton);
			Controls.Add(AddFoodButton);
			Controls.Add(FoodDataGridView);
			Name = "FoodForm";
			Text = "FoodForm";
			Load += FoodForm_Load;
			((System.ComponentModel.ISupportInitialize)FoodDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private DataGridViewTextBoxColumn NameColumn;
		private DataGridViewTextBoxColumn IdColumn;
		private DataGridViewTextBoxColumn PriceColumn;
		private DataGridViewTextBoxColumn FoodTypeColumn;
		private Button AddFoodButton;
		private Button RefreshButton;
		public DataGridView FoodDataGridView;
	}
}