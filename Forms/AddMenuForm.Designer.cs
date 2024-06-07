namespace RestaurantOrderingSystem.Forms
{
	partial class AddMenuForm
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
			this.labelAdd = new System.Windows.Forms.Label();
			this.labelMenuName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
			this.labelDesc = new System.Windows.Forms.Label();
			this.labelCat = new System.Windows.Forms.Label();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonUpload = new System.Windows.Forms.Button();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// labelAdd
			// 
			this.labelAdd.AutoSize = true;
			this.labelAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAdd.Location = new System.Drawing.Point(54, 31);
			this.labelAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelAdd.Name = "labelAdd";
			this.labelAdd.Size = new System.Drawing.Size(86, 19);
			this.labelAdd.TabIndex = 0;
			this.labelAdd.Text = "Add Menu";
			// 
			// labelMenuName
			// 
			this.labelMenuName.AutoSize = true;
			this.labelMenuName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMenuName.Location = new System.Drawing.Point(90, 76);
			this.labelMenuName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMenuName.Name = "labelMenuName";
			this.labelMenuName.Size = new System.Drawing.Size(50, 18);
			this.labelMenuName.TabIndex = 0;
			this.labelMenuName.Text = "Name";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(161, 72);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(217, 26);
			this.textBoxName.TabIndex = 1;
			// 
			// richTextBoxDesc
			// 
			this.richTextBoxDesc.Location = new System.Drawing.Point(161, 132);
			this.richTextBoxDesc.Name = "richTextBoxDesc";
			this.richTextBoxDesc.Size = new System.Drawing.Size(217, 130);
			this.richTextBoxDesc.TabIndex = 2;
			this.richTextBoxDesc.Text = "";
			// 
			// labelDesc
			// 
			this.labelDesc.AutoSize = true;
			this.labelDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDesc.Location = new System.Drawing.Point(52, 132);
			this.labelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDesc.Name = "labelDesc";
			this.labelDesc.Size = new System.Drawing.Size(88, 18);
			this.labelDesc.TabIndex = 0;
			this.labelDesc.Text = "Description";
			// 
			// labelCat
			// 
			this.labelCat.AutoSize = true;
			this.labelCat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCat.Location = new System.Drawing.Point(68, 285);
			this.labelCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCat.Name = "labelCat";
			this.labelCat.Size = new System.Drawing.Size(72, 18);
			this.labelCat.TabIndex = 0;
			this.labelCat.Text = "Category";
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
			this.comboBoxCategory.Location = new System.Drawing.Point(161, 282);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(217, 26);
			this.comboBoxCategory.TabIndex = 3;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(605, 425);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(132, 30);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.Text = "Add New Menu";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(759, 425);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(74, 30);
			this.buttonReset.TabIndex = 7;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxImage.Location = new System.Drawing.Point(484, 72);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(349, 190);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImage.TabIndex = 5;
			this.pictureBoxImage.TabStop = false;
			// 
			// openImageFileDialog
			// 
			this.openImageFileDialog.FileName = "MenuImage";
			// 
			// buttonUpload
			// 
			this.buttonUpload.Location = new System.Drawing.Point(656, 282);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.Size = new System.Drawing.Size(177, 32);
			this.buttonUpload.TabIndex = 5;
			this.buttonUpload.Text = "Upload Menu Image";
			this.buttonUpload.UseVisualStyleBackColor = true;
			this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(161, 339);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(217, 26);
			this.textBoxPrice.TabIndex = 4;
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice.Location = new System.Drawing.Point(90, 343);
			this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(45, 18);
			this.labelPrice.TabIndex = 0;
			this.labelPrice.Text = "Price";
			// 
			// AddMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 537);
			this.Controls.Add(this.buttonUpload);
			this.Controls.Add(this.pictureBoxImage);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.richTextBoxDesc);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelCat);
			this.Controls.Add(this.labelDesc);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelMenuName);
			this.Controls.Add(this.labelAdd);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddMenuForm";
			this.Text = "AddPorductForm";
			this.Load += new System.EventHandler(this.AddMenuForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAdd;
		private System.Windows.Forms.Label labelMenuName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.RichTextBox richTextBoxDesc;
		private System.Windows.Forms.Label labelDesc;
		private System.Windows.Forms.Label labelCat;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.OpenFileDialog openImageFileDialog;
		private System.Windows.Forms.Button buttonUpload;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label labelPrice;
	}
}