using NUnit.Framework;
using AllProjects;


namespace Application_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Addition()
        {
            Assert.AreEqual(3, Calculator.Addition(1, 2));
        }

        [Test]
        public void Multiply()
        {
            Assert.AreEqual(18, Calculator.Multiply(2, 9));
        }

        [Test]
        public void Minus()
        {
            Assert.AreEqual(-7, Calculator.Minus(2, 9));
        }

        [Test]
        public void Divide()
        {
            Assert.AreEqual(2, Calculator.Divide(2, 1));

        }

        [Test]
        public void FloatPasser()
        {
            (float one, float two) AssignedValues = ValuePasser.ParseAssignValues("2", "1");

            Assert.IsTrue(AssignedValues.one == 2 && AssignedValues.two == 1);

        }

        [Test]
        public void FloatParsser()
        {
            float a = ValuePasser.ParseFloat("1");
            float b = ValuePasser.ParseFloat("a");
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