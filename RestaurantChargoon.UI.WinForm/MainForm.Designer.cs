﻿namespace Restaurant_Chargoon.UI.WinForm
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			signinUser = new Button();
			signupUserBtn = new Button();
			SuspendLayout();
			// 
			// signinUser
			// 
			signinUser.Location = new Point(145, 44);
			signinUser.Name = "signinUser";
			signinUser.Size = new Size(171, 63);
			signinUser.TabIndex = 0;
			signinUser.Text = "ورود کاربر";
			signinUser.UseVisualStyleBackColor = true;
			signinUser.Click += signinUser_Click;
			// 
			// signupUserBtn
			// 
			signupUserBtn.Location = new Point(145, 149);
			signupUserBtn.Name = "signupUserBtn";
			signupUserBtn.Size = new Size(171, 63);
			signupUserBtn.TabIndex = 1;
			signupUserBtn.Text = "ثبت نام کاربر";
			signupUserBtn.UseVisualStyleBackColor = true;
			signupUserBtn.Click += signupUserBtn_Click_1;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(461, 292);
			Controls.Add(signupUserBtn);
			Controls.Add(signinUser);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "صفحه اصلی";
			FormClosed += MainForm_FormClosed;
			Load += MainForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button signinUser;
		private Button signupUserBtn;
	}
}