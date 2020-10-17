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
    class InvoiceTests
    {
        [Test]
        public void AddPosition_WhenPositionIsNull_ShouldReturnArgumentNullException()
        {
            var invoice = new Invoice();

            Action action = () => invoice.AddPosition(null);

            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Test]
        public void AddPosition_WhenArgumentIsNotAvailable_ShouldReturnException()
        {
            var invoice = new Invoice();

            Action action = () => invoice.AddPosition(new InvoicePosition {IsAvailable = false });

            action.Should().ThrowExactly<Exception>();
        }

        [Test]
        public void AddPosition_WhenArgumentIsAvailable_ShouldAddPosition()
        {
            var invoice = new Invoice();

            invoice.AddPosition(new InvoicePosition { IsAvailable = true });

            var result = invoice.Positions.Count();

            result.Should().Be(1);
        }
    }
}
