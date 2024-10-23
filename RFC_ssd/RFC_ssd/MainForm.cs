/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 22/10/2024
 * Time: 07:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RFC_ssd
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
		string fecha="",nombre="",apellidop="",apellidom="";
		void BTNcalcularClick(object sender, EventArgs e)
		{
			fecha=DT_Calendario.Text;
			nombre=TXTnombre.Text;
			apellidop=TXTapellidop.Text;
			apellidom=TXTapellidoma.Text;
			if(TXTnombre.Text != "" && TXTapellidop.Text != "" && TXTapellidoma.Text != "" && TXTDireccion.Text != "" && TXTtelefono.Text != "")
			{
				string fecha1=fecha.Substring(0,2);
				string fecha2=fecha.Substring(3,2);
				string fecha3=fecha.Substring(8);
				string name=nombre.Substring(0,1);
				string paterno=apellidop.Substring(0,2);
				string materno=apellidom.Substring(0,1);
				string nc=paterno+materno+name;
				LBLrfc.Text=nc.ToUpper()+fecha3+fecha2+fecha1;
			}
			else
			{
				MessageBox.Show("Debes de llenar todos los campos");
			}
		}
	}
}
