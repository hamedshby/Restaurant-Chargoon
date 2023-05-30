namespace Restaurant_Chargoon.UI.WinForm.UserControls
{
	partial class UserRegisterUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			RegisterButton = new Button();
			AddressTextBox = new TextBox();
			label4 = new Label();
			NationalCodeTextBox = new TextBox();
			label3 = new Label();
			FamilyTextBox = new TextBox();
			label2 = new Label();
			NameTextBox = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// RegisterButton
			// 
			RegisterButton.Location = new Point(137, 284);
			RegisterButton.Name = "RegisterButton";
			RegisterButton.Size = new Size(94, 29);
			RegisterButton.TabIndex = 14;
			RegisterButton.Text = "ثبت نام";
			RegisterButton.UseVisualStyleBackColor = true;
			// 
			// AddressTextBox
			// 
			AddressTextBox.Location = new Point(38, 184);
			AddressTextBox.Multiline = true;
			AddressTextBox.Name = "AddressTextBox";
			AddressTextBox.Size = new Size(210, 74);
			AddressTextBox.TabIndex = 12;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(254, 184);
			label4.Name = "label4";
			label4.Size = new Size(44, 20);
			label4.TabIndex = 15;
			label4.Text = "آدرس";
			// 
			// NationalCodeTextBox
			// 
			NationalCodeTextBox.Location = new Point(38, 129);
			NationalCodeTextBox.Name = "NationalCodeTextBox";
			NationalCodeTextBox.Size = new Size(210, 27);
			NationalCodeTextBox.TabIndex = 11;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(254, 132);
			label3.Name = "label3";
			label3.Size = new Size(52, 20);
			label3.TabIndex = 13;
			label3.Text = "کدملی";
			// 
			// FamilyTextBox
			// 
			FamilyTextBox.Location = new Point(38, 69);
			FamilyTextBox.Name = "FamilyTextBox";
			FamilyTextBox.Size = new Size(210, 27);
			FamilyTextBox.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(254, 76);
			label2.Name = "label2";
			label2.Size = new Size(90, 20);
			label2.TabIndex = 10;
			label2.Text = "نام خانوادگی";
			// 
			// NameTextBox
			// 
			NameTextBox.Location = new Point(38, 23);
			NameTextBox.Name = "NameTextBox";
			NameTextBox.Size = new Size(210, 27);
			NameTextBox.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(254, 26);
			label1.Name = "label1";
			label1.Size = new Size(27, 20);
			label1.TabIndex = 7;
			label1.Text = "نام";
			// 
			// UserRegisterUC
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(RegisterButton);
			Controls.Add(AddressTextBox);
			Controls.Add(label4);
			Controls.Add(NationalCodeTextBox);
			Controls.Add(label3);
			Controls.Add(FamilyTextBox);
			Controls.Add(label2);
			Controls.Add(NameTextBox);
			Controls.Add(label1);
			Name = "UserRegisterUC";
			Size = new Size(368, 340);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button RegisterButton;
		private TextBox AddressTextBox;
		private Label label4;
		private TextBox NationalCodeTextBox;
		private Label label3;
		private TextBox FamilyTextBox;
		private Label label2;
		private TextBox NameTextBox;
		private Label label1;
	}
}
