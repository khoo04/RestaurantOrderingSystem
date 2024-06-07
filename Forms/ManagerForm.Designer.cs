namespace RestaurantOrderingSystem.Forms
{
	partial class ManagerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.addMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.manageMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelManage = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuToolStripMenuItem1,
            this.manageMenuToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(884, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// addMenuToolStripMenuItem1
			// 
			this.addMenuToolStripMenuItem1.Name = "addMenuToolStripMenuItem1";
			this.addMenuToolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
			this.addMenuToolStripMenuItem1.Text = "Add Menu";
			this.addMenuToolStripMenuItem1.Click += new System.EventHandler(this.addMenuToolStripMenuItem1_Click);
			// 
			// manageMenuToolStripMenuItem
			// 
			this.manageMenuToolStripMenuItem.Name = "manageMenuToolStripMenuItem";
			this.manageMenuToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.manageMenuToolStripMenuItem.Text = "Manage Menu";
			this.manageMenuToolStripMenuItem.Click += new System.EventHandler(this.manageMenuToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.viewToolStripMenuItem.Text = "View Report";
			this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.logOutToolStripMenuItem.Text = "Log Out";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// panelManage
			// 
			this.panelManage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelManage.Location = new System.Drawing.Point(0, 24);
			this.panelManage.Name = "panelManage";
			this.panelManage.Size = new System.Drawing.Size(884, 537);
			this.panelManage.TabIndex = 1;
			// 
			// ManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.panelManage);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ManagerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManagerForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Panel panelManage;
		private System.Windows.Forms.ToolStripMenuItem addMenuToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem manageMenuToolStripMenuItem;
	}
}