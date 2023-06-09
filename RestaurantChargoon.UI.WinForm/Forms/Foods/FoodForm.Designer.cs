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
            this.FoodDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFoodButton = new System.Windows.Forms.Button();
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
            this.NameColumn,
            this.IdColumn,
            this.PriceColumn,
            this.FoodTypeColumn});
            this.FoodDataGridView.Location = new System.Drawing.Point(0, 27);
            this.FoodDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FoodDataGridView.Name = "FoodDataGridView";
            this.FoodDataGridView.ReadOnly = true;
            this.FoodDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoodDataGridView.RowHeadersWidth = 51;
            this.FoodDataGridView.RowTemplate.Height = 29;
            this.FoodDataGridView.Size = new System.Drawing.Size(528, 224);
            this.FoodDataGridView.TabIndex = 0;
            this.FoodDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodDataGridView_CellContentClick);
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
            // AddFoodButton
            // 
            this.AddFoodButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFoodButton.Location = new System.Drawing.Point(419, 1);
            this.AddFoodButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddFoodButton.Name = "AddFoodButton";
            this.AddFoodButton.Size = new System.Drawing.Size(108, 22);
            this.AddFoodButton.TabIndex = 1;
            this.AddFoodButton.Text = "افزودن";
            this.AddFoodButton.UseVisualStyleBackColor = true;
            this.AddFoodButton.Click += new System.EventHandler(this.AddFoodButton_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 251);
            this.Controls.Add(this.AddFoodButton);
            this.Controls.Add(this.FoodDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FoodForm_FormClosed);
            this.Load += new System.EventHandler(this.FoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodDataGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private Button AddFoodButton;
		public DataGridView FoodDataGridView;
		private DataGridViewTextBoxColumn NameColumn;
		private DataGridViewTextBoxColumn IdColumn;
		private DataGridViewTextBoxColumn PriceColumn;
		private DataGridViewTextBoxColumn FoodTypeColumn;
	}
}