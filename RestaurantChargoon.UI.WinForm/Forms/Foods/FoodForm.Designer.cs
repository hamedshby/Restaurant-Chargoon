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
            FoodDataGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            IdColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            FoodTypeColumn = new DataGridViewTextBoxColumn();
            AddFoodButton = new Button();
            ((System.ComponentModel.ISupportInitialize)FoodDataGridView).BeginInit();
            SuspendLayout();
            // 
            // FoodDataGridView
            // 
            FoodDataGridView.AllowUserToAddRows = false;
            FoodDataGridView.AllowUserToDeleteRows = false;
            FoodDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FoodDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FoodDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, IdColumn, PriceColumn, FoodTypeColumn });
            FoodDataGridView.Location = new Point(0, 36);
            FoodDataGridView.Name = "FoodDataGridView";
            FoodDataGridView.ReadOnly = true;
            FoodDataGridView.RightToLeft = RightToLeft.Yes;
            FoodDataGridView.RowHeadersWidth = 51;
            FoodDataGridView.RowTemplate.Height = 29;
            FoodDataGridView.Size = new Size(603, 299);
            FoodDataGridView.TabIndex = 0;
            FoodDataGridView.CellClick += FoodDataGridView_CellClick;
            FoodDataGridView.CellContentClick += FoodDataGridView_CellContentClick;
            // 
            // NameColumn
            // 
            NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "نام";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Visible = false;
            IdColumn.Width = 125;
            // 
            // PriceColumn
            // 
            PriceColumn.DataPropertyName = "Price";
            PriceColumn.HeaderText = "قیمت";
            PriceColumn.MinimumWidth = 6;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            PriceColumn.Width = 125;
            // 
            // FoodTypeColumn
            // 
            FoodTypeColumn.DataPropertyName = "FoodType";
            FoodTypeColumn.HeaderText = "نوع";
            FoodTypeColumn.MinimumWidth = 6;
            FoodTypeColumn.Name = "FoodTypeColumn";
            FoodTypeColumn.ReadOnly = true;
            FoodTypeColumn.Width = 125;
            // 
            // AddFoodButton
            // 
            AddFoodButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddFoodButton.Location = new Point(479, 1);
            AddFoodButton.Name = "AddFoodButton";
            AddFoodButton.Size = new Size(124, 29);
            AddFoodButton.TabIndex = 1;
            AddFoodButton.Text = "افزودن";
            AddFoodButton.UseVisualStyleBackColor = true;
            AddFoodButton.Click += AddFoodButton_Click;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 335);
            Controls.Add(AddFoodButton);
            Controls.Add(FoodDataGridView);
            Name = "FoodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FoodForm";
            FormClosed += FoodForm_FormClosed;
            Load += FoodForm_Load;
            VisibleChanged += FoodForm_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)FoodDataGridView).EndInit();
            ResumeLayout(false);
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