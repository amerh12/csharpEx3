using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNaloga4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Zaposlen DelavecEna = new Zaposlen();

            DelavecEna.Ime = "Ziga";
            DelavecEna.Priimek = "Zerjav";
            DelavecEna.Placa = 1024.35;

            /*DelavecEna.RealnaPlaca(3.5); - NIKJER NI PISAL DA MORAM IZPISAT POVEČANO PLAČO TAKO DA METODO, KAKO TO NAREST IMATE V RAZREDU ZAPOSLEN
            V TEM KOMENTARJU JE PRIKAZANO KAKO BI KLICAL METODO
            */


            Console.WriteLine("Delavec " + DelavecEna.Ime +  " " + DelavecEna.Priimek + " ima urno postavko: " + DelavecEna.ToString());

        }
    }
}
