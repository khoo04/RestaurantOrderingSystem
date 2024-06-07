namespace RestaurantOrderingSystem.Forms
{
	partial class UpdateMenuForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMenuForm));
			this.buttonChange = new System.Windows.Forms.Button();
			this.buttunClose = new System.Windows.Forms.Button();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelCat = new System.Windows.Forms.Label();
			this.labelDesc = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelMenuName = new System.Windows.Forms.Label();
			this.labelUpdate = new System.Windows.Forms.Label();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.buttonUpdateMenu = new System.Windows.Forms.Button();
			this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonChange
			// 
			this.buttonChange.Location = new System.Drawing.Point(630, 276);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(177, 32);
			this.buttonChange.TabIndex = 17;
			this.buttonChange.Text = "Change Menu Image";
			this.buttonChange.UseVisualStyleBackColor = true;
			this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
			// 
			// buttunClose
			// 
			this.buttunClose.Location = new System.Drawing.Point(715, 416);
			this.buttunClose.Name = "buttunClose";
			this.buttunClose.Size = new System.Drawing.Size(92, 30);
			this.buttunClose.TabIndex = 19;
			this.buttunClose.Text = "Close";
			this.buttunClose.UseVisualStyleBackColor = true;
			this.buttunClose.Click += new System.EventHandler(this.buttunClose_Click);
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Items.AddRange(new object[] {
            "Appetizer",
            "Main Course",
            "Dessert",
            "Beverage",
            "Special"});
			this.comboBoxCategory.Location = new System.Drawing.Point(135, 276);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(217, 26);
			this.comboBoxCategory.TabIndex = 15;
			// 
			// richTextBoxDesc
			// 
			this.richTextBoxDesc.Location = new System.Drawing.Point(135, 126);
			this.richTextBoxDesc.Name = "richTextBoxDesc";
			this.richTextBoxDesc.Size = new System.Drawing.Size(217, 130);
			this.richTextBoxDesc.TabIndex = 14;
			this.richTextBoxDesc.Text = "";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(135, 333);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(217, 26);
			this.textBoxPrice.TabIndex = 16;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(135, 66);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(217, 26);
			this.textBoxName.TabIndex = 13;
			// 
			// labelCat
			// 
			this.labelCat.AutoSize = true;
			this.labelCat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCat.Location = new System.Drawing.Point(42, 279);
			this.labelCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCat.Name = "labelCat";
			this.labelCat.Size = new System.Drawing.Size(72, 18);
			this.labelCat.TabIndex = 8;
			this.labelCat.Text = "Category";
			// 
			// labelDesc
			// 
			this.labelDesc.AutoSize = true;
			this.labelDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDesc.Location = new System.Drawing.Point(26, 126);
			this.labelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDesc.Name = "labelDesc";
			this.labelDesc.Size = new System.Drawing.Size(88, 18);
			this.labelDesc.TabIndex = 9;
			this.labelDesc.Text = "Description";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice.Location = new System.Drawing.Point(64, 337);
			this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(45, 18);
			this.labelPrice.TabIndex = 10;
			this.labelPrice.Text = "Price";
			// 
			// labelMenuName
			// 
			this.labelMenuName.AutoSize = true;
			this.labelMenuName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMenuName.Location = new System.Drawing.Point(64, 70);
			this.labelMenuName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMenuName.Name = "labelMenuName";
			this.labelMenuName.Size = new System.Drawing.Size(50, 18);
			this.labelMenuName.TabIndex = 11;
			this.labelMenuName.Text = "Name";
			// 
			// labelUpdate
			// 
			this.labelUpdate.AutoSize = true;
			this.labelUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUpdate.Location = new System.Drawing.Point(28, 25);
			this.labelUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelUpdate.Name = "labelUpdate";
			this.labelUpdate.Size = new System.Drawing.Size(110, 19);
			this.labelUpdate.TabIndex = 12;
			this.labelUpdate.Text = "Update Menu";
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxImage.Location = new System.Drawing.Point(458, 66);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(349, 190);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImage.TabIndex = 18;
			this.pictureBoxImage.TabStop = false;
			// 
			// buttonUpdateMenu
			// 
			this.buttonUpdateMenu.Location = new System.Drawing.Point(577, 416);
			this.buttonUpdateMenu.Name = "buttonUpdateMenu";
			this.buttonUpdateMenu.Size = new System.Drawing.Size(132, 30);
			this.buttonUpdateMenu.TabIndex = 19;
			this.buttonUpdateMenu.Text = "Update Menu";
			this.buttonUpdateMenu.UseVisualStyleBackColor = true;
			this.buttonUpdateMenu.Click += new System.EventHandler(this.buttonUpdateMenu_Click);
			// 
			// openImageFileDialog
			// 
			this.openImageFileDialog.FileName = "ImageSelected";
			this.openImageFileDialog.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.GIF)|*.PNG;*.BMP;*.JPG;*.GIF";
			// 
			// UpdateMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 478);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.pictureBoxImage);
			this.Controls.Add(this.buttonUpdateMenu);
			this.Controls.Add(this.buttunClose);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.richTextBoxDesc);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelCat);
			this.Controls.Add(this.labelDesc);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelMenuName);
			this.Controls.Add(this.labelUpdate);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UpdateMenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update Menu";
			this.Load += new System.EventHandler(this.UpdateMenuForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonChange;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.Button buttunClose;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.RichTextBox richTextBoxDesc;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelCat;
		private System.Windows.Forms.Label labelDesc;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelMenuName;
		private System.Windows.Forms.Label labelUpdate;
		private System.Windows.Forms.Button buttonUpdateMenu;
		private System.Windows.Forms.OpenFileDialog openImageFileDialog;
	}
}