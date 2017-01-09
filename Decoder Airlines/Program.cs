using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Decoder_Airlines
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            listaVuelos listaVuelos = new listaVuelos();
            listaPasajeros listaPasajeros = new listaPasajeros();
            listaCiudades listaCiudades = new listaCiudades();


            // Leer Vuelos
            StreamReader Leer;
            Leer = new StreamReader("Vuelos.txt");

            while (!Leer.EndOfStream)
            {
                string lineas = Leer.ReadLine();
                char delimitador = ('|');
                string[] palabras = lineas.Split(delimitador);
          
                Vuelo vueloN = new Vuelo(palabras[0], palabras[1], int.Parse(palabras[3]), int.Parse(palabras[2]), palabras[4], Int32.Parse(palabras[5]), Int32.Parse(palabras[6]));
                listaVuelos.Add(vueloN);
            }
            Leer.Close();



            // Leer Pasajeros
            StreamReader LeerPasajeros;
            LeerPasajeros = new StreamReader("Pasajeros.txt");

            while(!LeerPasajeros.EndOfStream)
            {
                string lineas = LeerPasajeros.ReadLine();
                char delimitador = ('|');
                string[] palabras = lineas.Split(delimitador);

                Pasajero pasajeroN = new Pasajero(palabras[0], palabras[1], palabras[2], Int32.Parse(palabras[3]), Int32.Parse(palabras[4]));
                listaPasajeros.Add(pasajeroN);
            }
            LeerPasajeros.Close();

           for(int i = 0; i < listaPasajeros.Count(); i++)
            {
                for(int j = 0; j < listaVuelos.Count(); j++)
                {
                    if(listaPasajeros[i].indiceVuelo == listaVuelos[j].contadorAsientos)
                    {
                        listaVuelos[j].indice[listaPasajeros[i].numeroAsiento - 1] = false;
                    }
                }
            }

           
            //Leer Ciudades
            StreamReader LeerCiudades;
            LeerCiudades = new StreamReader("Ciudades.txt");

            while(!LeerCiudades.EndOfStream)
            {
                string lineas = LeerCiudades.ReadLine();
                char delimitador = ('|');
                string[] palabras = lineas.Split(delimitador);

                Ciudad ciudadN = new Ciudad(palabras[0], Int32.Parse(palabras[1]), Int32.Parse(palabras[2]));
                listaCiudades.Add(ciudadN);
            }
            LeerCiudades.Close();

            
            // Insertar aristas
            foreach (Ciudad myCiudad in listaCiudades)
            {
                foreach (Vuelo myVuelo in listaVuelos)
                {
                    if (myCiudad.nombre == myVuelo.origen)
                    {
                        int cont = 0;

                        Arista nuevaArista = new Arista();

                        nuevaArista.origen = myVuelo.origen;
                        nuevaArista.destino = myVuelo.destino;
                        nuevaArista.costo = myVuelo.costo;

                        foreach (Ciudad otherCiudad in listaCiudades)
                        {
                            if (otherCiudad.nombre == myVuelo.destino)
                            {
                                nuevaArista.indice = cont;
                                break;
                            }
                            cont++;
                        }

                        myCiudad.myListaAristas.Add(nuevaArista);
                    }
                }
            }
            




            Application.Run(new Principal(ref listaVuelos, ref listaPasajeros, ref listaCiudades));




            //Escribir Vuelos
            StreamWriter Escribir = new StreamWriter("Vuelos.txt");
            foreach (Vuelo objeto in listaVuelos)
            {
                Escribir.WriteLine(objeto.origen.ToString() + '|' + objeto.destino.ToString() + '|' + objeto.costo + '|' + objeto.tiempo + '|' + objeto.fecha + '|' + objeto.indiceVuelo + '|' + objeto.contadorAsientos);
            }
            Escribir.Close();


            //Escribir Pasajeros
            StreamWriter EscribirPasajero = new StreamWriter("Pasajeros.txt");
            foreach(Pasajero objeto in listaPasajeros)
            {
                EscribirPasajero.WriteLine(objeto.nombre + "|" + objeto.apellido + "|" + objeto.edad + "|" + objeto.numeroAsiento + "|" + objeto.indiceVuelo);
            }
            EscribirPasajero.Close();

            
            //Escribir Ciudades
            StreamWriter EscribirCiudades = new StreamWriter("Ciudades.txt");
            foreach(Ciudad myCiudad in listaCiudades)
            {
                EscribirCiudades.WriteLine(myCiudad.nombre + '|' + myCiudad.x + '|' + myCiudad.y);
            }
            EscribirCiudades.Close();
        }
    }
}
