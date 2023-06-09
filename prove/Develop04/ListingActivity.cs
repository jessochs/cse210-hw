using System;

public class ListingActivity : Activity
{
    // private string _encouragement = "";
    private List<string> _listPrompt = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who helped you this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your personal hereos?"

    };

    private Random rnd = new Random();

    public string GetQuestion()
    {
        return _listPrompt[rnd.Next(_listPrompt.Count)];
    }

    public void DisplayListingActivity()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        


    }
}