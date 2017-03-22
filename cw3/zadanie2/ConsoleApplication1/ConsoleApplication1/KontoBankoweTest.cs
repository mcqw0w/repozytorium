using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApplication1
{
    [TestFixture]
    class KontoBankoweTest
    {
        [Test]

        public void WyplacTest()
        {
            KontoBankowe aa = new KontoBankowe(30.0);
            KontoBankowe bb = new KontoBankowe(250.0);
            Assert.Multiple(() =>
            {
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => aa.Wyplac(0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => aa.Wyplac(-10.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wieksza od stanu konta"), () => aa.Wyplac(120.0));

                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => bb.Wyplac(0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => bb.Wyplac(-13.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wieksza od stanu konta"), () => bb.Wyplac(500.0));

                Assert.AreEqual(200.0, bb.Wyplac(50.0));
                Assert.AreEqual(200.0, bb.Stankonta());

            });
        }
        [Test]
        public void WplacTest()
        {
            KontoBankowe aa = new KontoBankowe(30);

            Assert.Multiple(() =>
            {
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => aa.Wplac(0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => aa.Wplac(-13.0));
                Assert.AreEqual(250, aa.Wplac(20));
            });
        }

        [Test]
        public void StanKontaTestMethod()
        {
            KontoBankowe aa = new KontoBankowe(250);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(100.0, aa.Stankonta());
                Assert.AreNotEqual(251.0, aa.Stankonta());
            });
        }

        [Test]
        public void PrzelewTestMethod()
        {
            KontoBankowe aa = new KontoBankowe(30);
            KontoBankowe bb = new KontoBankowe(250);

            Assert.Multiple(() =>
            {
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => aa.Przelew(bb, 0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => aa.Przelew(bb, -1.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wieksza od stanu konta"), () => aa.Przelew(bb, 1000.0));

                aa.Przelew(bb, 50.0);

                Assert.AreEqual(30.0, aa.Stankonta());
                Assert.AreEqual(250.0, bb.Stankonta());
            });
        }
    }
}
