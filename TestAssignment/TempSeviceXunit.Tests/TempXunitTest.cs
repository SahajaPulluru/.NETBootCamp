using System;
using Xunit;
using System.Text;
using Xunit.Sdk;

namespace TempService.test
{
    public class TempXUnitTest
    {
        [Fact]
        public void TestCelsiusToFahrenheit()
        {
            Temp t = new Temp();
            double actual = t.CelsiusToFahrenheit(30);
            double expected = 86;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void TestFahrenheitToCelsius()
        {
            Temp t = new Temp();
            double actual = t.FahrenheitToCelsius(86);
            double expected = 30;
            Assert.Equal(expected, actual);

        }

    }
}
