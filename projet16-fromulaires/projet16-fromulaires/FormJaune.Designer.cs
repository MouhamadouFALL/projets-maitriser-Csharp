/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/22/2021
 * Time: 7:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet16_fromulaires
{
	partial class FormJaune
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnMain;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label id;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.TextBox txtPrenom;
		private System.Windows.Forms.TextBox txtClasse;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button btnAnnuler;
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.TextBox txtMoyenne;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtRappreci;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnEffacer;
		private System.Windows.Forms.TextBox txtRmoyenne;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtRnom;
		private System.Windows.Forms.TextBox txtRprenom;
		private System.Windows.Forms.TextBox txtRclasse;
		private System.Windows.Forms.TextBox txtRid;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label Rid;
		private System.Windows.Forms.Label Saisie;
		private System.Windows.Forms.Label label1;
		
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
			this.btnMain = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.btnValider = new System.Windows.Forms.Button();
			this.txtMoyenne = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.txtPrenom = new System.Windows.Forms.TextBox();
			this.txtClasse = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtRappreci = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnEffacer = new System.Windows.Forms.Button();
			this.txtRmoyenne = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtRnom = new System.Windows.Forms.TextBox();
			this.txtRprenom = new System.Windows.Forms.TextBox();
			this.txtRclasse = new System.Windows.Forms.TextBox();
			this.txtRid = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Rid = new System.Windows.Forms.Label();
			this.Saisie = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnMain
			// 
			this.btnMain.Location = new System.Drawing.Point(48, 316);
			this.btnMain.Name = "btnMain";
			this.btnMain.Size = new System.Drawing.Size(147, 42);
			this.btnMain.TabIndex = 0;
			this.btnMain.Text = "Retour au Menu Principal";
			this.btnMain.UseVisualStyleBackColor = true;
			this.btnMain.Click += new System.EventHandler(this.BtnMainClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.Saisie);
			this.panel1.Controls.Add(this.btnAnnuler);
			this.panel1.Controls.Add(this.btnValider);
			this.panel1.Controls.Add(this.btnMain);
			this.panel1.Controls.Add(this.txtMoyenne);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtNom);
			this.panel1.Controls.Add(this.txtPrenom);
			this.panel1.Controls.Add(this.txtClasse);
			this.panel1.Controls.Add(this.txtID);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.id);
			this.panel1.Location = new System.Drawing.Point(1, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(278, 373);
			this.panel1.TabIndex = 1;
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.Location = new System.Drawing.Point(157, 229);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(103, 29);
			this.btnAnnuler.TabIndex = 11;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			// 
			// btnValider
			// 
			this.btnValider.Location = new System.Drawing.Point(21, 229);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(103, 29);
			this.btnValider.TabIndex = 10;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = true;
			// 
			// txtMoyenne
			// 
			this.txtMoyenne.Location = new System.Drawing.Point(172, 165);
			this.txtMoyenne.Name = "txtMoyenne";
			this.txtMoyenne.Size = new System.Drawing.Size(88, 20);
			this.txtMoyenne.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 24);
			this.label5.TabIndex = 8;
			this.label5.Text = "Moyenne";
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(172, 61);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(88, 20);
			this.txtNom.TabIndex = 7;
			// 
			// txtPrenom
			// 
			this.txtPrenom.Location = new System.Drawing.Point(172, 92);
			this.txtPrenom.Name = "txtPrenom";
			this.txtPrenom.Size = new System.Drawing.Size(88, 20);
			this.txtPrenom.TabIndex = 6;
			// 
			// txtClasse
			// 
			this.txtClasse.Location = new System.Drawing.Point(172, 130);
			this.txtClasse.Name = "txtClasse";
			this.txtClasse.Size = new System.Drawing.Size(88, 20);
			this.txtClasse.TabIndex = 5;
			this.txtClasse.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(172, 17);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(88, 20);
			this.txtID.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(21, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "Classe";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nom";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Prenom";
			// 
			// id
			// 
			this.id.Location = new System.Drawing.Point(21, 19);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(49, 24);
			this.id.TabIndex = 0;
			this.id.Text = "ID";
			this.id.Click += new System.EventHandler(this.Label1Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtRappreci);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.btnEffacer);
			this.panel2.Controls.Add(this.txtRmoyenne);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.txtRnom);
			this.panel2.Controls.Add(this.txtRprenom);
			this.panel2.Controls.Add(this.txtRclasse);
			this.panel2.Controls.Add(this.txtRid);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.Rid);
			this.panel2.Enabled = false;
			this.panel2.Location = new System.Drawing.Point(285, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(278, 373);
			this.panel2.TabIndex = 12;
			// 
			// txtRappreci
			// 
			this.txtRappreci.Location = new System.Drawing.Point(172, 199);
			this.txtRappreci.Name = "txtRappreci";
			this.txtRappreci.Size = new System.Drawing.Size(88, 20);
			this.txtRappreci.TabIndex = 12;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(21, 202);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 24);
			this.label11.TabIndex = 11;
			this.label11.Text = "Appréciation";
			// 
			// btnEffacer
			// 
			this.btnEffacer.Location = new System.Drawing.Point(71, 237);
			this.btnEffacer.Name = "btnEffacer";
			this.btnEffacer.Size = new System.Drawing.Size(140, 43);
			this.btnEffacer.TabIndex = 10;
			this.btnEffacer.Text = "Effacer";
			this.btnEffacer.UseVisualStyleBackColor = true;
			// 
			// txtRmoyenne
			// 
			this.txtRmoyenne.Location = new System.Drawing.Point(172, 165);
			this.txtRmoyenne.Name = "txtRmoyenne";
			this.txtRmoyenne.Size = new System.Drawing.Size(88, 20);
			this.txtRmoyenne.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(21, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 24);
			this.label6.TabIndex = 8;
			this.label6.Text = "Moyenne";
			// 
			// txtRnom
			// 
			this.txtRnom.Location = new System.Drawing.Point(172, 61);
			this.txtRnom.Name = "txtRnom";
			this.txtRnom.Size = new System.Drawing.Size(88, 20);
			this.txtRnom.TabIndex = 7;
			// 
			// txtRprenom
			// 
			this.txtRprenom.Location = new System.Drawing.Point(172, 92);
			this.txtRprenom.Name = "txtRprenom";
			this.txtRprenom.Size = new System.Drawing.Size(88, 20);
			this.txtRprenom.TabIndex = 6;
			// 
			// txtRclasse
			// 
			this.txtRclasse.Location = new System.Drawing.Point(172, 130);
			this.txtRclasse.Name = "txtRclasse";
			this.txtRclasse.Size = new System.Drawing.Size(88, 20);
			this.txtRclasse.TabIndex = 5;
			// 
			// txtRid
			// 
			this.txtRid.Location = new System.Drawing.Point(172, 17);
			this.txtRid.Name = "txtRid";
			this.txtRid.Size = new System.Drawing.Size(88, 20);
			this.txtRid.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(21, 133);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 24);
			this.label7.TabIndex = 3;
			this.label7.Text = "Classe";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(21, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 24);
			this.label8.TabIndex = 2;
			this.label8.Text = "Nom";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(21, 95);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 24);
			this.label9.TabIndex = 1;
			this.label9.Text = "Prenom";
			// 
			// Rid
			// 
			this.Rid.Location = new System.Drawing.Point(21, 19);
			this.Rid.Name = "Rid";
			this.Rid.Size = new System.Drawing.Size(49, 24);
			this.Rid.TabIndex = 0;
			this.Rid.Text = "ID";
			// 
			// Saisie
			// 
			this.Saisie.Location = new System.Drawing.Point(48, 2);
			this.Saisie.Name = "Saisie";
			this.Saisie.Size = new System.Drawing.Size(125, 17);
			this.Saisie.TabIndex = 13;
			this.Saisie.Text = "Saisie";
			this.Saisie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Saisie.Click += new System.EventHandler(this.Label1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(41, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 17);
			this.label1.TabIndex = 14;
			this.label1.Text = "Recap";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FormJaune
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(586, 435);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Enabled = false;
			this.Name = "FormJaune";
			this.Text = "FormJaune";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
