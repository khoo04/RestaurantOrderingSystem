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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			this.Hide();	
			loginForm.ShowDialog();
			this.Close();
		}

		private void buttonRegister_Click(object sender, EventArgs e)
		{
			PasswordForm passwordForm = new PasswordForm();
			this.Hide();
			passwordForm.ShowDialog();
			this.Close();
		}
	}
}
