using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kamil", "Student", "1993/04/17", 1, 3, 875493);
            student.DodajOcene("ZPrOb", "2017/03/14", 5.0);
            student.DodajOcene("ZPrOb", "2017/03/14", 4.0);
            student.DodajOcene("ZPrOb", "2017/03/14", 3.0);
            student.DodajOcene("ZPrOb", "2017/03/14", 2.0);

            student.DodajOcene("PSI", "2017/03/14", 5.0);
            student.DodajOcene("SI", "2017/03/14", 4.0);
            student.DodajOcene("AiOK", "2017/03/14", 3.0);

            student.WypiszInfo();
            student.WypiszOceny();

            Console.WriteLine();

            Console.WriteLine("usun ocene ZPrOb 2017/03/14 2.0");
            student.UsunOcene("ZPrOb", "2017/03/14", 2.0);
            student.WypiszOceny();

            Console.WriteLine();

            Console.WriteLine("usun oceny z ZPrOb");
            student.UsunOceny("ZPrOb");
            student.WypiszOceny();

            Console.WriteLine();

            Console.WriteLine("usun oceny");
            student.UsunOceny();
            student.WypiszOceny();

            Console.WriteLine("-----------------");

            Pilkarz p = new Pilkarz("Mati", "Szczupak", "1991/02/17", "Napastnik", "AA", 5);
            PilkarzReczny pr = new PilkarzReczny("Kamilas", "Kolo", "1997/12/12", "Obrotowy", "BB", 4);
            PilkarzNozny pn = new PilkarzNozny("Krzysiu", "Rzutnik", "1994/03/19", "Pomocnik", "AA", 6);

            p.StrzelGola();
            pr.StrzelGola();
            pn.StrzelGola();

            Console.ReadKey();
        }
    }
}
