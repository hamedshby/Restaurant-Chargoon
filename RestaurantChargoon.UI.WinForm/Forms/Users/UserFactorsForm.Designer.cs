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
			UserFactorDataGridView = new DataGridView();
			RestaurantName = new DataGridViewTextBoxColumn();
			FactorId = new DataGridViewTextBoxColumn();
			TotalPrice = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)UserFactorDataGridView).BeginInit();
			SuspendLayout();
			// 
			// UserFactorDataGridView
			// 
			UserFactorDataGridView.AllowUserToAddRows = false;
			UserFactorDataGridView.AllowUserToDeleteRows = false;
			UserFactorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			UserFactorDataGridView.Columns.AddRange(new DataGridViewColumn[] { RestaurantName, FactorId, TotalPrice });
			UserFactorDataGridView.Dock = DockStyle.Fill;
			UserFactorDataGridView.Location = new Point(0, 0);
			UserFactorDataGridView.Name = "UserFactorDataGridView";
			UserFactorDataGridView.ReadOnly = true;
			UserFactorDataGridView.RightToLeft = RightToLeft.Yes;
			UserFactorDataGridView.RowHeadersWidth = 51;
			UserFactorDataGridView.RowTemplate.Height = 29;
			UserFactorDataGridView.Size = new Size(485, 237);
			UserFactorDataGridView.TabIndex = 0;
			UserFactorDataGridView.CellContentClick += UserFactorDataGridView_CellContentClick;
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
			// FactorId
			// 
			FactorId.DataPropertyName = "Id";
			FactorId.HeaderText = "FactorId";
			FactorId.MinimumWidth = 6;
			FactorId.Name = "FactorId";
			FactorId.ReadOnly = true;
			FactorId.Visible = false;
			FactorId.Width = 125;
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
			// UserFactorsForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(485, 237);
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
		private DataGridViewTextBoxColumn RestaurantName;
		private DataGridViewTextBoxColumn FactorId;
		private DataGridViewTextBoxColumn TotalPrice;
	}
}