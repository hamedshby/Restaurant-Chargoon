namespace RestaurantChargoon.UI.WinForm.Forms.Restaurants
{
	partial class RestaurantDashboardUserForm
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
			RestaurantDataGridView = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			Select = new DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)RestaurantDataGridView).BeginInit();
			SuspendLayout();
			// 
			// RestaurantDataGridView
			// 
			RestaurantDataGridView.AllowUserToAddRows = false;
			RestaurantDataGridView.AllowUserToDeleteRows = false;
			RestaurantDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			RestaurantDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Column1, Column2, Column3, Column4, Select });
			RestaurantDataGridView.Dock = DockStyle.Fill;
			RestaurantDataGridView.Location = new Point(0, 0);
			RestaurantDataGridView.Name = "RestaurantDataGridView";
			RestaurantDataGridView.ReadOnly = true;
			RestaurantDataGridView.RightToLeft = RightToLeft.Yes;
			RestaurantDataGridView.RowHeadersWidth = 51;
			RestaurantDataGridView.RowTemplate.Height = 29;
			RestaurantDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			RestaurantDataGridView.Size = new Size(800, 261);
			RestaurantDataGridView.TabIndex = 3;
			RestaurantDataGridView.CellContentClick += RestaurantDataGridView_CellContentClick;
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
			// Column1
			// 
			Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Column1.DataPropertyName = "Name";
			Column1.HeaderText = "نام رستوران";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			// 
			// Column2
			// 
			Column2.DataPropertyName = "StartTime";
			Column2.HeaderText = "ساعت شروع";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			Column2.Width = 125;
			// 
			// Column3
			// 
			Column3.DataPropertyName = "EndTime";
			Column3.HeaderText = "ساعت پایان";
			Column3.MinimumWidth = 6;
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			Column3.Width = 125;
			// 
			// Column4
			// 
			Column4.DataPropertyName = "Address";
			Column4.HeaderText = "ادرس";
			Column4.MinimumWidth = 6;
			Column4.Name = "Column4";
			Column4.ReadOnly = true;
			Column4.Width = 125;
			// 
			// Select
			// 
			Select.HeaderText = "انتخاب";
			Select.MinimumWidth = 6;
			Select.Name = "Select";
			Select.ReadOnly = true;
			Select.Text = "انتخاب";
			Select.UseColumnTextForButtonValue = true;
			Select.Width = 125;
			// 
			// RestaurantDashboardUserForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 261);
			Controls.Add(RestaurantDataGridView);
			Name = "RestaurantDashboardUserForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "لیست رستورانها";
			FormClosed += RestaurantDashboardUserForm_FormClosed;
			Load += RestaurantDashboardUserForm_Load;
			((System.ComponentModel.ISupportInitialize)RestaurantDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView RestaurantDataGridView;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewButtonColumn Select;
	}
}