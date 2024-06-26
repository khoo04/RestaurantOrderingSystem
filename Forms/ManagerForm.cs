﻿using System;
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
	public partial class ManagerForm : Form
	{
		public ManagerForm()
		{
			InitializeComponent();
		}

		private void loadForm(Form form)
		{
			if (this.panelManage.Controls.Count > 0)
			{
				this.panelManage.Controls.RemoveAt(0);
			}
			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			this.panelManage.Controls.Add(form);
			form.Show();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void addMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new AddMenuForm());
		}

		private void deleteMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new DeleteMenuForm());
		}

		private void viewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadForm(new ViewReportForm());
		}
	}
}
