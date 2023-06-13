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
            this.label1 = new System.Windows.Forms.Label();
            this.RestaurantNametextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.factorDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveFactorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.factorDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام رستوران";
            // 
            // RestaurantNametextBox
            // 
            this.RestaurantNametextBox.Location = new System.Drawing.Point(159, 18);
            this.RestaurantNametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestaurantNametextBox.Name = "RestaurantNametextBox";
            this.RestaurantNametextBox.ReadOnly = true;
            this.RestaurantNametextBox.Size = new System.Drawing.Size(150, 23);
            this.RestaurantNametextBox.TabIndex = 2;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(159, 55);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.ReadOnly = true;
            this.UserNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.UserNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام کاربر";
            // 
            // factorDetailsDataGridView
            // 
            this.factorDetailsDataGridView.AllowUserToAddRows = false;
            this.factorDetailsDataGridView.AllowUserToDeleteRows = false;
            this.factorDetailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factorDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.factorDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.FoodName,
            this.Price,
            this.FoodType,
            this.Delete});
            this.factorDetailsDataGridView.Location = new System.Drawing.Point(-1, 92);
            this.factorDetailsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.factorDetailsDataGridView.Name = "factorDetailsDataGridView";
            this.factorDetailsDataGridView.ReadOnly = true;
            this.factorDetailsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.factorDetailsDataGridView.RowHeadersWidth = 51;
            this.factorDetailsDataGridView.RowTemplate.Height = 29;
            this.factorDetailsDataGridView.Size = new System.Drawing.Size(420, 140);
            this.factorDetailsDataGridView.TabIndex = 5;
            this.factorDetailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.factorDetailsDataGridView_CellContentClick);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 125;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "نام";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // FoodType
            // 
            this.FoodType.DataPropertyName = "FoodType";
            this.FoodType.HeaderText = "نوع";
            this.FoodType.MinimumWidth = 6;
            this.FoodType.Name = "FoodType";
            this.FoodType.ReadOnly = true;
            this.FoodType.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "حذف";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "حذف";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // SaveFactorButton
            // 
            this.SaveFactorButton.Location = new System.Drawing.Point(10, 52);
            this.SaveFactorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveFactorButton.Name = "SaveFactorButton";
            this.SaveFactorButton.Size = new System.Drawing.Size(124, 22);
            this.SaveFactorButton.TabIndex = 6;
            this.SaveFactorButton.Text = "تایید نهایی";
            this.SaveFactorButton.UseVisualStyleBackColor = true;
            this.SaveFactorButton.Click += new System.EventHandler(this.SaveFactorButton_Click);
            // 
            // CartDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 233);
            this.Controls.Add(this.SaveFactorButton);
            this.Controls.Add(this.factorDetailsDataGridView);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RestaurantNametextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CartDashboardForm";
            this.Text = "CartDashboardForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CartDashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.CartDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.factorDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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