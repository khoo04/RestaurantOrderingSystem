using RestaurantOrderingSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			string username = textBoxUsername.Text; 
			string password = textBoxPassword.Text;
			User user;

			if (Login(username, password, out char? role, out user))
			{
				if (role == 'M')
				{
					this.Hide();
					ManagerForm managerForm = new ManagerForm(user);
					this.Close();
					managerForm.ShowDialog();
				}
				else
				{
					this.Hide();
					CashierForm cashierForm = new CashierForm(user);
					this.Close();
					cashierForm.ShowDialog();
				}
			}
		}

		private bool Login(string username, string password, out char? role, out User user)
		{
			RestaurantDBDataContext db = new RestaurantDBDataContext();

			//Retrieve User Row
			user = (from u in db.Users
						where u.username == username
						select u).FirstOrDefault();

			if (user != null)
			{
				if (user.password == HashPassword(password))
				{
					role = user.position;
					return true;
				}
				else
				{
					MessageBox.Show("Invalid Credentials");
					role = null;
					return false;
				}
			}
			else
			{
				MessageBox.Show("Invalid Credentials");
				role = null;
				return false;
			}
		}
		private string HashPassword(string password)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
		}
	}
}
