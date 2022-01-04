/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 1/3/2022
 * Time: 8:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projet17_Forms
{
	/// <summary>
	/// Description of Help.
	/// </summary>
	public partial class Help : Form
	{
		public Help()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void BtnPrecedentClick(object sender, EventArgs e)
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
		void BtnMenuClick(object sender, EventArgs e)
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
	}
}
