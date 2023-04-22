using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your percent in the class?");
        string grade = Console.ReadLine();

        int x = int.Parse(grade);

        string letter = "";

        if (x >= 90)
        {
            Console.WriteLine("You have an A");
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (x > 70)
        {
            Console.WriteLine("You Passed the class");
        }
        else{
            Console.WriteLine("You did not pass the class");
        }
        
    }
}