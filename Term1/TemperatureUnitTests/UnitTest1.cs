using NUnit.Framework;
using System;
using Temp_Convertor;
namespace TemperatureUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FloatParsser()
        {
            float a = ValueParsser.ParseFloat("1");
            float b = ValueParsser.ParseFloat("a");
            Assert.IsTrue(a == 1 && b == 0);
        }

        [Test]
        public void CelsuisConvert()
        {
            Assert.AreEqual(0, Temperature.ConvertToCelsius(32));
        }

        [Test]
        public void FarhenheitConvert()
        {
            Assert.AreEqual(32, Temperature.ConvertToFahrenheit(0));
        }
    }
}