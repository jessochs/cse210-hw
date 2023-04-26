using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 101);

        Console.Write("What is your guess?");
        string guess = Console.ReadLine();
        
        
        int y = int.Parse(guess);

        while (y > x)
        {
            Console.WriteLine("Lower");
            Console.Write("What is your guess?");

            if (y < x)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess?");
            }
            else if (y == x)
            {
                Console.WriteLine("You guessed the number!");
            }
        }
    }
}