using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ZwyklyTelefon : ITelefon
    {
        private string Typ;

        public ZwyklyTelefon(string typ)
        {
            Typ = typ;
        }
        public void WybierzNumer(string numer)
        {
            Console.WriteLine("Wybiera nr {0}", numer);
        }

        public void WyslijWiadomosc(string numer, string tresc)
        {
            Console.WriteLine("Napisal: {0} do {1}", tresc, numer);
        }

        public void PokazTyp()
        {
            Console.WriteLine("Telefon jest typu : {0}", Typ);
        }
    }
}
