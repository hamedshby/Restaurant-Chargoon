namespace Restaurant_Chargoon.UI.WinForm.UserControls
{
	partial class RestaurantRegisterUC
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
			label6 = new Label();
			textBox1 = new TextBox();
			label5 = new Label();
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
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(111, 142);
			label6.Name = "label6";
			label6.Size = new Size(18, 20);
			label6.TabIndex = 32;
			label6.Text = "تا";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(56, 139);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(49, 27);
			textBox1.TabIndex = 24;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(230, 139);
			label5.Name = "label5";
			label5.Size = new Size(19, 20);
			label5.TabIndex = 31;
			label5.Text = "از";
			// 
			// RegisterButton
			// 
			RegisterButton.Location = new Point(155, 291);
			RegisterButton.Name = "RegisterButton";
			RegisterButton.Size = new Size(94, 29);
			RegisterButton.TabIndex = 26;
			RegisterButton.Text = "ثبت نام";
			RegisterButton.UseVisualStyleBackColor = true;
			// 
			// AddressTextBox
			// 
			AddressTextBox.Location = new Point(56, 191);
			AddressTextBox.Multiline = true;
			AddressTextBox.Name = "AddressTextBox";
			AddressTextBox.Size = new Size(210, 74);
			AddressTextBox.TabIndex = 25;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(272, 191);
			label4.Name = "label4";
			label4.Size = new Size(44, 20);
			label4.TabIndex = 30;
			label4.Text = "آدرس";
			// 
			// NationalCodeTextBox
			// 
			NationalCodeTextBox.Location = new Point(175, 136);
			NationalCodeTextBox.Name = "NationalCodeTextBox";
			NationalCodeTextBox.Size = new Size(49, 27);
			NationalCodeTextBox.TabIndex = 23;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(272, 139);
			label3.Name = "label3";
			label3.Size = new Size(91, 20);
			label3.TabIndex = 29;
			label3.Text = "ساعت کارکرد";
			// 
			// FamilyTextBox
			// 
			FamilyTextBox.Location = new Point(56, 76);
			FamilyTextBox.Name = "FamilyTextBox";
			FamilyTextBox.Size = new Size(210, 27);
			FamilyTextBox.TabIndex = 22;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(272, 83);
			label2.Name = "label2";
			label2.Size = new Size(105, 20);
			label2.TabIndex = 28;
			label2.Text = "صاحب رستوران";
			// 
			// NameTextBox
			// 
			NameTextBox.Location = new Point(56, 30);
			NameTextBox.Name = "NameTextBox";
			NameTextBox.Size = new Size(210, 27);
			NameTextBox.TabIndex = 21;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(272, 33);
			label1.Name = "label1";
			label1.Size = new Size(81, 20);
			label1.TabIndex = 27;
			label1.Text = "نام رستوران";
			// 
			// RestaurantRegisterUC
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label6);
			Controls.Add(textBox1);
			Controls.Add(label5);
			Controls.Add(RegisterButton);
			Controls.Add(AddressTextBox);
			Controls.Add(label4);
			Controls.Add(NationalCodeTextBox);
			Controls.Add(label3);
			Controls.Add(FamilyTextBox);
			Controls.Add(label2);
			Controls.Add(NameTextBox);
			Controls.Add(label1);
			Name = "RestaurantRegisterUC";
			Size = new Size(412, 353);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label6;
		private TextBox textBox1;
		private Label label5;
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
