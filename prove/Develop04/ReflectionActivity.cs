using System;

public class ReflectionActivity : Activity 
{
    private List<string> _prompt = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you helped someone in need."

    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience so meaningful to you?",
        "What was your favorite thing about this experience?",
        "What did you learn?",
        "Would you ever do someting like this again in the future?",
        "What can you apply from this experience to you daily life?",
        "Did this make you want to change anything?",
        "What do you want others to learn from this experience?" 
    };

    public ReflectionActivity()
    {
        _activityName = "Reflection Activity";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    private Random rnd = new Random();

    public string GetPrompt()
    {
        return _prompt[rnd.Next(_prompt.Count)];
    }
   

    public string GetQuestion()
    {
        return _questions[rnd.Next(_questions.Count)];
    }

    public void DisplayReflectionActivity()
    {
        DisplayStartMessage();
        Console.WriteLine("");
        Console.WriteLine(GetPrompt());
        Console.WriteLine("Press enter to continue.");
        string input = Console.ReadLine();
        int duration = _duration;

        while (duration > 0)
        {
            Console.WriteLine(GetQuestion());
            Spinner();
            duration-=5;
        }

        Console.WriteLine("");
        DisplayEndMessage();

    }
    
}