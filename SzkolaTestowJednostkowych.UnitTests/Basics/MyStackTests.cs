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
    class MyStackTests
    {
        MyStack<string> _stack;

        public void InitStack()
        {
            _stack = new MyStack<string>();
        }

        [Test]
        public void Push_WhenArgumentIsNull_ShouldThrowArgumentNullException()
        {
            InitStack();

            Action action = () => _stack.Push(null);

            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Test]
        public void Push_WhenArgumentIsValid_ShouldAddItemToStack()
        {
            InitStack();

            _stack.Push("item");

            var result = _stack.Count;

            result.Should().Be(1);
        }

        [Test]
        public void Pop_WhenStackIsEmpty_ShouldThrowInvalidOperationException()
        {
            InitStack();

            Action action = () => _stack.Pop();

            action.Should().ThrowExactly<InvalidOperationException>();
        }

        [Test]
        public void Pop_WhenArgumentIsValid_ShouldReturnLastItem()
        {
            InitStack();

            _stack.Push("item");

            var result = _stack.Pop();

            result.Should().Be("item");
        }

        [Test]
        public void Pop_WhenArgumentIsValid_ShouldRemoveItemFromStack()
        {
            InitStack();

            _stack.Push("item");
            _stack.Pop();

            var result = _stack.Count;

            result.Should().Be(0);
        }

        [Test]
        public void Peek_WhenStackIsEmpty_ShouldThrowInvalidOperationException()
        {
            InitStack();

            Action action = () => _stack.Peek();

            action.Should().ThrowExactly<InvalidOperationException>();
        }

        [Test]
        public void Peek_WhenArgumentIsValid_ShouldReturnLastItem()
        {
            InitStack();

            _stack.Push("item");

            var result = _stack.Peek();

            result.Should().Be("item");
        }

        [Test]
        public void Peek_WhenArgumentIsValid_ShouldNotRemoveItemFromStack()
        {
            InitStack();

            _stack.Push("item");
            _stack.Peek();

            var result = _stack.Count;

            result.Should().Be(1);
        }
    }
}
