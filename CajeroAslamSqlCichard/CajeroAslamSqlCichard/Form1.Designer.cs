namespace CajeroAslamSqlCichard
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
            this.BtIniciarSesion = new System.Windows.Forms.Button();
            this.BtRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtIniciarSesion
            // 
            this.BtIniciarSesion.Location = new System.Drawing.Point(260, 46);
            this.BtIniciarSesion.Name = "BtIniciarSesion";
            this.BtIniciarSesion.Size = new System.Drawing.Size(185, 108);
            this.BtIniciarSesion.TabIndex = 0;
            this.BtIniciarSesion.Text = "Iniciar sesión";
            this.BtIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // BtRegistrarse
            // 
            this.BtRegistrarse.Location = new System.Drawing.Point(260, 212);
            this.BtRegistrarse.Name = "BtRegistrarse";
            this.BtRegistrarse.Size = new System.Drawing.Size(203, 106);
            this.BtRegistrarse.TabIndex = 2;
            this.BtRegistrarse.Text = "Registrarse";
            this.BtRegistrarse.UseVisualStyleBackColor = true;
            this.BtRegistrarse.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtRegistrarse);
            this.Controls.Add(this.BtIniciarSesion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtIniciarSesion;
        private System.Windows.Forms.Button BtRegistrarse;
    }
}

