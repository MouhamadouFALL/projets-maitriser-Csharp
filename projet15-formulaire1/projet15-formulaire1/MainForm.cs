/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/22/2021
 * Time: 6:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projet15_formulaire1
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
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void BtnPlusClick(object sender, EventArgs e)
		{
			int a = int.Parse(txtx.Text);
			int b = int.Parse(txty.Text);
			int somme = a + b;
			txtr.Text = somme + "";
		}
		void BtnMoinsClick(object sender, EventArgs e)
		{
			int a = int.Parse(txtx.Text);
			int b = int.Parse(txty.Text);
			int moins = a - b;
			txtr.Text = moins + "";
		}
		void BtnDivisionClick(object sender, EventArgs e)
		{
			int a = int.Parse(txtx.Text);
			int b = int.Parse(txty.Text);
			if (b != 0) {
				int divise = a / b;
				txtr.Text = divise + "";
			}
		}
		void BtnFoisClick(object sender, EventArgs e)
		{
			int a = int.Parse(txtx.Text);
			int b = int.Parse(txty.Text);
			int mul = a * b;
			txtr.Text = mul + "";
		}
		void BtnEffacerClick(object sender, EventArgs e)
		{
			txtx.Text = null;
			txty.Text = null;
			txtr.Text = null;
		}
		void BtnFermerClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
