namespace TOPS_2._0.UI
{
	partial class CustomerForm
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
			FirstNameTxt = new TextBox();
			LastNameTxt = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			TypeCbx = new ComboBox();
			AddCustomerBtn = new Button();
			SuspendLayout();
			// 
			// FirstNameTxt
			// 
			FirstNameTxt.Location = new Point(184,31);
			FirstNameTxt.Margin = new Padding(5,6,5,6);
			FirstNameTxt.Name = "FirstNameTxt";
			FirstNameTxt.Size = new Size(169,35);
			FirstNameTxt.TabIndex = 0;
			// 
			// LastNameTxt
			// 
			LastNameTxt.Location = new Point(184,73);
			LastNameTxt.Margin = new Padding(5,6,5,6);
			LastNameTxt.Name = "LastNameTxt";
			LastNameTxt.Size = new Size(169,35);
			LastNameTxt.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(34,34);
			label1.Name = "label1";
			label1.Size = new Size(118,30);
			label1.TabIndex = 3;
			label1.Text = "First Name:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(36,73);
			label2.Name = "label2";
			label2.Size = new Size(117,30);
			label2.TabIndex = 4;
			label2.Text = "Last Name:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(91,118);
			label3.Name = "label3";
			label3.Size = new Size(61,30);
			label3.TabIndex = 5;
			label3.Text = "Type:";
			// 
			// TypeCbx
			// 
			TypeCbx.FormattingEnabled = true;
			TypeCbx.Location = new Point(184,115);
			TypeCbx.Name = "TypeCbx";
			TypeCbx.Size = new Size(169,38);
			TypeCbx.TabIndex = 6;
			// 
			// AddCustomerBtn
			// 
			AddCustomerBtn.Location = new Point(184,169);
			AddCustomerBtn.Name = "AddCustomerBtn";
			AddCustomerBtn.Size = new Size(169,41);
			AddCustomerBtn.TabIndex = 7;
			AddCustomerBtn.Text = "Add customer";
			AddCustomerBtn.UseVisualStyleBackColor = true;
			AddCustomerBtn.Click += AddCustomerBtn_Click;
			// 
			// CustomerForm
			// 
			AutoScaleDimensions = new SizeF(12F,30F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(407,233);
			Controls.Add(AddCustomerBtn);
			Controls.Add(TypeCbx);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(LastNameTxt);
			Controls.Add(FirstNameTxt);
			Font = new Font("Segoe UI",15.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
			Margin = new Padding(5,6,5,6);
			Name = "CustomerForm";
			Text = "CustomerForm";
			Load += CustomerForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox FirstNameTxt;
		private TextBox LastNameTxt;
		private Label label1;
		private Label label2;
		private Label label3;
		private ComboBox TypeCbx;
		private Button AddCustomerBtn;
	}
}