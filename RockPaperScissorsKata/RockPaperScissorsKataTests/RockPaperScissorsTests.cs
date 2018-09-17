using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RockPaperScissorsKata;

namespace RockPaperScissorsKataTests
{
    [TestFixture]
    public class RockPaperScissorsTests
    {
        [Test]
        public void Play_GivenRockAndScissors_ShouldReturnRock()
        {
            //Arrange
            var player1 = "Rock";
            var player2 = "Scissors";

            var sut = new RockPaperScissors();

            //Act
            var actual = sut.Play(player1, player2);

            //Assert
            var expected = "Rock has won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenScissorsAndRock_ShouldReturnRock()
        {
            //Arrange
            var player1 = "Scissors";
            var player2 = "Rock";

            var sut = new RockPaperScissors();

            //Act
            var actual = sut.Play(player1, player2);

            //Assert
            var expected = "Rock has won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenScissorsAndPaper_ShouldReturnScissors()
        {
            //Arrange
            var player1 = "Scissors";
            var player2 = "Paper";

            var sut = new RockPaperScissors();

            //Act
            var actual = sut.Play(player1, player2);

            //Assert
            var expected = "Scissors has won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPaperAndScissors_ShouldReturnScissors()
        {
            //Arrange
            var player1 = "Paper";
            var player2 = "Scissors";

            var sut = new RockPaperScissors();

            //Act
            var actual = sut.Play(player1, player2);

            //Assert
            var expected = "Scissors has won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPaperAndRock_ShouldReturnPaper()
        {
            //Arrange
            var player1 = "Paper";
            var player2 = "Rock";

            var sut = new RockPaperScissors();

            //Act
            var actual = sut.Play(player1, player2);

            //Assert
            var expected = "Paper has won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPaperAndScissors_ShouldReturnPaper()
        {
            //Arrange
            var player1 = "Rock";
            var player2 = "Paper";

            var sut = new RockPaperScissors();

            //Act
            var actual = sut.Play(player1, player2);

            //Assert
            var expected = "Paper has won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenScissorsAndScissors_ShouldReturnDraw()
        {
            //Arrange
            var player1 = "Scissors";
            var player2 = "Scissors";

            var sut = new RockPaperScissors();

            //Act
            var actual = sut.Play(player1, player2);

            //Assert
            var expected = "Draw";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPaperAndPaper_ShouldReturnDraw()
        {
            //Arrange
            var player1 = "Paper";
            var player2 = "Paper";

            var sut = new RockPaperScissors();

            //Act
            var actual = sut.Play(player1, player2);

            //Assert
            var expected = "Draw";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenRockAndRock_ShouldReturnDraw()
        {
            //Arrange
            var player1 = "Rock";
            var player2 = "Rock";

            var sut = new RockPaperScissors();

            //Act
            var actual = sut.Play(player1, player2);

            //Assert
            var expected = "Draw";
            Assert.AreEqual(expected, actual);
        }
    }
}
