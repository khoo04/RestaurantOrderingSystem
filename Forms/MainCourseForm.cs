using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem.Forms
{
	public partial class MainCourseForm : Form
	{

		IEnumerable<Menu> items;

		public delegate void AddItemCallBack(Menu item, int quantity);

		private AddItemCallBack AddItemToOrder;

		private Menu currentSelectedItem;
	
		public MainCourseForm(IEnumerable<Menu> appertizerItems, AddItemCallBack addItemCallBack)
		{
			InitializeComponent();
			textBoxName.ForeColor = Color.FromArgb(28, 40, 51);
			richTextBoxDesc.ForeColor = Color.Black;
			textBoxPrice.ForeColor = Color.Black;
			//Initialize CallBack
			AddItemToOrder = addItemCallBack;
			items = appertizerItems;
			foreach (var item in items)
			{
				comboBoxMainCourse.Items.Add(item.name);
			}
		}

		private void comboBoxMainCourse_SelectedIndexChanged(object sender, EventArgs e)
		{
			string itemSelected = comboBoxMainCourse.SelectedItem.ToString();
			currentSelectedItem = items.Where(item => item.name == itemSelected).FirstOrDefault();
			if (currentSelectedItem != null)
			{
				textBoxName.Text = currentSelectedItem.name;
				richTextBoxDesc.Text = currentSelectedItem.description;
				pictureBoxImage.Image = ByteArrayToImage(currentSelectedItem.image.ToArray());
				textBoxPrice.Text = currentSelectedItem.price.ToString();
			}
			else
			{
				MessageBox.Show("Menu Not Found!", "Alert");
			}
		}

		private Image ByteArrayToImage(byte[] bytes)
		{
			using (MemoryStream ms = new MemoryStream(bytes))
			{
				Image returnImage = System.Drawing.Image.FromStream(ms);
				return returnImage;
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			int quantity;
			bool isValid = int.TryParse(textBoxQuantity.Text, out quantity);
			if (isValid)
			{
				if (currentSelectedItem != null)
				{
					AddItemToOrder(currentSelectedItem, quantity);
				}
				else
				{
					MessageBox.Show("No item is selected", "Alert");
				}
			}
			else
			{
				MessageBox.Show("The quantity must be integer", "Alert");
			}
		}
	}
}
