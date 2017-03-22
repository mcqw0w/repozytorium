using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class KontoBankowe
    {
        double StanKonta;
        public KontoBankowe(double stankonta)
        {
            StanKonta = stankonta;
        }

        public double Stankonta()
        {
            return StanKonta;
        }

        public double Wyplac(double wyplata)
        {
            if (StanKonta - wyplata >= 0)
            {
                StanKonta -= wyplata;
            }
            return StanKonta;

        }
        public double Wplac(double wplata)
        {
            StanKonta += wplata;
            return StanKonta;
        }
        public void Przelew(KontoBankowe odbiorca, double ile)
        {
            if (StanKonta - ile >= 0)
            {
                StanKonta -= ile;
                odbiorca.Wplac(ile);
            }
            else
            {
                Console.WriteLine("Stan konta jest zbyt niski");
            }
        }
    }
}
