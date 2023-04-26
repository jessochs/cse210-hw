using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a number. When you are done type 0.");
        string numb = Console.ReadLine();

        int newNumber = int.Parse(numb);

        while (newNumber != 0)
        {
            Console.Write("Enter another number.");
            Console.ReadLine();

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum in {sum}");

        int average = sum / numbers.Count;

        Console.WriteLine($"The average is {average}");

        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }

        Console.WriteLine($"The max is: {maximum}");
    }
}