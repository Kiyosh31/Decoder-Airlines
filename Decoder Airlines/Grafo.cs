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
    public partial class Grafo : Form
    {
        listaCiudades listaCiudades;
        listaVuelos listaVuelos;
        listaPasajeros listaPasajeros;

        public int unoOdos = 1;
        public int total, total2;

        List<string> temporal = new List<string>();

        public Grafo(ref listaCiudades refListaCiudades, ref listaVuelos refListaVuelos, ref listaPasajeros refListaPasajeros)
        {
            InitializeComponent();

            this.listaCiudades = refListaCiudades;
            this.listaVuelos = refListaVuelos;
            this.listaPasajeros = refListaPasajeros;

            eliminarCiudadButton.Enabled = false;
            dijkstraButton.Enabled = false;
            propuestaButton.Enabled = false;
            barataButton.Enabled = false;
            cortaButton.Enabled = false;
        }

        public void pintarVertices()
        {
            Pen pen1 = new Pen(Color.Blue, 5);
            Font font = new Font("Gorgia", 16);
            SolidBrush brush = new SolidBrush(Color.Green);

            foreach (Ciudad myCiudad in listaCiudades)
            {
                mexicoPictureBox.CreateGraphics().DrawEllipse(pen1, myCiudad.x, myCiudad.y, 10, 10);
                mexicoPictureBox.CreateGraphics().DrawString(myCiudad.nombre, font, brush, myCiudad.x, myCiudad.y);
            }
        }

        public void pintarAristas()
        {
            Pen pen2 = new Pen(Color.Black, 7);
            pen2.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            foreach (Ciudad myCiudad in listaCiudades)
            {

                foreach (Arista myArista in myCiudad.myListaAristas)
                {
                    Point point1 = new Point(myCiudad.x, myCiudad.y);
                    Point point2 = new Point(listaCiudades[myArista.indice].x, listaCiudades[myArista.indice].y);

                    mexicoPictureBox.CreateGraphics().DrawLine(pen2, point1, point2);
                }
            }
        }

        private void grafoButton_Click(object sender, EventArgs e)
        {
            pintarVertices();
            pintarAristas();
        }

        // COMIENZA PRIM
        private bool Mi_contain(ref List<Ciudad> L, string a)
        {
            bool flag = false;
            foreach (Ciudad objeto in L)
            {
                if (a == objeto.nombre)
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;
        }

        public Arista aristaMenor(ref List<Ciudad> L)
        {
            quickSort(0, listaVuelos.Count - 1);

            Arista e = new Arista();
            List<Arista> listaAristas = new List<Arista>();

            foreach (Vuelo myVuelo in listaVuelos)
            {
                Arista nuevaArista = new Arista();

                nuevaArista.origen = myVuelo.origen;
                nuevaArista.destino = myVuelo.destino;
                nuevaArista.costo = myVuelo.costo;
                nuevaArista.ponderacion = myVuelo.tiempo;

                listaAristas.Add(nuevaArista);
            }

            for (int i = 0; i < listaAristas.Count; i++)
            {
                e = listaAristas[i];

                if (Mi_contain(ref L, e.origen))
                {
                    if (!Mi_contain(ref L, e.destino))
                    {
                        return e;
                    }
                }

                if (!Mi_contain(ref L, e.origen))
                {
                    if (Mi_contain(ref L, e.destino))
                    {
                        return e;
                    }
                }
            }

            return e;
        }

        private bool encontrarArista(ref List<Ciudad> L, ref Arista e)
        {
            bool encontrado = false;

            foreach (Ciudad myCiudad in L)
            {
                if (myCiudad.nombre == e.origen)
                {
                    encontrado = true;
                    return encontrado;
                }
            }
            return false;
        }

        private void primButton_Click(object sender, EventArgs e)
        {
            List<Ciudad> L = new List<Ciudad>();
            listaAristas ARM = new listaAristas();
            Arista E = new Arista();

            Pen pen1 = new Pen(Color.GreenYellow, 10);
            pen1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            int n = listaCiudades.Count;

            while (L.Count != n)
            {
                int x = 1, y = 1, x2 = 1, y2 = 1;
                E = aristaMenor(ref L);
                ARM.Add(E);

                foreach (Ciudad myCiudad in listaCiudades)
                {
                    if (E.origen == myCiudad.nombre)
                    {
                        x = myCiudad.x;
                        y = myCiudad.y;
                    }
                }

                foreach (Ciudad myCiudad in listaCiudades)
                {
                    if (E.destino == myCiudad.nombre)
                    {
                        x2 = myCiudad.x;
                        y2 = myCiudad.y;
                    }
                }

                mexicoPictureBox.CreateGraphics().DrawLine(pen1, x, y, x2, y2);
                //Console.WriteLine("x: " + x + " Y: " + y + " x2: " + x2 + " Y2: " + y2);

                if (encontrarArista(ref L, ref E))
                {
                    Ciudad n1 = new Ciudad(E.destino, 0, 0);
                    L.Add(n1);
                }
                else
                {
                    Ciudad n2 = new Ciudad(E.origen, 0, 0);
                    L.Add(n2);
                }
            }
            //ARM.Add(E);
        }

        public void quickSort(int primero, int ultimo)
        {
            int i, j, central;
            Vuelo pivote;
            central = (primero + ultimo) / 2;
            pivote = listaVuelos[central];
            i = primero;
            j = ultimo;

            do
            {
                while (listaVuelos[i].costo < pivote.costo) i++;
                while (listaVuelos[j].costo > pivote.costo) j--;

                if (i <= j)
                {
                    Vuelo temp;
                    temp = listaVuelos[i];
                    listaVuelos[i] = listaVuelos[j];
                    listaVuelos[j] = temp;
                    i++;
                    j--;
                }
            }
            while (i <= j);

            if (primero < j)
            {
                quickSort(primero, j);
            }

            if (i < ultimo)
            {
                quickSort(i, ultimo);
            }
        }
        // TERMINA PRIM



        // COMIENZA KRUSKAL
        private void Kruskal_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = mexicoPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Green, 10);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            List<listaListas> CC = new List<listaListas>();
            listaAristas T = new listaAristas();

            foreach (Ciudad myCiudad in listaCiudades)
            {
                listaListas nuevo = new listaListas();

                nuevo.nombre = myCiudad.nombre;
                nuevo.x = myCiudad.x;
                nuevo.y = myCiudad.y;

                CC.Add(nuevo);
            }

            int N = listaCiudades.Count;
            listaAristas A = new listaAristas();
            quickSort(0, listaVuelos.Count - 1);

            foreach (Vuelo myVuelo in listaVuelos)
            {
                Arista nuevo = new Arista();

                nuevo.origen = myVuelo.origen;
                nuevo.destino = myVuelo.destino;
                nuevo.ponderacion = myVuelo.tiempo;

                A.Add(nuevo);
            }

            Arista v = new Arista();

            while (T.Count < N - 1)
            {
                v = A[0];
                A.RemoveAt(0);

                int c1 = 0, c2 = 0;
                bool flag = false;

                foreach (listaListas lista1 in CC)
                {
                    if (lista1.nombre == v.origen)
                    {
                        break;
                    }
                    else
                    {
                        foreach (Ciudad ciudad2 in lista1.ciudades)
                        {
                            if (ciudad2.nombre == v.origen)
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                    if (flag == true)
                    {
                        break;
                    }
                    c1++;
                }
                flag = false;

                foreach (listaListas lista2 in CC)
                {
                    if (lista2.nombre == v.destino)
                    {
                        break;
                    }

                    foreach (Ciudad myCiudad2 in lista2.ciudades)
                    {
                        if (myCiudad2.nombre == v.destino)
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (flag == true)
                    {
                        break;
                    }
                    c2++;
                }

                if (c1 != c2)
                {
                    T.Add(v);
                    MessageBox.Show(v.origen + v.destino);
                    int x = 0, y = 0, x2 = 0, y2 = 0;

                    foreach (Ciudad myCiudad in listaCiudades)
                    {
                        if (myCiudad.nombre == v.origen)
                        {
                            x = myCiudad.x;
                            y = myCiudad.y;
                        }
                    }

                    foreach (Ciudad myCiudad in listaCiudades)
                    {
                        if (myCiudad.nombre == v.destino)
                        {
                            x2 = myCiudad.x;
                            y2 = myCiudad.y;
                        }
                    }

                    papel.DrawLine(pen, x, y, x2, y2);

                    Ciudad nuevo = new Ciudad(CC[c2].nombre, 0, 0);

                    foreach (Ciudad myCiudad in CC[c2].ciudades)
                    {
                        Ciudad nuevo2 = new Ciudad(myCiudad.nombre, 0, 0);

                        nuevo2.nombre = myCiudad.nombre;
                        nuevo2.x = myCiudad.x;
                        nuevo2.y = myCiudad.y;

                        CC[c1].ciudades.Add(nuevo2);
                    }

                    nuevo.nombre = CC[c2].nombre;
                    nuevo.x = CC[c2].x;
                    nuevo.y = CC[c2].y;
                    CC[c1].ciudades.Add(nuevo);
                    CC.RemoveAt(c2);
                }
            }

            foreach (Arista myArista in T)
            {
                Console.WriteLine(myArista.origen);
                Console.WriteLine(myArista.destino);
                Console.WriteLine("--");
            }
        }
        // TERMINA KRUSKAL



        // COMIENZA DIJKSTRA
        private Dijkstra Min(ref listaDijkstra VD)
        {
            Dijkstra menorD = new Dijkstra();
            int menor = 1000;

            foreach (Dijkstra myDijk in VD)
            {
                if (myDijk.distancia < menor && myDijk.def == false)
                {
                    menor = myDijk.distancia;
                    menorD = myDijk;
                }
            }
            return menorD;
        }

        private Ciudad FindD(string nombre)
        {
            Ciudad n = new Ciudad(nombre, 0, 0);

            foreach (Ciudad myCiudad in listaCiudades)
            {
                if (nombre == myCiudad.nombre)
                {
                    n = myCiudad;
                    return n;
                }
            }
            return n;
        }

        private void Actualiza(Dijkstra e, ref listaDijkstra VC)
        {
            Ciudad n = new Ciudad(e.nombre, 0, 0);
            n = FindD(e.nombre);

            foreach (Arista myArista in n.myListaAristas)
            {
                int i = 0;

                foreach (Dijkstra objetoVC in VC)
                {
                    if (myArista.destino == objetoVC.nombre)
                    {
                        break;
                    }
                    i++;
                }

                if ((myArista.ponderacion + e.distancia) < (VC[i].distancia))
                {
                    VC[i].distancia = myArista.ponderacion + e.distancia;
                    VC[i].nodo_ant = e.nombre;
                }
            }
        }

        private void ActualizaCosto(Dijkstra e, ref listaDijkstra VC)
        {
            Ciudad n = new Ciudad(e.nombre, 0, 0);
            n = FindD(e.nombre);

            foreach (Arista myArista in n.myListaAristas)
            {
                int i = 0;

                foreach (Dijkstra objetoVC in VC)
                {
                    if (myArista.destino == objetoVC.nombre)
                    {
                        break;
                    }
                    i++;
                }

                if ((myArista.costo + e.distancia) < (VC[i].distancia))
                {
                    VC[i].distancia = myArista.costo + e.distancia;
                    VC[i].nodo_ant = e.nombre;
                }
            }
        }

        private void dijkstraButton_Click(object sender, EventArgs e)
        {
            string nodo_seleccionado = origenTextBox.Text;

            Graphics papel;
            papel = mexicoPictureBox.CreateGraphics();
            Pen lapiz1 = new Pen(Color.Green, 10);
            Pen lapiz2 = new Pen(Color.Red, 3);
            int infinito = 0;

            foreach (Vuelo objeto in listaVuelos)
            {
                infinito += objeto.tiempo;
            }

            listaDijkstra VD = new listaDijkstra();

            foreach (Ciudad objeto in listaCiudades)
            {
                Dijkstra nuevo = new Dijkstra();
                nuevo.nombre = objeto.nombre;
                nuevo.distancia = infinito + 10;
                VD.Add(nuevo);
            }

            int nDef = 0;
            Dijkstra nodo_Act = new Dijkstra();

            foreach (Ciudad objeto in listaCiudades)
            {
                if (objeto.nombre == nodo_seleccionado)
                {
                    papel.DrawEllipse(lapiz1, objeto.x, objeto.y, 10, 10);
                }
            }

            nodo_Act.nombre = nodo_seleccionado;
            nodo_Act.nodo_ant = nodo_seleccionado;
            nodo_Act.distancia = 0;
            nodo_Act.def = true;

            foreach (Dijkstra objeto in VD)
            {
                if (nodo_Act.nombre == objeto.nombre)
                {
                    objeto.distancia = nodo_Act.distancia;
                    objeto.def = nodo_Act.def;
                    objeto.nodo_ant = nodo_Act.nodo_ant;
                }
            }
            nDef++;

            while (nDef < listaCiudades.Count)
            {
                Actualiza(nodo_Act, ref VD);
                nodo_Act = Min(ref VD);
                foreach (Dijkstra objeto in VD)
                {
                    if (nodo_Act.nombre == objeto.nombre)
                    {
                        objeto.def = true;
                    }
                }
                nodo_Act.def = true;
                nDef++;
            }

            foreach (Dijkstra objeto in VD)
            {
                Console.WriteLine(objeto.nombre);
                Console.WriteLine(objeto.distancia);
                Console.WriteLine(objeto.nodo_ant);
                Console.WriteLine(objeto.def);
            }

            for (int i = VD.Count - 1; i >= 0; i--)
            {
                int x = 0, y = 0, x2 = 0, y2 = 0;

                if (VD[i].nodo_ant.ToString() == "-")
                {
                    break;
                }

                foreach (Ciudad objeto in listaCiudades)
                {
                    if (objeto.nombre == VD[i].nombre)
                    {
                        x = objeto.x;
                        y = objeto.y;
                    }
                }

                foreach (Ciudad objeto in listaCiudades)
                {
                    if (objeto.nombre == Convert.ToString(VD[i].nodo_ant))
                    {
                        x2 = objeto.x;
                        y2 = objeto.y;
                    }
                }
                papel.DrawLine(lapiz2, x, y, x2, y2);
            }

            foreach (Dijkstra Elem in VD)
            {
                temporal.Clear();
                Console.WriteLine(nodo_seleccionado + " -> " + Elem.nombre + ": " + Elem.distancia);

                temporal.Add(Elem.nombre);
                string aux = Elem.nombre;
                int breakeador = 0;

                while (aux != nodo_seleccionado)
                {
                    if (breakeador == VD.Count)
                    {
                        break;
                    }

                    foreach (Dijkstra objeto in VD)
                    {
                        if (objeto.nombre == aux)
                        {
                            temporal.Add(objeto.nodo_ant);
                            aux = objeto.nodo_ant;
                        }
                    }
                    breakeador++;
                }

                Console.WriteLine("Ruta a seguir");
                string cad = "";

                for (int i = temporal.Count - 1; i >= 0; i--)
                {
                    if (i != 0)
                    {
                        if (temporal[i] != temporal[i - 1])
                        {
                            cad += temporal[i] + "->";
                        }
                    }
                }
                Console.Write(cad);
                Console.WriteLine("--");
            }
        }

        private void propuestaButton_Click(object sender, EventArgs e)
        {
            Propuesta VentanaPropuesta = new Propuesta(ref temporal, total, total2, unoOdos, origenTextBox.Text, destinoTextBox.Text, ref listaVuelos, ref listaPasajeros);
            VentanaPropuesta.ShowDialog();
        }

        private void origentextbox_TextChanged(object sender, EventArgs e)
        {
            if(origenTextBox.Text == "")
            {
                
            }
            else
            {
                primButton.Enabled = true;
                dijkstraButton.Enabled = true;
            }
            
        }

        private void destinoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (destinoTextBox.Text == "")
            {
                
            }
            else
            {
                cortaButton.Enabled = true;
                barataButton.Enabled = true;
            }
        }

        private void cortaButton_Click(object sender, EventArgs e)
        {
            string nodo_seleccionado = origenTextBox.Text;

            propuestaButton.Enabled = true;

            Graphics papel;
            papel = mexicoPictureBox.CreateGraphics();
            Pen lapiz1 = new Pen(Color.Green, 10);
            Pen lapiz2 = new Pen(Color.Red, 3);
            int infinito = 0;

            foreach (Vuelo objeto in listaVuelos)
            {
                infinito += objeto.tiempo;
            }

            listaDijkstra VD = new listaDijkstra();

            foreach (Ciudad objeto in listaCiudades)
            {
                Dijkstra nuevo = new Dijkstra();
                nuevo.nombre = objeto.nombre;
                nuevo.distancia = infinito + 10;
                VD.Add(nuevo);
            }

            int nDef = 0;
            Dijkstra nodo_Act = new Dijkstra();

            foreach (Ciudad objeto in listaCiudades)
            {
                if (objeto.nombre == nodo_seleccionado)
                {
                    papel.DrawEllipse(lapiz1, objeto.x, objeto.y, 10, 10);
                }
            }

            nodo_Act.nombre = Convert.ToString(nodo_seleccionado);
            nodo_Act.nodo_ant = nodo_seleccionado;
            nodo_Act.distancia = 0;
            nodo_Act.def = true;

            foreach (Dijkstra objeto in VD)
            {
                if (nodo_Act.nombre == objeto.nombre)
                {
                    objeto.distancia = nodo_Act.distancia;
                    objeto.def = nodo_Act.def;
                    objeto.nodo_ant = nodo_Act.nodo_ant;
                }
            }
            nDef++;

            while (nDef < listaCiudades.Count)
            {
                Actualiza(nodo_Act, ref VD);
                nodo_Act = Min(ref VD);
                foreach (Dijkstra objeto in VD)
                {
                    if (nodo_Act.nombre == objeto.nombre)
                    {
                        objeto.def = true;
                    }
                }
                nodo_Act.def = true;
                nDef++;
            }

            foreach (Dijkstra objeto in VD)
            {
                Console.WriteLine(objeto.nombre);
                Console.WriteLine(objeto.distancia);
                Console.WriteLine(objeto.nodo_ant);
                Console.WriteLine(objeto.def);
            }

            List<string> temporal = new List<string>();
            temporal.Clear();

            foreach (Dijkstra Elem in VD)
            {
                temporal.Clear();
                Console.WriteLine(nodo_seleccionado + " -> " + Elem.nombre + ": " + Elem.distancia);

                temporal.Add(Elem.nombre);
                string aux = Elem.nombre;
                int breakeador = 0;

                while (aux != nodo_seleccionado)
                {
                    if (breakeador == VD.Count)
                    {
                        break;
                    }

                    foreach (Dijkstra myDijkstra in VD)
                    {
                        if (myDijkstra.nombre == aux)
                        {
                            bool f = false;

                            foreach (string temp in temporal)
                            {
                                if (temp == myDijkstra.nodo_ant)
                                {
                                    f = true;
                                }
                            }

                            if (f == false)
                            {
                                temporal.Add(myDijkstra.nodo_ant);
                                aux = myDijkstra.nodo_ant;
                            }
                        }
                    }
                    breakeador++;
                }

                Console.WriteLine("Ruta a seguir");
                for (int i = temporal.Count - 1; i >= 0; i--)
                {
                    if (i != 0)
                    {
                        if (temporal[i] != temporal[i - 1])
                        {
                            Console.WriteLine(temporal[i]);
                        }
                    }
                }

                total = Elem.distancia;

                Console.WriteLine("--");
                if (Elem.nombre.ToString() == destinoTextBox.Text)
                {
                    break;
                }
            }


            total2 = 0;
           

            foreach (string u in temporal)
            {
                Console.WriteLine(u);
            }

            for (int i = temporal.Count - 1; i > 0; i--)
            {
                foreach (Vuelo objeto in listaVuelos)
                {
                    if (temporal[i] == objeto.origen && temporal[i - 1] == objeto.destino)
                    {
                        total2 += objeto.costo;
                    }
                }
            }


            // MOSTRAR LISTA DISPONIBLE
            for (int i = temporal.Count - 1; i > 0; i--)
            {
                int x1 = 0, y1 = 0, x0 = 0, y0 = 0;

                for (int j = 0; j < listaCiudades.Count; j++)
                {
                    if (temporal[i] == listaCiudades[j].nombre)
                    {
                        x1 = listaCiudades[j].x;
                        y1 = listaCiudades[j].y;
                    }
                }

                for (int j = 0; j < listaCiudades.Count; j++)
                {
                    if (temporal[i - 1] == listaCiudades[j].nombre)
                    {
                        x0 = listaCiudades[j].x;
                        y0 = listaCiudades[j].y;
                    }
                }
                papel.DrawLine(lapiz2, x1, y1, x0, y0);
            }
        }

        private void barataButton_Click(object sender, EventArgs e)
        {
            unoOdos = 1;
            string nodo_seleccionado = origenTextBox.Text;

            Graphics papel;
            papel = mexicoPictureBox.CreateGraphics();
            Pen lapiz1 = new Pen(Color.Green, 10);
            Pen lapiz2 = new Pen(Color.Red, 3);
            int infinito = 0;

            foreach (Vuelo objeto in listaVuelos)
            {
                infinito += objeto.tiempo;
            }

            listaDijkstra VD = new listaDijkstra();

            foreach (Ciudad myCiudad in listaCiudades)
            {
                Dijkstra nuevo = new Dijkstra();
                nuevo.nombre = myCiudad.nombre;
                nuevo.distancia = infinito + 10;
                VD.Add(nuevo);
            }

            int nDef = 0;
            Dijkstra nodo_Act = new Dijkstra();

            foreach (Ciudad myCiudad in listaCiudades)
            {
                if (myCiudad.nombre == nodo_seleccionado)
                {
                    papel.DrawEllipse(lapiz1, myCiudad.x, myCiudad.y, 10, 10);
                }
            }

            nodo_Act.nombre = nodo_seleccionado;
            nodo_Act.nodo_ant = nodo_seleccionado;
            nodo_Act.distancia = 0;
            nodo_Act.def = true;

            foreach (Dijkstra myDijkstra in VD)
            {
                if (nodo_Act.nombre == myDijkstra.nombre)
                {
                    myDijkstra.distancia = nodo_Act.distancia;
                    myDijkstra.def = nodo_Act.def;
                    myDijkstra.nodo_ant = nodo_Act.nodo_ant;
                }
            }
            nDef++;

            while (nDef < listaCiudades.Count)
            {
                Actualiza(nodo_Act, ref VD);
                nodo_Act = Min(ref VD);

                foreach (Dijkstra myDijkstra in VD)
                {
                    if (nodo_Act.nombre == myDijkstra.nombre)
                    {
                        myDijkstra.def = true;
                    }
                }
                nodo_Act.def = true;
                nDef++;
            }

            foreach (Dijkstra objeto in VD)
            {
                Console.WriteLine(objeto.nombre);
                Console.WriteLine(objeto.distancia);
                Console.WriteLine(objeto.nodo_ant);
                Console.WriteLine(objeto.def);
            }

            temporal.Clear();

            foreach (Dijkstra Elem in VD)
            {
                temporal.Clear();
                Console.WriteLine(nodo_seleccionado + " -> " + Elem.nombre + ": " + Elem.distancia);

                temporal.Add(Elem.nombre);
                string aux = Elem.nombre;
                int breakeador = 0;

                while (aux != nodo_seleccionado)
                {
                    if (breakeador == VD.Count)
                    {
                        break;
                    }
                    foreach (Dijkstra myDijkstra in VD)
                    {
                        if (myDijkstra.nombre == aux)
                        {
                            bool f = false;

                            foreach (string temp in temporal)
                            {
                                if (temp == myDijkstra.nodo_ant)
                                {
                                    f = true;
                                }
                            }

                            if (f == false)
                            {
                                temporal.Add(myDijkstra.nodo_ant);
                                aux = myDijkstra.nodo_ant;
                            }
                        }
                    }
                    breakeador++;
                }

                Console.WriteLine("Ruta a seguir");
                for (int i = temporal.Count - 1; i >= 0; i--)
                {
                    if (i != 0)
                    {
                        if (temporal[i] != temporal[i - 1])
                            Console.WriteLine(temporal[i]);
                    }
                }
                total = Elem.distancia;
                Console.WriteLine("--");

                if (Elem.nombre.ToString() == destinoTextBox.Text)
                {
                    break;
                }
            }


            total2 = 0;


            foreach (string u in temporal)
            {
                Console.WriteLine(u);
            }
            for (int i = temporal.Count - 1; i > 0; i--)
            {
                foreach (Vuelo myVuelo in listaVuelos)
                {
                    if (temporal[i] == myVuelo.origen && temporal[i - 1] == myVuelo.destino)
                    {
                        total2 += myVuelo.costo;
                    }
                }
            }

            // MOSTRAR LISTA DISPONIBLE
            for (int i = temporal.Count - 1; i > 0; i--)
            {
                int x1 = 0, y1 = 0, x0 = 0, y0 = 0;

                for (int j = 0; j < listaCiudades.Count; j++)
                {
                    if (temporal[i] == listaCiudades[j].nombre)
                    {
                        x1 = listaCiudades[j].x;
                        y1 = listaCiudades[j].y;
                    }
                }

                for (int j = 0; j < listaCiudades.Count; j++)
                {
                    if (temporal[i - 1] == listaCiudades[j].nombre)
                    {
                        x0 = listaCiudades[j].x;
                        y0 = listaCiudades[j].y;
                    }
                }

                papel.DrawLine(lapiz2, x1, y1, x0, y0);
            }
        }

        // TERMINA DIJKSTRA

        private void eliminarCiudadButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaVuelos.Count; i++)
            {
                if (listaVuelos[i].origen == eliminarTextBox.Text || listaVuelos[i].destino == eliminarTextBox.Text)
                {
                    int aux = listaVuelos[i].indiceVuelo;
                    listaVuelos.RemoveAt(i);
                    i--;

                    for (int j = 0; j < listaPasajeros.Count; j++)
                    {
                        if (listaPasajeros[j].indiceVuelo == aux)
                        {
                            listaPasajeros.RemoveAt(j);
                            j--;
                        }
                    }

                    //Elimina la ciudad ingresada en el textBox
                    for (int k = 0; k < listaCiudades.Count; k++)
                    {
                        if (listaCiudades[k].nombre == eliminarTextBox.Text)
                        {
                            listaCiudades.RemoveAt(k);
                            break;
                        }
                    }
                }

                // Elimina Ciudades sin vuelos ligados a ellas
                bool existe = false;

                for (int k = 0; k < listaCiudades.Count; k++)
                {
                    for (int j = 0; j < listaVuelos.Count; j++)
                    {
                        if (listaCiudades[k].nombre == listaVuelos[j].origen || listaCiudades[k].nombre == listaVuelos[j].destino)
                        {
                            existe = true;
                            break;
                        }
                    }

                    if (existe == false)
                    {
                        listaCiudades.RemoveAt(k);
                    }
                }
            }
            this.Close();
        }

        private void eliminarTextBox_TextChanged(object sender, EventArgs e)
        {
            if (eliminarTextBox.Text == "")
            {
                
            }
            else
            {
                eliminarCiudadButton.Enabled = true;
            }
        }
    }
}
