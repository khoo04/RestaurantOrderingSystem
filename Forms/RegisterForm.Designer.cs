namespace RestaurantOrderingSystem.Forms
{
	partial class RegisterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxFullName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBoxRole = new System.Windows.Forms.ComboBox();
			this.labelRole = new System.Windows.Forms.Label();
			this.labelConfirmPassword = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.buttonRegister = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Full Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Username";
			// 
			// textBoxFullName
			// 
			this.textBoxFullName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxFullName.Location = new System.Drawing.Point(169, 11);
			this.textBoxFullName.Name = "textBoxFullName";
			this.textBoxFullName.Size = new System.Drawing.Size(164, 26);
			this.textBoxFullName.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBoxRole);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.labelRole);
			this.panel1.Controls.Add(this.labelConfirmPassword);
			this.panel1.Controls.Add(this.labelPassword);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBoxConfirmPassword);
			this.panel1.Controls.Add(this.textBoxPassword);
			this.panel1.Controls.Add(this.textBoxUsername);
			this.panel1.Controls.Add(this.textBoxFullName);
			this.panel1.Location = new System.Drawing.Point(65, 207);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(347, 214);
			this.panel1.TabIndex = 2;
			// 
			// comboBoxRole
			// 
			this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxRole.FormattingEnabled = true;
			this.comboBoxRole.Items.AddRange(new object[] {
            "Cashier",
            "Manager"});
			this.comboBoxRole.Location = new System.Drawing.Point(169, 165);
			this.comboBoxRole.Name = "comboBoxRole";
			this.comboBoxRole.Size = new System.Drawing.Size(164, 26);
			this.comboBoxRole.TabIndex = 4;
			// 
			// labelRole
			// 
			this.labelRole.AutoSize = true;
			this.labelRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRole.Location = new System.Drawing.Point(16, 169);
			this.labelRole.Name = "labelRole";
			this.labelRole.Size = new System.Drawing.Size(77, 18);
			this.labelRole.TabIndex = 0;
			this.labelRole.Text = "User Role";
			// 
			// labelConfirmPassword
			// 
			this.labelConfirmPassword.AutoSize = true;
			this.labelConfirmPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConfirmPassword.Location = new System.Drawing.Point(13, 129);
			this.labelConfirmPassword.Name = "labelConfirmPassword";
			this.labelConfirmPassword.Size = new System.Drawing.Size(137, 18);
			this.labelConfirmPassword.TabIndex = 0;
			this.labelConfirmPassword.Text = "Confirm Password";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPassword.Location = new System.Drawing.Point(13, 91);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(78, 18);
			this.labelPassword.TabIndex = 0;
			this.labelPassword.Text = "Password";
			// 
			// textBoxConfirmPassword
			// 
			this.textBoxConfirmPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxConfirmPassword.Location = new System.Drawing.Point(169, 125);
			this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
			this.textBoxConfirmPassword.Size = new System.Drawing.Size(164, 26);
			this.textBoxConfirmPassword.TabIndex = 3;
			this.textBoxConfirmPassword.UseSystemPasswordChar = true;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword.Location = new System.Drawing.Point(169, 87);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(164, 26);
			this.textBoxPassword.TabIndex = 2;
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUsername.Location = new System.Drawing.Point(169, 49);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(164, 26);
			this.textBoxUsername.TabIndex = 1;
			// 
			// buttonRegister
			// 
			this.buttonRegister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRegister.Location = new System.Drawing.Point(192, 444);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(93, 31);
			this.buttonRegister.TabIndex = 2;
			this.buttonRegister.Text = "Register";
			this.buttonRegister.UseVisualStyleBackColor = true;
			this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = global::RestaurantOrderingSystem.Properties.Resources.Restaurant_Logo;
			this.pictureBox1.Location = new System.Drawing.Point(145, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(186, 179);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// RegisterForm
			// 
			this.AcceptButton = this.buttonRegister;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 508);
			this.Controls.Add(this.buttonRegister);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Malaysian Restaurant Ordering System | Register";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxFullName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.Label labelConfirmPassword;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxConfirmPassword;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonRegister;
		private System.Windows.Forms.ComboBox comboBoxRole;
		private System.Windows.Forms.Label labelRole;
	}
}