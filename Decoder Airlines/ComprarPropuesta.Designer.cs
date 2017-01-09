namespace Decoder_Airlines
{
    partial class ComprarPropuesta
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
            this.origenLabel = new System.Windows.Forms.Label();
            this.vueloOrigenLabel = new System.Windows.Forms.Label();
            this.destinoLabel = new System.Windows.Forms.Label();
            this.vueloDestinoLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.edadLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.comprarButton = new System.Windows.Forms.Button();
            this.asientoButton = new System.Windows.Forms.Button();
            this.asientoTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // origenLabel
            // 
            this.origenLabel.AutoSize = true;
            this.origenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origenLabel.Location = new System.Drawing.Point(13, 13);
            this.origenLabel.Name = "origenLabel";
            this.origenLabel.Size = new System.Drawing.Size(104, 25);
            this.origenLabel.TabIndex = 0;
            this.origenLabel.Text = "Vuelo De: ";
            // 
            // vueloOrigenLabel
            // 
            this.vueloOrigenLabel.AutoSize = true;
            this.vueloOrigenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vueloOrigenLabel.Location = new System.Drawing.Point(123, 13);
            this.vueloOrigenLabel.Name = "vueloOrigenLabel";
            this.vueloOrigenLabel.Size = new System.Drawing.Size(23, 25);
            this.vueloOrigenLabel.TabIndex = 1;
            this.vueloOrigenLabel.Text = "0";
            // 
            // destinoLabel
            // 
            this.destinoLabel.AutoSize = true;
            this.destinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinoLabel.Location = new System.Drawing.Point(166, 13);
            this.destinoLabel.Name = "destinoLabel";
            this.destinoLabel.Size = new System.Drawing.Size(37, 25);
            this.destinoLabel.TabIndex = 2;
            this.destinoLabel.Text = "A: ";
            // 
            // vueloDestinoLabel
            // 
            this.vueloDestinoLabel.AutoSize = true;
            this.vueloDestinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vueloDestinoLabel.Location = new System.Drawing.Point(209, 13);
            this.vueloDestinoLabel.Name = "vueloDestinoLabel";
            this.vueloDestinoLabel.Size = new System.Drawing.Size(23, 25);
            this.vueloDestinoLabel.TabIndex = 3;
            this.vueloDestinoLabel.Text = "0";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(12, 104);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(81, 25);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "Nombre";
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoLabel.Location = new System.Drawing.Point(13, 162);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(82, 25);
            this.apellidoLabel.TabIndex = 5;
            this.apellidoLabel.Text = "Apellido";
            // 
            // edadLabel
            // 
            this.edadLabel.AutoSize = true;
            this.edadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadLabel.Location = new System.Drawing.Point(12, 219);
            this.edadLabel.Name = "edadLabel";
            this.edadLabel.Size = new System.Drawing.Size(58, 25);
            this.edadLabel.TabIndex = 6;
            this.edadLabel.Text = "Edad";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(100, 106);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(153, 22);
            this.nombreTextBox.TabIndex = 7;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(100, 165);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(153, 22);
            this.apellidoTextBox.TabIndex = 8;
            this.apellidoTextBox.TextChanged += new System.EventHandler(this.apellidoTextBox_TextChanged);
            // 
            // edadTextBox
            // 
            this.edadTextBox.Location = new System.Drawing.Point(100, 223);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(153, 22);
            this.edadTextBox.TabIndex = 9;
            this.edadTextBox.TextChanged += new System.EventHandler(this.edadTextBox_TextChanged);
            // 
            // comprarButton
            // 
            this.comprarButton.Location = new System.Drawing.Point(235, 352);
            this.comprarButton.Name = "comprarButton";
            this.comprarButton.Size = new System.Drawing.Size(94, 36);
            this.comprarButton.TabIndex = 10;
            this.comprarButton.Text = "Comprar";
            this.comprarButton.UseVisualStyleBackColor = true;
            this.comprarButton.Click += new System.EventHandler(this.comprarButton_Click);
            // 
            // asientoButton
            // 
            this.asientoButton.Location = new System.Drawing.Point(12, 283);
            this.asientoButton.Name = "asientoButton";
            this.asientoButton.Size = new System.Drawing.Size(94, 36);
            this.asientoButton.TabIndex = 11;
            this.asientoButton.Text = "Asiento";
            this.asientoButton.UseVisualStyleBackColor = true;
            this.asientoButton.Click += new System.EventHandler(this.asientoButton_Click);
            // 
            // asientoTextbox
            // 
            this.asientoTextbox.Location = new System.Drawing.Point(112, 290);
            this.asientoTextbox.Name = "asientoTextbox";
            this.asientoTextbox.Size = new System.Drawing.Size(65, 22);
            this.asientoTextbox.TabIndex = 12;
            // 
            // ComprarPropuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 400);
            this.Controls.Add(this.asientoTextbox);
            this.Controls.Add(this.asientoButton);
            this.Controls.Add(this.comprarButton);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.edadLabel);
            this.Controls.Add(this.apellidoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.vueloDestinoLabel);
            this.Controls.Add(this.destinoLabel);
            this.Controls.Add(this.vueloOrigenLabel);
            this.Controls.Add(this.origenLabel);
            this.Name = "ComprarPropuesta";
            this.Text = "ComprarPropuesta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label origenLabel;
        private System.Windows.Forms.Label vueloOrigenLabel;
        private System.Windows.Forms.Label destinoLabel;
        private System.Windows.Forms.Label vueloDestinoLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.Button comprarButton;
        private System.Windows.Forms.Button asientoButton;
        private System.Windows.Forms.TextBox asientoTextbox;
    }
}