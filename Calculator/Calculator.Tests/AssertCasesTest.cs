using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    class AssertCasesTest
    {
        NameJoiner sut1 = new NameJoiner();

        [Test]
        public void ShouldJoinNames()
        {
            var fullName = sut1.Join("Sandra", "Muller");

            Assert.That(fullName, Is.EqualTo("Sandra Muller"));
        }

        [Test]
        public void ShouldJoinNames_CaseSensitive()
        {
            var fullName = sut1.Join("sandra", "muller");

            Assert.That(fullName, Is.EqualTo("SANDRA MULLER").IgnoreCase);
        }

        [Test]
        public void ShouldJoinNames_NotEqual()
        {
            var fullName = sut1.Join("sandra", "muller");

            Assert.That(fullName, Is.Not.EqualTo("Jenny Hart").IgnoreCase);
        }

        Calculator sut2 = new Calculator();

        [Test]
        public void ShouldAddDoubles()
        {
            var result = sut2.AddDoubles(1.1, 2.2);

            //Assert.That(result, Is.EqualTo(3.3)); floats vary so we need to build in tolerance
            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }
    }
}
