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
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

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
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

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
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

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
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

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
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

            //Assert
            var expected = "Paper has won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenRockAndPaper_ShouldReturnPaper()
        {
            //Arrange
            var player1 = "Rock";
            var player2 = "Paper";
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

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
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

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
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

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
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

            //Assert
            var expected = "Draw";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenEmpty_ShouldReturnMessage()
        {
            //Arrange
            var player1 = "";
            var player2 = "";
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

            //Assert
            var expected = "Invalid input";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenWhitespace_ShouldReturnMessage()
        {
            //Arrange
            var player1 = " ";
            var player2 = " ";
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(player1, player2);

            //Assert
            var expected = "Invalid input";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenNull_ShouldReturnMessage()
        {
            //Arrange
            var nullOrWhitespace = new NullOrWhitespace();
            var rock = new WinnerRock();
            var paper = new WinnerPaper();
            var scissor = new WinnerScissors();

            nullOrWhitespace.SetSucessor(rock);
            rock.SetSucessor(paper);
            paper.SetSucessor(scissor);

            //Act
            var actual = nullOrWhitespace.Play(null, null);

            //Assert
            var expected = "Invalid input";
            Assert.AreEqual(expected, actual);
        }
    }
}
