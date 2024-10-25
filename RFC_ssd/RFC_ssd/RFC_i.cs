/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 24/10/2024
 * Time: 07:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RFC_ssd
{
	/// <summary>
	/// Description of RFC_i.
	/// </summary>
	public partial class RFC_i : Form
	{
		public RFC_i()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BTNcerrarClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
