using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem.Models
{
	internal abstract class MenuItem
	{
		protected static RestaurantDBDataContext db = new RestaurantDBDataContext();
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }

		public System.Data.Linq.Binary Image { set; get; }

		public MenuItem(string name, string description, decimal price, System.Data.Linq.Binary image)
		{
			Name = name;
			Description = description;
			Price = price;
			Image = image;
		}
		public abstract void AddNewRecord();

		public static void DeleteRecord(int menuID)
		{
			var menuItem = db.Menus.Where(menu => menu.Id == menuID).Single();
			db.Menus.DeleteOnSubmit(menuItem);
			db.SubmitChanges();
		}

		public static IEnumerable<Menu> RetrieveAllRecord()
		{
			IEnumerable<Menu> menus = from menuDetails in db.Menus
									  select menuDetails;

			return menus;
		}

		public static RestaurantOrderingSystem.Menu GetRecord(int menu)
		{
			RestaurantOrderingSystem.Menu menuItem = (from Menu in db.Menus
													 where Menu.Id == menu
													 select Menu).FirstOrDefault();
			return menuItem;
		}

		public static bool UpdateRecord(RestaurantOrderingSystem.Menu menuItem)
		{
			var existingMenuItem = db.Menus.SingleOrDefault(m => m.Id == menuItem.Id);

			if (existingMenuItem != null)
			{
				existingMenuItem.name = menuItem.name;
				existingMenuItem.description = menuItem.description;
				existingMenuItem.price = menuItem.price;
				existingMenuItem.image = menuItem.image;
	
				db.SubmitChanges();
				return true;
			}
			else
			{
				throw new ArgumentException("Menu item not found.");;
			}
		}
	}
}
