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
            Telefon samsung = new Telefon("Samsung", new FabrykaSamsung());
            Telefon apple = new Telefon("Apple", new FabrykaApple());

            samsung.Tworz();
            apple.Tworz();

            Console.ReadKey();
        }
    }
}
