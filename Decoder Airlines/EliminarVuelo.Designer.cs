namespace Decoder_Airlines
{
    partial class EliminarVuelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fechaButton = new System.Windows.Forms.Button();
            this.disponibilidadButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // fechaButton
            // 
            this.fechaButton.Location = new System.Drawing.Point(222, 42);
            this.fechaButton.Name = "fechaButton";
            this.fechaButton.Size = new System.Drawing.Size(112, 51);
            this.fechaButton.TabIndex = 1;
            this.fechaButton.Text = "Ordenar Por Fecha";
            this.fechaButton.UseVisualStyleBackColor = true;
            this.fechaButton.Click += new System.EventHandler(this.fechaButton_Click);
            // 
            // disponibilidadButton
            // 
            this.disponibilidadButton.Location = new System.Drawing.Point(222, 99);
            this.disponibilidadButton.Name = "disponibilidadButton";
            this.disponibilidadButton.Size = new System.Drawing.Size(112, 51);
            this.disponibilidadButton.TabIndex = 2;
            this.disponibilidadButton.Text = "Ordenar Por Disponibilidad";
            this.disponibilidadButton.UseVisualStyleBackColor = true;
            this.disponibilidadButton.Click += new System.EventHandler(this.disponibilidadButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(235, 282);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(99, 37);
            this.eliminarButton.TabIndex = 3;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // EliminarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 331);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.disponibilidadButton);
            this.Controls.Add(this.fechaButton);
            this.Controls.Add(this.listBox1);
            this.Name = "EliminarVuelo";
            this.Text = "EliminarVuelo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button fechaButton;
        private System.Windows.Forms.Button disponibilidadButton;
        private System.Windows.Forms.Button eliminarButton;
    }
}