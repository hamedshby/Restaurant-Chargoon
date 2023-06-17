namespace RestaurantChargoon.UI.WinForm.Forms.Restaurants
{
	partial class RestaurantFactorsForm
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
			UserFactorDataGridView = new DataGridView();
			UserName = new DataGridViewTextBoxColumn();
			OrderDate = new DataGridViewTextBoxColumn();
			RestaurantName = new DataGridViewTextBoxColumn();
			Id = new DataGridViewTextBoxColumn();
			TotalPrice = new DataGridViewTextBoxColumn();
			Detail = new DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)UserFactorDataGridView).BeginInit();
			SuspendLayout();
			// 
			// UserFactorDataGridView
			// 
			UserFactorDataGridView.AllowUserToAddRows = false;
			UserFactorDataGridView.AllowUserToDeleteRows = false;
			UserFactorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			UserFactorDataGridView.Columns.AddRange(new DataGridViewColumn[] { UserName, OrderDate, RestaurantName, Id, TotalPrice, Detail });
			UserFactorDataGridView.Dock = DockStyle.Fill;
			UserFactorDataGridView.Location = new Point(0, 0);
			UserFactorDataGridView.Name = "UserFactorDataGridView";
			UserFactorDataGridView.ReadOnly = true;
			UserFactorDataGridView.RightToLeft = RightToLeft.Yes;
			UserFactorDataGridView.RowHeadersWidth = 51;
			UserFactorDataGridView.RowTemplate.Height = 29;
			UserFactorDataGridView.Size = new Size(790, 252);
			UserFactorDataGridView.TabIndex = 1;
			UserFactorDataGridView.CellContentClick += UserFactorDataGridView_CellContentClick;
			// 
			// UserName
			// 
			UserName.DataPropertyName = "UserName";
			UserName.HeaderText = "نام کاربر";
			UserName.MinimumWidth = 6;
			UserName.Name = "UserName";
			UserName.ReadOnly = true;
			UserName.Width = 125;
			// 
			// OrderDate
			// 
			OrderDate.DataPropertyName = "OrderDate";
			OrderDate.HeaderText = "تاریخ سفارش";
			OrderDate.MinimumWidth = 6;
			OrderDate.Name = "OrderDate";
			OrderDate.ReadOnly = true;
			OrderDate.Width = 125;
			// 
			// RestaurantName
			// 
			RestaurantName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			RestaurantName.DataPropertyName = "RestaurantName";
			RestaurantName.HeaderText = "نام رستوران";
			RestaurantName.MinimumWidth = 6;
			RestaurantName.Name = "RestaurantName";
			RestaurantName.ReadOnly = true;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.HeaderText = "FactorId";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			Id.Width = 125;
			// 
			// TotalPrice
			// 
			TotalPrice.DataPropertyName = "TotalPrice";
			TotalPrice.HeaderText = "جمع فاکتور";
			TotalPrice.MinimumWidth = 6;
			TotalPrice.Name = "TotalPrice";
			TotalPrice.ReadOnly = true;
			TotalPrice.Width = 125;
			// 
			// Detail
			// 
			Detail.HeaderText = "جزییات";
			Detail.MinimumWidth = 6;
			Detail.Name = "Detail";
			Detail.ReadOnly = true;
			Detail.Text = "جزییات";
			Detail.UseColumnTextForButtonValue = true;
			Detail.Width = 125;
			// 
			// RestaurantFactorsForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(790, 252);
			Controls.Add(UserFactorDataGridView);
			Name = "RestaurantFactorsForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "لیست فاکتورها";
			FormClosed += RestaurantFactorsForm_FormClosed;
			Load += RestaurantFactorsForm_Load;
			((System.ComponentModel.ISupportInitialize)UserFactorDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView UserFactorDataGridView;
		private DataGridViewTextBoxColumn UserName;
		private DataGridViewTextBoxColumn OrderDate;
		private DataGridViewTextBoxColumn RestaurantName;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn TotalPrice;
		private DataGridViewButtonColumn Detail;
	}
}