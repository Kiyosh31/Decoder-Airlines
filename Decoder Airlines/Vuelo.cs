using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Decoder_Airlines
{
    public class Vuelo : IComparable<Vuelo>
    {
        public string origen, destino;
        public string fecha;

        public int costo;
        public int tiempo;
        public int contadorAsientos = 0;
        public int indiceVuelo;

        public bool[] indice = new bool[40];

        public Vuelo(string origen, string destino, int costo, int tiempo, string fecha, int indiceVuelo, int contadorAsientos)
        {
            this.origen = origen;
            this.destino = destino;
            this.costo = costo;
            this.tiempo = tiempo;
            this.fecha = fecha;
            this.indiceVuelo = indiceVuelo;
            this.contadorAsientos = contadorAsientos;

            for (int i = 0; i < 40; i++)
                indice[i] = true;
        }

        public override string ToString()
        {
            return "Origen: " + origen + " Destino: " + destino + "" + " Indice: " + indiceVuelo;
        }

        public int CompareTo(Vuelo other)
        {
            if (this.contadorAsientos < other.contadorAsientos)
                return 1;
            else if (this.contadorAsientos > other.contadorAsientos)
                return -1;
            else
                return 0;
        }
    }

    public class listaVuelos : List<Vuelo>
    {
        public void quickSortAsientos(int primero, int ultimo)
        {
            int i, j, central;
            Vuelo pivote;
            central = (primero + ultimo) / 2;
            pivote = this[central];
            i = primero;
            j = ultimo;
            do
            {
                while (this[i].contadorAsientos < pivote.contadorAsientos) i++;
                while (this[j].contadorAsientos > pivote.contadorAsientos) j--;
                if (i <= j)
                {
                    Vuelo temp;
                    temp = this[i];
                    this[i] = this[j];
                    this[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quickSortAsientos(primero, j);
            }
            if (i < ultimo)
            {
                quickSortAsientos(i, ultimo);
            }
        }

        public void quickSortFecha(int primero, int ultimo)
        {
            int i, j, central;
            Vuelo pivote;
            central = (primero + ultimo) / 2;
            pivote = this[central];
            i = primero;
            j = ultimo;
            do
            {
                while (Int32.Parse(this[i].fecha) < Int32.Parse(pivote.fecha)) i++;
                while (Int32.Parse(this[j].fecha) > Int32.Parse(pivote.fecha)) j--;
                if (i <= j)
                {
                    Vuelo temp;
                    temp = this[i];
                    this[i] = this[j];
                    this[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quickSortFecha(primero, j);
            }
            if (i < ultimo)
            {
                quickSortFecha(i, ultimo);
            }
        }
    }
}
