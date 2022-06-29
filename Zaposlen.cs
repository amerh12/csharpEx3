using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNaloga4
{
    internal class Zaposlen
    {
        public string _ime;
        public string _priimek;
        public double _placa;
       


        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }
        public string Priimek
        {
            get { return _priimek; }
                set { _priimek = value; }
        }
        public double Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public double RealnaPlaca (double podanOdstotek){


            double odstotekVdenarju = (podanOdstotek * 100) / _placa;
            double povecanaPlaca = _placa + odstotekVdenarju;
            return povecanaPlaca;

        
        }
        public override string ToString()
        {

            double urnaPostavka = _placa / 176;

            return Convert.ToString(urnaPostavka);


        }


    }
}
