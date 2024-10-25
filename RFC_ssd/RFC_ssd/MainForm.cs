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
		
		//Definimos las variables donde almacenaremos lo que el usuario introdujo//
		string fecha="",nombre="",apellidop="",apellidom="";
		void BTNcalcularClick(object sender, EventArgs e)
		{
			//Introducimos lo que el usuario introdujo en las variables//
			fecha=DT_Calendario.Text;
			nombre=TXTnombre.Text;
			apellidop=TXTapellidop.Text;
			apellidom=TXTapellidoma.Text;
			
			//Creamos una condicion para saber si se llenaron todos los campos/
			if(TXTnombre.Text != "" && TXTapellidop.Text != "" && TXTapellidoma.Text != "" && TXTDireccion.Text != "" && TXTtelefono.Text != "")
			{
				//Utilizamos substrings para almacenar los datos que necesitamos//
				string fecha1=fecha.Substring(0,2);
				string fecha2=fecha.Substring(3,2);
				string fecha3=fecha.Substring(8);
				string name=nombre.Substring(0,1);
				string paterno=apellidop.Substring(0,2);
				string materno=apellidom.Substring(0,1);
				string nc=paterno+materno+name;
				string nc2=nombre+" "+apellidop+" "+apellidom;
				//Creamos un objeto apartir del nuevo formulario//
				RFC_i rfc_i = new RFC_i();
				//Introducimos las variables en los labels hechos en el otro formulario//
				rfc_i.LBLnombre.Text="Hola "+nc2;
				rfc_i.LBLrfc2.Text=nc.ToUpper()+fecha1+fecha2+fecha3;
				//Abrimos el nuevo formulario//
				rfc_i.Show();
			}
			
			//Si la condicion no se cumplio mostramos un mensaje indicando que debe llenarlos//
			else
			{
				MessageBox.Show("Debes de llenar todos los campos");
			}
		}
		
		void BTNacercaClick(object sender, EventArgs e)
		{
			AcercaDe acerca = new AcercaDe();
			acerca.Show();
		}
	}
}
