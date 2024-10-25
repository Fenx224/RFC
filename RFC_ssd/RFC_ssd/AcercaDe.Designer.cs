/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 24/10/2024
 * Time: 10:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RFC_ssd
{
	partial class AcercaDe
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.BTNcerrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 380);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Version 4.0.0";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Creado por:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(118, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(164, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "3ro de Programacion";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkRed;
			this.label4.Location = new System.Drawing.Point(135, 222);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 30);
			this.label4.TabIndex = 3;
			this.label4.Text = "CBTis 217";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(124, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(155, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Metodologias agiles";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(86, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(253, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Calculadora de RFC";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(168, 279);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 29);
			this.label7.TabIndex = 6;
			this.label7.Text = "22/10/24";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(106, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(259, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "Jose de Jesus Zavala Garcia";
			// 
			// BTNcerrar
			// 
			this.BTNcerrar.Location = new System.Drawing.Point(330, 366);
			this.BTNcerrar.Name = "BTNcerrar";
			this.BTNcerrar.Size = new System.Drawing.Size(75, 23);
			this.BTNcerrar.TabIndex = 8;
			this.BTNcerrar.Text = "Cerrar";
			this.BTNcerrar.UseVisualStyleBackColor = true;
			this.BTNcerrar.Click += new System.EventHandler(this.BTNcerrarClick);
			// 
			// AcercaDe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 401);
			this.Controls.Add(this.BTNcerrar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AcercaDe";
			this.Text = "AcercaDe";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button BTNcerrar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
