using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SamsungEkran : IEkran
    {
        public void Tworz()
        {
            Console.WriteLine("Tworzę ekran dla Samsunga");
        }
    }
}
