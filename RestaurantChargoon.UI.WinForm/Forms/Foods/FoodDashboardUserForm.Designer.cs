namespace RestaurantChargoon.UI.WinForm.Forms.Foods
{
	partial class FoodDashboardUserForm
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
			showcartButton = new Button();
			((System.ComponentModel.ISupportInitialize)FoodDataGridView).BeginInit();
			SuspendLayout();
			// 
			// FoodDataGridView
			// 
			FoodDataGridView.AllowUserToAddRows = false;
			FoodDataGridView.AllowUserToDeleteRows = false;
			FoodDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			FoodDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			FoodDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, IdColumn, PriceColumn, FoodTypeColumn });
			FoodDataGridView.Location = new Point(0, 48);
			FoodDataGridView.Name = "FoodDataGridView";
			FoodDataGridView.ReadOnly = true;
			FoodDataGridView.RightToLeft = RightToLeft.Yes;
			FoodDataGridView.RowHeadersWidth = 51;
			FoodDataGridView.RowTemplate.Height = 29;
			FoodDataGridView.Size = new Size(614, 276);
			FoodDataGridView.TabIndex = 1;
			FoodDataGridView.CellContentClick += FoodDataGridView_CellContentClick;
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
			// showcartButton
			// 
			showcartButton.Location = new Point(12, 12);
			showcartButton.Name = "showcartButton";
			showcartButton.Size = new Size(155, 29);
			showcartButton.TabIndex = 2;
			showcartButton.Text = "مشاهده ی سبد خرید";
			showcartButton.UseVisualStyleBackColor = true;
			showcartButton.Click += showcartButton_Click;
			// 
			// FoodDashboardUserForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(614, 324);
			Controls.Add(showcartButton);
			Controls.Add(FoodDataGridView);
			Name = "FoodDashboardUserForm";
			StartPosition = FormStartPosition.CenterScreen;
			FormClosed += FoodDashboardUserForm_FormClosed;
			Load += FoodDashboardUserForm_Load;
			((System.ComponentModel.ISupportInitialize)FoodDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		public DataGridView FoodDataGridView;
		private DataGridViewTextBoxColumn NameColumn;
		private DataGridViewTextBoxColumn IdColumn;
		private DataGridViewTextBoxColumn PriceColumn;
		private DataGridViewTextBoxColumn FoodTypeColumn;
		private Button showcartButton;
	}
}