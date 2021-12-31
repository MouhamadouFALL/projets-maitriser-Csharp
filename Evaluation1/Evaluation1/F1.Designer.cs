/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/28/2021
 * Time: 6:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Evaluation1
{
	partial class F1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button bF1;
		private System.Windows.Forms.Button btnMF;
		private System.Windows.Forms.Button btnQuit;
		
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
			this.bF1 = new System.Windows.Forms.Button();
			this.btnMF = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bF1
			// 
			this.bF1.Location = new System.Drawing.Point(94, 13);
			this.bF1.Name = "bF1";
			this.bF1.Size = new System.Drawing.Size(109, 51);
			this.bF1.TabIndex = 0;
			this.bF1.Text = "F1";
			this.bF1.UseVisualStyleBackColor = true;
			this.bF1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnMF
			// 
			this.btnMF.Location = new System.Drawing.Point(94, 82);
			this.btnMF.Name = "btnMF";
			this.btnMF.Size = new System.Drawing.Size(109, 42);
			this.btnMF.TabIndex = 1;
			this.btnMF.Text = "retour MainForm";
			this.btnMF.UseVisualStyleBackColor = true;
			this.btnMF.Click += new System.EventHandler(this.BtnMFClick);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(94, 155);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(109, 45);
			this.btnQuit.TabIndex = 2;
			this.btnQuit.Text = "Quitter";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
			// 
			// F1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnMF);
			this.Controls.Add(this.bF1);
			this.Name = "F1";
			this.Text = "F1";
			this.ResumeLayout(false);

		}
	}
}
