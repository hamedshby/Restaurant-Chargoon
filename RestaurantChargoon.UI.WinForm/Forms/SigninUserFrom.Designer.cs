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
			NationalCodeTextBox = new TextBox();
			PasswordTextBox = new TextBox();
			Loginbtn = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(250, 29);
			label1.Name = "label1";
			label1.Size = new Size(43, 15);
			label1.TabIndex = 0;
			label1.Text = "کد ملی";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(250, 80);
			label2.Name = "label2";
			label2.Size = new Size(37, 15);
			label2.TabIndex = 1;
			label2.Text = "پسورد";
			// 
			// NationalCodeTextBox
			// 
			NationalCodeTextBox.Location = new Point(82, 29);
			NationalCodeTextBox.Margin = new Padding(3, 2, 3, 2);
			NationalCodeTextBox.Name = "NationalCodeTextBox";
			NationalCodeTextBox.Size = new Size(133, 23);
			NationalCodeTextBox.TabIndex = 3;
			// 
			// PasswordTextBox
			// 
			PasswordTextBox.Location = new Point(82, 80);
			PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
			PasswordTextBox.Name = "PasswordTextBox";
			PasswordTextBox.Size = new Size(133, 23);
			PasswordTextBox.TabIndex = 4;
			// 
			// Loginbtn
			// 
			Loginbtn.Location = new Point(82, 140);
			Loginbtn.Margin = new Padding(3, 2, 3, 2);
			Loginbtn.Name = "Loginbtn";
			Loginbtn.Size = new Size(132, 26);
			Loginbtn.TabIndex = 7;
			Loginbtn.Text = "ورود";
			Loginbtn.UseVisualStyleBackColor = true;
			Loginbtn.Click += enter_Click;
			// 
			// SigninUserFrom
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(325, 196);
			Controls.Add(Loginbtn);
			Controls.Add(PasswordTextBox);
			Controls.Add(NationalCodeTextBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "SigninUserFrom";
			StartPosition = FormStartPosition.CenterParent;
			Text = "فرم ورود کاربر";
			FormClosed += SigninUserFrom_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox NationalCodeTextBox;
		private TextBox PasswordTextBox;
		private Button Loginbtn;
	}
}