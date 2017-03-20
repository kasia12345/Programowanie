using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************************************************************/
//Programu niestety nie udało mi się napisać do końca.
/****************************************************************************/
namespace DziennikTests
{
    using NUnit.Framework;

    [TestFixture]
    public class DziennikTests
    {
        [Test]
        public void Test_OcenaUcznia()
        {
            Dziennik dziennik = new Dziennik();
            dziennik.sprawdzOcene("Anna", "Kowalska", "Biologia", 4.0);
            Assert.AreEqual(4.0, );

        }

        [Test]
        public void Test_SprawdzanieObecnosci()
        { }

        [Test]
        public void Test_LiczenieSredniejOcen()
        { }

        [Test]
        public void Test_DodaniePrzedmiotu()
        { }

        [Test]
        public void Test_EdycjaPrzedmiotu()
        { }
    }
}
