namespace GestionDeFuentes
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
            this.labelText = new System.Windows.Forms.Label();
            this.buttonNegrita = new System.Windows.Forms.Button();
            this.buttonCursiva = new System.Windows.Forms.Button();
            this.buttonSubrayada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(264, 149);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(201, 20);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "En un lugar de la mancha...";
            this.labelText.Click += new System.EventHandler(this.labelText_Click);
            // 
            // buttonNegrita
            // 
            this.buttonNegrita.Location = new System.Drawing.Point(134, 228);
            this.buttonNegrita.Name = "buttonNegrita";
            this.buttonNegrita.Size = new System.Drawing.Size(118, 47);
            this.buttonNegrita.TabIndex = 1;
            this.buttonNegrita.Text = "Negrita";
            this.buttonNegrita.UseVisualStyleBackColor = true;
            this.buttonNegrita.Click += new System.EventHandler(this.buttonNegrita_Click);
            // 
            // buttonCursiva
            // 
            this.buttonCursiva.Location = new System.Drawing.Point(307, 228);
            this.buttonCursiva.Name = "buttonCursiva";
            this.buttonCursiva.Size = new System.Drawing.Size(102, 47);
            this.buttonCursiva.TabIndex = 2;
            this.buttonCursiva.Text = "Cursiva";
            this.buttonCursiva.UseVisualStyleBackColor = true;
            this.buttonCursiva.Click += new System.EventHandler(this.buttonCursiva_Click);
            // 
            // buttonSubrayada
            // 
            this.buttonSubrayada.Location = new System.Drawing.Point(488, 228);
            this.buttonSubrayada.Name = "buttonSubrayada";
            this.buttonSubrayada.Size = new System.Drawing.Size(99, 47);
            this.buttonSubrayada.TabIndex = 3;
            this.buttonSubrayada.Text = "Subrayada";
            this.buttonSubrayada.UseVisualStyleBackColor = true;
            this.buttonSubrayada.Click += new System.EventHandler(this.buttonSubrayada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubrayada);
            this.Controls.Add(this.buttonCursiva);
            this.Controls.Add(this.buttonNegrita);
            this.Controls.Add(this.labelText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonNegrita;
        private System.Windows.Forms.Button buttonCursiva;
        private System.Windows.Forms.Button buttonSubrayada;
    }
}

