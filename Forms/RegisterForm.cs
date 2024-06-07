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

namespace RestaurantOrderingSystem.Forms
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void RegisterForm_Load(object sender, EventArgs e)
		{
			comboBoxRole.SelectedIndex = 0;
		}

		private void buttonRegister_Click(object sender, EventArgs e)
		{
			string fullName = textBoxFullName.Text;
			string username = textBoxUsername.Text;
			string password = textBoxPassword.Text;
			string cfrmPassword  = textBoxConfirmPassword.Text;

			if(fullName != string.Empty && username != string.Empty && password != string.Empty && cfrmPassword != string.Empty)
			{
				if (password == cfrmPassword)
				{
					bool success = false;
					if (comboBoxRole.SelectedIndex == 0)
					{
						//Create Cashier
						Cashier cashier = new Cashier(fullName,username,password);
						try
						{
							cashier.Register();
							success = true;

						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
					else
					{
						Manager manager = new Manager(fullName, username, password);
						try
						{
							manager.Register();
							success = true;

						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
					if (success)
					{
						MessageBox.Show("User registered successfully!");

						//Back to Main Form
						this.Hide();
						MainForm mainForm = new MainForm();
						this.Close();
						mainForm.ShowDialog();
					}		
				}
				else
				{
					MessageBox.Show("Confirm Password must same with password");
				}
			}
			else
			{
				MessageBox.Show("All field must be filled");
			}
		}
	}
}
