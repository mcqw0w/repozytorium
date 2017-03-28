using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Uczelnia
    {
        private static Uczelnia _Uczelnia;
        private DateTime DataRekrutacji;
        public Uczelnia(DateTime datarekrutacji)
        {
            DataRekrutacji = datarekrutacji;
        }
        static Uczelnia Sin(DateTime datarekrutacji)
        {
            if (_Uczelnia == null)
            {
                _Uczelnia = new Uczelnia(datarekrutacji);

                return _Uczelnia;
            }
            return _Uczelnia;

        }
        public DateTime RekrutujStudentow()
        {
            return DataRekrutacji;
        }
    }
}
