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
	public partial class PasswordForm : Form
	{
		const string SUPER_KEY = "abc123";
		public PasswordForm()
		{
			InitializeComponent();
		}

		private void PasswordForm_Load(object sender, EventArgs e)
		{

		}

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			String supertkey = textBoxSuperKey.Text;
			if (supertkey == SUPER_KEY)
			{
				RegisterForm registerForm = new RegisterForm();
				this.Hide();
				registerForm.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Invalid Super Key!");
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
			this.Hide();
			mainForm.ShowDialog();
			this.Close();
		}
	}
}
