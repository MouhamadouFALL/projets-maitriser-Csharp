/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/22/2021
 * Time: 6:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet15_formulaire1
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
		private System.Windows.Forms.TextBox txtx;
		private System.Windows.Forms.TextBox txty;
		private System.Windows.Forms.Button btnEffacer;
		private System.Windows.Forms.Button btnFermer;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnDivision;
		private System.Windows.Forms.Button btnMoins;
		private System.Windows.Forms.Button btnFois;
		private System.Windows.Forms.TextBox txtr;
		
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
			this.txtx = new System.Windows.Forms.TextBox();
			this.txty = new System.Windows.Forms.TextBox();
			this.btnEffacer = new System.Windows.Forms.Button();
			this.btnFermer = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btnDivision = new System.Windows.Forms.Button();
			this.btnMoins = new System.Windows.Forms.Button();
			this.btnFois = new System.Windows.Forms.Button();
			this.txtr = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(84, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(267, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Operation";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 37);
			this.label2.TabIndex = 1;
			this.label2.Text = "Entrer 1ère valeur";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 40);
			this.label3.TabIndex = 2;
			this.label3.Text = "Entrer 2ème valeur";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Resultat";
			// 
			// txtx
			// 
			this.txtx.Location = new System.Drawing.Point(310, 64);
			this.txtx.Name = "txtx";
			this.txtx.Size = new System.Drawing.Size(86, 20);
			this.txtx.TabIndex = 4;
			this.txtx.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// txty
			// 
			this.txty.Location = new System.Drawing.Point(310, 107);
			this.txty.Name = "txty";
			this.txty.Size = new System.Drawing.Size(86, 20);
			this.txty.TabIndex = 5;
			this.txty.Text = "    ";
			// 
			// btnEffacer
			// 
			this.btnEffacer.Location = new System.Drawing.Point(45, 262);
			this.btnEffacer.Name = "btnEffacer";
			this.btnEffacer.Size = new System.Drawing.Size(127, 44);
			this.btnEffacer.TabIndex = 8;
			this.btnEffacer.Text = "Effacer";
			this.btnEffacer.UseVisualStyleBackColor = true;
			this.btnEffacer.Click += new System.EventHandler(this.BtnEffacerClick);
			// 
			// btnFermer
			// 
			this.btnFermer.Location = new System.Drawing.Point(224, 262);
			this.btnFermer.Name = "btnFermer";
			this.btnFermer.Size = new System.Drawing.Size(127, 44);
			this.btnFermer.TabIndex = 9;
			this.btnFermer.Text = "Fermer";
			this.btnFermer.UseVisualStyleBackColor = true;
			this.btnFermer.Click += new System.EventHandler(this.BtnFermerClick);
			// 
			// btnPlus
			// 
			this.btnPlus.Location = new System.Drawing.Point(10, 161);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(92, 29);
			this.btnPlus.TabIndex = 10;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.BtnPlusClick);
			// 
			// btnDivision
			// 
			this.btnDivision.Location = new System.Drawing.Point(206, 161);
			this.btnDivision.Name = "btnDivision";
			this.btnDivision.Size = new System.Drawing.Size(92, 29);
			this.btnDivision.TabIndex = 11;
			this.btnDivision.Text = "/";
			this.btnDivision.UseVisualStyleBackColor = true;
			this.btnDivision.Click += new System.EventHandler(this.BtnDivisionClick);
			// 
			// btnMoins
			// 
			this.btnMoins.Location = new System.Drawing.Point(108, 161);
			this.btnMoins.Name = "btnMoins";
			this.btnMoins.Size = new System.Drawing.Size(92, 29);
			this.btnMoins.TabIndex = 12;
			this.btnMoins.Text = "-";
			this.btnMoins.UseVisualStyleBackColor = true;
			this.btnMoins.Click += new System.EventHandler(this.BtnMoinsClick);
			// 
			// btnFois
			// 
			this.btnFois.Location = new System.Drawing.Point(304, 161);
			this.btnFois.Name = "btnFois";
			this.btnFois.Size = new System.Drawing.Size(92, 29);
			this.btnFois.TabIndex = 13;
			this.btnFois.Text = "*";
			this.btnFois.UseVisualStyleBackColor = true;
			this.btnFois.Click += new System.EventHandler(this.BtnFoisClick);
			// 
			// txtr
			// 
			this.txtr.Location = new System.Drawing.Point(304, 220);
			this.txtr.Name = "txtr";
			this.txtr.Size = new System.Drawing.Size(92, 20);
			this.txtr.TabIndex = 14;
			this.txtr.Text = "    ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(430, 330);
			this.Controls.Add(this.txtr);
			this.Controls.Add(this.btnFois);
			this.Controls.Add(this.btnMoins);
			this.Controls.Add(this.btnDivision);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.btnFermer);
			this.Controls.Add(this.btnEffacer);
			this.Controls.Add(this.txty);
			this.Controls.Add(this.txtx);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "projet15-formulaire1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
