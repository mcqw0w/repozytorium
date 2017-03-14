using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StandardowyCzlowiek> ludzie = new List<StandardowyCzlowiek>();

            ludzie.Add(new StandardowyCzlowiek("Sebastian", 17, "Olsztyn"));
            ludzie.Add(new StandardowyCzlowiek("Maja", 16, "Warszawa"));
            ludzie.Add(new StandardowyCzlowiek("Czarek", 11, "Bartoszyce"));
            ludzie.Add(new StandardowyCzlowiek("Kamil", 21, "Brodnica"));
            ludzie.Add(new StandardowyCzlowiek("Grzegorz", 56, "Wąbrzeźno"));

            double sredniaWieku = (double)ludzie.Sum(x => x.Wiek) / ludzie.Count;

            Console.WriteLine("Srednia wieku {0}", sredniaWieku);

            foreach (var czlowiek in ludzie)
                Console.WriteLine(czlowiek.Imie);

            foreach (var czlowiek in ludzie)
                Console.WriteLine(czlowiek);

            Dictionary<string, int> miasta = new Dictionary<string, int>();

            foreach (var czlowiek in ludzie)
            {
                if (miasta.ContainsKey(czlowiek.Pochodzenie))
                    miasta[czlowiek.Pochodzenie]++;
                else
                    miasta.Add(czlowiek.Pochodzenie, 0);
            }

            string najczesciejWystepujaceMiasto = miasta.OrderByDescending(x => x.Value).First().Key;

            Console.WriteLine("Najczesciej wystepujace miasto {0}", najczesciejWystepujaceMiasto);

            Console.ReadKey();
        }
    }
}
