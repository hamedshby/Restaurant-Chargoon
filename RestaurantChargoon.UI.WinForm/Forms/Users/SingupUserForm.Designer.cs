﻿namespace RestaurantChargoon.UI.WinForm.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RestaurantManagerCheckBox = new System.Windows.Forms.CheckBox();
            this.NameTetxtBox = new System.Windows.Forms.TextBox();
            this.LastNameTetxtBox = new System.Windows.Forms.TextBox();
            this.NationalCodeTetxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTetxtBox = new System.Windows.Forms.TextBox();
            this.AddressTetxtBox = new System.Windows.Forms.TextBox();
            this.singup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "کد ملی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "پسورد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "آدرس";
            // 
            // RestaurantManagerCheckBox
            // 
            this.RestaurantManagerCheckBox.AutoSize = true;
            this.RestaurantManagerCheckBox.Location = new System.Drawing.Point(200, 280);
            this.RestaurantManagerCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestaurantManagerCheckBox.Name = "RestaurantManagerCheckBox";
            this.RestaurantManagerCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RestaurantManagerCheckBox.Size = new System.Drawing.Size(90, 19);
            this.RestaurantManagerCheckBox.TabIndex = 7;
            this.RestaurantManagerCheckBox.Text = "مدیر رستوران";
            this.RestaurantManagerCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameTetxtBox
            // 
            this.NameTetxtBox.Location = new System.Drawing.Point(88, 31);
            this.NameTetxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTetxtBox.Name = "NameTetxtBox";
            this.NameTetxtBox.Size = new System.Drawing.Size(212, 23);
            this.NameTetxtBox.TabIndex = 8;
            // 
            // LastNameTetxtBox
            // 
            this.LastNameTetxtBox.Location = new System.Drawing.Point(88, 78);
            this.LastNameTetxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameTetxtBox.Name = "LastNameTetxtBox";
            this.LastNameTetxtBox.Size = new System.Drawing.Size(212, 23);
            this.LastNameTetxtBox.TabIndex = 9;
            // 
            // NationalCodeTetxtBox
            // 
            this.NationalCodeTetxtBox.Location = new System.Drawing.Point(88, 129);
            this.NationalCodeTetxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NationalCodeTetxtBox.Name = "NationalCodeTetxtBox";
            this.NationalCodeTetxtBox.Size = new System.Drawing.Size(212, 23);
            this.NationalCodeTetxtBox.TabIndex = 10;
            this.NationalCodeTetxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NationalCodeTetxtBox_KeyPress);
            // 
            // PasswordTetxtBox
            // 
            this.PasswordTetxtBox.Location = new System.Drawing.Point(88, 186);
            this.PasswordTetxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTetxtBox.Name = "PasswordTetxtBox";
            this.PasswordTetxtBox.Size = new System.Drawing.Size(212, 23);
            this.PasswordTetxtBox.TabIndex = 11;
            this.PasswordTetxtBox.UseSystemPasswordChar = true;
            // 
            // AddressTetxtBox
            // 
            this.AddressTetxtBox.Location = new System.Drawing.Point(88, 241);
            this.AddressTetxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressTetxtBox.Name = "AddressTetxtBox";
            this.AddressTetxtBox.Size = new System.Drawing.Size(212, 23);
            this.AddressTetxtBox.TabIndex = 12;
            // 
            // singup
            // 
            this.singup.Location = new System.Drawing.Point(136, 320);
            this.singup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.singup.Name = "singup";
            this.singup.Size = new System.Drawing.Size(130, 35);
            this.singup.TabIndex = 13;
            this.singup.Text = "ثبت نام";
            this.singup.UseVisualStyleBackColor = true;
            this.singup.Click += new System.EventHandler(this.singup_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(88, 208);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(212, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "طول پسورد حداقل 5 کاراکتر و شامل حرف و عدد باشد";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(88, 152);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(212, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "کد ملی باید 10 رقم باشد";
            // 
            // SingupUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 364);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.singup);
            this.Controls.Add(this.AddressTetxtBox);
            this.Controls.Add(this.PasswordTetxtBox);
            this.Controls.Add(this.NationalCodeTetxtBox);
            this.Controls.Add(this.LastNameTetxtBox);
            this.Controls.Add(this.NameTetxtBox);
            this.Controls.Add(this.RestaurantManagerCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SingupUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم ثبت نام کاربر";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SingupUserForm_FormClosed);
            this.Load += new System.EventHandler(this.SingupUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox RestaurantManagerCheckBox;
        private TextBox NameTetxtBox;
        private TextBox LastNameTetxtBox;
        private TextBox NationalCodeTetxtBox;
        private TextBox PasswordTetxtBox;
        private TextBox AddressTetxtBox;
        private Button singup;
        private Label label6;
        private Label label7;
    }
}