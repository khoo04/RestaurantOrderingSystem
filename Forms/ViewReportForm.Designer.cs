namespace RestaurantOrderingSystem.Forms
{
	partial class ViewReportForm
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
			this.labelStartDate = new System.Windows.Forms.Label();
			this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
			this.labelEndDate = new System.Windows.Forms.Label();
			this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
			this.buttonReset = new System.Windows.Forms.Button();
			this.buttonGenerateReport = new System.Windows.Forms.Button();
			this.labelReportDetails = new System.Windows.Forms.Label();
			this.labelTimeGenerated = new System.Windows.Forms.Label();
			this.labelReportDateRange = new System.Windows.Forms.Label();
			this.dataGridViewReport = new System.Windows.Forms.DataGridView();
			this.labelTotalRevenue = new System.Windows.Forms.Label();
			this.labelOrderBy = new System.Windows.Forms.Label();
			this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
			this.SuspendLayout();
			// 
			// labelStartDate
			// 
			this.labelStartDate.AutoSize = true;
			this.labelStartDate.Location = new System.Drawing.Point(73, 30);
			this.labelStartDate.Name = "labelStartDate";
			this.labelStartDate.Size = new System.Drawing.Size(79, 18);
			this.labelStartDate.TabIndex = 0;
			this.labelStartDate.Text = "Start Date";
			// 
			// dateTimePickerStartDate
			// 
			this.dateTimePickerStartDate.Location = new System.Drawing.Point(176, 26);
			this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
			this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 26);
			this.dateTimePickerStartDate.TabIndex = 1;
			// 
			// labelEndDate
			// 
			this.labelEndDate.AutoSize = true;
			this.labelEndDate.Location = new System.Drawing.Point(492, 30);
			this.labelEndDate.Name = "labelEndDate";
			this.labelEndDate.Size = new System.Drawing.Size(74, 18);
			this.labelEndDate.TabIndex = 0;
			this.labelEndDate.Text = "End Date";
			// 
			// dateTimePickerEndDate
			// 
			this.dateTimePickerEndDate.Location = new System.Drawing.Point(595, 26);
			this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
			this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 26);
			this.dateTimePickerEndDate.TabIndex = 1;
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(712, 74);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(83, 33);
			this.buttonReset.TabIndex = 2;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// buttonGenerateReport
			// 
			this.buttonGenerateReport.Location = new System.Drawing.Point(521, 74);
			this.buttonGenerateReport.Name = "buttonGenerateReport";
			this.buttonGenerateReport.Size = new System.Drawing.Size(176, 33);
			this.buttonGenerateReport.TabIndex = 2;
			this.buttonGenerateReport.Text = "Generate Report";
			this.buttonGenerateReport.UseVisualStyleBackColor = true;
			this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
			// 
			// labelReportDetails
			// 
			this.labelReportDetails.AutoSize = true;
			this.labelReportDetails.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelReportDetails.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelReportDetails.Location = new System.Drawing.Point(73, 123);
			this.labelReportDetails.Name = "labelReportDetails";
			this.labelReportDetails.Size = new System.Drawing.Size(117, 19);
			this.labelReportDetails.TabIndex = 4;
			this.labelReportDetails.Text = "Report Details";
			// 
			// labelTimeGenerated
			// 
			this.labelTimeGenerated.AutoSize = true;
			this.labelTimeGenerated.Location = new System.Drawing.Point(74, 156);
			this.labelTimeGenerated.Name = "labelTimeGenerated";
			this.labelTimeGenerated.Size = new System.Drawing.Size(171, 18);
			this.labelTimeGenerated.TabIndex = 5;
			this.labelTimeGenerated.Text = "Report Generated Time";
			// 
			// labelReportDateRange
			// 
			this.labelReportDateRange.AutoSize = true;
			this.labelReportDateRange.Location = new System.Drawing.Point(74, 189);
			this.labelReportDateRange.Name = "labelReportDateRange";
			this.labelReportDateRange.Size = new System.Drawing.Size(258, 18);
			this.labelReportDateRange.TabIndex = 5;
			this.labelReportDateRange.Text = "Date Range: Start Date to End Date";
			// 
			// dataGridViewReport
			// 
			this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReport.Location = new System.Drawing.Point(77, 223);
			this.dataGridViewReport.Name = "dataGridViewReport";
			this.dataGridViewReport.Size = new System.Drawing.Size(718, 215);
			this.dataGridViewReport.TabIndex = 6;
			// 
			// labelTotalRevenue
			// 
			this.labelTotalRevenue.AutoSize = true;
			this.labelTotalRevenue.Location = new System.Drawing.Point(74, 458);
			this.labelTotalRevenue.Name = "labelTotalRevenue";
			this.labelTotalRevenue.Size = new System.Drawing.Size(105, 18);
			this.labelTotalRevenue.TabIndex = 7;
			this.labelTotalRevenue.Text = "Total Revenue";
			// 
			// labelOrderBy
			// 
			this.labelOrderBy.AutoSize = true;
			this.labelOrderBy.Location = new System.Drawing.Point(73, 74);
			this.labelOrderBy.Name = "labelOrderBy";
			this.labelOrderBy.Size = new System.Drawing.Size(70, 18);
			this.labelOrderBy.TabIndex = 0;
			this.labelOrderBy.Text = "Order By";
			// 
			// comboBoxOrderBy
			// 
			this.comboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOrderBy.FormattingEnabled = true;
			this.comboBoxOrderBy.Items.AddRange(new object[] {
            "Max Sales",
            "Min Sales"});
			this.comboBoxOrderBy.Location = new System.Drawing.Point(176, 71);
			this.comboBoxOrderBy.Name = "comboBoxOrderBy";
			this.comboBoxOrderBy.Size = new System.Drawing.Size(121, 26);
			this.comboBoxOrderBy.TabIndex = 8;
			// 
			// ViewReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 498);
			this.Controls.Add(this.comboBoxOrderBy);
			this.Controls.Add(this.labelTotalRevenue);
			this.Controls.Add(this.dataGridViewReport);
			this.Controls.Add(this.labelReportDateRange);
			this.Controls.Add(this.labelTimeGenerated);
			this.Controls.Add(this.labelReportDetails);
			this.Controls.Add(this.buttonGenerateReport);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.dateTimePickerEndDate);
			this.Controls.Add(this.labelOrderBy);
			this.Controls.Add(this.labelEndDate);
			this.Controls.Add(this.dateTimePickerStartDate);
			this.Controls.Add(this.labelStartDate);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ViewReportForm";
			this.Text = "ViewReportForm";
			this.Load += new System.EventHandler(this.ViewReportForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelStartDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
		private System.Windows.Forms.Label labelEndDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Button buttonGenerateReport;
		private System.Windows.Forms.Label labelReportDetails;
		private System.Windows.Forms.Label labelTimeGenerated;
		private System.Windows.Forms.Label labelReportDateRange;
		private System.Windows.Forms.DataGridView dataGridViewReport;
		private System.Windows.Forms.Label labelTotalRevenue;
		private System.Windows.Forms.Label labelOrderBy;
		private System.Windows.Forms.ComboBox comboBoxOrderBy;
	}
}