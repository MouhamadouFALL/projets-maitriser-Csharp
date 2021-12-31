/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/22/2021
 * Time: 7:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projet16_fromulaires
{
	/// <summary>
	/// Description of FormJaune.
	/// </summary>
	public partial class FormJaune : Form
	{
		public FormJaune()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnMainClick(object sender, EventArgs e)
		{
			MainForm mf = new MainForm();
			mf.Visible = true;
			
			this.Hide();
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
