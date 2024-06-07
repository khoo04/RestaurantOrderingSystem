using RestaurantOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantOrderingSystem.Forms
{
	public partial class ViewReportForm : Form
	{
		public ViewReportForm()
		{
			InitializeComponent();
		}

		private void buttonGenerateReport_Click(object sender, EventArgs e)
		{
			string currentTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm tt");
			labelTimeGenerated.Text = $"Report Generated Time : {currentTime}";
			string startDate = dateTimePickerStartDate.Value.ToString("dd-MM-yyyy");
			string endDate = dateTimePickerEndDate.Value.ToString("dd-MM-yyyy");
			labelReportDateRange.Text = $"Date Range: {startDate} - {endDate}";
			IQueryable<ReportData> reportData= ReportData.GetReportData(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);

			if (comboBoxOrderBy.SelectedIndex == 0)
			{
				var orderByData = from data in reportData
								  orderby data.TotalSales descending
								  select data;
				BuildTable(orderByData);
			}
			else
			{
				var orderByData = from data in reportData
								  orderby data.TotalSales ascending
								  select data;
				BuildTable(orderByData);
			}
			
		}

		private void BuildTable(IQueryable<ReportData> reportDatas)
		{
			DataTable reportTable = new DataTable();
			reportTable.Columns.Add("Menu ID", typeof(int));
			reportTable.Columns.Add("Menu Name", typeof(string));
			reportTable.Columns.Add("Unit Price", typeof(decimal));
			reportTable.Columns.Add("Quantity", typeof(int));
			reportTable.Columns.Add("Total Sales", typeof(decimal));

			decimal totalRevenue = 0;

			foreach (ReportData data in reportDatas)
			{
				DataRow dtRowReport = reportTable.NewRow();
				dtRowReport["Menu ID"] = data.MenuId;
				dtRowReport["Menu Name"] = data.MenuName;
				dtRowReport["Unit Price"] = data.MenuPrice;
				dtRowReport["Quantity"] = data.TotalQuantity;
				dtRowReport["Total Sales"] = Math.Round(data.TotalSales, 2);
				totalRevenue += data.TotalSales;
				reportTable.Rows.Add(dtRowReport);
			}

			dataGridViewReport.DataSource = reportTable;
			labelTotalRevenue.Text = $"Total Revenue: RM {Math.Round(totalRevenue, 2)}";

			dataGridViewReport.Columns["Menu Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			
			dataGridViewReport.AllowUserToAddRows = false;
			dataGridViewReport.ReadOnly = true;
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			InitState();
		}

		private void ViewReportForm_Load(object sender, EventArgs e)
		{
			InitState();
		}

		private void InitState()
		{
			comboBoxOrderBy.SelectedIndex = 0;
			labelReportDateRange.Text = "Data Range:";
			labelTimeGenerated.Text = "Report Generated Time:";
			dataGridViewReport.DataSource = null;
			dateTimePickerStartDate.Value = DateTime.Today;
			dateTimePickerEndDate.Value = DateTime.Today.AddDays(1);
			labelTotalRevenue.Text = "";
		}
	}
}
