/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 1/3/2022
 * Time: 7:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet17_Forms
{
	partial class Recapitulatif
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnPrecedent;
		private System.Windows.Forms.Button btnQuit;
		public System.Windows.Forms.TextBox matricule;
		public System.Windows.Forms.TextBox nom;
		public System.Windows.Forms.TextBox prenom;
		public System.Windows.Forms.TextBox naissance;
		public System.Windows.Forms.TextBox nationalite;
		private System.Windows.Forms.Button btnHelp;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnPrecedent = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.matricule = new System.Windows.Forms.TextBox();
			this.nom = new System.Windows.Forms.TextBox();
			this.prenom = new System.Windows.Forms.TextBox();
			this.naissance = new System.Windows.Forms.TextBox();
			this.nationalite = new System.Windows.Forms.TextBox();
			this.btnHelp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(162, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Recapitulatif";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(13, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Matricule";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label3.Location = new System.Drawing.Point(13, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nom";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label4.Location = new System.Drawing.Point(12, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Prenom";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label5.Location = new System.Drawing.Point(13, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Naissance";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label6.Location = new System.Drawing.Point(13, 221);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Nationalité";
			// 
			// btnPrecedent
			// 
			this.btnPrecedent.Location = new System.Drawing.Point(13, 279);
			this.btnPrecedent.Name = "btnPrecedent";
			this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
			this.btnPrecedent.TabIndex = 6;
			this.btnPrecedent.Text = "Precedent";
			this.btnPrecedent.UseVisualStyleBackColor = true;
			this.btnPrecedent.Click += new System.EventHandler(this.BtnPrecedentClick);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(162, 320);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(75, 23);
			this.btnQuit.TabIndex = 7;
			this.btnQuit.Text = "Quitter";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
			// 
			// matricule
			// 
			this.matricule.Location = new System.Drawing.Point(275, 69);
			this.matricule.Name = "matricule";
			this.matricule.Size = new System.Drawing.Size(126, 20);
			this.matricule.TabIndex = 8;
			this.matricule.TextChanged += new System.EventHandler(this.MatriculeTextChanged);
			// 
			// nom
			// 
			this.nom.Location = new System.Drawing.Point(275, 114);
			this.nom.Name = "nom";
			this.nom.Size = new System.Drawing.Size(125, 20);
			this.nom.TabIndex = 9;
			// 
			// prenom
			// 
			this.prenom.Location = new System.Drawing.Point(275, 150);
			this.prenom.Name = "prenom";
			this.prenom.Size = new System.Drawing.Size(125, 20);
			this.prenom.TabIndex = 10;
			// 
			// naissance
			// 
			this.naissance.Location = new System.Drawing.Point(275, 181);
			this.naissance.Name = "naissance";
			this.naissance.Size = new System.Drawing.Size(126, 20);
			this.naissance.TabIndex = 11;
			// 
			// nationalite
			// 
			this.nationalite.Location = new System.Drawing.Point(275, 223);
			this.nationalite.Name = "nationalite";
			this.nationalite.Size = new System.Drawing.Size(126, 20);
			this.nationalite.TabIndex = 12;
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(311, 279);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(90, 23);
			this.btnHelp.TabIndex = 13;
			this.btnHelp.Text = "Help";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.BtnHelpClick);
			// 
			// Recapitulatif
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lime;
			this.ClientSize = new System.Drawing.Size(413, 355);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.nationalite);
			this.Controls.Add(this.naissance);
			this.Controls.Add(this.prenom);
			this.Controls.Add(this.nom);
			this.Controls.Add(this.matricule);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnPrecedent);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Recapitulatif";
			this.Text = "Recapitulatif";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
