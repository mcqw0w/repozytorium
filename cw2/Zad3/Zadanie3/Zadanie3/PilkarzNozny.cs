using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub, int liczbaGoli)
            : base(imie, nazwisko, dataUrodzenia, pozycja, klub, liczbaGoli)
        {
        }

        public new void StrzelGola()
        {
            Console.WriteLine("Gol {0} {1}", imie, nazwisko);
        }
    }
}
