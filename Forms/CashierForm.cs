using RestaurantOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem.Forms
{
	public partial class CashierForm : Form
	{
		public User User { get; set; }
		private List<Menu_Order> customerOrder = new List<Menu_Order>();
		public CashierForm(User user)
		{
			User = user;
			InitializeComponent();
			richTextBoxOrderDetails.ForeColor = Color.FromArgb(28, 40, 51);
			richTextBoxQuantity.ForeColor = Color.Black;
		}
		
		public void loadForm(Form form)
		{
			if (this.panelForm.Controls.Count > 0)
			{
				this.panelForm.Controls.RemoveAt(0);
			}
			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			this.panelForm.Controls.Add(form);
			form.Show();
		}


		private void CashierForm_Load(object sender, EventArgs e)
		{
			labelCashierName.Text = $"Welcome, {User.fullname}";
			ResetForm();
		}

		private void ResetForm()
		{
			this.panelForm.Controls.Clear();
			textBoxName.Enabled = false;
			categoryToolStripMenuItem.Enabled = false;
			resetToolStripMenuItem.Enabled = false;
			saveOrderToolStripMenuItem.Enabled = false;
			buttonSaveOrder.Enabled = false;
			buttonReset.Enabled = false;
			buttonDeletePrevious.Enabled = false;
			textBoxName.Text = string.Empty;
			labelCustName.Text = "Customer Name";
			buttonNew.Enabled = true;
			customerOrder.Clear();
			UpdateOrderDetails();
		}

		private void AddMenuItemCallBack(Menu item, int quantity)
		{
			int index = customerOrder.FindIndex(order => order.menu_id == item.Id);
			if (index == -1)
			{
				Menu_Order menu_order = new Menu_Order
				{
					menu_id = item.Id,
					quantity = quantity
				};
				customerOrder.Add(menu_order);
			}
			else
			{
				customerOrder[index].quantity += quantity;
			}
			UpdateOrderDetails();
		}

		private void UpdateOrderDetails()
		{
			System.Data.Linq.Table<Menu> menuTable = new RestaurantDBDataContext().Menus;
			richTextBoxOrderDetails.Text = string.Empty;
			richTextBoxQuantity.Text = string.Empty;
			foreach (var order in customerOrder)
			{
				Menu menuItem = (from menu in menuTable where menu.Id == order.menu_id select menu).FirstOrDefault();
				richTextBoxOrderDetails.Text += menuItem.name + "\n";
				richTextBoxQuantity.Text += order.quantity + "\n";
			}
		}


		private void appetizerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new AppetizerForm(Appetizer.RetrieveAllRecord(),AddMenuItemCallBack));
		}

		private void mainCourseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new MainCourseForm(MainCourse.RetrieveAllRecord(),AddMenuItemCallBack));
		}

		private void dessertToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new DessertForm(Dessert.RetrieveAllRecord(),AddMenuItemCallBack));
		}

		private void beverageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new BeverageForm(Beverage.RetrieveAllRecord(),AddMenuItemCallBack));
		}

		private void specialToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new SpecialForm(Special.RetrieveAllRecord(),AddMenuItemCallBack)); 
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			new MainForm().ShowDialog();
			this.Close();
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			NewOrder();
		}

		private void NewOrder() {
			buttonDeletePrevious.Enabled = true;
			textBoxName.Enabled = true;
			buttonNew.Enabled = false;
			categoryToolStripMenuItem.Enabled = true;
			resetToolStripMenuItem.Enabled = true;
			saveOrderToolStripMenuItem.Enabled = true;
			buttonSaveOrder.Enabled = true;
			buttonReset.Enabled = true;
		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewOrder();
		}

		private void textBoxName_TextChanged(object sender, EventArgs e)
		{
			labelCustName.Text = textBoxName.Text;
		}

		private void buttonSaveOrder_Click(object sender, EventArgs e)
		{
			System.Data.Linq.Table<Menu> menuTable = new RestaurantDBDataContext().Menus;
			if (textBoxName.Text != string.Empty)
			{
				if (customerOrder.Count > 0)
				{
					decimal grandTotal = 0;
					string message = "";
					message += $"Customer Name: {textBoxName.Text}\n";
					message += $"Order Items\tQuantity\t\tTotal Price\n";
					foreach (Menu_Order order in customerOrder)
					{
						Menu menuItem = (from menu in menuTable where menu.Id == order.menu_id select menu).FirstOrDefault();
						decimal totalPrice = order.quantity * menuItem.price;
						message += $"{menuItem.name}\t{order.quantity}\t\tRM {totalPrice}\n";
						grandTotal+= totalPrice;
					}
					message += $"\nGrand Total: RM {grandTotal}";
					DialogResult result = MessageBox.Show(message, "Do you all the order is correct?", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						CustomerOrder cOrder = new CustomerOrder(User.Id);
						cOrder.SaveOrderToDB(textBoxName.Text, grandTotal, customerOrder);
						ResetForm();
						
					}
				}
				else
				{
					MessageBox.Show("At least one item should be added", "Alert");
				}
			}
			else
			{
				MessageBox.Show("Customer name must be provided!","Alert");
			}
		}

		private void buttonDeletePrevious_Click(object sender, EventArgs e)
		{
			if (customerOrder.Count > 0)
			{
				customerOrder.RemoveAt(customerOrder.Count - 1);
				UpdateOrderDetails();
			}
			else
			{
				MessageBox.Show("No Item in the order");
			}
		}
	}
}
