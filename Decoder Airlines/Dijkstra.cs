using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder_Airlines
{
    public class Dijkstra
    {
        public string nombre;
        public int distancia;
        public string nodo_ant = "-";
        public bool def = false;
    }

    public class listaDijkstra : List<Dijkstra>
    {

    }
}
