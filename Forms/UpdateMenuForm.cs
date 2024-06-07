using RestaurantOrderingSystem.Models;
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
	public partial class UpdateMenuForm : Form
	{
		public RestaurantOrderingSystem.Menu menuItem;
		public UpdateMenuForm(RestaurantOrderingSystem.Menu menuItem)
		{
			InitializeComponent();
			this.menuItem = menuItem;
		}

		private void UpdateMenuForm_Load(object sender, EventArgs e)
		{
			textBoxName.Text = menuItem.name;
			richTextBoxDesc.Text = menuItem.description;
			comboBoxCategory.SelectedItem = menuItem.category;
			textBoxPrice.Text = menuItem.price.ToString();
			pictureBoxImage.Image = ByteArrayToImage(menuItem.image.ToArray());
		}

		//Change Image to Byte Array to Store in DB
		private byte[] ImageToByteArray(System.Drawing.Image img)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				return ms.ToArray();
			}
		}

		private static Image ByteArrayToImage(byte[] bytes)
		{
			using (MemoryStream ms = new MemoryStream(bytes))
			{
				Image returnImage = System.Drawing.Image.FromStream(ms);
				return returnImage;
			}
		}

		private void buttunClose_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.None;
			this.Close();
		}

		private void buttonUpdateMenu_Click(object sender, EventArgs e)
		{
			string name = textBoxName.Text;
			string desc = richTextBoxDesc.Text;
			string category = comboBoxCategory.SelectedItem.ToString();
			decimal price;
			bool isPriceValid = Decimal.TryParse(textBoxPrice.Text, out price);

			if (name != string.Empty &&
				desc != string.Empty &&
				category != string.Empty &&
				textBoxPrice.Text != string.Empty &&
				pictureBoxImage.Image != null)
			{
				if (isPriceValid)
				{
					//Rounded to 2 Decimal Places
					price = decimal.Round(price, 2);
					menuItem.name = name;
					menuItem.description = desc;
					menuItem.category = category;
					menuItem.price = price;
					menuItem.image = ImageToByteArray(pictureBoxImage.Image);

					if (RestaurantOrderingSystem.Models.MenuItem.UpdateRecord(menuItem))
					{
						MessageBox.Show("Update Record Succesfully!", "Success");
						this.DialogResult = DialogResult.OK;
						this.Close();
					}

				}
				else
				{
					MessageBox.Show("Invalid Price, Only numbers are allowed");
				}
			}
			else
			{
				MessageBox.Show("Please fill up all fields");
			}
		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
			if (openImageFileDialog.ShowDialog() == DialogResult.OK)
			{
				pictureBoxImage.Image = Image.FromFile(openImageFileDialog.FileName);
			}
		}
	}
}
