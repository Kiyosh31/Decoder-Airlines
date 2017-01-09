using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder_Airlines
{
    public partial class AgregarXY : Form
    {
        public int x, y;

        public AgregarXY(string nombre)
        {
            InitializeComponent();

            label4.Text = nombre;

            xTextBox.Enabled = false;
            yTextBox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mexicoPictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            Point p = m.Location;
            x = p.X;
            y = p.Y;
            Console.WriteLine(p);
            xTextBox.Text = x.ToString();
            yTextBox.Text = y.ToString();
        }
    }
}
