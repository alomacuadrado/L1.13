namespace L1._13
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
			this.palindromo = new System.Windows.Forms.RadioButton();
			this.mayusculas = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.enviar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// palindromo
			// 
			this.palindromo.AutoSize = true;
			this.palindromo.Location = new System.Drawing.Point(303, 166);
			this.palindromo.Name = "palindromo";
			this.palindromo.Size = new System.Drawing.Size(245, 20);
			this.palindromo.TabIndex = 0;
			this.palindromo.TabStop = true;
			this.palindromo.Text = "Dime si mi nombre es un palíndromo";
			this.palindromo.UseVisualStyleBackColor = true;
			this.palindromo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// mayusculas
			// 
			this.mayusculas.AutoSize = true;
			this.mayusculas.Location = new System.Drawing.Point(303, 206);
			this.mayusculas.Name = "mayusculas";
			this.mayusculas.Size = new System.Drawing.Size(264, 20);
			this.mayusculas.TabIndex = 1;
			this.mayusculas.TabStop = true;
			this.mayusculas.Text = "Devuélveme mi nombre en mayúsculas";
			this.mayusculas.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(69, 186);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(196, 22);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 149);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "PON AQUÍ TU NOMBRE";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(69, 55);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(299, 40);
			this.button1.TabIndex = 4;
			this.button1.Text = "CONECTAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(69, 375);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(299, 40);
			this.button2.TabIndex = 5;
			this.button2.Text = "DESCONECTAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// enviar
			// 
			this.enviar.Location = new System.Drawing.Point(69, 263);
			this.enviar.Name = "enviar";
			this.enviar.Size = new System.Drawing.Size(172, 40);
			this.enviar.TabIndex = 6;
			this.enviar.Text = "ENVIAR";
			this.enviar.UseVisualStyleBackColor = true;
			this.enviar.Click += new System.EventHandler(this.enviar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 500);
			this.Controls.Add(this.enviar);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.mayusculas);
			this.Controls.Add(this.palindromo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton palindromo;
		private System.Windows.Forms.RadioButton mayusculas;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button enviar;
	}
}

