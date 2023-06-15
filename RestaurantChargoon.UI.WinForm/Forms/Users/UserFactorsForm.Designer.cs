namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	partial class UserFactorsForm
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			UserFactorDataGridView = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			RestaurantName = new DataGridViewTextBoxColumn();
			OrderDate = new DataGridViewTextBoxColumn();
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
			UserFactorDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, RestaurantName, OrderDate, TotalPrice, Detail });
			UserFactorDataGridView.Dock = DockStyle.Fill;
			UserFactorDataGridView.Location = new Point(0, 0);
			UserFactorDataGridView.Name = "UserFactorDataGridView";
			UserFactorDataGridView.ReadOnly = true;
			UserFactorDataGridView.RightToLeft = RightToLeft.Yes;
			UserFactorDataGridView.RowHeadersWidth = 51;
			UserFactorDataGridView.RowTemplate.Height = 29;
			UserFactorDataGridView.Size = new Size(735, 237);
			UserFactorDataGridView.TabIndex = 0;
			UserFactorDataGridView.CellContentClick += UserFactorDataGridView_CellContentClick;
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
			// RestaurantName
			// 
			RestaurantName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			RestaurantName.DataPropertyName = "RestaurantName";
			RestaurantName.HeaderText = "نام رستوران";
			RestaurantName.MinimumWidth = 6;
			RestaurantName.Name = "RestaurantName";
			RestaurantName.ReadOnly = true;
			// 
			// OrderDate
			// 
			OrderDate.DataPropertyName = "OrderDate";
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
			OrderDate.DefaultCellStyle = dataGridViewCellStyle1;
			OrderDate.HeaderText = "تاریخ سفارش";
			OrderDate.MinimumWidth = 6;
			OrderDate.Name = "OrderDate";
			OrderDate.ReadOnly = true;
			OrderDate.Width = 150;
			// 
			// TotalPrice
			// 
			TotalPrice.DataPropertyName = "TotalPrice";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
			TotalPrice.DefaultCellStyle = dataGridViewCellStyle2;
			TotalPrice.HeaderText = "جمع فاکتور";
			TotalPrice.MinimumWidth = 6;
			TotalPrice.Name = "TotalPrice";
			TotalPrice.ReadOnly = true;
			TotalPrice.Width = 125;
			// 
			// Detail
			// 
			Detail.HeaderText = "مشاهده ی جزییات";
			Detail.MinimumWidth = 6;
			Detail.Name = "Detail";
			Detail.ReadOnly = true;
			Detail.Resizable = DataGridViewTriState.True;
			Detail.SortMode = DataGridViewColumnSortMode.Automatic;
			Detail.Text = "مشاهده ی جزییات";
			Detail.UseColumnTextForButtonValue = true;
			Detail.Width = 160;
			// 
			// UserFactorsForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(735, 237);
			Controls.Add(UserFactorDataGridView);
			Name = "UserFactorsForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "سفارشات شما";
			FormClosed += UserOrdersForm_FormClosed;
			Load += UserOrdersForm_Load;
			((System.ComponentModel.ISupportInitialize)UserFactorDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView UserFactorDataGridView;
		private DataGridViewTextBoxColumn FactorId;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn RestaurantName;
		private DataGridViewTextBoxColumn OrderDate;
		private DataGridViewTextBoxColumn TotalPrice;
		private DataGridViewButtonColumn Detail;
	}
}