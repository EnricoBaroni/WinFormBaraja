using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBaraja
{
    class Carta
    {
        private int numero;
        private string[] palos = {"Diamantes", "Picas", "Corazones", "Treboles" };
        private int palo;
        private string file;

        //Constructor
        public Carta(int numeroCarta, int paloCarta)
        {
            numero = numeroCarta;
            palo = paloCarta;
            file = numeroCarta + " " + palos[palo] + ".png";
        }
        public override string ToString()
        {
            return (numero + " de " + palos[palo]);
        }
        
        //GETTERS Y SETTERS
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Palo
        {
            get { return palo; }
            set { palo = value; }
        }
        public string File
        {
            get { return file; }
            set { file = value; }
        }
    }
}
