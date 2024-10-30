using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class ClienteChatForm : Form
    {
        private NetworkStream? salida;// flujo para recibir datos
        private BinaryWriter? escritor; // facilita la escritura en el flujo
        private BinaryReader? lector; // facilita la lectura del flujo
        private Thread? lecturaThread; // Thread para procesar mensajes entrantes
        private string mensaje = "";

        public ClienteChatForm()
        {
            System.Diagnostics.Debug.WriteLine("Entre: Constructor");
            InitializeComponent();
            // Establece la posición de la ventana del cliente a la izquierda de la pantalla
            this.StartPosition = FormStartPosition.Manual;
            // A la izquierda
            this.Location = new Point(200, 100); 
        }

        // Inicializa el subproceso para lectura

        private void ClienteChatForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Entre: OnLoad");
            
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            string ip = ipTextBox.Text; // obtener la IP del usuario.
            if (string.IsNullOrWhiteSpace(ip))
            {
                MessageBox.Show("Por favor, ingrese una dirección IP válida.", "IP inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Iniciar el cliente y se conceta al servidor.
            lecturaThread = new Thread(() => EjecutarCliente(ip));
            lecturaThread.Start();
        }
        // Cierra todos los subprocesos asociados con esta aplicación
        private void ClienteChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        // Delegado que permite llamar al método MostrarMensaje
        private delegate void DisplayDelegate(string message);

        // El método MostrarMensaje establece la propiedad Text de mostrarTextBox de manera segura para el subproceso
        private void MostrarMensaje(string mensaje)
        {
            if (mostrarTextBox.InvokeRequired)
            {
                Invoke(new DisplayDelegate(MostrarMensaje), new object[] { mensaje });
            }
            else
            {
                mostrarTextBox.Text += mensaje;
            }
        }

        // Delegado que permite llamar al método DeshabilitarSalida
        private delegate void DisableInputDelegate(bool value);

        // El método DeshabilitarSalida establece la propiedad ReadOnly de entradaTextBox de manera segura para el subproceso
        private void DeshabilitarSalida(bool valor)
        {
            if (entradaTextBox.InvokeRequired)
            {
                Invoke(new DisableInputDelegate(DeshabilitarSalida), new object[] { valor });
            }
            else
            {
                entradaTextBox.ReadOnly = valor;
            }
        }
       

        // Envía al servidor el texto que escribe el usuario
        private void entradaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Entre: entradaTextBox_KeyDown CLIENTE");
            try
            {
                if (e.KeyCode == Keys.Enter && entradaTextBox.ReadOnly == false)
                {

                    escritor.Write("CLIENTE>>> " + entradaTextBox.Text);
                    mostrarTextBox.Text += "\r\nCLIENTE>>>" + entradaTextBox.Text;
                    entradaTextBox.Clear();
                }
            }
            catch (SocketException)
            {
                mostrarTextBox.Text += "\nError al escribir el objeto";
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Entre: entradaTextBox_KeyDown CLIENTE");
            try
            {
                if (entradaTextBox.ReadOnly == false)
                {

                    escritor.Write("CLIENTE>>> " + entradaTextBox.Text);
                    mostrarTextBox.Text += "\r\nCLIENTE>>>" + entradaTextBox.Text;
                    entradaTextBox.Clear();
                }
            }
            catch (SocketException)
            {
                mostrarTextBox.Text += "\nError al escribir el objeto";
            }
        }


        // Se conecta al servidor y muestra el texto generado por el servidor
        public void EjecutarCliente(string ip)
        {
            TcpClient cliente;

            try
            {
                MostrarMensaje("Tratando de conectar\r\n");

                // Paso 1: crear TcpClient y conectar al servidor usando la IP proporcionada
                cliente = new TcpClient();
                cliente.Connect(ip, 50000); // Usa la IP ingresada por el usuario

                // Paso 2: obtener NetworkStream asociado con TcpClient
                salida = cliente.GetStream();

                // Crea objetos para escribir y leer a través del flujo
                escritor = new BinaryWriter(salida);
                lector = new BinaryReader(salida);

                MostrarMensaje("\r\nSe recibieron flujos de E/S\r\n");
                DeshabilitarSalida(false); // habilita entradaTextBox

                // Itera hasta que el servidor indica la terminación
                do
                {
                    try
                    {
                        // Lee mensaje del servidor
                        mensaje = lector.ReadString();
                        MostrarMensaje("\r\n" + mensaje);
                    }
                    catch (Exception)
                    {
                        // Maneja excepción si hay error al leer datos del servidor
                        Environment.Exit(Environment.ExitCode);
                    }
                } while (mensaje != "SERVIDOR>>> TERMINAR");

                // Paso 4: cierra la conexión
                escritor.Close();
                lector.Close();
                salida.Close();
                cliente.Close();
                Application.Exit();
            }
            catch (Exception error)
            {
                // Maneja excepción si hay error al establecer la conexión
                MessageBox.Show(error.ToString(), "Error en la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);
            }
        }

        
    }
}
