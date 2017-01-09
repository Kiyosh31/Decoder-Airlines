namespace Decoder_Airlines
{
    partial class Grafo
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
            this.kruskalButton = new System.Windows.Forms.Button();
            this.primButton = new System.Windows.Forms.Button();
            this.eliminarCiudadButton = new System.Windows.Forms.Button();
            this.eliminarTextBox = new System.Windows.Forms.TextBox();
            this.grafoButton = new System.Windows.Forms.Button();
            this.dijkstraButton = new System.Windows.Forms.Button();
            this.origenTextBox = new System.Windows.Forms.TextBox();
            this.origenLabel = new System.Windows.Forms.Label();
            this.destinoLabel = new System.Windows.Forms.Label();
            this.destinoTextBox = new System.Windows.Forms.TextBox();
            this.propuestaButton = new System.Windows.Forms.Button();
            this.mexicoPictureBox = new System.Windows.Forms.PictureBox();
            this.cortaButton = new System.Windows.Forms.Button();
            this.barataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mexicoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kruskalButton
            // 
            this.kruskalButton.Location = new System.Drawing.Point(247, 613);
            this.kruskalButton.Name = "kruskalButton";
            this.kruskalButton.Size = new System.Drawing.Size(87, 30);
            this.kruskalButton.TabIndex = 2;
            this.kruskalButton.Text = "Precio";
            this.kruskalButton.UseVisualStyleBackColor = true;
            this.kruskalButton.Click += new System.EventHandler(this.Kruskal_Click);
            // 
            // primButton
            // 
            this.primButton.Location = new System.Drawing.Point(154, 613);
            this.primButton.Name = "primButton";
            this.primButton.Size = new System.Drawing.Size(87, 30);
            this.primButton.TabIndex = 3;
            this.primButton.Text = "Tiempo";
            this.primButton.UseVisualStyleBackColor = true;
            this.primButton.Click += new System.EventHandler(this.primButton_Click);
            // 
            // eliminarCiudadButton
            // 
            this.eliminarCiudadButton.Location = new System.Drawing.Point(12, 506);
            this.eliminarCiudadButton.Name = "eliminarCiudadButton";
            this.eliminarCiudadButton.Size = new System.Drawing.Size(149, 30);
            this.eliminarCiudadButton.TabIndex = 4;
            this.eliminarCiudadButton.Text = "Eliminar CIudad";
            this.eliminarCiudadButton.UseVisualStyleBackColor = true;
            this.eliminarCiudadButton.Click += new System.EventHandler(this.eliminarCiudadButton_Click);
            // 
            // eliminarTextBox
            // 
            this.eliminarTextBox.Location = new System.Drawing.Point(12, 478);
            this.eliminarTextBox.Name = "eliminarTextBox";
            this.eliminarTextBox.Size = new System.Drawing.Size(149, 22);
            this.eliminarTextBox.TabIndex = 5;
            this.eliminarTextBox.TextChanged += new System.EventHandler(this.eliminarTextBox_TextChanged);
            // 
            // grafoButton
            // 
            this.grafoButton.Location = new System.Drawing.Point(12, 613);
            this.grafoButton.Name = "grafoButton";
            this.grafoButton.Size = new System.Drawing.Size(87, 30);
            this.grafoButton.TabIndex = 6;
            this.grafoButton.Text = "Vuelos";
            this.grafoButton.UseVisualStyleBackColor = true;
            this.grafoButton.Click += new System.EventHandler(this.grafoButton_Click);
            // 
            // dijkstraButton
            // 
            this.dijkstraButton.Location = new System.Drawing.Point(499, 613);
            this.dijkstraButton.Name = "dijkstraButton";
            this.dijkstraButton.Size = new System.Drawing.Size(87, 30);
            this.dijkstraButton.TabIndex = 7;
            this.dijkstraButton.Text = "Dijkstra";
            this.dijkstraButton.UseVisualStyleBackColor = true;
            this.dijkstraButton.Click += new System.EventHandler(this.dijkstraButton_Click);
            // 
            // origenTextBox
            // 
            this.origenTextBox.Location = new System.Drawing.Point(867, 378);
            this.origenTextBox.Name = "origenTextBox";
            this.origenTextBox.Size = new System.Drawing.Size(68, 22);
            this.origenTextBox.TabIndex = 8;
            this.origenTextBox.TextChanged += new System.EventHandler(this.origentextbox_TextChanged);
            // 
            // origenLabel
            // 
            this.origenLabel.AutoSize = true;
            this.origenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origenLabel.Location = new System.Drawing.Point(867, 351);
            this.origenLabel.Name = "origenLabel";
            this.origenLabel.Size = new System.Drawing.Size(68, 24);
            this.origenLabel.TabIndex = 9;
            this.origenLabel.Text = "Origen";
            // 
            // destinoLabel
            // 
            this.destinoLabel.AutoSize = true;
            this.destinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinoLabel.Location = new System.Drawing.Point(953, 351);
            this.destinoLabel.Name = "destinoLabel";
            this.destinoLabel.Size = new System.Drawing.Size(73, 24);
            this.destinoLabel.TabIndex = 11;
            this.destinoLabel.Text = "Destino";
            // 
            // destinoTextBox
            // 
            this.destinoTextBox.Location = new System.Drawing.Point(953, 378);
            this.destinoTextBox.Name = "destinoTextBox";
            this.destinoTextBox.Size = new System.Drawing.Size(73, 22);
            this.destinoTextBox.TabIndex = 10;
            this.destinoTextBox.TextChanged += new System.EventHandler(this.destinoTextBox_TextChanged);
            // 
            // propuestaButton
            // 
            this.propuestaButton.Location = new System.Drawing.Point(867, 415);
            this.propuestaButton.Name = "propuestaButton";
            this.propuestaButton.Size = new System.Drawing.Size(100, 36);
            this.propuestaButton.TabIndex = 12;
            this.propuestaButton.Text = "Propuesta";
            this.propuestaButton.UseVisualStyleBackColor = true;
            this.propuestaButton.Click += new System.EventHandler(this.propuestaButton_Click);
            // 
            // mexicoPictureBox
            // 
            this.mexicoPictureBox.Image = global::Decoder_Airlines.Properties.Resources.Mexico;
            this.mexicoPictureBox.Location = new System.Drawing.Point(-2, -2);
            this.mexicoPictureBox.Name = "mexicoPictureBox";
            this.mexicoPictureBox.Size = new System.Drawing.Size(1251, 656);
            this.mexicoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mexicoPictureBox.TabIndex = 0;
            this.mexicoPictureBox.TabStop = false;
            // 
            // cortaButton
            // 
            this.cortaButton.Location = new System.Drawing.Point(592, 613);
            this.cortaButton.Name = "cortaButton";
            this.cortaButton.Size = new System.Drawing.Size(125, 30);
            this.cortaButton.TabIndex = 13;
            this.cortaButton.Text = "Ruta Mas Corta";
            this.cortaButton.UseVisualStyleBackColor = true;
            this.cortaButton.Click += new System.EventHandler(this.cortaButton_Click);
            // 
            // barataButton
            // 
            this.barataButton.Location = new System.Drawing.Point(723, 613);
            this.barataButton.Name = "barataButton";
            this.barataButton.Size = new System.Drawing.Size(136, 30);
            this.barataButton.TabIndex = 14;
            this.barataButton.Text = "Ruta Mas Barata";
            this.barataButton.UseVisualStyleBackColor = true;
            this.barataButton.Click += new System.EventHandler(this.barataButton_Click);
            // 
            // Grafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 655);
            this.Controls.Add(this.barataButton);
            this.Controls.Add(this.cortaButton);
            this.Controls.Add(this.propuestaButton);
            this.Controls.Add(this.destinoLabel);
            this.Controls.Add(this.destinoTextBox);
            this.Controls.Add(this.origenLabel);
            this.Controls.Add(this.origenTextBox);
            this.Controls.Add(this.dijkstraButton);
            this.Controls.Add(this.grafoButton);
            this.Controls.Add(this.eliminarTextBox);
            this.Controls.Add(this.eliminarCiudadButton);
            this.Controls.Add(this.primButton);
            this.Controls.Add(this.kruskalButton);
            this.Controls.Add(this.mexicoPictureBox);
            this.Name = "Grafo";
            this.Text = "Grafo";
            ((System.ComponentModel.ISupportInitialize)(this.mexicoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mexicoPictureBox;
        private System.Windows.Forms.Button kruskalButton;
        private System.Windows.Forms.Button primButton;
        private System.Windows.Forms.Button eliminarCiudadButton;
        private System.Windows.Forms.TextBox eliminarTextBox;
        private System.Windows.Forms.Button grafoButton;
        private System.Windows.Forms.Button dijkstraButton;
        private System.Windows.Forms.TextBox origenTextBox;
        private System.Windows.Forms.Label origenLabel;
        private System.Windows.Forms.Label destinoLabel;
        private System.Windows.Forms.TextBox destinoTextBox;
        private System.Windows.Forms.Button propuestaButton;
        private System.Windows.Forms.Button cortaButton;
        private System.Windows.Forms.Button barataButton;
    }
}