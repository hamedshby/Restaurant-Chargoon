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
            this.NationalCodeTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد ملی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "پسورد";
            // 
            // NationalCodeTextBox
            // 
            this.NationalCodeTextBox.Location = new System.Drawing.Point(82, 29);
            this.NationalCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NationalCodeTextBox.Name = "NationalCodeTextBox";
            this.NationalCodeTextBox.Size = new System.Drawing.Size(133, 23);
            this.NationalCodeTextBox.TabIndex = 3;
            this.NationalCodeTextBox.Text = "1111111111";
            this.NationalCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NationalCodeTextBox_KeyPress);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(82, 80);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(133, 23);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.Text = "111qqq";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(82, 140);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(132, 26);
            this.Loginbtn.TabIndex = 7;
            this.Loginbtn.Text = "ورود";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.enter_Click);
            // 
            // SigninUserFrom
            // 
            this.AcceptButton = this.Loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 196);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NationalCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SigninUserFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم ورود کاربر";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SigninUserFrom_FormClosed);
            this.Load += new System.EventHandler(this.SigninUserFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox NationalCodeTextBox;
		private TextBox PasswordTextBox;
		private Button Loginbtn;
	}
}