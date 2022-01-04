/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 1/3/2022
 * Time: 8:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet17_Forms
{
	partial class Help
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox nom;
		public System.Windows.Forms.TextBox prenom;
		public System.Windows.Forms.TextBox naissance;
		public System.Windows.Forms.TextBox nationalite;
		private System.Windows.Forms.Button btnPrecedent;
		private System.Windows.Forms.Button btnMenu;
		private System.Windows.Forms.Button btnQuit;
		public System.Windows.Forms.TextBox matricule;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nom = new System.Windows.Forms.TextBox();
			this.prenom = new System.Windows.Forms.TextBox();
			this.naissance = new System.Windows.Forms.TextBox();
			this.nationalite = new System.Windows.Forms.TextBox();
			this.btnPrecedent = new System.Windows.Forms.Button();
			this.btnMenu = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.matricule = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(264, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(119, 115);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(148, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "HELP";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nom";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Prenom";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 236);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Date Naissance";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 270);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Nationalité";
			// 
			// nom
			// 
			this.nom.Location = new System.Drawing.Point(264, 164);
			this.nom.Name = "nom";
			this.nom.Size = new System.Drawing.Size(119, 20);
			this.nom.TabIndex = 6;
			this.nom.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// prenom
			// 
			this.prenom.Location = new System.Drawing.Point(264, 201);
			this.prenom.Name = "prenom";
			this.prenom.Size = new System.Drawing.Size(119, 20);
			this.prenom.TabIndex = 7;
			// 
			// naissance
			// 
			this.naissance.Location = new System.Drawing.Point(264, 236);
			this.naissance.Name = "naissance";
			this.naissance.Size = new System.Drawing.Size(119, 20);
			this.naissance.TabIndex = 8;
			// 
			// nationalite
			// 
			this.nationalite.Location = new System.Drawing.Point(264, 272);
			this.nationalite.Name = "nationalite";
			this.nationalite.Size = new System.Drawing.Size(119, 20);
			this.nationalite.TabIndex = 9;
			// 
			// btnPrecedent
			// 
			this.btnPrecedent.Location = new System.Drawing.Point(27, 323);
			this.btnPrecedent.Name = "btnPrecedent";
			this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
			this.btnPrecedent.TabIndex = 10;
			this.btnPrecedent.Text = "Precedent";
			this.btnPrecedent.UseVisualStyleBackColor = true;
			this.btnPrecedent.Click += new System.EventHandler(this.BtnPrecedentClick);
			// 
			// btnMenu
			// 
			this.btnMenu.Location = new System.Drawing.Point(298, 323);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(85, 23);
			this.btnMenu.TabIndex = 11;
			this.btnMenu.Text = "Menu";
			this.btnMenu.UseVisualStyleBackColor = true;
			this.btnMenu.Click += new System.EventHandler(this.BtnMenuClick);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(160, 323);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(75, 23);
			this.btnQuit.TabIndex = 12;
			this.btnQuit.Text = "Quitter";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
			// 
			// matricule
			// 
			this.matricule.Location = new System.Drawing.Point(148, 164);
			this.matricule.Name = "matricule";
			this.matricule.Size = new System.Drawing.Size(100, 20);
			this.matricule.TabIndex = 13;
			this.matricule.Visible = false;
			// 
			// Help
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 358);
			this.Controls.Add(this.matricule);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnMenu);
			this.Controls.Add(this.btnPrecedent);
			this.Controls.Add(this.nationalite);
			this.Controls.Add(this.naissance);
			this.Controls.Add(this.prenom);
			this.Controls.Add(this.nom);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Help";
			this.Text = "Help";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
