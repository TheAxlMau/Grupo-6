﻿namespace Main1
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
            this.bttnCambiarTexto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCambiarTexto2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnCambiarTexto
            // 
            this.bttnCambiarTexto.Location = new System.Drawing.Point(74, 115);
            this.bttnCambiarTexto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnCambiarTexto.Name = "bttnCambiarTexto";
            this.bttnCambiarTexto.Size = new System.Drawing.Size(98, 54);
            this.bttnCambiarTexto.TabIndex = 0;
            this.bttnCambiarTexto.Text = "Cambiar Texto";
            this.bttnCambiarTexto.UseVisualStyleBackColor = true;
            this.bttnCambiarTexto.Click += new System.EventHandler(this.bttnCambiarTexto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // bttnCambiarTexto2
            // 
            this.bttnCambiarTexto2.Location = new System.Drawing.Point(450, 307);
            this.bttnCambiarTexto2.Name = "bttnCambiarTexto2";
            this.bttnCambiarTexto2.Size = new System.Drawing.Size(131, 51);
            this.bttnCambiarTexto2.TabIndex = 2;
            this.bttnCambiarTexto2.Text = "Cambiar Texto 2";
            this.bttnCambiarTexto2.UseVisualStyleBackColor = true;
            this.bttnCambiarTexto2.Click += new System.EventHandler(this.bttnCambiarTexto2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(675, 385);
=======
            this.ClientSize = new System.Drawing.Size(900, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnCambiarTexto2);
>>>>>>> 4bc7669d1d137d4073a4a46b8ac834dc4592805d
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnCambiarTexto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCambiarTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnCambiarTexto2;
        private System.Windows.Forms.Label label2;
    }
}

