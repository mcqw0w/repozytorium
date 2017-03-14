using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Rzezimieszek : Bohater
    {
        public double Energia { get; private set; }

        public Rzezimieszek(string imie, double hp, double atak, RasaEnum.Rasy rasa, double energia)
        {
            Imie = imie;
            Hp = hp + energia;
            Atak = atak;
            Rasa = rasa;
            Energia = energia;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Energia: {0:0.00}\n", Energia);
        }
    }
}
