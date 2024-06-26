﻿namespace RestaurantOrderingSystem
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonRegister = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "RESTAURANT";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(17, 20);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(325, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "\"Savor the Taste of Malaysia\"\n";
			// 
			// buttonLogin
			// 
			this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonLogin.Location = new System.Drawing.Point(318, 384);
			this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(117, 57);
			this.buttonLogin.TabIndex = 2;
			this.buttonLogin.Text = "LOGIN";
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// buttonRegister
			// 
			this.buttonRegister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRegister.Location = new System.Drawing.Point(182, 384);
			this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(117, 57);
			this.buttonRegister.TabIndex = 3;
			this.buttonRegister.Text = "REGISTER";
			this.buttonRegister.UseVisualStyleBackColor = true;
			this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Maroon;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(299, 46);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(214, 44);
			this.label4.TabIndex = 5;
			this.label4.Text = "MALAYSIA";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.label3.Location = new System.Drawing.Point(184, 92);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(314, 26);
			this.label3.TabIndex = 6;
			this.label3.Text = "Restaurant Ordering System";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(41, 224);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(535, 139);
			this.panel1.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::RestaurantOrderingSystem.Properties.Resources.Restaurant_Logo;
			this.pictureBox1.Location = new System.Drawing.Point(214, 39);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(190, 181);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(616, 477);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonRegister);
			this.Controls.Add(this.buttonLogin);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

