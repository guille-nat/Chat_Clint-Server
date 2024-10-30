using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class ServidorChatForm : Form
    {
        public ServidorChatForm()
        {
            InitializeComponent();
            // Establece la posición de la ventana del servidor a la derecha de la pantalla
            this.StartPosition = FormStartPosition.Manual;
            // A la derecha
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - 200, 100);
        }

        private Socket? conexion;
        private Thread? lecturaThread;
        private NetworkStream? socketStream;
        private BinaryWriter? escritor;
        private BinaryReader? lector;

        private void ServidorChatForm_load(object sender, EventArgs e)
        {
            
            lecturaThread = new Thread( EjecutarServidor);
            lecturaThread.Start();
        }

        private void ServidorChatform_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private delegate void Displaydelegate(string mensaje);

        private void MostrarMensaje(string mensaje)
        {
            if (mostrarTextBox.InvokeRequired)
            {
                Invoke(new Displaydelegate(MostrarMensaje), new object[] { mensaje });
            }
            else
            {
                mostrarTextBox.Text += mensaje;
            }
        }

        private delegate void DisableInputDelegate(bool value);

        private void DeshabilitarEntrada(bool valor)
        {
            if (entradaTextbox.InvokeRequired)
            {
                Invoke(new DisableInputDelegate(DeshabilitarEntrada), new object[] { valor });
            }
            else
            {
                entradaTextbox.ReadOnly = valor;
            }
        }

        private void entradaTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Entre: entradaTextBox_KeyDown SERVIDOR");
            try
            {
                if (e.KeyCode == Keys.Enter && entradaTextbox.ReadOnly == false)
                {
                    escritor.Write("SERVIDOR>>>" + entradaTextbox.Text);
                    mostrarTextBox.Text += "\r\nSERVIDOR>>>" + entradaTextbox.Text;

                    if (entradaTextbox.Text == "TERMINAR")
                    {
                        conexion.Close();
                    }
                    entradaTextbox.Clear();
                }
            }
            catch (SocketException)
            {
                mostrarTextBox.Text += "\nError al escribir objeto";
            }
        }
        private void btnEnviarServidor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Entre: entradaTextBox_KeyDown SERVIDOR");
            try
            {
                if (entradaTextbox.ReadOnly == false)
                {
                    escritor.Write("SERVIDOR>>>" + entradaTextbox.Text);
                    mostrarTextBox.Text += "\r\nSERVIDOR>>>" + entradaTextbox.Text;

                    if (entradaTextbox.Text == "TERMINAR")
                    {
                        conexion.Close();
                    }
                    entradaTextbox.Clear();
                }
            }
            catch (SocketException)
            {
                mostrarTextBox.Text += "\nError al escribir objeto";
            }
        }
        private void MostrarIPServidor(string ip)
        {
            // Verifica si es necesario invocar el método en el hilo principal
            if (labelIPDir.InvokeRequired) 
            {
                labelIPDir.Invoke(new Action<string>(MostrarIPServidor), ip);
            }
            else
            {
                // Actualiza el texto del Label
                labelIPDir.Text = ip; 
            }
        }
        public void EjecutarServidor()
        {
            TcpListener oyente;
            int contador = 1;

            try
            {
                // Obtener la dirección IP local
                string ip = Dns.GetHostEntry(Dns.GetHostName())
                       .AddressList
                       .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork)
                       ?.ToString();

                if (ip == null)
                {
                    throw new Exception("No se pudo encontrar una dirección IP válida.");
                }
                oyente = new TcpListener(IPAddress.Any, 50000); 
                oyente.Start();
                string ip_coneted = $"Servidor escuchando en {IPAddress.Any.ToString()}:50000\r\n";
                MostrarIPServidor(ip_coneted); // Actualiza el Label con la IP
                while (true)
                {
                    MostrarMensaje("Esperando una conexión\r\n");
                    conexion = oyente.AcceptSocket();
                    socketStream = new NetworkStream(conexion);
                    escritor = new BinaryWriter(socketStream);
                    lector = new BinaryReader(socketStream);

                    MostrarMensaje("Conexion " + contador + " recibida.\r\n");
                    escritor.Write("SERVIDOR>>> Conexión exitosa");
                    DeshabilitarEntrada(false);
                    string laRespuesta = "";
                    do
                    {
                        try
                        {
                            laRespuesta = lector.ReadString();

                            MostrarMensaje("\r\n" + laRespuesta);
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    } while (laRespuesta != "CLIENTE>>> TERMINAR" && conexion.Connected);

                    MostrarMensaje("\r\nEl usuario terminó la conexion\r\n");

                    escritor.Close();
                    lector.Close();
                    socketStream.Close();
                    conexion.Close();

                    DeshabilitarEntrada(true);
                    contador++;

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        
    }
}
