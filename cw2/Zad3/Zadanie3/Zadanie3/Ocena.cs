using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Ocena
    {
        public string NazwaPrzedmiotu { get { return nazwaPrzedmiotu; } }
        public string Data { get { return data; } }
        public double Wartosc { get { return wartosc; } }
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public Ocena(string nazwaPrzedmiotu, string data, double wartosc)
        {
            this.nazwaPrzedmiotu = nazwaPrzedmiotu;
            this.data = data;
            this.wartosc = wartosc;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Przedmiot: {0}, ocena: {1:0.0}, data: {2}", nazwaPrzedmiotu, wartosc, data);
        }
    }
}
