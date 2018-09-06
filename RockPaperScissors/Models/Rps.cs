using System;
using System.Collections.Generic;

namespace RPS
{
  public class Game
  {
    private int _player1Number;
    private int _player2Number;
    private Dictionary<string, int> handValue = new Dictionary<string, int> ()
    {
      { "rock", 0 },
      { "paper", 1 },
      { "scissors", 2 }
    };


    public Game(string player1, string player2)
    {
      _player1Number = handValue[player1];
      _player2Number = handValue[player2];
    }

    public int GetPlayer1Number()
    {
      return _player1Number;

    }
    public int GetPlayer2Number()
    {
      return _player2Number;
    }

    public string DetermineWinner()
    {
      int difference = Math.Abs(_player1Number - _player2Number);
      if (difference == 2)
      {
        return (_player1Number < _player2Number) ? "Player One Wins!" : "Player Two Wins!";
      }
      else if (difference == 1)
      {
        return (_player1Number > _player2Number) ? "Player One Wins!" : "Player Two Wins!";
      }
      else
      {
        return "It is a draw!";
      }
    }

  }

  public class Program
  {
    public static void Main()
    {


    }
  }

}
