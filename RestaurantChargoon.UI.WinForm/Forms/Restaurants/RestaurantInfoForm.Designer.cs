namespace RestaurantChargoon.UI.WinForm.Forms.Restaurants
{
    partial class RestaurantInfoForm
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
            SaveButton = new Button();
            CancelButton = new Button();
            EditButton = new Button();
            ToTimePicker = new DateTimePicker();
            FromTimePicker = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            AddressTextBox = new TextBox();
            ResturantNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(83, 366);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 29;
            SaveButton.Text = "ذخیره";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(211, 366);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 28;
            CancelButton.Text = "انصراف";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(339, 366);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 27;
            EditButton.Text = "ویرایش";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ToTimePicker
            // 
            ToTimePicker.CustomFormat = "HH:mm";
            ToTimePicker.Format = DateTimePickerFormat.Custom;
            ToTimePicker.Location = new Point(215, 203);
            ToTimePicker.Margin = new Padding(3, 4, 3, 4);
            ToTimePicker.Name = "ToTimePicker";
            ToTimePicker.ShowUpDown = true;
            ToTimePicker.Size = new Size(166, 27);
            ToTimePicker.TabIndex = 37;
            ToTimePicker.Value = new DateTime(2029, 12, 25, 0, 0, 0, 0);
            // 
            // FromTimePicker
            // 
            FromTimePicker.CustomFormat = "HH:mm";
            FromTimePicker.Format = DateTimePickerFormat.Custom;
            FromTimePicker.Location = new Point(215, 117);
            FromTimePicker.Margin = new Padding(3, 4, 3, 4);
            FromTimePicker.Name = "FromTimePicker";
            FromTimePicker.ShowUpDown = true;
            FromTimePicker.Size = new Size(166, 27);
            FromTimePicker.TabIndex = 36;
            FromTimePicker.Value = new DateTime(2029, 12, 25, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 262);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 35;
            label5.Text = "آدرس رستوران";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 208);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 34;
            label4.Text = "تا ساعت";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 122);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 33;
            label3.Text = "از ساعت";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 58);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 32;
            label1.Text = "نام رستوران";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(30, 262);
            AddressTextBox.Margin = new Padding(3, 4, 3, 4);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(351, 68);
            AddressTextBox.TabIndex = 31;
            // 
            // ResturantNameTextBox
            // 
            ResturantNameTextBox.Location = new Point(215, 51);
            ResturantNameTextBox.Margin = new Padding(3, 4, 3, 4);
            ResturantNameTextBox.Name = "ResturantNameTextBox";
            ResturantNameTextBox.Size = new Size(166, 27);
            ResturantNameTextBox.TabIndex = 30;
            // 
            // RestaurantInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 412);
            Controls.Add(ToTimePicker);
            Controls.Add(FromTimePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(AddressTextBox);
            Controls.Add(ResturantNameTextBox);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(EditButton);
            Name = "RestaurantInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اطلاعات رستوران";
            FormClosed += RestaurantInfoForm_FormClosed;
            Load += RestaurantInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Button CancelButton;
        private Button EditButton;
        private DateTimePicker ToTimePicker;
        private DateTimePicker FromTimePicker;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox AddressTextBox;
        private TextBox ResturantNameTextBox;
    }
}