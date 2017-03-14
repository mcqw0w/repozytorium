using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Wojownik : Bohater
    {
        public Wojownik(string imie, double hp, double atak, RasaEnum.Rasy rasa)
        {
            Imie = imie;
            Hp = hp;
            Atak = atak;
            Rasa = rasa;
        }

        public void RzutToporem(Bohater kogo)
        {
            if (!SprawdzHp())
                return;

            Random r = new Random(DateTime.Now.Millisecond);

            double minAtak = Atak * 1.5;
            double maxAtak = Atak * 2;

            double obrazenia = r.NextDouble() * (maxAtak - minAtak) + minAtak;

            kogo.OtrzymaneObrazenia(obrazenia);

            Console.WriteLine("{0} otrzymal {1:0.00} obrazen zadanych rzuconym toporem od {2}\npozostalo mu {3:0.00} HP", kogo.Imie, obrazenia, Imie, kogo.Hp);
        }
    }
}
