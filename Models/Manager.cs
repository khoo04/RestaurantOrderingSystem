using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem.Models
{
	internal class Manager : User, Registerable
	{
		RestaurantDBDataContext db = new RestaurantDBDataContext();
		public char Role { get; } = 'M';
		public Manager(string fullName, string username, string password) :
			base(fullName, username, password)
		{
		}

		public void Register()
		{
			//Retrieve All User Record
			IEnumerable<RestaurantOrderingSystem.User> users = from userDetails in db.Users
															   select userDetails;

			//Check the username is taken or not
			foreach (RestaurantOrderingSystem.User userDetails in users)
			{
				if (userDetails.username == base.Username)
				{
					throw new Exception("The username is taken!");
				}
			}
			//Using the namespace Restaurant Ordering System
			RestaurantOrderingSystem.User user = new RestaurantOrderingSystem.User
			{
				fullname = base.FullName,
				username = base.Username,
				password = base.Password,
				position = Role
			};

			db.Users.InsertOnSubmit(user);
			db.SubmitChanges();
		}
	}
}
