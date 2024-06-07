using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem.Models
{
	internal class CustomerOrder
	{
		private static RestaurantDBDataContext db = new RestaurantDBDataContext();
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime CreatedDate { get; set; }
		public int PICID { get; set; }

		public Order order;

		public CustomerOrder(int PICID) {

			order = new Order();
			GeneratedOrderID();
			order.Id = Id;
			order.pic_id = PICID;
		}

		private void GeneratedOrderID()
		{
			int rowOrderCount;
			//Check The Order Row
			int count = (from order in db.Orders select order).Count();
			if (count != 0)
			{
				rowOrderCount = (from order in db.Orders
								 select order.Id).Max();
			}
			else
			{
				rowOrderCount = 1;
			}

			Id = ++rowOrderCount;
		}

		public void SaveOrderToDB(string custName, decimal totalPrice, List<Menu_Order> menu_orders)
		{
			Name = custName;
			TotalPrice = totalPrice;
			CreatedDate = DateTime.Now;

			order.customer_name = Name;
			order.total_price = TotalPrice;
			order.created_at = CreatedDate;

			db.Orders.InsertOnSubmit(order);

			foreach (Menu_Order menu_order in menu_orders)
			{
				menu_order.order_id = order.Id;
				db.Menu_Orders.InsertOnSubmit(menu_order);
			}

			foreach (Menu_Order menu_Order in menu_orders)
			{
				Console.WriteLine($"Order ID : {menu_Order.order_id}");
				Console.WriteLine($"Menu ID : {menu_Order.menu_id}");
			}

			db.SubmitChanges();
			MessageBox.Show("Record saved successfully", "Success");
		}
	}
}
