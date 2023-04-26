using System;

class Program
{
    static void Main(string[] args)
    {
        string yourName = PromptUserName();
        int yourNumber = PromptUserNumber();

        int yourNumbSquare = SquareNumber(yourNumber);

        DisplayResult(yourName, yourNumbSquare);




    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to class");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name?");
        string name = Console.ReadLine();
        
        return name;

    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);

        return number;

    }
    static int SquareNumber(int number)
    {
        int squareNum = number * number;

        return squareNum;
    }
    static void DisplayResult(string name, int squareNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNum}.");
    }
}
