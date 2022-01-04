/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 1/3/2022
 * Time: 7:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projet17_Forms
{
	/// <summary>
	/// Description of Recapitulatif.
	/// </summary>
	public partial class Recapitulatif : Form
	{
		public Recapitulatif()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnPrecedentClick(object sender, EventArgs e)
		{
			MainForm mf = new MainForm();
			mf.Visible = true;
			
			mf.matricule.Text = matricule.Text;
			mf.nom.Text = nom.Text;
			mf.prenom.Text = prenom.Text;
			mf.naissance.Text = naissance.Text;
			mf.nationalite.Text = nationalite.Text;
			
			this.Hide();
		}
		void MatriculeTextChanged(object sender, EventArgs e)
		{
			
		}
		void BtnQuitClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		void BtnHelpClick(object sender, EventArgs e)
		{
			Help help = new Help();
			
			help.Visible = true;
			
			help.matricule.Text = matricule.Text;
			help.nom.Text = nom.Text;
			help.prenom.Text = prenom.Text;
			help.naissance.Text = naissance.Text;
			help.nationalite.Text = nationalite.Text;
			
			this.Hide();
		}
		
	}
}
