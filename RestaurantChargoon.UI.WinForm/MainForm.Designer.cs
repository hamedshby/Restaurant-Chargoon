namespace Restaurant_Chargoon.UI.WinForm
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
            this.signinUser = new System.Windows.Forms.Button();
            this.signupUserBtn = new System.Windows.Forms.Button();
            this.signupRestaurant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signinUser
            // 
            this.signinUser.Location = new System.Drawing.Point(275, 55);
            this.signinUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signinUser.Name = "signinUser";
            this.signinUser.Size = new System.Drawing.Size(150, 47);
            this.signinUser.TabIndex = 0;
            this.signinUser.Text = "ورود کاربر";
            this.signinUser.UseVisualStyleBackColor = true;
            this.signinUser.Click += new System.EventHandler(this.signinUser_Click);
            // 
            // signupUserBtn
            // 
            this.signupUserBtn.Location = new System.Drawing.Point(275, 134);
            this.signupUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signupUserBtn.Name = "signupUserBtn";
            this.signupUserBtn.Size = new System.Drawing.Size(150, 47);
            this.signupUserBtn.TabIndex = 1;
            this.signupUserBtn.Text = "ثبت نام کاربر";
            this.signupUserBtn.UseVisualStyleBackColor = true;
            this.signupUserBtn.Click += new System.EventHandler(this.signupUserBtn_Click_1);
            // 
            // signupRestaurant
            // 
            this.signupRestaurant.Location = new System.Drawing.Point(275, 212);
            this.signupRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signupRestaurant.Name = "signupRestaurant";
            this.signupRestaurant.Size = new System.Drawing.Size(150, 47);
            this.signupRestaurant.TabIndex = 2;
            this.signupRestaurant.Text = "ثبت نام رستوران";
            this.signupRestaurant.UseVisualStyleBackColor = true;
            this.signupRestaurant.Click += new System.EventHandler(this.signupRestaurant_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.signupRestaurant);
            this.Controls.Add(this.signupUserBtn);
            this.Controls.Add(this.signinUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "صفحه اصلی";
            this.ResumeLayout(false);

		}

		#endregion

		private Button signinUser;
		private Button signupUserBtn;
		private Button signupRestaurant;
	}
}