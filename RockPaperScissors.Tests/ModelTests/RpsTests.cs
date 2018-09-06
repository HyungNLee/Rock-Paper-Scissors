using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;

namespace RPS.Tests
{
  [TestClass]
  public class RPSTest
  {
    [TestMethod]
    public void GetChoice_IsARock_True()
    {
      // Arrange
      string sample = "Rock";
      Game newGame = new Game();

      // Act
      string result = newGame.GetChoice();
      // Assert
      Assert.AreEqual(sample, result);
    }
  }
}
