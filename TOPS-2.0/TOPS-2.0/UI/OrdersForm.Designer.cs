namespace TOPS_2._0.UI
{
	partial class OrdersForm
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
			OrdersGridView = new DataGridView();
			OrderSearchTxt = new TextBox();
			FilterCbx = new ComboBox();
			((System.ComponentModel.ISupportInitialize) OrdersGridView).BeginInit();
			SuspendLayout();
			// 
			// OrdersGridView
			// 
			OrdersGridView.AllowUserToOrderColumns = true;
			OrdersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			OrdersGridView.Location = new Point(12,56);
			OrdersGridView.Name = "OrdersGridView";
			OrdersGridView.Size = new Size(820,422);
			OrdersGridView.TabIndex = 0;
			// 
			// OrderSearchTxt
			// 
			OrderSearchTxt.Location = new Point(12,12);
			OrderSearchTxt.Name = "OrderSearchTxt";
			OrderSearchTxt.PlaceholderText = "Order search...";
			OrderSearchTxt.Size = new Size(175,35);
			OrderSearchTxt.TabIndex = 1;
			// 
			// FilterCbx
			// 
			FilterCbx.FormattingEnabled = true;
			FilterCbx.Location = new Point(226,12);
			FilterCbx.Name = "FilterCbx";
			FilterCbx.Size = new Size(215,38);
			FilterCbx.TabIndex = 2;
			FilterCbx.Text = "Filters";
			// 
			// OrdersForm
			// 
			AutoScaleDimensions = new SizeF(12F,30F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(844,490);
			Controls.Add(FilterCbx);
			Controls.Add(OrderSearchTxt);
			Controls.Add(OrdersGridView);
			Font = new Font("Segoe UI",15.75F,FontStyle.Regular,GraphicsUnit.Point, 0);
			Margin = new Padding(5,6,5,6);
			Name = "OrdersForm";
			Text = "OrdersForm";
			((System.ComponentModel.ISupportInitialize) OrdersGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView OrdersGridView;
		private TextBox OrderSearchTxt;
		private ComboBox FilterCbx;
	}
}