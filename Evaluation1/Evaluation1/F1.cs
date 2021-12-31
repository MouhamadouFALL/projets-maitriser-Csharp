/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/28/2021
 * Time: 6:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Evaluation1
{
	/// <summary>
	/// Description of F1.
	/// </summary>
	public partial class F1 : Form
	{
		public F1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
	
		}
		void BtnMFClick(object sender, EventArgs e)
		{
			MainForm mf = new MainForm();
			mf.Visible = true;
			
			this.Hide();
		}
		void BtnQuitClick(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
