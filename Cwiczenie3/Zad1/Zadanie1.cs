using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void Divide_DivideTwoNumbers()
        {
            var calc = new Calculator();
            double division = calc.DivideNumbers(4.0, 2.0);
            Assert.AreEqual(2.0, division);
        }
    }
}
