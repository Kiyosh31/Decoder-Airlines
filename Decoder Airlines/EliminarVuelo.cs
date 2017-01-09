
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
    public partial class EliminarVuelo : Form
    {
        listaVuelos listaVuelos;
        listaPasajeros listaPasajeros;

        int indiceVuelo;

        public EliminarVuelo(ref listaVuelos refListaVuelos, ref listaPasajeros listaPasajeros)
        {
            InitializeComponent();
            this.listaVuelos = refListaVuelos;
            this.listaPasajeros = listaPasajeros;

            eliminarButton.Enabled = false;
            verVuelos();
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
            eliminarButton.Enabled = true;
        }

        private void fechaButton_Click(object sender, EventArgs e)
        {
            listaVuelos.quickSortFecha(0, listaVuelos.Count - 1);
            listBox1.Items.Clear();
            verVuelos();
        }

        private void disponibilidadButton_Click(object sender, EventArgs e)
        {
            listaVuelos.quickSortAsientos(0, listaVuelos.Count - 1);
            listBox1.Items.Clear();
            verVuelos();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaPasajeros.Count; i++)
            {
                if (listaVuelos[listBox1.SelectedIndex].indiceVuelo == listaPasajeros[i].indiceVuelo)
                {
                    listaPasajeros.RemoveAt(i);
                }
            }

            listaVuelos.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Clear();
            verVuelos();
            eliminarButton.Enabled = false;

            if (listaVuelos.Count == 0)
            {
                this.Close();
            }
        }
    }
}
