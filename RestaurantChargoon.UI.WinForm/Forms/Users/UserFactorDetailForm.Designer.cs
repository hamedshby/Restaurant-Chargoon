﻿namespace RestaurantChargoon.UI.WinForm.Forms.Users
{
	partial class UserFactorDetailForm
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
			FactcorDetailDataGridView = new DataGridView();
			FoodName = new DataGridViewTextBoxColumn();
			Price = new DataGridViewTextBoxColumn();
			FoodType = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)FactcorDetailDataGridView).BeginInit();
			SuspendLayout();
			// 
			// FactcorDetailDataGridView
			// 
			FactcorDetailDataGridView.AllowUserToAddRows = false;
			FactcorDetailDataGridView.AllowUserToDeleteRows = false;
			FactcorDetailDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			FactcorDetailDataGridView.Columns.AddRange(new DataGridViewColumn[] { FoodName, Price, FoodType });
			FactcorDetailDataGridView.Dock = DockStyle.Fill;
			FactcorDetailDataGridView.Location = new Point(0, 0);
			FactcorDetailDataGridView.Name = "FactcorDetailDataGridView";
			FactcorDetailDataGridView.ReadOnly = true;
			FactcorDetailDataGridView.RightToLeft = RightToLeft.Yes;
			FactcorDetailDataGridView.RowHeadersWidth = 51;
			FactcorDetailDataGridView.RowTemplate.Height = 29;
			FactcorDetailDataGridView.Size = new Size(576, 242);
			FactcorDetailDataGridView.TabIndex = 0;
			// 
			// FoodName
			// 
			FoodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			FoodName.DataPropertyName = "FoodName";
			FoodName.HeaderText = "نام";
			FoodName.MinimumWidth = 6;
			FoodName.Name = "FoodName";
			FoodName.ReadOnly = true;
			// 
			// Price
			// 
			Price.DataPropertyName = "Price";
			Price.HeaderText = "قیمت";
			Price.MinimumWidth = 6;
			Price.Name = "Price";
			Price.ReadOnly = true;
			Price.Width = 125;
			// 
			// FoodType
			// 
			FoodType.DataPropertyName = "FoodType";
			FoodType.HeaderText = "نوع";
			FoodType.MinimumWidth = 6;
			FoodType.Name = "FoodType";
			FoodType.ReadOnly = true;
			FoodType.Width = 125;
			// 
			// UserFactorDetailForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(576, 242);
			Controls.Add(FactcorDetailDataGridView);
			Name = "UserFactorDetailForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "جزییات سفارش";
			FormClosed += UserFactorDetailForm_FormClosed;
			Load += UserFactorDetailForm_Load;
			((System.ComponentModel.ISupportInitialize)FactcorDetailDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView FactcorDetailDataGridView;
		private DataGridViewTextBoxColumn FoodName;
		private DataGridViewTextBoxColumn Price;
		private DataGridViewTextBoxColumn FoodType;
	}
}