/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/28/2021
 * Time: 6:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Evaluation1
{
	partial class F2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button b;
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
			this.b = new System.Windows.Forms.Button();
			this.btnMF = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// b
			// 
			this.b.Location = new System.Drawing.Point(89, 29);
			this.b.Name = "b";
			this.b.Size = new System.Drawing.Size(106, 44);
			this.b.TabIndex = 0;
			this.b.Text = "F2";
			this.b.UseVisualStyleBackColor = true;
			this.b.Click += new System.EventHandler(this.BClick);
			// 
			// btnMF
			// 
			this.btnMF.Location = new System.Drawing.Point(89, 95);
			this.btnMF.Name = "btnMF";
			this.btnMF.Size = new System.Drawing.Size(106, 42);
			this.btnMF.TabIndex = 1;
			this.btnMF.Text = "retour MainForm";
			this.btnMF.UseVisualStyleBackColor = true;
			this.btnMF.Click += new System.EventHandler(this.BtnMFClick);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(89, 173);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(106, 40);
			this.btnQuit.TabIndex = 2;
			this.btnQuit.Text = "Quitter";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
			// 
			// F2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnMF);
			this.Controls.Add(this.b);
			this.Name = "F2";
			this.Text = "F2";
			this.ResumeLayout(false);

		}
	}
}
