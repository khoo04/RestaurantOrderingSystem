using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem.Models
{
	internal abstract class User
	{
		public string FullName { get; set; }
		public string Username { get; set; }
		public string _password;

		public string Password { get { return _password; } set { _password = HashPassword(value); } }

		protected User(string fullName, string username, string password)
		{
			FullName = fullName;
			Username = username;
			Password = password;
		}

		private string HashPassword(string password)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
		}
	}
}
