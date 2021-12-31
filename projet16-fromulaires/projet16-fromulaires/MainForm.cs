/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/22/2021
 * Time: 7:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projet16_fromulaires
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		// Formulaire Jaune
		void BtnJauneClick(object sender, EventArgs e)
		{
			// Afficher FormJaune
			FormJaune fj = new FormJaune();
			fj.Visible = true;
			
			// Fermer MainForm
			this.Hide();
		}
		
		void BtnBleuClick(object sender, EventArgs e)
		{
			FormBleu fb = new FormBleu();
			fb.Visible = true;
			
			this.Hide();
		}
		void BtnRougeClick(object sender, EventArgs e)
		{
			FormRouge fb = new FormRouge();
			fb.Visible = true;
			
			this.Hide();
		}
		void BtnVertClick(object sender, EventArgs e)
		{
			FormVert fb = new FormVert();
			fb.Visible = true;
			
			this.Hide();
		}
	}
}
