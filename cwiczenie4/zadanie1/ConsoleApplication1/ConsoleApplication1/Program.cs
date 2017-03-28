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
            Uczelnia UWM = new Uczelnia(DateTime.Parse("2018/10/09"));
            Uczelnia Stamford = new Uczelnia(DateTime.Parse("2018/12/12"));

            Console.WriteLine(UWM.RekrutujStudentow());
            Console.WriteLine(Stamford.RekrutujStudentow());
            Console.ReadLine();
        }
    }
}
