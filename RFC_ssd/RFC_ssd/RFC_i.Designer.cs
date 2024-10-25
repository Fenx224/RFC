/*
 * Created by SharpDevelop.
 * User: fenx2
 * Date: 24/10/2024
 * Time: 07:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RFC_ssd
{
	partial class RFC_i
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
			this.LBLnombre = new System.Windows.Forms.Label();
			this.LBLrfc2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LBLnombre
			// 
			this.LBLnombre.Location = new System.Drawing.Point(79, 54);
			this.LBLnombre.Name = "LBLnombre";
			this.LBLnombre.Size = new System.Drawing.Size(173, 23);
			this.LBLnombre.TabIndex = 0;
			this.LBLnombre.Text = "Hola";
			// 
			// LBLrfc2
			// 
			this.LBLrfc2.Location = new System.Drawing.Point(79, 120);
			this.LBLrfc2.Name = "LBLrfc2";
			this.LBLrfc2.Size = new System.Drawing.Size(216, 23);
			this.LBLrfc2.TabIndex = 1;
			this.LBLrfc2.Text = "label1";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(74, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tu RFC es:";
			// 
			// RFC_i
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 321);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LBLrfc2);
			this.Controls.Add(this.LBLnombre);
			this.Name = "RFC_i";
			this.Text = "RFC_i";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label LBLrfc2;
		public System.Windows.Forms.Label LBLnombre;
	}
}
