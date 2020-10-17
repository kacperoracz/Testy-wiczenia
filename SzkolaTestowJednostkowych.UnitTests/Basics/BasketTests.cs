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
    class BasketTests
    {
        [Test]
        public void AddProduct_WhenCalled_ShouldAddProductToList()
        {
            var basket = new Basket();

            basket.AddProduct(new Product { Price = 10});

            basket.Products.Should().HaveCount(1);
        }

        [Test]
        public void AddProduct_WhenCalled_ShouldUpdateTotalPrice()
        {
            var basket = new Basket();

            basket.AddProduct(new Product { Price = 10 });

            basket.TotalPrice.Should().Be(10);
        }
    }
}
