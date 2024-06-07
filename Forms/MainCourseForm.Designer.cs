namespace RestaurantOrderingSystem.Forms
{
	partial class MainCourseForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelDesc = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelMainCourse = new System.Windows.Forms.Label();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.labelQuantity = new System.Windows.Forms.Label();
			this.comboBoxMainCourse = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 454);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBoxImage);
			this.panel1.Controls.Add(this.richTextBoxDesc);
			this.panel1.Controls.Add(this.labelName);
			this.panel1.Controls.Add(this.textBoxPrice);
			this.panel1.Controls.Add(this.textBoxName);
			this.panel1.Controls.Add(this.labelPrice);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.labelDesc);
			this.panel1.Location = new System.Drawing.Point(366, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 448);
			this.panel1.TabIndex = 14;
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.Location = new System.Drawing.Point(40, 252);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(215, 126);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImage.TabIndex = 7;
			this.pictureBoxImage.TabStop = false;
			// 
			// richTextBoxDesc
			// 
			this.richTextBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBoxDesc.Enabled = false;
			this.richTextBoxDesc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBoxDesc.Location = new System.Drawing.Point(40, 86);
			this.richTextBoxDesc.Name = "richTextBoxDesc";
			this.richTextBoxDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richTextBoxDesc.Size = new System.Drawing.Size(212, 125);
			this.richTextBoxDesc.TabIndex = 6;
			this.richTextBoxDesc.Text = "";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(37, 33);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(53, 19);
			this.labelName.TabIndex = 4;
			this.labelName.Text = "Name";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPrice.Enabled = false;
			this.textBoxPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPrice.Location = new System.Drawing.Point(83, 398);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(172, 19);
			this.textBoxPrice.TabIndex = 5;
			// 
			// textBoxName
			// 
			this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxName.Enabled = false;
			this.textBoxName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxName.Location = new System.Drawing.Point(84, 34);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(171, 19);
			this.textBoxName.TabIndex = 5;
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice.Location = new System.Drawing.Point(37, 397);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(49, 19);
			this.labelPrice.TabIndex = 3;
			this.labelPrice.Text = "Price";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(37, 233);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Image";
			// 
			// labelDesc
			// 
			this.labelDesc.AutoSize = true;
			this.labelDesc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDesc.Location = new System.Drawing.Point(37, 67);
			this.labelDesc.Name = "labelDesc";
			this.labelDesc.Size = new System.Drawing.Size(99, 19);
			this.labelDesc.TabIndex = 3;
			this.labelDesc.Text = "Description";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.labelMainCourse);
			this.panel2.Controls.Add(this.textBoxQuantity);
			this.panel2.Controls.Add(this.buttonAdd);
			this.panel2.Controls.Add(this.labelQuantity);
			this.panel2.Controls.Add(this.comboBoxMainCourse);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(357, 448);
			this.panel2.TabIndex = 13;
			// 
			// labelMainCourse
			// 
			this.labelMainCourse.AutoSize = true;
			this.labelMainCourse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMainCourse.Location = new System.Drawing.Point(32, 33);
			this.labelMainCourse.Name = "labelMainCourse";
			this.labelMainCourse.Size = new System.Drawing.Size(107, 19);
			this.labelMainCourse.TabIndex = 14;
			this.labelMainCourse.Text = "Main Course";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Location = new System.Drawing.Point(134, 70);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.Size = new System.Drawing.Size(173, 26);
			this.textBoxQuantity.TabIndex = 2;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdd.Location = new System.Drawing.Point(211, 115);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(96, 26);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Add Item";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// labelQuantity
			// 
			this.labelQuantity.AutoSize = true;
			this.labelQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQuantity.Location = new System.Drawing.Point(58, 73);
			this.labelQuantity.Name = "labelQuantity";
			this.labelQuantity.Size = new System.Drawing.Size(76, 19);
			this.labelQuantity.TabIndex = 13;
			this.labelQuantity.Text = "Quantity";
			// 
			// comboBoxMainCourse
			// 
			this.comboBoxMainCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMainCourse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxMainCourse.FormattingEnabled = true;
			this.comboBoxMainCourse.Location = new System.Drawing.Point(134, 31);
			this.comboBoxMainCourse.Name = "comboBoxMainCourse";
			this.comboBoxMainCourse.Size = new System.Drawing.Size(173, 26);
			this.comboBoxMainCourse.TabIndex = 1;
			this.comboBoxMainCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainCourse_SelectedIndexChanged);
			// 
			// MainCourseForm
			// 
			this.AcceptButton = this.buttonAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 454);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainCourseForm";
			this.Text = "MainCourseForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.RichTextBox richTextBoxDesc;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelDesc;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelMainCourse;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label labelQuantity;
		private System.Windows.Forms.ComboBox comboBoxMainCourse;
	}
}