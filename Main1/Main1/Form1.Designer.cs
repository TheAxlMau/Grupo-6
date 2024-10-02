namespace Main1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnCambiarTexto
            // 
            this.bttnCambiarTexto.Location = new System.Drawing.Point(99, 142);
            this.bttnCambiarTexto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnCambiarTexto.Name = "bttnCambiarTexto";
            this.bttnCambiarTexto.Size = new System.Drawing.Size(131, 66);
            this.bttnCambiarTexto.TabIndex = 0;
            this.bttnCambiarTexto.Text = "Cambiar Texto";
            this.bttnCambiarTexto.UseVisualStyleBackColor = true;
            this.bttnCambiarTexto.Click += new System.EventHandler(this.bttnCambiarTexto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cambiar Texto 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnCambiarTexto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

