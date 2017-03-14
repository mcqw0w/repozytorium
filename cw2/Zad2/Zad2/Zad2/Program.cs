using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bohater> postacie = tworzPostacie();
            Random r = new Random(DateTime.Now.Millisecond);
            int runda = 1;

            foreach (var postac in postacie)
                if (postac.SprawdzHp())
                    Console.WriteLine(postac);

            Console.WriteLine();

            while ((postacie[0].SprawdzHp() || postacie[1].SprawdzHp()) && postacie[2].SprawdzHp())
            {
                Console.WriteLine("Runda: {0}\n", runda);

                if (r.NextDouble() > 0.5)
                    postacie[0].BijWroga(postacie[2]);
                else
                    ((Mag)postacie[0]).RzucCzar(postacie[2]);

                if (r.NextDouble() > 0.5)
                    postacie[1].BijWroga(postacie[2]);
                else
                    ((Wojownik)postacie[1]).RzutToporem(postacie[2]);


                if (r.NextDouble() > 0.5 && postacie[0].SprawdzHp())
                    postacie[2].BijWroga(postacie[0]);
                else
                    postacie[2].BijWroga(postacie[1]);

                runda++;
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static List<Bohater> tworzPostacie()
        {
            List<Bohater> postacie = new List<Bohater>();

            postacie.Add(new Mag("Medzik", 40, 20, RasaEnum.Rasy.Czlowiek, 200));
            postacie.Add(new Wojownik("Fighter", 350, 100, RasaEnum.Rasy.Krasnolud));

            postacie.Add(new Rzezimieszek("Enemy", 500, 70, RasaEnum.Rasy.Ork, 40));

            return postacie;
        }
    }
}
