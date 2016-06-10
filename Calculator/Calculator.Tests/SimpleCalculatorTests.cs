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
        [Test]
        public void shouldAddTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}
