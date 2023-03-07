using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Snake And Ladder");

        Play game = new Play();
        PlayerRollsTheDie playerRollsTheDie = new PlayerRollsTheDie();
        CheckOption checkOption = new CheckOption();

        int roll = playerRollsTheDie.RollDie();
        Console.WriteLine("You rolled {0}.", roll);

        int option = checkOption.CheckForOption();

        switch (option)
        {
            case 0:
                break;
            case 1:
                game.PlaySnakeAndLadder(roll);
                break;
            case 2:
                game.PlaySnakeAndLadder(-roll);
                break;
        }
    }
}
