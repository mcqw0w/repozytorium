using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    abstract class Bohater : IBohater
    {
        public string Imie { get; protected set; }
        public double Hp { get; protected set; }
        public double Atak { get; protected set; }
        public RasaEnum.Rasy Rasa { get; protected set; }

        public void BijWroga(Bohater kogo)
        {
            if (!SprawdzHp())
                return;

            Random r = new Random(DateTime.Now.Millisecond);

            double minAtak = Atak * 0.9;
            double maxAtak = Atak * 1.1;

            double obrazenia = r.NextDouble() * (maxAtak - minAtak) + minAtak;

            kogo.OtrzymaneObrazenia(obrazenia);

            Console.WriteLine("{0} otrzymal {1:0.00} obrazen zadanych atakiem od {2}\npozostalo mu {3:0.00} HP", kogo.Imie, obrazenia, Imie, kogo.Hp);
        }

        public bool SprawdzHp()
        {
            return Hp > 0;
        }

        public void OtrzymaneObrazenia(double obrazenia)
        {
            if (!SprawdzHp())
                return;

            Hp -= obrazenia;
        }

        public override string ToString()
        {
            return string.Format("Imie: {0}\nHP: {1:0.00}\nAtak: {2:0.00}\nRasa: {3}\n", Imie, Hp, Atak, Rasa);
        }
    }
}
