using System;

public class PlayerRollsTheDie
{
    private Random random;

    public PlayerRollsTheDie()
    {
        random = new Random();
    }

    public int RollDie()
    {
        int roll = random.Next(1, 7);
        Console.WriteLine("You rolled a {0}", roll);
        return roll;
    }
}
