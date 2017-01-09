namespace Decoder_Airlines
{
    partial class RegistroPasajero
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.asientosButton = new System.Windows.Forms.Button();
            this.asientostextBox = new System.Windows.Forms.TextBox();
            this.comprarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.borrarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buscarCTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(16, 33);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(141, 22);
            this.nombreTextBox.TabIndex = 3;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(16, 78);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(141, 22);
            this.apellidoTextBox.TabIndex = 4;
            this.apellidoTextBox.TextChanged += new System.EventHandler(this.apellidoTextBox_TextChanged);
            // 
            // edadTextBox
            // 
            this.edadTextBox.Location = new System.Drawing.Point(16, 123);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(141, 22);
            this.edadTextBox.TabIndex = 5;
            this.edadTextBox.TextChanged += new System.EventHandler(this.edadTextBox_TextChanged);
            // 
            // asientosButton
            // 
            this.asientosButton.Location = new System.Drawing.Point(196, 33);
            this.asientosButton.Name = "asientosButton";
            this.asientosButton.Size = new System.Drawing.Size(73, 49);
            this.asientosButton.TabIndex = 8;
            this.asientosButton.Text = "Asiento";
            this.asientosButton.UseVisualStyleBackColor = true;
            this.asientosButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // asientostextBox
            // 
            this.asientostextBox.Location = new System.Drawing.Point(275, 46);
            this.asientostextBox.Name = "asientostextBox";
            this.asientostextBox.Size = new System.Drawing.Size(53, 22);
            this.asientostextBox.TabIndex = 9;
            // 
            // comprarButton
            // 
            this.comprarButton.Location = new System.Drawing.Point(196, 119);
            this.comprarButton.Name = "comprarButton";
            this.comprarButton.Size = new System.Drawing.Size(86, 31);
            this.comprarButton.TabIndex = 10;
            this.comprarButton.Text = "Comprar";
            this.comprarButton.UseVisualStyleBackColor = true;
            this.comprarButton.Click += new System.EventHandler(this.comprarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lista De Clientes";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 323);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 132);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // borrarButton
            // 
            this.borrarButton.Location = new System.Drawing.Point(105, 461);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(138, 33);
            this.borrarButton.TabIndex = 13;
            this.borrarButton.Text = "Eliminar Pasajero";
            this.borrarButton.UseVisualStyleBackColor = true;
            this.borrarButton.Click += new System.EventHandler(this.borrarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Buscar Cliente";
            // 
            // buscarCTextBox
            // 
            this.buscarCTextBox.Location = new System.Drawing.Point(12, 279);
            this.buscarCTextBox.Name = "buscarCTextBox";
            this.buscarCTextBox.Size = new System.Drawing.Size(178, 22);
            this.buscarCTextBox.TabIndex = 15;
            this.buscarCTextBox.TextChanged += new System.EventHandler(this.buscarTextBox);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 506);
            this.Controls.Add(this.buscarCTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.borrarButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comprarButton);
            this.Controls.Add(this.asientostextBox);
            this.Controls.Add(this.asientosButton);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            //this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.Button asientosButton;
        private System.Windows.Forms.TextBox asientostextBox;
        private System.Windows.Forms.Button comprarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button borrarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buscarCTextBox;
    }
}