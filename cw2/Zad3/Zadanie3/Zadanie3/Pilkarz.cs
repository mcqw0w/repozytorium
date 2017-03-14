using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub, int liczbaGoli)
            : base(imie, nazwisko, dataUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;
            this.liczbaGoli = liczbaGoli;
        }

        public new void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("pozycja: {0}, klub {1}, liczba goli: {2}", pozycja, klub, liczbaGoli);
        }

        public void StrzelGola()
        {
            Console.WriteLine("Goooooool {0} {1}", imie, nazwisko);
        }
    }
}
