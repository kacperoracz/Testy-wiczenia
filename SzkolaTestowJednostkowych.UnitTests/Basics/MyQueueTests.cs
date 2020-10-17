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
    class MyQueueTests
    {
        private MyQueue<string> _queue;

        private void InitQueue()
        {
            _queue = new MyQueue<string>();
        }

        [Test]
        public void Enqueue_WhenArgumentIsNull_ShouldThrowArgumentNullException()
        {
            InitQueue();

            Action action = () => _queue.Enqueue(null);

            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Test]
        public void Enqueue_WhenArgumentIsValid_ShouldAddItemToQueue()
        {
            InitQueue();

            _queue.Enqueue("item");

            var result = _queue.Count;

            result.Should().Be(1);
        }

        [Test]
        public void Peek_WhenQueueIsEmpty_ShouldThrowInvalidOperationException()
        {
            InitQueue();

            Action action = () => _queue.Peek();

            action.Should().ThrowExactly<InvalidOperationException>();
        }

        [Test]
        public void Peek_WhenQueueHasItems_ShouldReturnFirstItem()
        {
            InitQueue();

            _queue.Enqueue("item");

            var result = _queue.Peek();

            result.Should().Be("item");
        }

        [Test]
        public void Peek_WhenQueueHasItems_ShouldNotRemoveAnyItem()
        {
            InitQueue();

            _queue.Enqueue("item");
            _queue.Peek();

            var result = _queue.Count;

            result.Should().Be(1);
        }

        [Test]
        public void Dequeue_WhenQueueIsEmpty_ShouldThrowInvalidOperationException()
        {
            InitQueue();

            Action action = () => _queue.Dequeue();

            action.Should().ThrowExactly<InvalidOperationException>();
        }

        [Test]
        public void Dequeue_WhenQueueHasItems_ShouldReturnFirstItem()
        {
            InitQueue();

            _queue.Enqueue("item");

            var result = _queue.Dequeue();

            result.Should().Be("item");
        }

        [Test]
        public void Deueue_WhenQueueHasItems_ShouldRemoveFirstItem()
        {
            InitQueue();

            _queue.Enqueue("item");
            _queue.Dequeue();

            var result = _queue.Count;

            result.Should().Be(0);
        }
    }
}
