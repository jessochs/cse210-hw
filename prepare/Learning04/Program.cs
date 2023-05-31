using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetName("Samuel Jackson");
        assignment1.SetTopic("multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetName("jessica");
        assignment2.SetTopic("English");
        assignment2.SetSection("1-2");
        assignment2.SetProblems("10-20, 34-37");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetName("Mary Waters");
        assignment3.SetTopic("European History");
        assignment3.SetTitle("The causes of world war 11");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWRitingAssignment());

    }
}