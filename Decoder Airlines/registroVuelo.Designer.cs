namespace Decoder_Airlines
{
    partial class registroVuelo
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
            this.label2 = new System.Windows.Forms.Label();
            this.origenTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.destinoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tiempoTextBox = new System.Windows.Forms.TextBox();
            this.registroButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Origen";
            // 
            // origenTextBox
            // 
            this.origenTextBox.Location = new System.Drawing.Point(12, 42);
            this.origenTextBox.Name = "origenTextBox";
            this.origenTextBox.Size = new System.Drawing.Size(181, 22);
            this.origenTextBox.TabIndex = 2;
            this.origenTextBox.TextChanged += new System.EventHandler(this.origenTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destino";
            // 
            // destinoTextBox
            // 
            this.destinoTextBox.Location = new System.Drawing.Point(12, 100);
            this.destinoTextBox.Name = "destinoTextBox";
            this.destinoTextBox.Size = new System.Drawing.Size(181, 22);
            this.destinoTextBox.TabIndex = 4;
            this.destinoTextBox.TextChanged += new System.EventHandler(this.destinoTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo";
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(12, 159);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(181, 22);
            this.precioTextBox.TabIndex = 6;
            this.precioTextBox.TextChanged += new System.EventHandler(this.precioTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiempo De Vuelo";
            // 
            // tiempoTextBox
            // 
            this.tiempoTextBox.Location = new System.Drawing.Point(12, 218);
            this.tiempoTextBox.Name = "tiempoTextBox";
            this.tiempoTextBox.Size = new System.Drawing.Size(181, 22);
            this.tiempoTextBox.TabIndex = 8;
            this.tiempoTextBox.TextChanged += new System.EventHandler(this.tiempoTextBox_TextChanged);
            // 
            // registroButton
            // 
            this.registroButton.Location = new System.Drawing.Point(149, 334);
            this.registroButton.Name = "registroButton";
            this.registroButton.Size = new System.Drawing.Size(96, 38);
            this.registroButton.TabIndex = 10;
            this.registroButton.Text = "Registrar";
            this.registroButton.UseVisualStyleBackColor = true;
            this.registroButton.Click += new System.EventHandler(this.registroButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 274);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // registroVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 380);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registroButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tiempoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.origenTextBox);
            this.Name = "registroVuelo";
            this.Text = "registroVuelo";
            this.Load += new System.EventHandler(this.registroVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox origenTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox destinoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tiempoTextBox;
        private System.Windows.Forms.Button registroButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}