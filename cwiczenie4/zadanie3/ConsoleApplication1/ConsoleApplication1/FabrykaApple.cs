using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FabrykaApple : IFabryka
    {
        public IObudowa TworzObudowe()
        {
            return new AppleObudowa();
        }

        public IEkran TworzEkran()
        {
            return new AppleEkran();
        }
    }
}
