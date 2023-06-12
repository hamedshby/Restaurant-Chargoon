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
            this.UserFactorDataGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestaurantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserFactorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserFactorDataGridView
            // 
            this.UserFactorDataGridView.AllowUserToAddRows = false;
            this.UserFactorDataGridView.AllowUserToDeleteRows = false;
            this.UserFactorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserFactorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.RestaurantName,
            this.Id,
            this.TotalPrice,
            this.Detail});
            this.UserFactorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserFactorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.UserFactorDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserFactorDataGridView.Name = "UserFactorDataGridView";
            this.UserFactorDataGridView.ReadOnly = true;
            this.UserFactorDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserFactorDataGridView.RowHeadersWidth = 51;
            this.UserFactorDataGridView.RowTemplate.Height = 29;
            this.UserFactorDataGridView.Size = new System.Drawing.Size(691, 189);
            this.UserFactorDataGridView.TabIndex = 1;
            this.UserFactorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserFactorDataGridView_CellContentClick);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "نام کاربر";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // RestaurantName
            // 
            this.RestaurantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RestaurantName.DataPropertyName = "RestaurantName";
            this.RestaurantName.HeaderText = "نام رستوران";
            this.RestaurantName.MinimumWidth = 6;
            this.RestaurantName.Name = "RestaurantName";
            this.RestaurantName.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "FactorId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "جمع فاکتور";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 125;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "جزییات";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Text = "جزییات";
            this.Detail.UseColumnTextForButtonValue = true;
            this.Detail.Width = 125;
            // 
            // RestaurantFactorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 189);
            this.Controls.Add(this.UserFactorDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RestaurantFactorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestaurantFactorsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestaurantFactorsForm_FormClosed);
            this.Load += new System.EventHandler(this.RestaurantFactorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserFactorDataGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DataGridView UserFactorDataGridView;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn RestaurantName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewButtonColumn Detail;
    }
}