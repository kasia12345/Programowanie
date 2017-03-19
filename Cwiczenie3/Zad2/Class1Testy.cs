using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KontoBankowe.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class Class1Testy
    {
        [Test]
        public void Test_Wplacanie()
        {
            KontoBankowe source = new KontoBankowe();
            source.WplacPieniadze(200);
            Assert.AreEqual(200, source.StanKonta);
        }

        [Test]
        public void Test_Wyplacanie()
        {
            KontoBankowe source = new KontoBankowe();
            source.WplacPieniadze(200);
            source.WyplacPieniadze(20);
            Assert.AreEqual(180, source.StanKonta);
        }

        [Test]
        public void Test_StanKonta()
        {
            KontoBankowe source = new KontoBankowe();
            source.WplacPieniadze(200);
            Assert.AreEqual(200, source.StanKonta);
        }

        [Test]
        public void Test_Transfer()
        {
            KontoBankowe source = new KontoBankowe();
            source.WplacPieniadze(200);

            KontoBankowe destination = new KontoBankowe();
            destination.WplacPieniadze(150);

            source.TransferPieniedzy(source, destination, 100);

            Assert.AreEqual(250, destination.StanKonta);
            Assert.AreEqual(100, source.StanKonta);
        }
    }
}
