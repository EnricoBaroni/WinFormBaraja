using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBaraja
{
    class Baraja
    {
        private List<Carta> barajaCartas = new List<Carta>();
        Carta carta;
       
        public Baraja()
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 1; j <= 12; j++)
                {
                    carta = new Carta(j, i);
                    barajaCartas.Add(carta);
                }
            }
        }
        //GETTERS Y SETTERS
        public List<Carta> BarajaCartas
        {
            get { return barajaCartas; }
            set { barajaCartas = value; }
        }

        //METODOS
        //NumeroCartas(): Escribe en pantalla cuantas cartas tiene la baraja actualmente.
        public int NumeroCartas()
        {
            //Console.WriteLine("La baraja tiene {0} cartas", (barajaCartas.Count));
            return barajaCartas.Count();

        }
        //RobaCarta(): Escribe en pantalla el valor de la primera carta de la baraja,
        //la "saca" de la baraja(elimina de la lista) y la devuelve
        public Carta RobaCarta()
        {
            carta = barajaCartas[0];
            //Console.WriteLine(carta.ToString());
            barajaCartas.RemoveAt(0);
            return carta;
        }
        //CogeCarta(int n): Coge la carta (escribe en pantalla) que está en la posición "n" pasada por parámetro,
        //la saca de la baraja y la devuelve
        public Carta CogeCarta(int n)
        {
            carta = barajaCartas[n];
            //Console.WriteLine(carta.ToString());
            barajaCartas.RemoveAt(n);
            return carta;
        }
        //CogeCartaAlAzar(): Coge una carta (escribe en pantalla) al azar,
        //la saca de la baraja y la devuelve.
        public Carta CogeCartaAlAzar()
        {
            var rnd = new Random();
            int random = rnd.Next(barajaCartas.Count());
            carta = barajaCartas[random];
            //Console.WriteLine(carta.ToString());
            barajaCartas.RemoveAt(random);
            return carta;
        }
        //Barajar(): Mezcla las cartas en la lista.
        public void Barajar()
        {
            var rnd = new Random();
            int random;
            int numeroCartas = 0;
            List<Carta> barajaRandom = new List<Carta>();
            //Rellenamos la lista nueva y vaciamos la original
            for (int i = 0; i < barajaCartas.Count(); i++)
            {
                barajaRandom.Add(barajaCartas[i]);
            }
            barajaCartas.Clear();
            //Mientras el numero random no este en la lista nueva, lo metemos
            do
            {
                random = rnd.Next(barajaRandom.Count());
                while (barajaCartas.Contains(barajaRandom[random]) == false)
                {
                    barajaCartas.Add(barajaRandom[random]);
                    numeroCartas++;
                }
            } while (numeroCartas < barajaRandom.Count());
        }
        //ToString(): Escribe el nombre de todas las cartas de la baraja (una por línea).
        public override string ToString()
        {
            for (int i = 0; i < barajaCartas.Count(); i++)
            {
                //Console.WriteLine(barajaCartas[i].ToString());
            }
            return "La baraja contiene estas cartas";
        }
    }
}
