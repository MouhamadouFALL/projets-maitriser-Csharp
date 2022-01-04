/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 1/3/2022
 * Time: 7:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet17_Forms
{
	partial class MainForm
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
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.Button btnAnnuler;
		private System.Windows.Forms.Button btnQuit;
		public System.Windows.Forms.TextBox matricule;
		public System.Windows.Forms.TextBox nom;
		public System.Windows.Forms.TextBox prenom;
		public System.Windows.Forms.TextBox naissance;
		public System.Windows.Forms.ComboBox nationalite;
		
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
			this.btnValider = new System.Windows.Forms.Button();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.matricule = new System.Windows.Forms.TextBox();
			this.nom = new System.Windows.Forms.TextBox();
			this.prenom = new System.Windows.Forms.TextBox();
			this.naissance = new System.Windows.Forms.TextBox();
			this.nationalite = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(144, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "FICHE IDENTIFICATION";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(27, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Matricule";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(27, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nom";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label4.Location = new System.Drawing.Point(27, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Prenom";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label5.Location = new System.Drawing.Point(27, 188);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Date Naissance";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label6.Location = new System.Drawing.Point(27, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Nationalité";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// btnValider
			// 
			this.btnValider.Location = new System.Drawing.Point(27, 288);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(75, 23);
			this.btnValider.TabIndex = 6;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = true;
			this.btnValider.Click += new System.EventHandler(this.BtnValiderClick);
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.Location = new System.Drawing.Point(331, 288);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
			this.btnAnnuler.TabIndex = 7;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnulerClick);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(180, 316);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(75, 23);
			this.btnQuit.TabIndex = 8;
			this.btnQuit.Text = "Quitter";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
			// 
			// matricule
			// 
			this.matricule.Location = new System.Drawing.Point(310, 56);
			this.matricule.Name = "matricule";
			this.matricule.Size = new System.Drawing.Size(121, 20);
			this.matricule.TabIndex = 9;
			// 
			// nom
			// 
			this.nom.Location = new System.Drawing.Point(310, 104);
			this.nom.Name = "nom";
			this.nom.Size = new System.Drawing.Size(121, 20);
			this.nom.TabIndex = 10;
			// 
			// prenom
			// 
			this.prenom.Location = new System.Drawing.Point(310, 148);
			this.prenom.Name = "prenom";
			this.prenom.Size = new System.Drawing.Size(121, 20);
			this.prenom.TabIndex = 11;
			// 
			// naissance
			// 
			this.naissance.Location = new System.Drawing.Point(310, 188);
			this.naissance.Name = "naissance";
			this.naissance.Size = new System.Drawing.Size(121, 20);
			this.naissance.TabIndex = 12;
			// 
			// nationalite
			// 
			this.nationalite.FormattingEnabled = true;
			this.nationalite.Items.AddRange(new object[] {
			"SENEGAL",
			"MAURITQNIE",
			"MALI",
			"GAMBIE"});
			this.nationalite.Location = new System.Drawing.Point(310, 226);
			this.nationalite.Name = "nationalite";
			this.nationalite.Size = new System.Drawing.Size(121, 21);
			this.nationalite.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(450, 351);
			this.Controls.Add(this.nationalite);
			this.Controls.Add(this.naissance);
			this.Controls.Add(this.prenom);
			this.Controls.Add(this.nom);
			this.Controls.Add(this.matricule);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnAnnuler);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "projet17-Forms";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
