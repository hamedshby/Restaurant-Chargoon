namespace RestaurantChargoon.UI.WinForm.Forms
{
    partial class SingupUserForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            user = new CheckBox();
            restaurantManager = new CheckBox();
            name = new TextBox();
            lastname = new TextBox();
            id = new TextBox();
            password = new TextBox();
            address = new TextBox();
            singup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(650, 56);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "نام";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(650, 113);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(650, 188);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "کد ملی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(650, 257);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "پسورد";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(650, 320);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 4;
            label5.Text = "آدرس";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(650, 382);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "وضعیت کاربر";
            label6.Click += label6_Click;
            // 
            // user
            // 
            user.AutoSize = true;
            user.Location = new Point(551, 382);
            user.Name = "user";
            user.Size = new Size(74, 24);
            user.TabIndex = 6;
            user.Text = "مشتری";
            user.UseVisualStyleBackColor = true;
            // 
            // restaurantManager
            // 
            restaurantManager.AutoSize = true;
            restaurantManager.Location = new Point(405, 382);
            restaurantManager.Name = "restaurantManager";
            restaurantManager.Size = new Size(113, 24);
            restaurantManager.TabIndex = 7;
            restaurantManager.Text = "مدیر رستوران";
            restaurantManager.UseVisualStyleBackColor = true;
            restaurantManager.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // name
            // 
            name.Location = new Point(383, 56);
            name.Name = "name";
            name.Size = new Size(242, 27);
            name.TabIndex = 8;
            // 
            // lastname
            // 
            lastname.Location = new Point(383, 113);
            lastname.Name = "lastname";
            lastname.Size = new Size(242, 27);
            lastname.TabIndex = 9;
            // 
            // id
            // 
            id.Location = new Point(383, 181);
            id.Name = "id";
            id.Size = new Size(242, 27);
            id.TabIndex = 10;
            // 
            // password
            // 
            password.Location = new Point(383, 257);
            password.Name = "password";
            password.Size = new Size(242, 27);
            password.TabIndex = 11;
            // 
            // address
            // 
            address.Location = new Point(383, 320);
            address.Name = "address";
            address.Size = new Size(242, 27);
            address.TabIndex = 12;
            // 
            // singup
            // 
            singup.Location = new Point(88, 413);
            singup.Name = "singup";
            singup.Size = new Size(148, 47);
            singup.TabIndex = 13;
            singup.Text = "ثبت نام";
            singup.UseVisualStyleBackColor = true;
            // 
            // SingupUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 472);
            Controls.Add(singup);
            Controls.Add(address);
            Controls.Add(password);
            Controls.Add(id);
            Controls.Add(lastname);
            Controls.Add(name);
            Controls.Add(restaurantManager);
            Controls.Add(user);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SingupUserForm";
            Text = "فرم ثبت نام کاربر";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox user;
        private CheckBox restaurantManager;
        private TextBox name;
        private TextBox lastname;
        private TextBox id;
        private TextBox password;
        private TextBox address;
        private Button singup;
    }
}