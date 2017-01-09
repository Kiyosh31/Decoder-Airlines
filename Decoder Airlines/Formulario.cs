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
    public partial class Formulario : Form
    {
        listaVuelos listaVuelos;
        listaPasajeros listaPasajeros;
        int indiceVuelo;

        public Formulario(ref listaVuelos listaVuelos, ref listaPasajeros listaPasajeros)
        {
            InitializeComponent();
            this.listaVuelos = listaVuelos;
            this.listaPasajeros = listaPasajeros;
            registroButton.Enabled = false;
            verVuelos();
        }

        private void registroButton_Click(object sender, EventArgs e)
        {
            RegistroPasajero VentanaRegistro = new RegistroPasajero(ref listaVuelos, indiceVuelo, ref listaPasajeros);
            VentanaRegistro.ShowDialog();
        }

        private void verVuelos()
        {
            foreach (Vuelo vuelo in this.listaVuelos)
            {
                this.listBox1.Items.Add(vuelo.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceVuelo = listBox1.SelectedIndex;
            registroButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaVuelos.quickSortAsientos(0, listaVuelos.Count - 1);
            listBox1.Items.Clear();
            verVuelos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaVuelos.quickSortFecha(0, listaVuelos.Count - 1);
            listBox1.Items.Clear();
            verVuelos();
        }
    }
}
