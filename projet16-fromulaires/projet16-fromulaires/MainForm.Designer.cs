/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/22/2021
 * Time: 7:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projet16_fromulaires
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnJaune;
		private System.Windows.Forms.Button btnBleu;
		private System.Windows.Forms.Button btnRouge;
		private System.Windows.Forms.Button btnVert;
		private System.Windows.Forms.Button btnQuitter;
		
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
			this.btnJaune = new System.Windows.Forms.Button();
			this.btnBleu = new System.Windows.Forms.Button();
			this.btnRouge = new System.Windows.Forms.Button();
			this.btnVert = new System.Windows.Forms.Button();
			this.btnQuitter = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnJaune
			// 
			this.btnJaune.BackColor = System.Drawing.Color.Yellow;
			this.btnJaune.Location = new System.Drawing.Point(85, 43);
			this.btnJaune.Name = "btnJaune";
			this.btnJaune.Size = new System.Drawing.Size(160, 59);
			this.btnJaune.TabIndex = 0;
			this.btnJaune.Text = "Jaune";
			this.btnJaune.UseVisualStyleBackColor = false;
			this.btnJaune.Click += new System.EventHandler(this.BtnJauneClick);
			// 
			// btnBleu
			// 
			this.btnBleu.BackColor = System.Drawing.Color.Blue;
			this.btnBleu.Location = new System.Drawing.Point(307, 43);
			this.btnBleu.Name = "btnBleu";
			this.btnBleu.Size = new System.Drawing.Size(160, 59);
			this.btnBleu.TabIndex = 1;
			this.btnBleu.Text = "Bleu";
			this.btnBleu.UseVisualStyleBackColor = false;
			this.btnBleu.Click += new System.EventHandler(this.BtnBleuClick);
			// 
			// btnRouge
			// 
			this.btnRouge.BackColor = System.Drawing.Color.Red;
			this.btnRouge.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnRouge.Location = new System.Drawing.Point(85, 175);
			this.btnRouge.Name = "btnRouge";
			this.btnRouge.Size = new System.Drawing.Size(160, 59);
			this.btnRouge.TabIndex = 2;
			this.btnRouge.Text = "Rouge";
			this.btnRouge.UseVisualStyleBackColor = false;
			this.btnRouge.Click += new System.EventHandler(this.BtnRougeClick);
			// 
			// btnVert
			// 
			this.btnVert.BackColor = System.Drawing.Color.Lime;
			this.btnVert.Location = new System.Drawing.Point(307, 175);
			this.btnVert.Name = "btnVert";
			this.btnVert.Size = new System.Drawing.Size(160, 59);
			this.btnVert.TabIndex = 3;
			this.btnVert.Text = "Vert";
			this.btnVert.UseVisualStyleBackColor = false;
			this.btnVert.Click += new System.EventHandler(this.BtnVertClick);
			// 
			// btnQuitter
			// 
			this.btnQuitter.BackColor = System.Drawing.Color.White;
			this.btnQuitter.Location = new System.Drawing.Point(193, 286);
			this.btnQuitter.Name = "btnQuitter";
			this.btnQuitter.Size = new System.Drawing.Size(160, 59);
			this.btnQuitter.TabIndex = 4;
			this.btnQuitter.Text = "Quitter";
			this.btnQuitter.UseVisualStyleBackColor = false;
			this.btnQuitter.Click += new System.EventHandler(this.Button5Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 372);
			this.Controls.Add(this.btnQuitter);
			this.Controls.Add(this.btnVert);
			this.Controls.Add(this.btnRouge);
			this.Controls.Add(this.btnBleu);
			this.Controls.Add(this.btnJaune);
			this.Name = "MainForm";
			this.Text = "projet16-fromulaires";
			this.ResumeLayout(false);

		}
	}
}
