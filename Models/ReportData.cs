using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem.Models
{
	internal class ReportData
	{
		public int MenuId { get; set; }
		public string MenuName { get; set; }
		public decimal MenuPrice { get; set; }
		public int TotalQuantity { get; set; }

		public decimal TotalSales { get; set; }

		private static readonly RestaurantDBDataContext db = new RestaurantDBDataContext();

		public static IQueryable<ReportData> GetReportData(DateTime startDate, DateTime endDate)
		{
			var reportData = from menu_order in db.Menu_Orders
							 join order in db.Orders on menu_order.order_id equals order.Id
							 join menu in db.Menus on menu_order.menu_id equals menu.Id
							 where order.created_at >= startDate && order.created_at <= endDate
							 group menu_order by new { menu.Id, menu.name, menu.price } into g
							 select new ReportData
							 {
								 MenuId = g.Key.Id,
								 MenuName = g.Key.name,
								 MenuPrice = g.Key.price,
								 TotalQuantity = g.Sum(menu_order => menu_order.quantity),
								 TotalSales = g.Key.price * g.Sum(menu_order => menu_order.quantity),
							 };

			return reportData;
		}
	}
}
