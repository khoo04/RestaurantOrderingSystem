namespace RestaurantOrderingSystem.Forms
{
	partial class CashierForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
			this.labelCashierName = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.appetizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dessertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beverageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.specialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelOrderDetails = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.labelCustName = new System.Windows.Forms.Label();
			this.labelOrderDetails = new System.Windows.Forms.Label();
			this.labelOrder = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonSaveOrder = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.labelCust = new System.Windows.Forms.Label();
			this.panelForm = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.panelOrderDetails.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelCashierName
			// 
			this.labelCashierName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelCashierName.AutoSize = true;
			this.labelCashierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCashierName.Location = new System.Drawing.Point(22, 12);
			this.labelCashierName.Name = "labelCashierName";
			this.labelCashierName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.labelCashierName.Size = new System.Drawing.Size(183, 18);
			this.labelCashierName.TabIndex = 0;
			this.labelCashierName.Text = "Welcome, Cashier Name";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.logOutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(884, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// orderToolStripMenuItem
			// 
			this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.saveOrderToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
			this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.orderToolStripMenuItem.Text = "Order";
			// 
			// newOrderToolStripMenuItem
			// 
			this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
			this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.newOrderToolStripMenuItem.Text = "New Order";
			// 
			// saveOrderToolStripMenuItem
			// 
			this.saveOrderToolStripMenuItem.Name = "saveOrderToolStripMenuItem";
			this.saveOrderToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.saveOrderToolStripMenuItem.Text = "Save Order";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// categoryToolStripMenuItem
			// 
			this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appetizerToolStripMenuItem,
            this.mainCourseToolStripMenuItem,
            this.dessertToolStripMenuItem,
            this.beverageToolStripMenuItem,
            this.specialToolStripMenuItem});
			this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
			this.categoryToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
			this.categoryToolStripMenuItem.Text = "Food Category";
			// 
			// appetizerToolStripMenuItem
			// 
			this.appetizerToolStripMenuItem.Name = "appetizerToolStripMenuItem";
			this.appetizerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.appetizerToolStripMenuItem.Text = "Appetizer";
			this.appetizerToolStripMenuItem.Click += new System.EventHandler(this.appetizerToolStripMenuItem_Click);
			// 
			// mainCourseToolStripMenuItem
			// 
			this.mainCourseToolStripMenuItem.Name = "mainCourseToolStripMenuItem";
			this.mainCourseToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.mainCourseToolStripMenuItem.Text = "Main Course";
			this.mainCourseToolStripMenuItem.Click += new System.EventHandler(this.mainCourseToolStripMenuItem_Click);
			// 
			// dessertToolStripMenuItem
			// 
			this.dessertToolStripMenuItem.Name = "dessertToolStripMenuItem";
			this.dessertToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.dessertToolStripMenuItem.Text = "Dessert";
			this.dessertToolStripMenuItem.Click += new System.EventHandler(this.dessertToolStripMenuItem_Click);
			// 
			// beverageToolStripMenuItem
			// 
			this.beverageToolStripMenuItem.Name = "beverageToolStripMenuItem";
			this.beverageToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.beverageToolStripMenuItem.Text = "Beverage";
			this.beverageToolStripMenuItem.Click += new System.EventHandler(this.beverageToolStripMenuItem_Click);
			// 
			// specialToolStripMenuItem
			// 
			this.specialToolStripMenuItem.Name = "specialToolStripMenuItem";
			this.specialToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.specialToolStripMenuItem.Text = "Special";
			this.specialToolStripMenuItem.Click += new System.EventHandler(this.specialToolStripMenuItem_Click);
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.logOutToolStripMenuItem.Text = "Log Out";
			// 
			// panelOrderDetails
			// 
			this.panelOrderDetails.AutoScroll = true;
			this.panelOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelOrderDetails.Controls.Add(this.label1);
			this.panelOrderDetails.Controls.Add(this.labelCustName);
			this.panelOrderDetails.Controls.Add(this.labelOrderDetails);
			this.panelOrderDetails.Controls.Add(this.labelCashierName);
			this.panelOrderDetails.Controls.Add(this.labelOrder);
			this.panelOrderDetails.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelOrderDetails.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panelOrderDetails.Location = new System.Drawing.Point(661, 24);
			this.panelOrderDetails.Name = "panelOrderDetails";
			this.panelOrderDetails.Size = new System.Drawing.Size(223, 537);
			this.panelOrderDetails.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(146, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Quantity";
			// 
			// labelCustName
			// 
			this.labelCustName.AutoSize = true;
			this.labelCustName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCustName.Location = new System.Drawing.Point(19, 82);
			this.labelCustName.Name = "labelCustName";
			this.labelCustName.Size = new System.Drawing.Size(101, 16);
			this.labelCustName.TabIndex = 1;
			this.labelCustName.Text = "Customer Name";
			// 
			// labelOrderDetails
			// 
			this.labelOrderDetails.AutoSize = true;
			this.labelOrderDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOrderDetails.Location = new System.Drawing.Point(19, 111);
			this.labelOrderDetails.Name = "labelOrderDetails";
			this.labelOrderDetails.Size = new System.Drawing.Size(83, 16);
			this.labelOrderDetails.TabIndex = 1;
			this.labelOrderDetails.Text = "Order Details";
			// 
			// labelOrder
			// 
			this.labelOrder.AutoSize = true;
			this.labelOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOrder.Location = new System.Drawing.Point(18, 48);
			this.labelOrder.Name = "labelOrder";
			this.labelOrder.Size = new System.Drawing.Size(58, 19);
			this.labelOrder.TabIndex = 0;
			this.labelOrder.Text = "Order:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonSaveOrder);
			this.panel1.Controls.Add(this.buttonNew);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.labelCust);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(661, 83);
			this.panel1.TabIndex = 4;
			// 
			// buttonSaveOrder
			// 
			this.buttonSaveOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSaveOrder.Location = new System.Drawing.Point(116, 45);
			this.buttonSaveOrder.Name = "buttonSaveOrder";
			this.buttonSaveOrder.Size = new System.Drawing.Size(98, 23);
			this.buttonSaveOrder.TabIndex = 2;
			this.buttonSaveOrder.Text = "Save Order";
			this.buttonSaveOrder.UseVisualStyleBackColor = true;
			// 
			// buttonNew
			// 
			this.buttonNew.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNew.Location = new System.Drawing.Point(12, 45);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(98, 23);
			this.buttonNew.TabIndex = 2;
			this.buttonNew.Text = "New Order";
			this.buttonNew.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(119, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(148, 22);
			this.textBox1.TabIndex = 1;
			// 
			// labelCust
			// 
			this.labelCust.AutoSize = true;
			this.labelCust.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCust.Location = new System.Drawing.Point(12, 15);
			this.labelCust.Name = "labelCust";
			this.labelCust.Size = new System.Drawing.Size(101, 16);
			this.labelCust.TabIndex = 0;
			this.labelCust.Text = "Customer Name";
			// 
			// panelForm
			// 
			this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelForm.Location = new System.Drawing.Point(0, 107);
			this.panelForm.Name = "panelForm";
			this.panelForm.Size = new System.Drawing.Size(661, 454);
			this.panelForm.TabIndex = 5;
			// 
			// CashierForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.panelForm);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelOrderDetails);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "CashierForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CashierForm";
			this.Load += new System.EventHandler(this.CashierForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelOrderDetails.ResumeLayout(false);
			this.panelOrderDetails.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCashierName;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveOrderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem appetizerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mainCourseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dessertToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem beverageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem specialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.Panel panelOrderDetails;
		private System.Windows.Forms.Label labelOrderDetails;
		private System.Windows.Forms.Label labelOrder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelCust;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonSaveOrder;
		private System.Windows.Forms.Panel panelForm;
		private System.Windows.Forms.Label labelCustName;
	}
}