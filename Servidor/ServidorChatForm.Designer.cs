using System;

namespace Servidor
{
    partial class ServidorChatForm
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
            entradaTextbox = new System.Windows.Forms.TextBox();
            mostrarTextBox = new System.Windows.Forms.TextBox();
            btnEnviarServidor = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            labelIPDir = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // entradaTextbox
            // 
            entradaTextbox.Location = new System.Drawing.Point(84, 133);
            entradaTextbox.Name = "entradaTextbox";
            entradaTextbox.Size = new System.Drawing.Size(615, 23);
            entradaTextbox.TabIndex = 0;
            entradaTextbox.KeyDown += entradaTextbox_KeyDown;
            // 
            // mostrarTextBox
            // 
            mostrarTextBox.BackColor = System.Drawing.Color.LightGray;
            mostrarTextBox.Location = new System.Drawing.Point(12, 162);
            mostrarTextBox.Multiline = true;
            mostrarTextBox.Name = "mostrarTextBox";
            mostrarTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            mostrarTextBox.Size = new System.Drawing.Size(798, 339);
            mostrarTextBox.TabIndex = 1;
            // 
            // btnEnviarServidor
            // 
            btnEnviarServidor.Location = new System.Drawing.Point(705, 132);
            btnEnviarServidor.Name = "btnEnviarServidor";
            btnEnviarServidor.Size = new System.Drawing.Size(106, 23);
            btnEnviarServidor.TabIndex = 2;
            btnEnviarServidor.Text = "Enviar";
            btnEnviarServidor.UseVisualStyleBackColor = true;
            btnEnviarServidor.Click += btnEnviarServidor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(14, 136);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Mnsaje >>";
            // 
            // labelIPDir
            // 
            labelIPDir.AutoSize = true;
            labelIPDir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelIPDir.ForeColor = System.Drawing.SystemColors.Window;
            labelIPDir.Location = new System.Drawing.Point(12, 9);
            labelIPDir.Name = "labelIPDir";
            labelIPDir.Size = new System.Drawing.Size(0, 32);
            labelIPDir.TabIndex = 4;
            // 
            // ServidorChatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            ClientSize = new System.Drawing.Size(824, 513);
            Controls.Add(labelIPDir);
            Controls.Add(label1);
            Controls.Add(btnEnviarServidor);
            Controls.Add(mostrarTextBox);
            Controls.Add(entradaTextbox);
            Location = new System.Drawing.Point(600, 100);
            Name = "ServidorChatForm";
            Text = "Servidor";
            Load += ServidorChatForm_load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.TextBox entradaTextbox;
        private System.Windows.Forms.TextBox mostrarTextBox;
        private System.Windows.Forms.Button btnEnviarServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label labelIPDir;
    }
}
