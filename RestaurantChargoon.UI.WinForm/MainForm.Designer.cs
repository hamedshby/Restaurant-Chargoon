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
            signinUser = new Button();
            signupUser = new Button();
            signupRestaurant = new Button();
            SuspendLayout();
            // 
            // signinUser
            // 
            signinUser.Location = new Point(314, 73);
            signinUser.Name = "signinUser";
            signinUser.Size = new Size(171, 63);
            signinUser.TabIndex = 0;
            signinUser.Text = "ورود کاربر";
            signinUser.UseVisualStyleBackColor = true;
            // 
            // signupUser
            // 
            signupUser.Location = new Point(314, 178);
            signupUser.Name = "signupUser";
            signupUser.Size = new Size(171, 63);
            signupUser.TabIndex = 1;
            signupUser.Text = "ثبت نام کاربر";
            signupUser.UseVisualStyleBackColor = true;
            // 
            // signupRestaurant
            // 
            signupRestaurant.Location = new Point(314, 283);
            signupRestaurant.Name = "signupRestaurant";
            signupRestaurant.Size = new Size(171, 63);
            signupRestaurant.TabIndex = 2;
            signupRestaurant.Text = "ثبت نام رستوران";
            signupRestaurant.UseVisualStyleBackColor = true;
            signupRestaurant.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signupRestaurant);
            Controls.Add(signupUser);
            Controls.Add(signinUser);
            Name = "MainForm";
            Text = "صفحه اصلی";
            ResumeLayout(false);
        }

        #endregion

        private Button signinUser;
        private Button signupUser;
        private Button signupRestaurant;
    }
}