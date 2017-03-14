using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class KontoBankowe
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public string NrKonta { get; private set; }
        public double FunduszeNaKoncie { get; private set; }
        private int id { get; set; }
        public bool DoUsuniecia { get; private set; }

        public KontoBankowe(string imie, string nazwisko, string nrKonta, double funduszeNaKoncie, int id)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NrKonta = nrKonta;
            FunduszeNaKoncie = funduszeNaKoncie;
            this.id = id;
            DoUsuniecia = false;
        }

        public void WplacPieniadze(double kwota)
        {
            if (kwota > 0)
                FunduszeNaKoncie += kwota;

            Console.WriteLine("Stan konta po wplacie {0}\n", FunduszeNaKoncie);
        }

        public void ZmienFundusze(double kwota)
        {
            FunduszeNaKoncie = kwota;

            Console.WriteLine("Stan konta po zmianie {0}\n", FunduszeNaKoncie);
        }

        public void DodajOdsetki()
        {
            FunduszeNaKoncie *= 1.1;

            Console.WriteLine("Stan konta po dodaniu odsetek {0}\n", FunduszeNaKoncie);
        }

        public void UsunKonto()
        {
            DoUsuniecia = true;

            Console.WriteLine("Konto do usuniecia\n");
        }

        public void WyplacPieniadze(double kwota)
        {
            if (kwota <= FunduszeNaKoncie)
                FunduszeNaKoncie -= kwota;

            Console.WriteLine("Stan konta po wyplacie {0}\n", FunduszeNaKoncie);
        }

        public override string ToString()
        {
            string doUsuniecia = DoUsuniecia ? "Tak" : "Nie";
            return string.Format("Wlascicielem konta o nr konta {0} jest {1} {2} stan konta: {3}, do usuniecia: {4}\n", NrKonta, Imie, Nazwisko, FunduszeNaKoncie, doUsuniecia);
        }
    }
}
