using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder_Airlines
{
    public class Pasajero
    {
        public string nombre;
        public string apellido;
        public string edad;
        public int numeroAsiento;
        public int indiceVuelo;
        
        public Pasajero(string nombre, string apellido, string edad, int numeroAsiento, int indiceVuelo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.numeroAsiento = numeroAsiento;
            this.indiceVuelo = indiceVuelo;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "  Apellido: " + apellido + "  Asiento: " + numeroAsiento + "  Indice: " + indiceVuelo;
        }
    }

    public class listaPasajeros : List<Pasajero>
    {
        
    }
}
