﻿namespace RestaurantChargoon.UI.WinForm.Forms
{
    partial class AddFoodForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FoodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "نوع";
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(67, 65);
            this.PricetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(133, 23);
            this.PricetextBox.TabIndex = 9;
            this.PricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PricetextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "قیمت";
            // 
            // FoodTypeComboBox
            // 
            this.FoodTypeComboBox.FormattingEnabled = true;
            this.FoodTypeComboBox.Location = new System.Drawing.Point(67, 117);
            this.FoodTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FoodTypeComboBox.Name = "FoodTypeComboBox";
            this.FoodTypeComboBox.Size = new System.Drawing.Size(133, 23);
            this.FoodTypeComboBox.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(67, 162);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 22);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "ذخیره";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(67, 24);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(133, 23);
            this.NameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "نام";
            // 
            // AddFoodForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FoodTypeComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddFoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن منو";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddFoodForm_FormClosed);
            this.Load += new System.EventHandler(this.AddFoodForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox PricetextBox;
        private Label label2;
        private ComboBox FoodTypeComboBox;
        private Button SaveButton;
        private TextBox NameTextBox;
        private Label label1;
    }
}