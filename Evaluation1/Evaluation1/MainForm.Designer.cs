/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/28/2021
 * Time: 5:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Evaluation1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label auth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox login;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.Button btnAnnuler;
		private System.Windows.Forms.Button btnF1;
		private System.Windows.Forms.Button btnF2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.auth = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.login = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.btnValider = new System.Windows.Forms.Button();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.btnF1 = new System.Windows.Forms.Button();
			this.btnF2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// auth
			// 
			this.auth.BackColor = System.Drawing.Color.Turquoise;
			this.auth.Location = new System.Drawing.Point(114, 2);
			this.auth.Name = "auth";
			this.auth.Size = new System.Drawing.Size(166, 35);
			this.auth.TabIndex = 0;
			this.auth.Text = "Authentification";
			this.auth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.auth.Click += new System.EventHandler(this.Label1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(41, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(29, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mot de passe";
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(273, 55);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(100, 20);
			this.login.TabIndex = 3;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(273, 91);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(100, 20);
			this.password.TabIndex = 4;
			// 
			// btnValider
			// 
			this.btnValider.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnValider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnValider.Location = new System.Drawing.Point(66, 205);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(75, 23);
			this.btnValider.TabIndex = 5;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = false;
			this.btnValider.Click += new System.EventHandler(this.BtnValiderClick);
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAnnuler.Location = new System.Drawing.Point(298, 205);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
			this.btnAnnuler.TabIndex = 6;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = false;
			this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnulerClick);
			// 
			// btnF1
			// 
			this.btnF1.BackColor = System.Drawing.SystemColors.Control;
			this.btnF1.Location = new System.Drawing.Point(66, 271);
			this.btnF1.Name = "btnF1";
			this.btnF1.Size = new System.Drawing.Size(75, 23);
			this.btnF1.TabIndex = 7;
			this.btnF1.Text = "F1";
			this.btnF1.UseVisualStyleBackColor = false;
			this.btnF1.Click += new System.EventHandler(this.BtnF1Click);
			// 
			// btnF2
			// 
			this.btnF2.Location = new System.Drawing.Point(298, 271);
			this.btnF2.Name = "btnF2";
			this.btnF2.Size = new System.Drawing.Size(75, 23);
			this.btnF2.TabIndex = 8;
			this.btnF2.Text = "F2";
			this.btnF2.UseVisualStyleBackColor = true;
			this.btnF2.Click += new System.EventHandler(this.BtnF2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(385, 351);
			this.Controls.Add(this.btnF2);
			this.Controls.Add(this.btnF1);
			this.Controls.Add(this.btnAnnuler);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.password);
			this.Controls.Add(this.login);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.auth);
			this.Name = "MainForm";
			this.Text = "Evaluation1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
