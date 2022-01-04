/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 1/3/2022
 * Time: 7:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projet17_Forms
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
		void Label6Click(object sender, EventArgs e)
		{
	
		}
		void BtnValiderClick(object sender, EventArgs e)
		{
			Recapitulatif recap = new Recapitulatif();
			
			recap.Visible = true;
			
			recap.matricule.Text = matricule.Text;
			recap.nom.Text = nom.Text;
			recap.prenom.Text = prenom.Text;
			recap.naissance.Text = naissance.Text;
			recap.nationalite.Text = nationalite.Text;
			
			this.Hide();
		}
		void BtnQuitClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		void BtnAnnulerClick(object sender, EventArgs e)
		{
			matricule.Text = null;
			nom.Text = null;
			prenom.Text = null;
			naissance.Text = null;
			nationalite.Text = null;
		}
	}
}
