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
    class TicTacToeTests
    {
        [TestCase(1)]
        [TestCase(2)]
        public void SolveGame_WhenPlayerWinsInRow_ShouldReturnPlayerNumber(int player) 
        {
            var ticTacToe = new TicTacToe();
            var board = new[,]
            {
                {player, player, player },
                {1, 0, 2 },
                {0, 2, 1 }
            };

            var result = ticTacToe.SolveGame(board);

            result.Should().Be(player);

        }

        [TestCase(1)]
        [TestCase(2)]
        public void SovleGame_WhenPlayerWinsInColimn_ShouldReturnPlayerNumber(int player) 
        {
            var ticTacToe = new TicTacToe();
            var board = new[,]
            {
                {player, 1, 0 },
                {player, 0, 2 },
                {player, 2, 1 }
            };

            var result = ticTacToe.SolveGame(board);

            result.Should().Be(player);
        }

        [TestCase(1)]
        [TestCase(2)]
        public void SovleGame_WhenPlayerWinsInDiagonal_ShouldReturnPlayerNumber(int player) 
        {
            var ticTacToe = new TicTacToe();
            var board = new[,]
            {
                {player, 0, 1 },
                {1, player, 2 },
                {0, 2, player }
            };

            var result = ticTacToe.SolveGame(board);

            result.Should().Be(player);
        }

        [Test]
        public void SovleGame_WhenGameIsNotSolved_ShouldReturnMinusOne() 
        {
            var ticTacToe = new TicTacToe();
            var board = new[,]
            {
                {2, 1, 0 },
                {1, 1, 2 },
                {0, 2, 1 }
            };

            var result = ticTacToe.SolveGame(board);

            result.Should().Be(-1);
        }

        [Test]
        public void SovleGame_WhenGameIsTied_ShouldReturnZero() 
        {
            var ticTacToe = new TicTacToe();
            var board = new[,]
            {
                {0, 0, 0 },
                {1, 0, 2 },
                {0, 2, 1 }
            };

            var result = ticTacToe.SolveGame(board);

            result.Should().Be(0);
        }
    }
}
