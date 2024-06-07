namespace RestaurantOrderingSystem.Forms
{
	partial class PasswordForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.textBoxSuperKey = new System.Windows.Forms.TextBox();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 54);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 18);
			this.label1.TabIndex = 0;
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(18, 27);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(115, 18);
			this.label.TabIndex = 1;
			this.label.Text = "Enter Superkey";
			// 
			// textBoxSuperKey
			// 
			this.textBoxSuperKey.Location = new System.Drawing.Point(21, 54);
			this.textBoxSuperKey.Name = "textBoxSuperKey";
			this.textBoxSuperKey.Size = new System.Drawing.Size(358, 26);
			this.textBoxSuperKey.TabIndex = 2;
			this.textBoxSuperKey.UseSystemPasswordChar = true;
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(294, 103);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(85, 35);
			this.buttonClose.TabIndex = 3;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.Location = new System.Drawing.Point(189, 103);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(99, 35);
			this.buttonSubmit.TabIndex = 3;
			this.buttonSubmit.Text = "Submit";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// PasswordForm
			// 
			this.AcceptButton = this.buttonSubmit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 158);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.textBoxSuperKey);
			this.Controls.Add(this.label);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PasswordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enter the superkey";
			this.Load += new System.EventHandler(this.PasswordForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox textBoxSuperKey;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonSubmit;
	}
}