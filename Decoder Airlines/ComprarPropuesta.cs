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
    public partial class ComprarPropuesta : Form
    {
        listaVuelos listaVuelos;
        listaPasajeros listaPasajeros;
        Vuelo myVuelo;

        int cont;

        public string a, b, c;

        public ComprarPropuesta(Vuelo objeto, ref listaVuelos refListaVuelos, ref listaPasajeros refListaPasajeros, int informacion, string nombre, string apellido, string edad)
        {
            InitializeComponent();

            this.listaVuelos = refListaVuelos;
            this.listaPasajeros = refListaPasajeros;
            this.myVuelo = objeto;

            origenLabel.Text = myVuelo.origen.ToString();
            destinoLabel.Text = myVuelo.destino.ToString();

            asientoButton.Enabled = false;
            comprarButton.Enabled = false;

            asientoTextbox.Enabled = false;
            apellidoTextBox.Enabled = false;
            edadTextBox.Enabled = false;

            findIndice();

            foreach (Pasajero myPasajero in listaPasajeros)
            {
                foreach (Vuelo myVuelo in listaVuelos)
                {
                    if (myPasajero.indiceVuelo == myVuelo.indiceVuelo)
                    {
                        myVuelo.indice[myPasajero.numeroAsiento] = false;
                    }
                }
            }
        }

        public void findIndice()
        {
            cont = 0;

            foreach (Vuelo vuelo in listaVuelos)
            {
                if (vuelo == myVuelo)
                {
                    break;
                }
                cont++;
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            if(nombreTextBox.Text == "")
            {
                
            }
            else
            {
                apellidoTextBox.Enabled = true;
            }
        }

        private void apellidoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (apellidoTextBox.Text == "")
            {
                
            }
            else
            {
                edadTextBox.Enabled = true;
            }
        }

        private void edadTextBox_TextChanged(object sender, EventArgs e)
        {
            if (edadTextBox.Text == "")
            {
                
            }
            else
            {
                asientoButton.Enabled = true;
            }
        }

        private void asientoButton_Click(object sender, EventArgs e)
        {
            AsientosPropuesta VentanaAsientos = new AsientosPropuesta(ref listaVuelos, cont);
            VentanaAsientos.ShowDialog();

            asientoTextbox.Text = VentanaAsientos.asientoSeleccionado;

            comprarButton.Enabled = true;
        }

        private void comprarButton_Click(object sender, EventArgs e)
        {
            Pasajero nuevo = new Pasajero(nombreTextBox.Text, apellidoTextBox.Text, edadTextBox.Text, Int32.Parse(asientoTextbox.Text) - 1, myVuelo.indiceVuelo);
            listaPasajeros.Add(nuevo);

            listaVuelos[cont].contadorAsientos++;

            a = nombreTextBox.Text;
            b = apellidoTextBox.Text;
            c = edadTextBox.Text;

            this.Close();
        }
    }
}
