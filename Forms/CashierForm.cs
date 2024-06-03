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
	public partial class CashierForm : Form
	{

		List<string> text = new List<string>(){ "ABC", "BCD" };
		public CashierForm()
		{
			InitializeComponent();
		
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
			changeOrderDetails();
			//categoryToolStripMenuItem.Enabled = false;
		}

		private void appetizerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new AppetizerForm());
		}

		private void mainCourseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new MainCourseForm());
		}

		private void dessertToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new DessertForm());
		}

		private void beverageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new BeverageForm());
		}

		private void specialToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new SpecialForm()); 
		}



		private void changeOrderDetails()
		{
			String message = "";
			foreach(string t in text)
			{
				message += t + "\n";
			}
			labelOrderDetails.Text = message;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}
