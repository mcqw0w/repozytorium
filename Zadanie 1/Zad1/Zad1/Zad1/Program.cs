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
            samochod audi = new samochod("Audi", 4, 60);
            samochod citroen = new samochod("Citroen",4,100,"Biały",2014);
            samochod fiat = new samochod("Fiat", 4, 0);

            audi.Jedz(60.0);
            citroen.Jedz(100.0);
            fiat.Jedz(10.0);

            audi.Hamuj();
            citroen.Hamuj();
            fiat.Hamuj();

           
            Console.WriteLine(audi);
            Console.WriteLine(citroen);
            Console.WriteLine(fiat);
            Console.ReadKey();
            
        }
    }
}
