using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KontoBankowe> konta = new List<KontoBankowe>();

            konta.Add(new KontoBankowe("Kamil", "Bąbel", "99251", 30.0, 0));
            konta.Add(new KontoBankowe("Maja", "Pszczółka", "12345", 700.0, 1));
            konta.Add(new KontoBankowe("Sebastian", "Aspol", "77752", 5000.0, 2));

            foreach (var konto in konta)
                Console.WriteLine(konto);

            konta[0].WplacPieniadze(150.0);
            konta[1].DodajOdsetki();
            konta[2].UsunKonto();

            foreach (var konto in konta)
                Console.WriteLine(konto);

            konta = konta.FindAll(x => x.DoUsuniecia == false).ToList();

            foreach (var konto in konta)
                Console.WriteLine(konto);

            Console.ReadKey();
        }
    }
}
