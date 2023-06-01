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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.RadioButton();
            this.restaurantManager = new System.Windows.Forms.RadioButton();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد ملی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "پسورد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "وضعیت کاربر";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(424, 47);
            this.id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(133, 23);
            this.id.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(424, 98);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(133, 23);
            this.password.TabIndex = 4;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(501, 140);
            this.user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(59, 19);
            this.user.TabIndex = 5;
            this.user.TabStop = true;
            this.user.Text = "مشتری";
            this.user.UseVisualStyleBackColor = true;
            // 
            // restaurantManager
            // 
            this.restaurantManager.AutoSize = true;
            this.restaurantManager.Location = new System.Drawing.Point(377, 140);
            this.restaurantManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restaurantManager.Name = "restaurantManager";
            this.restaurantManager.Size = new System.Drawing.Size(89, 19);
            this.restaurantManager.TabIndex = 6;
            this.restaurantManager.TabStop = true;
            this.restaurantManager.Text = "مدیر رستوران";
            this.restaurantManager.UseVisualStyleBackColor = true;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(433, 221);
            this.enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(132, 40);
            this.enter.TabIndex = 7;
            this.enter.Text = "ورود";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // SigninUserFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.restaurantManager);
            this.Controls.Add(this.user);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SigninUserFrom";
            this.Text = "فرم ورود کاربر";
            this.ResumeLayout(false);
            this.PerformLayout();

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