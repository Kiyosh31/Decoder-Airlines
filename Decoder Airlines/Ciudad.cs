using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder_Airlines
{
    public class Ciudad
    {
        public string nombre;
        public int x, y;

        public Ciudad(string nombre, int x, int y)
        {
            this.nombre = nombre;
            this.x = x;
            this.y = y;
        }
        public listaAristas myListaAristas = new listaAristas();
    }

    public class listaListas
    {
        public string nombre;
        public int x;
        public int y;

        public List<Ciudad> ciudades = new List<Ciudad>();
    }

    public class Arista
    {
        public string origen;
        public string destino;
        public int ponderacion;
        public int indice;
        public int costo;
    }

    public class listaAristas : List<Arista>
    {

    }

    public class listaCiudades : List<Ciudad>
    {
        public listaCiudades()
        {

        }
    }
}
