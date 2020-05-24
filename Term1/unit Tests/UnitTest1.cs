using NUnit.Framework;
using Palindrone;

namespace unit_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            Assert.IsTrue(PalindroneClass.CheckPalindrone("race car"));
        }
    }
}