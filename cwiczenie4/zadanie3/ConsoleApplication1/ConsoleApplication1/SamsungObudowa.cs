using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SamsungObudowa : IObudowa
    {
        public void Towrz()
        {
            Console.WriteLine("Tworzę obudowę dla Samsunga");
        }
    }
}
