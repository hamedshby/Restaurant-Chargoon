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
            this.FoodDataGridView = new System.Windows.Forms.DataGridView();
            this.showcartButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToCart = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FoodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodDataGridView
            // 
            this.FoodDataGridView.AllowUserToAddRows = false;
            this.FoodDataGridView.AllowUserToDeleteRows = false;
            this.FoodDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameColumn,
            this.PriceColumn,
            this.FoodTypeColumn,
            this.AddToCart});
            this.FoodDataGridView.Location = new System.Drawing.Point(0, 36);
            this.FoodDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FoodDataGridView.Name = "FoodDataGridView";
            this.FoodDataGridView.ReadOnly = true;
            this.FoodDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodDataGridView.RowHeadersWidth = 51;
            this.FoodDataGridView.RowTemplate.Height = 29;
            this.FoodDataGridView.Size = new System.Drawing.Size(635, 207);
            this.FoodDataGridView.TabIndex = 1;
            this.FoodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodDataGridView_CellContentClick);
            // 
            // showcartButton
            // 
            this.showcartButton.Location = new System.Drawing.Point(485, 9);
            this.showcartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showcartButton.Name = "showcartButton";
            this.showcartButton.Size = new System.Drawing.Size(136, 22);
            this.showcartButton.TabIndex = 2;
            this.showcartButton.Text = "مشاهده ی سبد خرید";
            this.showcartButton.UseVisualStyleBackColor = true;
            this.showcartButton.Click += new System.EventHandler(this.showcartButton_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "نام";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            this.PriceColumn.HeaderText = "قیمت";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 125;
            // 
            // FoodTypeColumn
            // 
            this.FoodTypeColumn.DataPropertyName = "FoodType";
            this.FoodTypeColumn.HeaderText = "نوع";
            this.FoodTypeColumn.MinimumWidth = 6;
            this.FoodTypeColumn.Name = "FoodTypeColumn";
            this.FoodTypeColumn.ReadOnly = true;
            this.FoodTypeColumn.Width = 125;
            // 
            // AddToCart
            // 
            this.AddToCart.HeaderText = "افزودن به سبد خرید";
            this.AddToCart.MinimumWidth = 6;
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.ReadOnly = true;
            this.AddToCart.Text = "افزودن به سبد خرید";
            this.AddToCart.UseColumnTextForButtonValue = true;
            this.AddToCart.Width = 150;
            // 
            // FoodDashboardUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 243);
            this.Controls.Add(this.showcartButton);
            this.Controls.Add(this.FoodDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FoodDashboardUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FoodDashboardUserForm_FormClosed);
            this.Load += new System.EventHandler(this.FoodDashboardUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodDataGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public DataGridView FoodDataGridView;
		private DataGridViewTextBoxColumn IdColumn;
		private Button showcartButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn FoodTypeColumn;
        private DataGridViewButtonColumn AddToCart;
    }
}