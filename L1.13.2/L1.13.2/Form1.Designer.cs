namespace L1._13._2
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.F = new System.Windows.Forms.RadioButton();
			this.C = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.degreesBox = new System.Windows.Forms.TextBox();
			this.connectbtn = new System.Windows.Forms.Button();
			this.disconnectbtn = new System.Windows.Forms.Button();
			this.enviar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// F
			// 
			this.F.AutoSize = true;
			this.F.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.F.Location = new System.Drawing.Point(367, 159);
			this.F.Name = "F";
			this.F.Size = new System.Drawing.Size(226, 29);
			this.F.TabIndex = 0;
			this.F.TabStop = true;
			this.F.Text = "Convertir a Fahrenheit";
			this.F.UseVisualStyleBackColor = true;
			// 
			// C
			// 
			this.C.AutoSize = true;
			this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C.Location = new System.Drawing.Point(367, 214);
			this.C.Name = "C";
			this.C.Size = new System.Drawing.Size(198, 29);
			this.C.TabIndex = 1;
			this.C.TabStop = true;
			this.C.Text = "Convertir a Celsius";
			this.C.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(407, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Introduce valor en grados Celsius/Fahrenheit:";
			// 
			// degreesBox
			// 
			this.degreesBox.Location = new System.Drawing.Point(32, 186);
			this.degreesBox.Name = "degreesBox";
			this.degreesBox.Size = new System.Drawing.Size(295, 22);
			this.degreesBox.TabIndex = 3;
			// 
			// connectbtn
			// 
			this.connectbtn.Location = new System.Drawing.Point(32, 48);
			this.connectbtn.Name = "connectbtn";
			this.connectbtn.Size = new System.Drawing.Size(293, 35);
			this.connectbtn.TabIndex = 4;
			this.connectbtn.Text = "CONNECT";
			this.connectbtn.UseVisualStyleBackColor = true;
			this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click_1);
			// 
			// disconnectbtn
			// 
			this.disconnectbtn.Location = new System.Drawing.Point(32, 298);
			this.disconnectbtn.Name = "disconnectbtn";
			this.disconnectbtn.Size = new System.Drawing.Size(293, 35);
			this.disconnectbtn.TabIndex = 5;
			this.disconnectbtn.Text = "DISCONNECT";
			this.disconnectbtn.UseVisualStyleBackColor = true;
			this.disconnectbtn.Click += new System.EventHandler(this.disconnectbtn_Click_1);
			// 
			// enviar
			// 
			this.enviar.Location = new System.Drawing.Point(109, 214);
			this.enviar.Name = "enviar";
			this.enviar.Size = new System.Drawing.Size(141, 49);
			this.enviar.TabIndex = 6;
			this.enviar.Text = "ENVIAR";
			this.enviar.UseVisualStyleBackColor = true;
			this.enviar.Click += new System.EventHandler(this.enviar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.enviar);
			this.Controls.Add(this.disconnectbtn);
			this.Controls.Add(this.connectbtn);
			this.Controls.Add(this.degreesBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.C);
			this.Controls.Add(this.F);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton F;
		private System.Windows.Forms.RadioButton C;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox degreesBox;
		private System.Windows.Forms.Button connectbtn;
		private System.Windows.Forms.Button disconnectbtn;
		private System.Windows.Forms.Button enviar;
	}
}

