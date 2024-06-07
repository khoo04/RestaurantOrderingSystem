using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem.Models
{
	internal class Beverage : MenuItem
	{
		public static string Category { get; } = "Beverage";
		public Beverage(string name, string description, decimal price, Binary image) : base(name, description, price, image)
		{
		}

		public override void AddNewRecord()
		{
			//Retrieve All User Record
			//Notes: DatabaseContext from parent class
			IEnumerable<RestaurantOrderingSystem.Menu> menuDetails = from menuD in db.Menus
																	 select menuD;

			//Check the username is taken or not
			foreach (RestaurantOrderingSystem.Menu menuDetail in menuDetails)
			{
				if (menuDetail.name == base.Name)
				{
					throw new Exception("The menu name is taken!");
				}
			}
			//Using the namespace Restaurant Ordering System
			RestaurantOrderingSystem.Menu menu = new RestaurantOrderingSystem.Menu
			{
				name = base.Name,
				description = base.Description,
				price = base.Price,
				image = base.Image,
				category = Category,
			};

			db.Menus.InsertOnSubmit(menu);
			db.SubmitChanges();
		}

		public static new IEnumerable<Menu> RetrieveAllRecord()
		{
			IEnumerable<Menu> menus = from menuD in db.Menus
									  where menuD.category == Category
									  select menuD;
			return menus;
		}
	}
}
