namespace Decoder_Airlines
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.vuelosButton = new System.Windows.Forms.Button();
            this.registroButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.rutasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decoder Airlines";
            // 
            // vuelosButton
            // 
            this.vuelosButton.Location = new System.Drawing.Point(21, 49);
            this.vuelosButton.Name = "vuelosButton";
            this.vuelosButton.Size = new System.Drawing.Size(102, 52);
            this.vuelosButton.TabIndex = 1;
            this.vuelosButton.Text = "Comprar Vuelos";
            this.vuelosButton.UseVisualStyleBackColor = true;
            this.vuelosButton.Click += new System.EventHandler(this.vuelosButton_Click);
            // 
            // registroButton
            // 
            this.registroButton.Location = new System.Drawing.Point(129, 49);
            this.registroButton.Name = "registroButton";
            this.registroButton.Size = new System.Drawing.Size(102, 52);
            this.registroButton.TabIndex = 2;
            this.registroButton.Text = "Registrar Vuelo";
            this.registroButton.UseVisualStyleBackColor = true;
            this.registroButton.Click += new System.EventHandler(this.registroButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(129, 107);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(102, 52);
            this.eliminarButton.TabIndex = 3;
            this.eliminarButton.Text = "Eliminar Vuelo";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // rutasButton
            // 
            this.rutasButton.Location = new System.Drawing.Point(21, 107);
            this.rutasButton.Name = "rutasButton";
            this.rutasButton.Size = new System.Drawing.Size(102, 52);
            this.rutasButton.TabIndex = 4;
            this.rutasButton.Text = "Rutas";
            this.rutasButton.UseVisualStyleBackColor = true;
            this.rutasButton.Click += new System.EventHandler(this.rutasButton_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 256);
            this.Controls.Add(this.rutasButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.registroButton);
            this.Controls.Add(this.vuelosButton);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vuelosButton;
        private System.Windows.Forms.Button registroButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button rutasButton;
    }
}

