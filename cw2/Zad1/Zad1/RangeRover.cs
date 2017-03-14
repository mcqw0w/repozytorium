using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class RangeRover : ISamochod
    {
        public string WypiszMarke()
        {
            return "Range Rover";
        }

        public string WypiszSalon()
        {
            return "Salon Mariacki-Range Rover";
        }
    }
}
