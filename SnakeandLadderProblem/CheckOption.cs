using System;

public class CheckOption
{
    private Random random;

    public CheckOption()
    {
        random = new Random();
    }

    public int CheckForOption()
    {
        int option = random.Next(0, 3); 

        switch (option)
        {
            case 0:
                Console.WriteLine("No Play. Stay in the same position.");
                break;
            case 1:
                Console.WriteLine("Ladder! Move ahead by the number received in the die.");
                break;
            case 2:
                Console.WriteLine("Snake! Move behind by the number received in the die.");
                break;
        }

        return option;
    }
}
