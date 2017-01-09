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
    public partial class registroVuelo : Form
    {
        listaVuelos listaVuelos;
        listaCiudades listaCiudades;

        public string fecha;
        public int indiceVuelo;
        public int contadorAsientos;

        public int x;
        public int y;

        public registroVuelo(ref listaVuelos refListaVuelos, ref listaCiudades refListaCiudades)
        {
            InitializeComponent();

            this.listaVuelos = refListaVuelos;
            this.listaCiudades = refListaCiudades;

            registroButton.Enabled = false;
            destinoTextBox.Enabled = false;
            precioTextBox.Enabled = false;
            tiempoTextBox.Enabled = false;
            dateTimePicker1.Enabled = false;

            if (refListaVuelos.Count() == 0)
            {
                indiceVuelo = -1;
            }
            else
            {
                indiceVuelo = refListaVuelos[refListaVuelos.Count - 1].indiceVuelo;
            }
        }

        private void registroVuelo_Load(object sender, EventArgs e)
        {
            precioTextBox.Enabled = false;
        }

        private void origenTextBox_TextChanged(object sender, EventArgs e)
        {
            destinoTextBox.Enabled = true;
        }

        private void destinoTextBox_TextChanged(object sender, EventArgs e)
        {
            precioTextBox.Enabled = true;
        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {
            tiempoTextBox.Enabled = true;
        }

        private void tiempoTextBox_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        { 
            registroButton.Enabled = true;
        }

        private void registroButton_Click(object sender, EventArgs e)
        {
            fecha = dateTimePicker1.Value.ToString("ddMMyyyy");
            indiceVuelo++;
            Vuelo vueloN = new Vuelo(origenTextBox.Text, destinoTextBox.Text, Int32.Parse(precioTextBox.Text), Int32.Parse(tiempoTextBox.Text), fecha, indiceVuelo, contadorAsientos);
            listaVuelos.Add(vueloN);

            bool bandera = false;
            bool bandera1 = false;

            foreach(Ciudad myCiudad in listaCiudades)
            {
                if(myCiudad.nombre.ToString() == origenTextBox.Text)
                {
                    bandera = true;
                }
                if(myCiudad.nombre.ToString() == destinoTextBox.Text)
                {
                    bandera1 = true;
                }
            }

            if(bandera == false)
            {
                AgregarXY agregarxy = new AgregarXY(origenTextBox.Text);
                agregarxy.ShowDialog();

                Ciudad nuevo = new Ciudad(origenTextBox.Text.ToString(), agregarxy.x, agregarxy.y);
                listaCiudades.Add(nuevo);
            }

            if (bandera1 == false)
            {
                AgregarXY agregarxy = new AgregarXY(destinoTextBox.Text);
                agregarxy.ShowDialog();

                Ciudad nuevo = new Ciudad(destinoTextBox.Text.ToString(), agregarxy.x, agregarxy.y);
                listaCiudades.Add(nuevo);
            }
            this.Close();
        }
    }
}
