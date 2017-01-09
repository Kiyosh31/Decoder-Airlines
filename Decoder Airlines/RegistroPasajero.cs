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
    public partial class RegistroPasajero : Form
    {
        listaVuelos listaVuelos;
        listaPasajeros listaPasajeros;

        int indiceVuelo;
        int indicePasajero;

        public RegistroPasajero(ref listaVuelos refListaVuelos, int indiceVuelo, ref listaPasajeros listaPasajeros)
        {
            InitializeComponent();
            this.listaVuelos = refListaVuelos;
            this.indiceVuelo = indiceVuelo;
            this.listaPasajeros = listaPasajeros;

            //Inicializo los asientos ocupados en el vuelo correspondiente
            foreach(Pasajero myPasajero in listaPasajeros)
            {
                foreach(Vuelo myVuelo in listaVuelos)
                {
                    if(myPasajero.indiceVuelo == myVuelo.indiceVuelo)
                    {
                        myVuelo.indice[myPasajero.numeroAsiento - 1] = false;
                    }
                }
            }

            //actualizo el indice del pasajero para que sea congruente con el del vuelo
            if(listaVuelos.Count() == 0)
            {
                indiceVuelo = -1;
            }
            else
            {
                indiceVuelo = refListaVuelos[refListaVuelos.Count - 1].indiceVuelo;
            }
            
            verPasajeros();

            asientostextBox.Enabled = false;
            comprarButton.Enabled = false;
            borrarButton.Enabled = false;
            comprarButton.Enabled = false;
            asientosButton.Enabled = false;
            apellidoTextBox.Enabled = false;
            edadTextBox.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Asientos VentanaAsientos = new Asientos(ref listaVuelos, ref listaPasajeros, indiceVuelo);
            VentanaAsientos.ShowDialog();
            asientostextBox.Text = VentanaAsientos.getAsiento();
            comprarButton.Enabled = true;
        }

        private void comprarButton_Click(object sender, EventArgs e)
        {
            listaVuelos[indiceVuelo].indice[Int32.Parse(asientostextBox.Text) - 1] = false;
            listaVuelos[indiceVuelo].contadorAsientos++;

            Pasajero NuevoPasajero = new Pasajero(nombreTextBox.Text, apellidoTextBox.Text, edadTextBox.Text, Int32.Parse(asientostextBox.Text), indiceVuelo);
            listaPasajeros.Add(NuevoPasajero);

            this.Close();
        }

        private void verPasajeros()
        {
            foreach(Pasajero pasajero in this.listaPasajeros)
            {
                this.listBox1.Items.Add(pasajero.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indicePasajero = listBox1.SelectedIndex;
            borrarButton.Enabled = true;
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            int a = 0;
            foreach(Vuelo myVuelo in listaVuelos)
            {
                if(myVuelo.indiceVuelo == listaPasajeros[listBox1.SelectedIndex].indiceVuelo)
                {
                    break;
                }
                a++;
            }

            listaVuelos[a].indice[listaPasajeros[listBox1.SelectedIndex].numeroAsiento - 1] = true;
            listaPasajeros.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Clear();
            verPasajeros();

            borrarButton.Enabled = false;
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            apellidoTextBox.Enabled = true;
        }

        private void apellidoTextBox_TextChanged(object sender, EventArgs e)
        {
            edadTextBox.Enabled = true;
        }

        private void edadTextBox_TextChanged(object sender, EventArgs e)
        {
            asientosButton.Enabled = true;
        }

        private void buscarTextBox(object sender, EventArgs e)
        {
            //System.Console.WriteLine("llamado funcion");
            if (buscarCTextBox.Text == "")
            {
                verPasajeros();
            }
            else
            {
                foreach (Pasajero myPasajero in this.listaPasajeros)
                {
                    if (buscarCTextBox.Text == myPasajero.nombre)
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add(myPasajero.ToString());
                    }

                    if (buscarCTextBox.Text == "")
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add(myPasajero.ToString());
                    }
                }
            }
        }
    }
}
