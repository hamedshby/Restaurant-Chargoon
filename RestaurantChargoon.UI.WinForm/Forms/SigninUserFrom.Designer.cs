namespace RestaurantChargoon.UI.WinForm.Forms
{
    partial class SigninUserFrom
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
            id = new TextBox();
            password = new TextBox();
            user = new RadioButton();
            restaurantManager = new RadioButton();
            enter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(677, 63);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "کد ملی";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(677, 131);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "پسورد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(677, 187);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "وضعیت کاربر";
            // 
            // id
            // 
            id.Location = new Point(485, 63);
            id.Name = "id";
            id.Size = new Size(151, 27);
            id.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(485, 131);
            password.Name = "password";
            password.Size = new Size(151, 27);
            password.TabIndex = 4;
            // 
            // user
            // 
            user.AutoSize = true;
            user.Location = new Point(573, 187);
            user.Name = "user";
            user.Size = new Size(73, 24);
            user.TabIndex = 5;
            user.TabStop = true;
            user.Text = "مشتری";
            user.UseVisualStyleBackColor = true;
            user.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // restaurantManager
            // 
            restaurantManager.AutoSize = true;
            restaurantManager.Location = new Point(431, 187);
            restaurantManager.Name = "restaurantManager";
            restaurantManager.Size = new Size(112, 24);
            restaurantManager.TabIndex = 6;
            restaurantManager.TabStop = true;
            restaurantManager.Text = "مدیر رستوران";
            restaurantManager.UseVisualStyleBackColor = true;
            restaurantManager.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // enter
            // 
            enter.Location = new Point(495, 295);
            enter.Name = "enter";
            enter.Size = new Size(151, 54);
            enter.TabIndex = 7;
            enter.Text = "ورود";
            enter.UseVisualStyleBackColor = true;
            // 
            // SigninUserFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(enter);
            Controls.Add(restaurantManager);
            Controls.Add(user);
            Controls.Add(password);
            Controls.Add(id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SigninUserFrom";
            Text = "فرم ورود کاربر";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox id;
        private TextBox password;
        private RadioButton user;
        private RadioButton restaurantManager;
        private Button enter;
    }
}