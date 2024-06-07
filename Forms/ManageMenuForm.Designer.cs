namespace RestaurantOrderingSystem.Forms
{
	partial class ManageMenuForm
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
			this.labelManage = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.labelCategory = new System.Windows.Forms.Label();
			this.buttonUpdate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelManage
			// 
			this.labelManage.AutoSize = true;
			this.labelManage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelManage.Location = new System.Drawing.Point(39, 37);
			this.labelManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelManage.Name = "labelManage";
			this.labelManage.Size = new System.Drawing.Size(115, 19);
			this.labelManage.TabIndex = 10;
			this.labelManage.Text = "Manage Menu";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(698, 431);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(132, 30);
			this.buttonDelete.TabIndex = 15;
			this.buttonDelete.Text = "Delete Menu";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(43, 76);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(787, 329);
			this.dataGridView1.TabIndex = 16;
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Items.AddRange(new object[] {
            "All",
            "Appetizer",
            "Main Course",
            "Dessert",
            "Beverage",
            "Special"});
			this.comboBoxCategory.Location = new System.Drawing.Point(658, 37);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(172, 26);
			this.comboBoxCategory.TabIndex = 17;
			this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
			// 
			// labelCategory
			// 
			this.labelCategory.AutoSize = true;
			this.labelCategory.Location = new System.Drawing.Point(511, 40);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(131, 18);
			this.labelCategory.TabIndex = 18;
			this.labelCategory.Text = "Filter by Category";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(560, 431);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(132, 30);
			this.buttonUpdate.TabIndex = 15;
			this.buttonUpdate.Text = "Update Menu";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// ManageMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 498);
			this.Controls.Add(this.labelCategory);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.labelManage);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ManageMenuForm";
			this.Text = "DeleteMenuForm";
			this.Load += new System.EventHandler(this.UpdateMenuForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelManage;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.Button buttonUpdate;
	}
}