using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator sut = new SimpleCalculator();

        [Test]
        public void shouldAddTwoNumbers()
        {
            Assert.That(sut.Add(1,2), Is.EqualTo(3));
        }

        [Test]
        public void shouldMultiplyTwoNumbers()
        {
            Assert.That(sut.Multiply(2, 2), Is.EqualTo(4));
        }
    }
}
