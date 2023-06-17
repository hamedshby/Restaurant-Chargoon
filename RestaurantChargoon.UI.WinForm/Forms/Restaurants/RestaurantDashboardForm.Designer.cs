namespace RestaurantChargoon.UI.WinForm.Forms
{
	partial class RestaurantDashboardForm
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
            this.AddRestaurantButton = new System.Windows.Forms.Button();
            this.RestaurantDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowMenu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ShowFactors = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RestaurantListBtn = new System.Windows.Forms.Button();
            this.ShowOrdersButton = new System.Windows.Forms.Button();
            this.AddtoBasketButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRestaurantButton
            // 
            this.AddRestaurantButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRestaurantButton.Location = new System.Drawing.Point(845, 5);
            this.AddRestaurantButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRestaurantButton.Name = "AddRestaurantButton";
            this.AddRestaurantButton.Size = new System.Drawing.Size(150, 33);
            this.AddRestaurantButton.TabIndex = 1;
            this.AddRestaurantButton.Text = "ثبت رستوران جدید";
            this.AddRestaurantButton.UseVisualStyleBackColor = true;
            this.AddRestaurantButton.Click += new System.EventHandler(this.AddRestaurantButton_Click);
            // 
            // RestaurantDataGridView
            // 
            this.RestaurantDataGridView.AllowUserToAddRows = false;
            this.RestaurantDataGridView.AllowUserToDeleteRows = false;
            this.RestaurantDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurantDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RestaurantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestaurantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ShowMenu,
            this.ShowFactors,
            this.Edit,
            this.Delete});
            this.RestaurantDataGridView.Location = new System.Drawing.Point(0, 46);
            this.RestaurantDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestaurantDataGridView.Name = "RestaurantDataGridView";
            this.RestaurantDataGridView.ReadOnly = true;
            this.RestaurantDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RestaurantDataGridView.RowHeadersWidth = 51;
            this.RestaurantDataGridView.RowTemplate.Height = 29;
            this.RestaurantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RestaurantDataGridView.Size = new System.Drawing.Size(1004, 202);
            this.RestaurantDataGridView.TabIndex = 2;
            this.RestaurantDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RestaurantDataGridView_CellContentClick);
            this.RestaurantDataGridView.VisibleChanged += new System.EventHandler(this.RestaurantDashboardForm_VisibleChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "نام رستوران";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StartTime";
            this.Column2.HeaderText = "ساعت شروع";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EndTime";
            this.Column3.HeaderText = "ساعت پایان";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Address";
            this.Column4.HeaderText = "ادرس";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ShowMenu
            // 
            this.ShowMenu.HeaderText = "مشاهده منو";
            this.ShowMenu.MinimumWidth = 6;
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.ReadOnly = true;
            this.ShowMenu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowMenu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ShowMenu.Text = "مشاهده منو";
            this.ShowMenu.UseColumnTextForButtonValue = true;
            // 
            // ShowFactors
            // 
            this.ShowFactors.HeaderText = "مشاهده فاکتورها";
            this.ShowFactors.MinimumWidth = 20;
            this.ShowFactors.Name = "ShowFactors";
            this.ShowFactors.ReadOnly = true;
            this.ShowFactors.Text = "مشاهده فاکتورها";
            this.ShowFactors.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "ویرایش رستوران";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "ویرایش رستوران";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "حذف رستوران";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "حذف رستوران";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // RestaurantListBtn
            // 
            this.RestaurantListBtn.Location = new System.Drawing.Point(685, 8);
            this.RestaurantListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestaurantListBtn.Name = "RestaurantListBtn";
            this.RestaurantListBtn.Size = new System.Drawing.Size(145, 30);
            this.RestaurantListBtn.TabIndex = 3;
            this.RestaurantListBtn.Text = "لیست رستورانها";
            this.RestaurantListBtn.UseVisualStyleBackColor = true;
            this.RestaurantListBtn.Click += new System.EventHandler(this.RestaurantListBtn_Click);
            // 
            // ShowOrdersButton
            // 
            this.ShowOrdersButton.Location = new System.Drawing.Point(514, 9);
            this.ShowOrdersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowOrdersButton.Name = "ShowOrdersButton";
            this.ShowOrdersButton.Size = new System.Drawing.Size(154, 29);
            this.ShowOrdersButton.TabIndex = 4;
            this.ShowOrdersButton.Text = "تاریخچه سفارشها";
            this.ShowOrdersButton.UseVisualStyleBackColor = true;
            this.ShowOrdersButton.Click += new System.EventHandler(this.ShowOrdersButton_Click);
            // 
            // AddtoBasketButton
            // 
            this.AddtoBasketButton.Location = new System.Drawing.Point(344, 9);
            this.AddtoBasketButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddtoBasketButton.Name = "AddtoBasketButton";
            this.AddtoBasketButton.Size = new System.Drawing.Size(154, 29);
            this.AddtoBasketButton.TabIndex = 5;
            this.AddtoBasketButton.Text = "ثبت سفارش";
            this.AddtoBasketButton.UseVisualStyleBackColor = true;
            this.AddtoBasketButton.Click += new System.EventHandler(this.AddtoBasketButton_Click);
            // 
            // RestaurantDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 248);
            this.Controls.Add(this.AddtoBasketButton);
            this.Controls.Add(this.ShowOrdersButton);
            this.Controls.Add(this.RestaurantListBtn);
            this.Controls.Add(this.RestaurantDataGridView);
            this.Controls.Add(this.AddRestaurantButton);
            this.Name = "RestaurantDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "داشبورد رستوران";
            this.Load += new System.EventHandler(this.RestaurantDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantDataGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private Button AddRestaurantButton;
		private DataGridView RestaurantDataGridView;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewButtonColumn ShowMenu;
		private DataGridViewButtonColumn ShowFactors;
		private DataGridViewButtonColumn Edit;
		private DataGridViewButtonColumn Delete;
		private Button RestaurantListBtn;
		private Button ShowOrdersButton;
        private Button AddtoBasketButton;
    }
}