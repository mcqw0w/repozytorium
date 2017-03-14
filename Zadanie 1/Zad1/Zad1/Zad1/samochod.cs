using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class samochod
    {
        public string Marka {get ; private set;}
        public int LiczbaKol { get; private set;}
        public double Predkosc { get; private set;}
        public string Kolor { get; private set;}
        public int Rocznik { get; private set;}

        public samochod(string marka,int liczbakol,double predkosc, string kolor = "Czarny", int rocznik= 2016)
        {
            Marka = marka;
            LiczbaKol = liczbakol;
            Predkosc = predkosc;
            Kolor = kolor;
            Rocznik = rocznik;
        }
        public void Jedz(double predkosc)
        {
            Console.WriteLine("Prędkość samochodu to{0}", predkosc);
        }
        public void Hamuj()
        {
            Predkosc = 0.0;
        }

        

        public override string ToString()
        {
            return string.Format("{0} samochód marki {1} jedzie z prędkością {2}\n Domyślna ilość kół używanych jendocześnie w samochodzie to {3}", Kolor,Marka,Predkosc,LiczbaKol);
        }

        
    
    }
}
