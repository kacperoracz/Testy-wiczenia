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
    class FizzBuzzTests
    {
        [Test]
        public void GetOutput_WhenNumberIsDivisibleBy3_ShouldReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            result.Should().Be("Fizz");
        }

        [Test]
        public void GetOutput_WhenNumberIsDivisibleBy5_ShouldReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            result.Should().Be("Buzz");
        }

        [Test]
        public void GetOutput_WhenNumberIsDivisibleBy3And5_ShouldReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            result.Should().Be("FizzBuzz");
        }

        [Test]
        public void GetOutput_WhenNumberIsNotDivisibleBy3And5_ShouldReturnNumber()
        {
            var result = FizzBuzz.GetOutput(4);

            result.Should().Be("4");
        }
    }
}
