using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace L1._13._2
{
	public partial class Form1 : Form
	{
		Socket server;
		public Form1()
		{
			InitializeComponent();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}



		
		private void connectbtn_Click_1(object sender, EventArgs e)
		{
			IPAddress direc = IPAddress.Parse("192.168.56.102");
			IPEndPoint ipep = new IPEndPoint(direc, 9100);
			server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				server.Connect(ipep);
				this.BackColor = Color.Green;
				MessageBox.Show("Conectado");

			}
			catch (SocketException ex)

			{
				MessageBox.Show("No me he podido conectar");
				return;
			}
		}

		private void disconnectbtn_Click_1(object sender, EventArgs e)
		{
			string query = "0/";
			byte[] msg = System.Text.Encoding.ASCII.GetBytes(query);
			server.Send(msg);
			this.BackColor = Color.Gray;
			server.Shutdown(SocketShutdown.Both);
			server.Close();
		}

		private void enviar_Click(object sender, EventArgs e)
		{

			if (F.Checked)
			{
				string x_value = degreesBox.Text;


				string query = "1/" + x_value;
				byte[] msg = System.Text.Encoding.ASCII.GetBytes(query);
				server.Send(msg);
				byte[] msg2 = new byte[80];
				server.Receive(msg2);
				query = Encoding.ASCII.GetString(msg2).Split('\0')[0];
				MessageBox.Show("Tu conversión a grados Fahrenheit:  " + query + "   ºF");
			}
			else if (C.Checked)
			{

				string x_value = degreesBox.Text;


				string query = "2/" + x_value;
				byte[] msg = System.Text.Encoding.ASCII.GetBytes(query);
				server.Send(msg);
				byte[] msg2 = new byte[80];
				server.Receive(msg2);
				query = Encoding.ASCII.GetString(msg2).Split('\0')[0];
				MessageBox.Show("Tu conversión a grados Celsius:  " + query + "   ºC");
			}
			else
			{
				MessageBox.Show("Presione alguna de las dos consultas");
			}
		}
	}
}

