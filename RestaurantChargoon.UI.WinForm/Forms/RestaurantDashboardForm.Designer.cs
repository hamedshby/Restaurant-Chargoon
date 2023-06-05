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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRestaurantButton
            // 
            this.AddRestaurantButton.Location = new System.Drawing.Point(26, 28);
            this.AddRestaurantButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRestaurantButton.Name = "AddRestaurantButton";
            this.AddRestaurantButton.Size = new System.Drawing.Size(150, 33);
            this.AddRestaurantButton.TabIndex = 1;
            this.AddRestaurantButton.Text = "ثبت رستوران";
            this.AddRestaurantButton.UseVisualStyleBackColor = true;
            this.AddRestaurantButton.Click += new System.EventHandler(this.AddRestaurantButton_Click);
            // 
            // RestaurantDataGridView
            // 
            this.RestaurantDataGridView.AllowUserToAddRows = false;
            this.RestaurantDataGridView.AllowUserToDeleteRows = false;
            this.RestaurantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestaurantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.RestaurantDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RestaurantDataGridView.Location = new System.Drawing.Point(0, 83);
            this.RestaurantDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestaurantDataGridView.Name = "RestaurantDataGridView";
            this.RestaurantDataGridView.ReadOnly = true;
            this.RestaurantDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RestaurantDataGridView.RowHeadersWidth = 51;
            this.RestaurantDataGridView.RowTemplate.Height = 29;
            this.RestaurantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RestaurantDataGridView.Size = new System.Drawing.Size(563, 165);
            this.RestaurantDataGridView.TabIndex = 2;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Id";
            this.Column5.HeaderText = "Id";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "RestaurantName";
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
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EndTime";
            this.Column3.HeaderText = "ساعت پایان";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Address";
            this.Column4.HeaderText = "ادرس";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(393, 31);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(116, 27);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.Text = "مشاهده منو";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // RestaurantDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 248);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.RestaurantDataGridView);
            this.Controls.Add(this.AddRestaurantButton);
            this.Name = "RestaurantDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RestaurantDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestaurantDashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.RestaurantDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantDataGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private Button AddRestaurantButton;
		private DataGridView RestaurantDataGridView;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private Button MenuButton;
	}
}