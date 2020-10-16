using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolaTestowJednostkowych.Basics;

namespace SzkolaTestowJednostkowych.UnitTests.Basics
{
    class MathTests
    {
        [TestCase(3, 3, 3)]
        [TestCase(4, 2, 2)]
        [TestCase(7, 5, 1)]
        public void GetMwd_WhenCalled_ShouldReturnNwd(int number1, int number2, int nwd)
        {
            var math = new SzkolaTestowJednostkowych.Basics.Math();

            var result = math.GetNwd(number1, number2);

            result.Should().Be(nwd);
        }

        [Test]
        public void GetEvenNumbers_WhenCalled_ShouldReturnOnlyEvenNumbers()
        {
            var math = new SzkolaTestowJednostkowych.Basics.Math();

            IEnumerable<int> numbers = math.GetEvenNumbers(7);

            numbers.Should().BeEquivalentTo(6, 4, 2);
        }

    }
}
