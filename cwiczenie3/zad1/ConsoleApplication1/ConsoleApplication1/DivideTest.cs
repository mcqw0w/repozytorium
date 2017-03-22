using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using NUnit.Framework;
    [TestFixture]
    class DivideTest
    {
        [Test]
        public void DivideTestS()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(0.5, Divide.DivideNumbers(1.0, 2.0));
                Assert.AreEqual(0, Divide.DivideNumbers(0.0, 2.0));
                Assert.AreNotEqual(0.5, Divide.DivideNumbers(1.0, 3.0));
                Assert.Throws(typeof(DivideByZeroException), () => Divide.DivideNumbers(1.0, 0.0));
            });

        }
    }
}
