namespace Decoder_Airlines
{
    partial class Formulario
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
            this.registroButton = new System.Windows.Forms.Button();
            this.ordenarFechaButton = new System.Windows.Forms.Button();
            this.ordenarDispButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 276);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // registroButton
            // 
            this.registroButton.Location = new System.Drawing.Point(260, 256);
            this.registroButton.Name = "registroButton";
            this.registroButton.Size = new System.Drawing.Size(84, 33);
            this.registroButton.TabIndex = 2;
            this.registroButton.Text = "Siguiente";
            this.registroButton.UseVisualStyleBackColor = true;
            this.registroButton.Click += new System.EventHandler(this.registroButton_Click);
            // 
            // ordenarFechaButton
            // 
            this.ordenarFechaButton.Location = new System.Drawing.Point(224, 56);
            this.ordenarFechaButton.Name = "ordenarFechaButton";
            this.ordenarFechaButton.Size = new System.Drawing.Size(120, 47);
            this.ordenarFechaButton.TabIndex = 3;
            this.ordenarFechaButton.Text = "Ordenar Por Fecha";
            this.ordenarFechaButton.UseVisualStyleBackColor = true;
            this.ordenarFechaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordenarDispButton
            // 
            this.ordenarDispButton.Location = new System.Drawing.Point(224, 120);
            this.ordenarDispButton.Name = "ordenarDispButton";
            this.ordenarDispButton.Size = new System.Drawing.Size(120, 47);
            this.ordenarDispButton.TabIndex = 4;
            this.ordenarDispButton.Text = "Ordenar Por Disponibilidad";
            this.ordenarDispButton.UseVisualStyleBackColor = true;
            this.ordenarDispButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 300);
            this.Controls.Add(this.ordenarDispButton);
            this.Controls.Add(this.ordenarFechaButton);
            this.Controls.Add(this.registroButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button registroButton;
        private System.Windows.Forms.Button ordenarFechaButton;
        private System.Windows.Forms.Button ordenarDispButton;
    }
}