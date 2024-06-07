using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantOrderingSystem.Forms
{
	public partial class ManageMenuForm : Form
	{
		public ManageMenuForm()
		{
			InitializeComponent();
		}

		private void UpdateMenuForm_Load(object sender, EventArgs e)
		{
			RefreshForm();
		}
		
		private void RefreshForm()
		{
			comboBoxCategory.SelectedIndex = 0;
			UpdateTable(RestaurantOrderingSystem.Models.MenuItem.RetrieveAllRecord());
		}
		
		private void UpdateTable(IEnumerable<Menu> menus)
		{
			DataTable menuTable = new DataTable();
			menuTable.Columns.Add("Menu ID", typeof(int));
			menuTable.Columns.Add("Name", typeof(string));
			menuTable.Columns.Add("Description", typeof(string));
			menuTable.Columns.Add("Price", typeof(decimal));
			menuTable.Columns.Add("Image", typeof(System.Drawing.Bitmap));

			foreach (Menu menu in menus)
			{
				DataRow dtRowMenu = menuTable.NewRow();
				dtRowMenu["Menu ID"] = menu.Id;
				dtRowMenu["Name"] = menu.name;
				dtRowMenu["Description"] = menu.description;
				dtRowMenu["Price"] = menu.price;
				dtRowMenu["Image"] = ByteArrayToImage(menu.image.ToArray());
				menuTable.Rows.Add(dtRowMenu);
			}

			dataGridView1.DataSource = menuTable;

			// Set row height
			dataGridView1.RowTemplate.Height = 160;

			// Adjust the image column
			DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["Image"];
			imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
			imageColumn.Width = 250;

			DataGridViewTextBoxColumn descriptionColumn = (DataGridViewTextBoxColumn)dataGridView1.Columns["Description"];
			descriptionColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

			dataGridView1.Columns["Menu ID"].Width = 100; // Specify the width for the Menu ID column
			dataGridView1.Columns["Name"].Width = 150; // Specify the width for the Name column
			dataGridView1.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns["Price"].Width = 75; // Specify the width for the Price column

			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.ReadOnly = true;
		}

		private static Image ByteArrayToImage(byte[] bytes)
		{
			using (MemoryStream ms = new MemoryStream(bytes))
			{
				Image returnImage = System.Drawing.Image.FromStream(ms);
				return returnImage;
			}
		}

		private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedCategory = comboBoxCategory.SelectedItem.ToString();
			if (selectedCategory == "All") {
				UpdateTable(RestaurantOrderingSystem.Models.MenuItem.RetrieveAllRecord());
			}
			else if (selectedCategory == "Appetizer")
			{
				UpdateTable(RestaurantOrderingSystem.Models.Appetizer.RetrieveAllRecord());
			}
			else if (selectedCategory == "Main Course")
			{
				UpdateTable(RestaurantOrderingSystem.Models.MainCourse.RetrieveAllRecord());
			}
			else if (selectedCategory == "Dessert")
			{
				UpdateTable(RestaurantOrderingSystem.Models.Dessert.RetrieveAllRecord());
			}
			else if (selectedCategory == "Beverage")
			{
				UpdateTable(RestaurantOrderingSystem.Models.Beverage.RetrieveAllRecord());
			}
			else if (selectedCategory == "Special")
			{
				UpdateTable(RestaurantOrderingSystem.Models.Special.RetrieveAllRecord());
			}
			else
			{
				MessageBox.Show("Category not found!");
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell != null)
			{
				DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
				// Get the value of the first column
				var value = selectedRow.Cells[0].Value;
				var menuItem = RestaurantOrderingSystem.Models.MenuItem.GetRecord((int)value);
				UpdateMenuForm updateMenuForm = new UpdateMenuForm(menuItem);
				DialogResult result = updateMenuForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					UpdateTable(RestaurantOrderingSystem.Models.MenuItem.RetrieveAllRecord());
				}
			}
			
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentCell != null)
			{
				DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
				// Get the value of the first column
				var value = selectedRow.Cells[0].Value;

				DialogResult result = MessageBox.Show(
					$"Do you want to delete this menu?\nMenu ID: {value}",
					"Delete Confirmation",
					MessageBoxButtons.OKCancel
				);
				if (result == DialogResult.OK)
				{
					RestaurantOrderingSystem.Models.MenuItem.DeleteRecord((int)value);
					RefreshForm();
				}
			}
		}
	}
}
