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
            ipTextBox = new System.Windows.Forms.TextBox();
            btnConectar = new System.Windows.Forms.Button();
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
            label1.Location = new System.Drawing.Point(14, 136);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Mnsaje >>";
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new System.Drawing.Point(325, 55);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new System.Drawing.Size(100, 23);
            ipTextBox.TabIndex = 4;
            // 
            // btnConectar
            // 
            btnConectar.Location = new System.Drawing.Point(431, 55);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new System.Drawing.Size(75, 23);
            btnConectar.TabIndex = 5;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // ClienteChatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(824, 513);
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
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button btnConectar;
    }
}
