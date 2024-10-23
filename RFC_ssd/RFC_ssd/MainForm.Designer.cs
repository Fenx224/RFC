/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 22/10/2024
 * Time: 07:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RFC_ssd
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.LBLapellido2 = new System.Windows.Forms.Label();
			this.LBLdireccion = new System.Windows.Forms.Label();
			this.LBLtelefono = new System.Windows.Forms.Label();
			this.LBLapellido1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.LBLsemestre = new System.Windows.Forms.Label();
			this.TXTapellidoma = new System.Windows.Forms.TextBox();
			this.TXTDireccion = new System.Windows.Forms.TextBox();
			this.TXTtelefono = new System.Windows.Forms.TextBox();
			this.TXTapellidop = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.TXTnombre = new System.Windows.Forms.TextBox();
			this.LBLnombre = new System.Windows.Forms.Label();
			this.DT_Calendario = new System.Windows.Forms.DateTimePicker();
			this.BTNcalcular = new System.Windows.Forms.Button();
			this.LBLrfc = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LBLapellido2
			// 
			this.LBLapellido2.Location = new System.Drawing.Point(34, 138);
			this.LBLapellido2.Name = "LBLapellido2";
			this.LBLapellido2.Size = new System.Drawing.Size(115, 23);
			this.LBLapellido2.TabIndex = 0;
			this.LBLapellido2.Text = "Apellido Materno";
			// 
			// LBLdireccion
			// 
			this.LBLdireccion.Location = new System.Drawing.Point(34, 179);
			this.LBLdireccion.Name = "LBLdireccion";
			this.LBLdireccion.Size = new System.Drawing.Size(100, 23);
			this.LBLdireccion.TabIndex = 1;
			this.LBLdireccion.Text = "Direccion";
			// 
			// LBLtelefono
			// 
			this.LBLtelefono.Location = new System.Drawing.Point(34, 225);
			this.LBLtelefono.Name = "LBLtelefono";
			this.LBLtelefono.Size = new System.Drawing.Size(100, 23);
			this.LBLtelefono.TabIndex = 2;
			this.LBLtelefono.Text = "Telefono";
			// 
			// LBLapellido1
			// 
			this.LBLapellido1.Location = new System.Drawing.Point(34, 97);
			this.LBLapellido1.Name = "LBLapellido1";
			this.LBLapellido1.Size = new System.Drawing.Size(130, 23);
			this.LBLapellido1.TabIndex = 5;
			this.LBLapellido1.Text = "Apellido Paterno";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(34, 310);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "label5";
			// 
			// LBLsemestre
			// 
			this.LBLsemestre.Location = new System.Drawing.Point(34, 263);
			this.LBLsemestre.Name = "LBLsemestre";
			this.LBLsemestre.Size = new System.Drawing.Size(100, 23);
			this.LBLsemestre.TabIndex = 3;
			this.LBLsemestre.Text = "Semestre";
			// 
			// TXTapellidoma
			// 
			this.TXTapellidoma.Location = new System.Drawing.Point(145, 139);
			this.TXTapellidoma.Name = "TXTapellidoma";
			this.TXTapellidoma.Size = new System.Drawing.Size(136, 22);
			this.TXTapellidoma.TabIndex = 6;
			// 
			// TXTDireccion
			// 
			this.TXTDireccion.Location = new System.Drawing.Point(145, 180);
			this.TXTDireccion.Name = "TXTDireccion";
			this.TXTDireccion.Size = new System.Drawing.Size(136, 22);
			this.TXTDireccion.TabIndex = 7;
			// 
			// TXTtelefono
			// 
			this.TXTtelefono.Location = new System.Drawing.Point(145, 222);
			this.TXTtelefono.Name = "TXTtelefono";
			this.TXTtelefono.Size = new System.Drawing.Size(136, 22);
			this.TXTtelefono.TabIndex = 8;
			// 
			// TXTapellidop
			// 
			this.TXTapellidop.Location = new System.Drawing.Point(145, 94);
			this.TXTapellidop.Name = "TXTapellidop";
			this.TXTapellidop.Size = new System.Drawing.Size(136, 22);
			this.TXTapellidop.TabIndex = 11;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"1er Semestre",
									"2do Semestre",
									"3er Semestre",
									"4to Semestre",
									"5to Semestre",
									"6to Semestre"});
			this.comboBox1.Location = new System.Drawing.Point(145, 260);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(136, 24);
			this.comboBox1.TabIndex = 12;
			this.comboBox1.Text = "Semestre";
			// 
			// TXTnombre
			// 
			this.TXTnombre.Location = new System.Drawing.Point(145, 56);
			this.TXTnombre.Name = "TXTnombre";
			this.TXTnombre.Size = new System.Drawing.Size(136, 22);
			this.TXTnombre.TabIndex = 14;
			// 
			// LBLnombre
			// 
			this.LBLnombre.Location = new System.Drawing.Point(34, 55);
			this.LBLnombre.Name = "LBLnombre";
			this.LBLnombre.Size = new System.Drawing.Size(100, 23);
			this.LBLnombre.TabIndex = 13;
			this.LBLnombre.Text = "Nombre";
			// 
			// DT_Calendario
			// 
			this.DT_Calendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DT_Calendario.Location = new System.Drawing.Point(145, 311);
			this.DT_Calendario.Name = "DT_Calendario";
			this.DT_Calendario.Size = new System.Drawing.Size(200, 22);
			this.DT_Calendario.TabIndex = 17;
			// 
			// BTNcalcular
			// 
			this.BTNcalcular.Location = new System.Drawing.Point(226, 392);
			this.BTNcalcular.Name = "BTNcalcular";
			this.BTNcalcular.Size = new System.Drawing.Size(75, 23);
			this.BTNcalcular.TabIndex = 18;
			this.BTNcalcular.Text = "Calcular";
			this.BTNcalcular.UseVisualStyleBackColor = true;
			this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcularClick);
			// 
			// LBLrfc
			// 
			this.LBLrfc.Location = new System.Drawing.Point(214, 356);
			this.LBLrfc.Name = "LBLrfc";
			this.LBLrfc.Size = new System.Drawing.Size(158, 23);
			this.LBLrfc.TabIndex = 19;
			this.LBLrfc.Text = "    ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(33, 356);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 20;
			this.label1.Text = "Tu RFC es:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 445);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LBLrfc);
			this.Controls.Add(this.BTNcalcular);
			this.Controls.Add(this.DT_Calendario);
			this.Controls.Add(this.TXTnombre);
			this.Controls.Add(this.LBLnombre);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.TXTapellidop);
			this.Controls.Add(this.TXTtelefono);
			this.Controls.Add(this.TXTDireccion);
			this.Controls.Add(this.TXTapellidoma);
			this.Controls.Add(this.LBLapellido1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.LBLsemestre);
			this.Controls.Add(this.LBLtelefono);
			this.Controls.Add(this.LBLdireccion);
			this.Controls.Add(this.LBLapellido2);
			this.Name = "MainForm";
			this.Text = "RFC_ssd";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LBLrfc;
		private System.Windows.Forms.Button BTNcalcular;
		private System.Windows.Forms.DateTimePicker DT_Calendario;
		private System.Windows.Forms.Label LBLnombre;
		private System.Windows.Forms.TextBox TXTnombre;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox TXTapellidop;
		private System.Windows.Forms.TextBox TXTtelefono;
		private System.Windows.Forms.TextBox TXTDireccion;
		private System.Windows.Forms.TextBox TXTapellidoma;
		private System.Windows.Forms.Label LBLsemestre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label LBLapellido1;
		private System.Windows.Forms.Label LBLtelefono;
		private System.Windows.Forms.Label LBLdireccion;
		private System.Windows.Forms.Label LBLapellido2;
	}
}
