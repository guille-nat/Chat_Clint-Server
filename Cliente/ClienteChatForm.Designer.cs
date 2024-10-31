namespace Cliente
{
    partial class ClienteChatForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            entradaTextBox = new System.Windows.Forms.TextBox();
            mostrarTextBox = new System.Windows.Forms.TextBox();
            btnEnviar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnConectar = new System.Windows.Forms.Button();
            ipTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textNombreUsuario = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // entradaTextBox
            // 
            entradaTextBox.Location = new System.Drawing.Point(84, 133);
            entradaTextBox.Name = "entradaTextBox";
            entradaTextBox.Size = new System.Drawing.Size(615, 23);
            entradaTextBox.TabIndex = 0;
            entradaTextBox.KeyDown += entradaTextBox_KeyDown;
            // 
            // mostrarTextBox
            // 
            mostrarTextBox.Location = new System.Drawing.Point(12, 162);
            mostrarTextBox.Multiline = true;
            mostrarTextBox.Name = "mostrarTextBox";
            mostrarTextBox.Size = new System.Drawing.Size(798, 339);
            mostrarTextBox.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new System.Drawing.Point(705, 132);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new System.Drawing.Size(106, 23);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(5, 136);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Mensaje >>";
            // 
            // btnConectar
            // 
            btnConectar.Location = new System.Drawing.Point(380, 62);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new System.Drawing.Size(75, 23);
            btnConectar.TabIndex = 5;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new System.Drawing.Point(228, 63);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new System.Drawing.Size(148, 23);
            ipTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.Window;
            label2.Location = new System.Drawing.Point(10, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(186, 15);
            label2.TabIndex = 6;
            label2.Text = "Ingrese la direccion IP del servidor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.Window;
            label3.Location = new System.Drawing.Point(472, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre de usuario:";
            // 
            // textNombreUsuario
            // 
            textNombreUsuario.Location = new System.Drawing.Point(589, 63);
            textNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textNombreUsuario.Name = "textNombreUsuario";
            textNombreUsuario.Size = new System.Drawing.Size(110, 23);
            textNombreUsuario.TabIndex = 8;
            // 
            // ClienteChatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ClientSize = new System.Drawing.Size(824, 513);
            Controls.Add(textNombreUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnConectar);
            Controls.Add(ipTextBox);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Controls.Add(mostrarTextBox);
            Controls.Add(entradaTextBox);
            Name = "ClienteChatForm";
            Text = "Cliente";
            Load += ClienteChatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox entradaTextBox;
        private System.Windows.Forms.TextBox mostrarTextBox;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombreUsuario;
    }
}
