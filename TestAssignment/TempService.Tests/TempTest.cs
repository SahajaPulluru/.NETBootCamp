using System;
using NUnit.Framework;
using System.Text;

namespace TempService.test
{
    [TestFixture]
    internal class TempTest
    {
        [Test]
        public void TestCelsiusToFahrenheit()
        {
            Temp t = new Temp();
            double result = t.CelsiusToFahrenheit(30);
            Assert.That(result, Is.EqualTo(86));
        }
        [Test]
        public void TestFahrenheitToCelsius()
        {
            Temp t = new Temp();
            double result = t.FahrenheitToCelsius(86);
            Assert.That(result, Is.EqualTo(30));
        }

    }
}
