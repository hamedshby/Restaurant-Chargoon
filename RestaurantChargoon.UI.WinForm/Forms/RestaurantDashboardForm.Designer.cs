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
			label1 = new Label();
			AddRestaurantButton = new Button();
			dataGridView1 = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(490, 100);
			label1.Name = "label1";
			label1.Size = new Size(118, 20);
			label1.TabIndex = 0;
			label1.Text = "داشبورد رستوران ";
			// 
			// AddRestaurantButton
			// 
			AddRestaurantButton.Location = new Point(222, 30);
			AddRestaurantButton.Name = "AddRestaurantButton";
			AddRestaurantButton.Size = new Size(171, 44);
			AddRestaurantButton.TabIndex = 1;
			AddRestaurantButton.Text = "ثبت رستوران";
			AddRestaurantButton.UseVisualStyleBackColor = true;
			AddRestaurantButton.Click += AddRestaurantButton_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
			dataGridView1.Location = new Point(23, 219);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RightToLeft = RightToLeft.Yes;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(615, 188);
			dataGridView1.TabIndex = 2;
			// 
			// Column1
			// 
			Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Column1.HeaderText = "نام رستوران";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			// 
			// Column2
			// 
			Column2.HeaderText = "ساعت شروع";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			Column2.Width = 125;
			// 
			// Column3
			// 
			Column3.HeaderText = "ساعت پایان";
			Column3.MinimumWidth = 6;
			Column3.Name = "Column3";
			Column3.Width = 125;
			// 
			// Column4
			// 
			Column4.HeaderText = "ادرس";
			Column4.MinimumWidth = 6;
			Column4.Name = "Column4";
			Column4.Width = 125;
			// 
			// RestaurantDashboardForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(643, 433);
			Controls.Add(dataGridView1);
			Controls.Add(AddRestaurantButton);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "RestaurantDashboardForm";
			Text = "RestaurantDashboard";
			FormClosed += RestaurantDashboardForm_FormClosed;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button AddRestaurantButton;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
	}
}