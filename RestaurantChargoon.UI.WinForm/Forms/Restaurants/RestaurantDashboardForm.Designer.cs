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
            Id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ShowMenu = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            ShowFactors = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)RestaurantDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AddRestaurantButton
            // 
            AddRestaurantButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddRestaurantButton.Location = new Point(754, 7);
            AddRestaurantButton.Name = "AddRestaurantButton";
            AddRestaurantButton.Size = new Size(171, 44);
            AddRestaurantButton.TabIndex = 1;
            AddRestaurantButton.Text = "ثبت رستوران جدید";
            AddRestaurantButton.UseVisualStyleBackColor = true;
            AddRestaurantButton.Click += AddRestaurantButton_Click;
            // 
            // RestaurantDataGridView
            // 
            RestaurantDataGridView.AllowUserToAddRows = false;
            RestaurantDataGridView.AllowUserToDeleteRows = false;
            RestaurantDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RestaurantDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RestaurantDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RestaurantDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Column1, Column2, Column3, Column4, ShowMenu, Edit, ShowFactors, Delete });
            RestaurantDataGridView.Location = new Point(0, 62);
            RestaurantDataGridView.Name = "RestaurantDataGridView";
            RestaurantDataGridView.ReadOnly = true;
            RestaurantDataGridView.RightToLeft = RightToLeft.Yes;
            RestaurantDataGridView.RowHeadersWidth = 51;
            RestaurantDataGridView.RowTemplate.Height = 29;
            RestaurantDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RestaurantDataGridView.Size = new Size(935, 269);
            RestaurantDataGridView.TabIndex = 2;
            RestaurantDataGridView.CellContentClick += RestaurantDataGridView_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
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
            // 
            // Column3
            // 
            Column3.DataPropertyName = "EndTime";
            Column3.HeaderText = "ساعت پایان";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Address";
            Column4.HeaderText = "ادرس";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // ShowMenu
            // 
            ShowMenu.HeaderText = "مشاهده منو";
            ShowMenu.MinimumWidth = 6;
            ShowMenu.Name = "ShowMenu";
            ShowMenu.ReadOnly = true;
            ShowMenu.Resizable = DataGridViewTriState.True;
            ShowMenu.SortMode = DataGridViewColumnSortMode.Automatic;
            ShowMenu.Text = "مشاهده منو";
            ShowMenu.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "ویرایش رستوران";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "ویرایش رستوران";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // ShowFactors
            // 
            ShowFactors.HeaderText = "مشاهده فاکتورها";
            ShowFactors.MinimumWidth = 20;
            ShowFactors.Name = "ShowFactors";
            ShowFactors.ReadOnly = true;
            ShowFactors.Text = "مشاهده فاکتورها";
            ShowFactors.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "حذف رستوران";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "حذف رستوران";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // RestaurantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 331);
            Controls.Add(RestaurantDataGridView);
            Controls.Add(AddRestaurantButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RestaurantDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "داشبورد رستوران";
            FormClosed += RestaurantDashboardForm_FormClosed;
            Load += RestaurantDashboardForm_Load;
            VisibleChanged += RestaurantDashboardForm_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)RestaurantDataGridView).EndInit();
            ResumeLayout(false);
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
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn ShowFactors;
        private DataGridViewButtonColumn Delete;
    }
}