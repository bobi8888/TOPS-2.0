namespace TOPS_2._0
{
	partial class LogInForm
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
			UsernameTxt = new TextBox();
			PasswordTxt = new TextBox();
			UsernameLbl = new Label();
			PasswordLbl = new Label();
			LoginBtn = new Button();
			SuspendLayout();
			// 
			// UsernameTxt
			// 
			UsernameTxt.Location = new Point(139,12);
			UsernameTxt.Margin = new Padding(5,6,5,6);
			UsernameTxt.Name = "UsernameTxt";
			UsernameTxt.PlaceholderText = "Enter user name";
			UsernameTxt.Size = new Size(169,35);
			UsernameTxt.TabIndex = 0;
			// 
			// PasswordTxt
			// 
			PasswordTxt.Location = new Point(139,59);
			PasswordTxt.Margin = new Padding(5,6,5,6);
			PasswordTxt.Name = "PasswordTxt";
			PasswordTxt.PlaceholderText = "Enter password";
			PasswordTxt.Size = new Size(169,35);
			PasswordTxt.TabIndex = 1;
			// 
			// UsernameLbl
			// 
			UsernameLbl.AutoSize = true;
			UsernameLbl.Location = new Point(14,15);
			UsernameLbl.Name = "UsernameLbl";
			UsernameLbl.Size = new Size(117,30);
			UsernameLbl.TabIndex = 2;
			UsernameLbl.Text = "User name:";
			// 
			// PasswordLbl
			// 
			PasswordLbl.AutoSize = true;
			PasswordLbl.Location = new Point(27,62);
			PasswordLbl.Name = "PasswordLbl";
			PasswordLbl.Size = new Size(104,30);
			PasswordLbl.TabIndex = 3;
			PasswordLbl.Text = "Password:";
			// 
			// LoginBtn
			// 
			LoginBtn.Location = new Point(160,113);
			LoginBtn.Name = "LoginBtn";
			LoginBtn.Size = new Size(109,37);
			LoginBtn.TabIndex = 4;
			LoginBtn.Text = "Log in";
			LoginBtn.UseVisualStyleBackColor = true;
			// 
			// LogInForm
			// 
			AutoScaleDimensions = new SizeF(12F,30F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(359,179);
			Controls.Add(LoginBtn);
			Controls.Add(PasswordLbl);
			Controls.Add(UsernameLbl);
			Controls.Add(PasswordTxt);
			Controls.Add(UsernameTxt);
			Font = new Font("Segoe UI",15.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
			Margin = new Padding(5,6,5,6);
			Name = "LogInForm";
			Text = "Welcome, please log in";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox UsernameTxt;
		private TextBox PasswordTxt;
		private Label UsernameLbl;
		private Label PasswordLbl;
		private Button LoginBtn;
	}
}
