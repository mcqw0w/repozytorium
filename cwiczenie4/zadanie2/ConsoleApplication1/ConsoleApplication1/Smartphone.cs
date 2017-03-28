using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Smartphone : Dekorator
    {
        public Smartphone(ZwyklyTelefon zwyklytelefon, string typ)
            : base(zwyklytelefon, typ)
        {

        }
        public void zdjecie()
        {
            Console.WriteLine("Zdjecie zostało zrobione,obraz został zapisany w galerii telefonu");
        }
        public void uruchom(string aplikacja)
        {
            Console.WriteLine("{0} uruchamia sie", aplikacja);
        }
    }
}
