using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AppleObudowa : IObudowa
    {
        public void Towrz()
        {
            Console.WriteLine("Tworzę obudowę dla Apple");
        }
    }
}
