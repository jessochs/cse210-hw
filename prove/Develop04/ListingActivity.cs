using System;

public class ListingActivity : Activity
{

    private List<string> _listPrompt = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who helped you this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your personal hereos?"

    };

    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    private Random rnd = new Random();

    public string GetQuestion()
    {
        return _listPrompt[rnd.Next(_listPrompt.Count)];
    }

    public void DisplayListingActivity()
    {
        DisplayStartMessage();
        Console.WriteLine(GetQuestion());

        //display count of listed items

        string input;
        int counter = 0;
        Console.WriteLine("You may begin in:");
            Timer(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            
            input = Console.ReadLine();

            counter++;

        }
        Console.WriteLine($"{counter}");
        DisplayEndMessage();


    }
}