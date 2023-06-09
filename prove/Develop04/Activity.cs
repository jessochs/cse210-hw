using System;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;

    protected int _duration;

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine("");
        Console.WriteLine($"{_activityDescription}");
        // dispaly discription
        Console.Write("Please enter an amount of time in seconds to set the duration of the activity");
        string _duration = Console.ReadLine();
        Console.WriteLine("");
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner();
        
        // sauy get ready
        // run timer
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");
        Spinner();
        // end message string "Congrats you completed {_duration} seconds of the activity"
        Console.WriteLine($"Congrats you completed {_duration} seconds of the activity.");
        Spinner();
        // spinner
    }

    // Timer method with duration parameter
    public void Timer(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Spinner Method
    public void Spinner()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            List<string> animationCharacters = new List<string>();
            animationCharacters.Add("|");
            animationCharacters.Add("/");
            animationCharacters.Add("-");
            animationCharacters.Add("\\");

            foreach (string s in animationCharacters)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }


        }



    }

    

}