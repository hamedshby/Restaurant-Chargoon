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
            AddRestaurantButton = new Button();
            RestaurantDataGridView = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)RestaurantDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AddRestaurantButton
            // 
            AddRestaurantButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddRestaurantButton.Location = new Point(639, 0);
            AddRestaurantButton.Name = "AddRestaurantButton";
            AddRestaurantButton.Size = new Size(171, 44);
            AddRestaurantButton.TabIndex = 1;
            AddRestaurantButton.Text = "ثبت رستوران";
            AddRestaurantButton.UseVisualStyleBackColor = true;
            AddRestaurantButton.Click += AddRestaurantButton_Click;
            // 
            // RestaurantDataGridView
            // 
            RestaurantDataGridView.AllowUserToAddRows = false;
            RestaurantDataGridView.AllowUserToDeleteRows = false;
            RestaurantDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RestaurantDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RestaurantDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            RestaurantDataGridView.Location = new Point(0, 50);
            RestaurantDataGridView.Name = "RestaurantDataGridView";
            RestaurantDataGridView.ReadOnly = true;
            RestaurantDataGridView.RightToLeft = RightToLeft.Yes;
            RestaurantDataGridView.RowHeadersWidth = 51;
            RestaurantDataGridView.RowTemplate.Height = 29;
            RestaurantDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RestaurantDataGridView.Size = new Size(810, 281);
            RestaurantDataGridView.TabIndex = 2;
            RestaurantDataGridView.CellContentClick += RestaurantDataGridView_CellContentClick;
            RestaurantDataGridView.DataBindingComplete += RestaurantDataGridView_DataBindingComplete;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Id";
            Column5.HeaderText = "Id";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            Column5.Width = 125;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "RestaurantName";
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
            // RestaurantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 331);
            Controls.Add(RestaurantDataGridView);
            Controls.Add(AddRestaurantButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RestaurantDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "داشبورد رستوران";
            FormClosed += RestaurantDashboardForm_FormClosed;
            Load += RestaurantDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)RestaurantDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button AddRestaurantButton;
        private DataGridView RestaurantDataGridView;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}