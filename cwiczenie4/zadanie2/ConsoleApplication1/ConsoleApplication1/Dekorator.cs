using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Dekorator : ITelefon
    {
        ITelefon _Itelefon;
        string _Typ;
        public Dekorator(ITelefon _itelefon, string _typ)
        {
            _Itelefon = _itelefon;
            _Typ = _typ;
        }
        public void WybierzNumer(string numer)
        {
            _Itelefon.WybierzNumer(numer);
        }

        public void WyslijWiadomosc(string numer, string tresc)
        {
            _Itelefon.WyslijWiadomosc(numer, tresc);
        }

        public void PokazTyp()
        {
            Console.WriteLine("telefon typu : {0}", _Typ);
        }
    }
}
