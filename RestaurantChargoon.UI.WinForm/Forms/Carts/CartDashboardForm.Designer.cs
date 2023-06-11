namespace RestaurantChargoon.UI.WinForm.Forms.Carts
{
	partial class CartDashboardForm
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
			RestaurantNametextBox = new TextBox();
			UserNameTextBox = new TextBox();
			label2 = new Label();
			factorDetailsDataGridView = new DataGridView();
			SaveFactorButton = new Button();
			IdColumn = new DataGridViewTextBoxColumn();
			FoodName = new DataGridViewTextBoxColumn();
			Price = new DataGridViewTextBoxColumn();
			FoodType = new DataGridViewTextBoxColumn();
			Delete = new DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)factorDetailsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(385, 24);
			label1.Name = "label1";
			label1.Size = new Size(81, 20);
			label1.TabIndex = 1;
			label1.Text = "نام رستوران";
			// 
			// RestaurantNametextBox
			// 
			RestaurantNametextBox.Location = new Point(182, 24);
			RestaurantNametextBox.Name = "RestaurantNametextBox";
			RestaurantNametextBox.Size = new Size(171, 27);
			RestaurantNametextBox.TabIndex = 2;
			// 
			// UserNameTextBox
			// 
			UserNameTextBox.Location = new Point(182, 73);
			UserNameTextBox.Name = "UserNameTextBox";
			UserNameTextBox.Size = new Size(171, 27);
			UserNameTextBox.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(385, 73);
			label2.Name = "label2";
			label2.Size = new Size(60, 20);
			label2.TabIndex = 3;
			label2.Text = "نام کاربر";
			// 
			// factorDetailsDataGridView
			// 
			factorDetailsDataGridView.AllowUserToAddRows = false;
			factorDetailsDataGridView.AllowUserToDeleteRows = false;
			factorDetailsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			factorDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			factorDetailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, FoodName, Price, FoodType, Delete });
			factorDetailsDataGridView.Location = new Point(-1, 123);
			factorDetailsDataGridView.Name = "factorDetailsDataGridView";
			factorDetailsDataGridView.ReadOnly = true;
			factorDetailsDataGridView.RightToLeft = RightToLeft.Yes;
			factorDetailsDataGridView.RowHeadersWidth = 51;
			factorDetailsDataGridView.RowTemplate.Height = 29;
			factorDetailsDataGridView.Size = new Size(480, 187);
			factorDetailsDataGridView.TabIndex = 5;
			factorDetailsDataGridView.CellContentClick += factorDetailsDataGridView_CellContentClick;
			// 
			// SaveFactorButton
			// 
			SaveFactorButton.Location = new Point(12, 69);
			SaveFactorButton.Name = "SaveFactorButton";
			SaveFactorButton.Size = new Size(142, 29);
			SaveFactorButton.TabIndex = 6;
			SaveFactorButton.Text = "تایید نهایی";
			SaveFactorButton.UseVisualStyleBackColor = true;
			SaveFactorButton.Click += SaveFactorButton_Click;
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
			// FoodName
			// 
			FoodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			FoodName.DataPropertyName = "FoodName";
			FoodName.HeaderText = "نام";
			FoodName.MinimumWidth = 6;
			FoodName.Name = "FoodName";
			FoodName.ReadOnly = true;
			// 
			// Price
			// 
			Price.DataPropertyName = "Price";
			Price.HeaderText = "قیمت";
			Price.MinimumWidth = 6;
			Price.Name = "Price";
			Price.ReadOnly = true;
			Price.Width = 125;
			// 
			// FoodType
			// 
			FoodType.DataPropertyName = "FoodType";
			FoodType.HeaderText = "نوع";
			FoodType.MinimumWidth = 6;
			FoodType.Name = "FoodType";
			FoodType.ReadOnly = true;
			FoodType.Width = 125;
			// 
			// Delete
			// 
			Delete.HeaderText = "حذف";
			Delete.MinimumWidth = 6;
			Delete.Name = "Delete";
			Delete.ReadOnly = true;
			Delete.Resizable = DataGridViewTriState.True;
			Delete.SortMode = DataGridViewColumnSortMode.Automatic;
			Delete.Text = "حذف";
			Delete.UseColumnTextForButtonValue = true;
			Delete.Width = 125;
			// 
			// CartDashboardForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(478, 311);
			Controls.Add(SaveFactorButton);
			Controls.Add(factorDetailsDataGridView);
			Controls.Add(UserNameTextBox);
			Controls.Add(label2);
			Controls.Add(RestaurantNametextBox);
			Controls.Add(label1);
			Name = "CartDashboardForm";
			Text = "CartDashboardForm";
			FormClosed += CartDashboardForm_FormClosed;
			Load += CartDashboardForm_Load;
			((System.ComponentModel.ISupportInitialize)factorDetailsDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
		private TextBox RestaurantNametextBox;
		private TextBox UserNameTextBox;
		private Label label2;
		public DataGridView factorDetailsDataGridView;
		private Button SaveFactorButton;
		private DataGridViewTextBoxColumn IdColumn;
		private DataGridViewTextBoxColumn FoodName;
		private DataGridViewTextBoxColumn Price;
		private DataGridViewTextBoxColumn FoodType;
		private DataGridViewButtonColumn Delete;
	}
}