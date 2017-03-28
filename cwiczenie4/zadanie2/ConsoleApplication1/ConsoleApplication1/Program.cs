using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ZwyklyTelefon stary = new ZwyklyTelefon("Plastik");
            ZwyklyTelefon nowy = new ZwyklyTelefon("Cegla");
            Smartphone htc = new Smartphone(nowy, "Nowy");

            stary.WyslijWiadomosc("25887512", "Wszystko działa");
            htc.zdjecie();

            Console.ReadLine();
        }
    }
}
