namespace RestaurantOrderingSystem.Forms
{
	partial class DeleteMenuForm
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
			this.labelDelete = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.labelCategory = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelDelete
			// 
			this.labelDelete.AutoSize = true;
			this.labelDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDelete.Location = new System.Drawing.Point(39, 37);
			this.labelDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDelete.Name = "labelDelete";
			this.labelDelete.Size = new System.Drawing.Size(103, 19);
			this.labelDelete.TabIndex = 10;
			this.labelDelete.Text = "Delete Menu";
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(698, 431);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(132, 30);
			this.buttonDelete.TabIndex = 15;
			this.buttonDelete.Text = "Delete Menu";
			this.buttonDelete.UseVisualStyleBackColor = true;
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
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(658, 37);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(172, 26);
			this.comboBoxCategory.TabIndex = 17;
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
			// DeleteMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 498);
			this.Controls.Add(this.labelCategory);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.labelDelete);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "DeleteMenuForm";
			this.Text = "DeleteMenuForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDelete;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.Label labelCategory;
	}
}