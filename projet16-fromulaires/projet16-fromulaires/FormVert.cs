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
	/// Description of FormVert.
	/// </summary>
	public partial class FormVert : Form
	{
		public FormVert()
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
			MainForm mf = new MainForm();
			mf.Visible = true;
			
			this.Hide();
		}
	}
}
