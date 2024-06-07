using RestaurantOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem.Forms
{
	public partial class AddMenuForm : Form
	{
		public AddMenuForm()
		{
			InitializeComponent();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
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
					bool isSuccess = false;
					switch (category)
					{
						case "Appetizer":
							Appetizer appetizer = new Appetizer(name,desc,price,ImageToByteArray(pictureBoxImage.Image));
							try
							{
								appetizer.AddNewRecord();
								isSuccess = true;
							}
							catch(Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
							break;
						case "Main Course":
							MainCourse mainCourse = new MainCourse(name, desc, price, ImageToByteArray(pictureBoxImage.Image));
							try
							{
								mainCourse.AddNewRecord();
								isSuccess = true;
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
							break;
						case "Dessert":
							Dessert dessert = new Dessert(name, desc, price, ImageToByteArray(pictureBoxImage.Image));
							try
							{
								dessert.AddNewRecord();
								isSuccess = true;
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
							break;
						case "Beverage":
							Beverage beverage = new Beverage(name, desc, price, ImageToByteArray(pictureBoxImage.Image));
							try
							{
								beverage.AddNewRecord();
								isSuccess = true;
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
							break;
						case "Special":
							Special special = new Special(name, desc, price, ImageToByteArray(pictureBoxImage.Image));
							try
							{
								special.AddNewRecord();
								isSuccess = true;
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
							break;
						default:
							MessageBox.Show("Not a valid option!");
							break;
					}
					if (isSuccess)
					{
						MessageBox.Show("Record Added","Success");
						resetForm();
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

		private void AddMenuForm_Load(object sender, EventArgs e)
		{
			comboBoxCategory.SelectedIndex = 0;
		}

		private void buttonUpload_Click(object sender, EventArgs e)
		{
			openImageFileDialog.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF";
			if (openImageFileDialog.ShowDialog() == DialogResult.OK)
			{
				pictureBoxImage.Image?.Dispose();
				try
				{
					pictureBoxImage.Image = Image.FromFile(openImageFileDialog.FileName);
				}
				catch (OutOfMemoryException ex)
				{
					MessageBox.Show("Unable to add this picture. Try another.");
				}
			}
		}

		//Change Image to Byte Array to Store in DB
		private byte[] ImageToByteArray(System.Drawing.Image img)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
				return ms.ToArray();
			}
		}

		private void resetForm()
		{
			textBoxName.Text = string.Empty;
			richTextBoxDesc.Text = string.Empty;
			pictureBoxImage.Image = null;
			comboBoxCategory.SelectedIndex = 0;
			textBoxPrice.Text = string.Empty;
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			resetForm();
		}
	}
}
