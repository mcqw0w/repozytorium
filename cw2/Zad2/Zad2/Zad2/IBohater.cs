using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    interface IBohater
    {
        void BijWroga(Bohater kogo);
        bool SprawdzHp();
        void OtrzymaneObrazenia(double obrazenia);
    }
}
