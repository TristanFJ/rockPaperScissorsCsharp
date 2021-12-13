using System;
using System.Collections.Generic;

namespace rockPaperScissorsCsharp
{
  class Game
  {

    public List<string> Throws { get; private set; } = new List<string>() { "rock", "paper", "scissors" };
    public int Points = 1;

    public Game()
    {
      getInputs();
    }

    public void getInputs()
    {
      Console.WriteLine("\nRock/Paper/Scissors?\n");
      string input = Console.ReadLine();
      Random rand = new Random();
      string Opponent = Throws[rand.Next(0, 3)];
      playGame(input, Opponent);
    }

    public void checkPoints()
    {
      if (Points <= 0)
      {
        Console.WriteLine("You're out of points! Game Over!! CTRL-C out of shame!!!!");
      }
    }

    private void playGame(string input, string Opponent)
    {
      switch (input.ToLower() + Opponent)
      {
        case "rockscissors":
        case "paperrock":
        case "scissorspaper":
          Console.WriteLine("You win.");
          Console.WriteLine($"Opponent chose {Opponent}.");
          Points += 3;
          checkPoints();
          Console.WriteLine($"You have {Points} points.");
          break;

        case "scissorsrock":
        case "rockpaper":
        case "paperscissors":
          Console.WriteLine("You lose.");
          Console.WriteLine($"Opponent chose {Opponent}.");
          Points--;
          checkPoints();
          Console.WriteLine($"You have {Points} points.");
          break;

        case "rockrock":
        case "paperpaper":
        case "scissorsscissors":
          Console.WriteLine("Nobody wins.");
          Console.WriteLine($"Opponent chose {Opponent}.");
          Points--;
          checkPoints();
          Console.WriteLine($"You have {Points} points.");
          break;
      }
      getInputs();
    }

  }
}