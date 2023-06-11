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
			showcartButton = new Button();
			Id = new DataGridViewTextBoxColumn();
			NameColumn = new DataGridViewTextBoxColumn();
			PriceColumn = new DataGridViewTextBoxColumn();
			FoodTypeColumn = new DataGridViewTextBoxColumn();
			AddToCart = new DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)FoodDataGridView).BeginInit();
			SuspendLayout();
			// 
			// FoodDataGridView
			// 
			FoodDataGridView.AllowUserToAddRows = false;
			FoodDataGridView.AllowUserToDeleteRows = false;
			FoodDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			FoodDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			FoodDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, NameColumn, PriceColumn, FoodTypeColumn, AddToCart });
			FoodDataGridView.Location = new Point(0, 48);
			FoodDataGridView.Name = "FoodDataGridView";
			FoodDataGridView.ReadOnly = true;
			FoodDataGridView.RightToLeft = RightToLeft.Yes;
			FoodDataGridView.RowHeadersWidth = 51;
			FoodDataGridView.RowTemplate.Height = 29;
			FoodDataGridView.Size = new Size(721, 276);
			FoodDataGridView.TabIndex = 1;
			FoodDataGridView.CellContentClick += FoodDataGridView_CellContentClick;
			// 
			// showcartButton
			// 
			showcartButton.Location = new Point(554, 12);
			showcartButton.Name = "showcartButton";
			showcartButton.Size = new Size(155, 29);
			showcartButton.TabIndex = 2;
			showcartButton.Text = "مشاهده ی سبد خرید";
			showcartButton.UseVisualStyleBackColor = true;
			showcartButton.Click += showcartButton_Click;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.HeaderText = "Id";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			Id.Width = 125;
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
			// AddToCart
			// 
			AddToCart.HeaderText = "افزودن به سبد خرید";
			AddToCart.MinimumWidth = 6;
			AddToCart.Name = "AddToCart";
			AddToCart.ReadOnly = true;
			AddToCart.Text = "افزودن به سبد خرید";
			AddToCart.UseColumnTextForButtonValue = true;
			AddToCart.Width = 150;
			// 
			// FoodDashboardUserForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(721, 324);
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
		private DataGridViewTextBoxColumn Id;
		private DataGridViewButtonColumn AddToCart;
	}
}