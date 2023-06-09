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
			label1.Location = new Point(286, 39);
			label1.Name = "label1";
			label1.Size = new Size(56, 20);
			label1.TabIndex = 0;
			label1.Text = "کد ملی";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(286, 107);
			label2.Name = "label2";
			label2.Size = new Size(48, 20);
			label2.TabIndex = 1;
			label2.Text = "پسورد";
			// 
			// NationalCodeTextBox
			// 
			NationalCodeTextBox.Location = new Point(94, 39);
			NationalCodeTextBox.Name = "NationalCodeTextBox";
			NationalCodeTextBox.Size = new Size(151, 27);
			NationalCodeTextBox.TabIndex = 3;
			NationalCodeTextBox.Text = "1111111111";
			// 
			// PasswordTextBox
			// 
			PasswordTextBox.Location = new Point(94, 107);
			PasswordTextBox.Name = "PasswordTextBox";
			PasswordTextBox.Size = new Size(151, 27);
			PasswordTextBox.TabIndex = 4;
			PasswordTextBox.Text = "111qqq";
			// 
			// Loginbtn
			// 
			Loginbtn.Location = new Point(94, 187);
			Loginbtn.Name = "Loginbtn";
			Loginbtn.Size = new Size(151, 35);
			Loginbtn.TabIndex = 7;
			Loginbtn.Text = "ورود";
			Loginbtn.UseVisualStyleBackColor = true;
			Loginbtn.Click += enter_Click;
			// 
			// SigninUserFrom
			// 
			AcceptButton = Loginbtn;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(371, 261);
			Controls.Add(Loginbtn);
			Controls.Add(PasswordTextBox);
			Controls.Add(NationalCodeTextBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "SigninUserFrom";
			StartPosition = FormStartPosition.CenterParent;
			Text = "فرم ورود کاربر";
			FormClosed += SigninUserFrom_FormClosed;
			Load += SigninUserFrom_Load;
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