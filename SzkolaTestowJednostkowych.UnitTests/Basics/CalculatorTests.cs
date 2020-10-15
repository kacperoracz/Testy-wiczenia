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
    class CalculatorTests
    {
        [Test]
        public void Add_WhenCalled_ShouldReturnSum()
        {
            var calculator = new Calculator();

            var result = calculator.Add(1, 2);

            result.Should().Be(3);
        }

        [Test]
        public void Devide_WhenCalled_ShouldreturnDevidedNumber()
        {
            var calculator = new Calculator();

            var result = calculator.Divide(4, 2);

            result.Should().Be(2);
        }

        [Test]
        public void Devide_WhenDevideByZero_ShouldReturnDivideByZeroException()
        {
            var calculator = new Calculator();

            Action act = () => calculator.Divide(4, 0);

            act.Should().ThrowExactly<DivideByZeroException>();
        }
    }
}
