using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Telefon
    {
        public string Nazwa { get; private set; }
        public IObudowa Obudowa { get; private set; }
        public IEkran Ekran { get; private set; }

        public Telefon(string nazwa, IFabryka fabryka)
        {
            Nazwa = nazwa;
            Obudowa = fabryka.TworzObudowe();
            Ekran = fabryka.TworzEkran();
        }

        public void Tworz()
        {
            Console.WriteLine("Telefon: {0}", Nazwa);
            Obudowa.Towrz();
            Ekran.Tworz();
            Console.WriteLine("Budowa zakończona");
        }
    }
}
