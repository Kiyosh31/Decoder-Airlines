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
    public partial class Propuesta : Form
    {
        List<string> temporal;
        listaVuelos listaVuelos;
        listaPasajeros listaPasajeros;

        public Propuesta(ref List<string> refTemporal, int total, int total2, int unoOdos, string origen, string destino, ref listaVuelos refListaVuelos, ref listaPasajeros refListaPasajeros)
        {
            InitializeComponent();

            this.listaVuelos = refListaVuelos;
            this.listaPasajeros = refListaPasajeros;
            this.temporal = refTemporal;
 
            vuelosTotalesLabel.Text = (temporal.Count - 1).ToString();
            origenLabel.Text = origen;
            destinoLabel.Text = destino;

            if (unoOdos == 1)
            {
                tiempoLabel.Text = total.ToString() + " min.";
                costoLabel.Text = "$" + total2.ToString();
            }
            else if (unoOdos == 2)
            {
                costoLabel.Text = "$" + total.ToString();
                tiempoLabel.Text = total2.ToString() + " min.";
            }
            verListBox();
        }

        public void verListBox()
        {
            for (int i = temporal.Count - 1; i > 0; i--)
            {
                foreach (Vuelo myVuelo in listaVuelos)
                {
                    if (temporal[i] == myVuelo.origen && temporal[i - 1] == myVuelo.destino)
                    {
                        vuelosListBox.Items.Add(myVuelo.ToString());
                    }
                }
            }
        }

        private void aceptarbutton_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string apellido = "";
            string edad = "";

            int button_informacion = 0;

            for (int i = temporal.Count - 1; i > 0; i--)
            {
                foreach (Vuelo myVuelo in listaVuelos)
                {
                    if (temporal[i] == myVuelo.origen && temporal[i - 1] == myVuelo.destino)
                    {
                        ComprarPropuesta VentanaPropuesta = new ComprarPropuesta(myVuelo, ref listaVuelos, ref listaPasajeros, button_informacion, nombre, edad, apellido);
                        VentanaPropuesta.ShowDialog();

                        button_informacion++;

                        nombre = VentanaPropuesta.a;
                        apellido = VentanaPropuesta.b;
                        edad = VentanaPropuesta.c;
                    }
                }
            }
            MessageBox.Show("Gracias por su Compra!");
            this.Close();
        }
    }
}
