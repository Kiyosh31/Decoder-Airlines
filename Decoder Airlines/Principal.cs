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
    public partial class Principal : Form
    {
        listaVuelos listaVuelos;
        listaPasajeros listaPasajeros;
        listaCiudades listaCiudades;

        public string asientoSeleccionado;

        public Principal(ref listaVuelos refListaVuelos, ref listaPasajeros listaPasajeros, ref listaCiudades listaCiudades)
        {
            InitializeComponent();

            this.listaVuelos = refListaVuelos;
            this.listaPasajeros = listaPasajeros;
            this.listaCiudades = listaCiudades;
        }

        private void vuelosButton_Click(object sender, EventArgs e)
        {
            if (listaVuelos.Count == 0)
            {
                MessageBox.Show("No Hay Vuelos Registrados");
            }
            else
            {
                Formulario VentanaFormulario = new Formulario(ref listaVuelos, ref listaPasajeros);
                VentanaFormulario.ShowDialog();
            }
        }

        private void registroButton_Click(object sender, EventArgs e)
        {
            registroVuelo VentanaRegistroVuelo = new registroVuelo(ref listaVuelos, ref listaCiudades);
            VentanaRegistroVuelo.ShowDialog();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (listaVuelos.Count == 0)
            {
                MessageBox.Show("No Hay Vuelos Registrados.");
            }
            else
            {
                EliminarVuelo VentanaEliminar = new EliminarVuelo(ref listaVuelos, ref listaPasajeros);
                VentanaEliminar.ShowDialog();
            }
        }

        private void rutasButton_Click(object sender, EventArgs e)
        {
            if (listaCiudades.Count == 0)
            {
                MessageBox.Show("No Hay Ciudades Registradas.");
            }
            else
            {
                Grafo VentanaGrafo = new Grafo(ref listaCiudades, ref listaVuelos, ref listaPasajeros);
                VentanaGrafo.ShowDialog();
            }
        }
    }
}
