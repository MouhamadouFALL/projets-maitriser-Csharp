/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/28/2021
 * Time: 5:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Evaluation1
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
		void BtnValiderClick(object sender, EventArgs e)
		{
			F1 f1 = new F1();
			f1.Visible = true;
			
			this.Hide();
		}
		void BtnF1Click(object sender, EventArgs e)
		{
			F1 f1 = new F1();
			f1.Visible = true;
			
			this.Hide();
		}
		void BtnF2Click(object sender, EventArgs e)
		{
			F2 f2 = new F2();
			f2.Visible = true;
			
			this.Hide();
		}
		void BtnAnnulerClick(object sender, EventArgs e)
		{
			login.Text = null;
			password.Text = null;
		}
	}
}
