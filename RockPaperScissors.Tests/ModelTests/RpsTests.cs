using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;

namespace RPS.Tests
{
  [TestClass]
  public class RPSTest
  {
    [TestMethod]
    public void GetPlayerNumbers_1_1()
    {
      // Arrange
      int player1 = 1;
      int player2 = 2;

      // Act
      Game newGame = new Game("paper", "scissors");
      int first = newGame.GetPlayer1Number();
      int second = newGame.GetPlayer2Number();
      // Assert
      // Assert.AreEqual(first, player1);
      Assert.AreEqual(second, player2);
    }

    [TestMethod]
    public void DetermineWinner_Player1_1to3()
    {
      // Arrange
      Game newGame = new Game("rock", "scissors");

      // Act
      string result = newGame.DetermineWinner();
      // Assert
      Assert.AreEqual("Player One Wins!", result);
    }

    [TestMethod]
    public void DetermineWinner_Tie()
    {
      // Arrange
      Game newGame = new Game("rock", "rock");

      // Act
      string result = newGame.DetermineWinner();
      // Assert
      Assert.AreEqual("It is a draw!", result);
    }

    [TestMethod]
    public void DetermineWinner_Player1_2to3()
    {
      // Arrange
      Game newGame = new Game("paper", "scissors");

      // Act
      string result = newGame.DetermineWinner();
      // Assert
      Assert.AreEqual("Player Two Wins!", result);
    }
  }
}
