using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            AstonMartin AM = new AstonMartin();
            wypisz(AM);

            RangeRover RR = new RangeRover();
            wypisz(RR);

            RollsRoyce RR2 = new RollsRoyce();
            wypisz(RR2);

            Console.ReadKey();
        }

        static void wypisz(ISamochod samochod)
        {
            Console.WriteLine(samochod.WypiszMarke() + "\n" + samochod.WypiszSalon() + "\n");
        }
    }
}
