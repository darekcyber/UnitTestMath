using NUnit.Framework;
using System;

namespace Calculations.Tests
{
    public class Tests
    {
        Power Power;
        [SetUp]
        public void Setup()
        {
            Power = new Power();
        }

        [Test]
        public void Test2Power2_ShouldRetrun4()
        {
            var Result = Power.Pow(2, 2);

            Assert.AreEqual(4, Result);
        }

        [Test]
        public void Test2Power3_ShouldReturn8()
        {
            var Result = Power.Pow(2, 3);

            Assert.AreEqual(8, Result);
        }

        [Test]
        public void TestMinus2Power3_ShouldThrownException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                Power.Pow(-2, 3);
            });
        }

        [Test]
        public void Test2PowerMinus3_ShouldThrownException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                Power.Pow(2, -3);
            });
        }
    }
}