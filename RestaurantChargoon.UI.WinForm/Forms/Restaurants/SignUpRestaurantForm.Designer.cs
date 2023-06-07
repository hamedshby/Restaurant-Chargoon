namespace RestaurantChargoon.UI.WinForm.Forms
{
    partial class SignUpRestaurantForm
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
            RegisterRestaurant = new Button();
            ResturantNameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            FromTimePicker = new DateTimePicker();
            ToTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // RegisterRestaurant
            // 
            RegisterRestaurant.Location = new Point(254, 341);
            RegisterRestaurant.Margin = new Padding(3, 4, 3, 4);
            RegisterRestaurant.Name = "RegisterRestaurant";
            RegisterRestaurant.Size = new Size(86, 31);
            RegisterRestaurant.TabIndex = 0;
            RegisterRestaurant.Text = "ثبت نام";
            RegisterRestaurant.UseVisualStyleBackColor = true;
            RegisterRestaurant.Click += RegisterRestaurant_Click;
            // 
            // ResturantNameTextBox
            // 
            ResturantNameTextBox.Location = new Point(222, 25);
            ResturantNameTextBox.Margin = new Padding(3, 4, 3, 4);
            ResturantNameTextBox.Name = "ResturantNameTextBox";
            ResturantNameTextBox.Size = new Size(166, 27);
            ResturantNameTextBox.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(37, 236);
            AddressTextBox.Margin = new Padding(3, 4, 3, 4);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(351, 68);
            AddressTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 31);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 6;
            label1.Text = "نام رستوران";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 99);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 8;
            label3.Text = "از ساعت";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 177);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 9;
            label4.Text = "تا ساعت";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 239);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 10;
            label5.Text = "آدرس رستوران";
            // 
            // FromTimePicker
            // 
            FromTimePicker.CustomFormat = "HH:mm";
            FromTimePicker.Format = DateTimePickerFormat.Custom;
            FromTimePicker.Location = new Point(222, 91);
            FromTimePicker.Margin = new Padding(3, 4, 3, 4);
            FromTimePicker.Name = "FromTimePicker";
            FromTimePicker.ShowUpDown = true;
            FromTimePicker.Size = new Size(166, 27);
            FromTimePicker.TabIndex = 13;
            FromTimePicker.Value = new DateTime(2029, 12, 25, 0, 0, 0, 0);
            // 
            // ToTimePicker
            // 
            ToTimePicker.CustomFormat = "HH:mm";
            ToTimePicker.Format = DateTimePickerFormat.Custom;
            ToTimePicker.Location = new Point(222, 177);
            ToTimePicker.Margin = new Padding(3, 4, 3, 4);
            ToTimePicker.Name = "ToTimePicker";
            ToTimePicker.ShowUpDown = true;
            ToTimePicker.Size = new Size(166, 27);
            ToTimePicker.TabIndex = 14;
            ToTimePicker.Value = new DateTime(2029, 12, 25, 0, 0, 0, 0);
            // 
            // SignUpRestaurantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 393);
            Controls.Add(ToTimePicker);
            Controls.Add(FromTimePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(AddressTextBox);
            Controls.Add(ResturantNameTextBox);
            Controls.Add(RegisterRestaurant);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpRestaurantForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ثبت نام رستوران";
            FormClosed += SignUpRestaurantForm_FormClosed;
            Load += SignUpRestaurantForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterRestaurant;
        private TextBox ResturantNameTextBox;
        private TextBox AddressTextBox;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker FromTimePicker;
        private DateTimePicker ToTimePicker;
    }
}