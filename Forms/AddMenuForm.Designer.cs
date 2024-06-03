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
			this.labelMenu = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.labelDesc = new System.Windows.Forms.Label();
			this.labelCat = new System.Windows.Forms.Label();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonUpload = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			// labelMenu
			// 
			this.labelMenu.AutoSize = true;
			this.labelMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMenu.Location = new System.Drawing.Point(90, 80);
			this.labelMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMenu.Name = "labelMenu";
			this.labelMenu.Size = new System.Drawing.Size(50, 18);
			this.labelMenu.TabIndex = 0;
			this.labelMenu.Text = "Name";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(161, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(217, 26);
			this.textBox1.TabIndex = 1;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(161, 132);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(217, 130);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
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
			this.comboBoxCategory.FormattingEnabled = true;
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
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Add New Menu";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(759, 425);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(74, 30);
			this.buttonReset.TabIndex = 4;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(484, 72);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(349, 190);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
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
			this.buttonUpload.TabIndex = 6;
			this.buttonUpload.Text = "Upload Menu Image";
			this.buttonUpload.UseVisualStyleBackColor = true;
			// 
			// AddMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 537);
			this.Controls.Add(this.buttonUpload);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelCat);
			this.Controls.Add(this.labelDesc);
			this.Controls.Add(this.labelMenu);
			this.Controls.Add(this.labelAdd);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AddMenuForm";
			this.Text = "AddPorductForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAdd;
		private System.Windows.Forms.Label labelMenu;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label labelDesc;
		private System.Windows.Forms.Label labelCat;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openImageFileDialog;
		private System.Windows.Forms.Button buttonUpload;
	}
}