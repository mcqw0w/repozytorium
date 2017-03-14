using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
     class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;
        private List<Ocena> oceny;

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu) : base(imie, nazwisko, dataUrodzenia)
        {
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;
            oceny = new List<Ocena>();
        }

        public new void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("rok: {0}, grupa: {1}, nr indeksu: {2}", rok, grupa, nrIndeksu);
        }

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            oceny.Add(new Ocena(nazwaPrzedmiotu, data, wartosc));
        }

        public void WypiszOceny()
        {
            foreach (var ocena in oceny)
                ocena.WypiszInfo();
        }

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            foreach (var ocena in oceny)
                if (ocena.NazwaPrzedmiotu == nazwaPrzedmiotu)
                    ocena.WypiszInfo();
        }

        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            Ocena doUsuniecia = oceny.Find(x => x.NazwaPrzedmiotu == nazwaPrzedmiotu && x.Data == data && x.Wartosc == wartosc);

            if (doUsuniecia != null)
                oceny.Remove(doUsuniecia);
        }

        public void UsunOceny()
        {
            oceny = new List<Ocena>();
        }

        public void UsunOceny(string nazwaPrzedmiotu)
        {
            oceny.RemoveAll(x => x.NazwaPrzedmiotu == nazwaPrzedmiotu);
        }
    }
}


