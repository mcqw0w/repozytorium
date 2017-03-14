using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Mag : Bohater
    {
        public double Mana { get; private set; }

        public Mag(string imie, double hp, double atak, RasaEnum.Rasy rasa, double mana)
        {
            Imie = imie;
            Hp = hp;
            Atak = atak;
            Rasa = rasa;
            Mana = mana;
        }

        public void RzucCzar(Bohater kogo)
        {
            if (!SprawdzHp())
                return;

            if (Mana <= 0)
                Console.WriteLine("{0}: brak many", Imie);

            Random r = new Random(DateTime.Now.Millisecond);

            double minAtak = Atak * 2;
            double maxAtak = Atak * 3;

            double obrazenia = r.NextDouble() * (maxAtak - minAtak) + minAtak;

            Mana -= 20;

            kogo.OtrzymaneObrazenia(obrazenia);

            Console.WriteLine("{0} otrzymal {1:0.00} obrazen zadanych czarem od {2}\npozostalo mu {3:0.00} HP", kogo.Imie, obrazenia, Imie, kogo.Hp);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Mana: {0:0.00}\n", Mana);
        }
    }
}
