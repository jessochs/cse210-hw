using System;

public class BreatheActivity : Activity
{

    public BreatheActivity()
    {
        _activityName = "Breathe Activity";
        _activityDescription = "This activity will take a few seconds to help you breathe.";
    }

    public void RunBreathingActivity()
    {
        DisplayStartMessage();

        int duration = _duration;

        while (duration > 0)
        {
            Console.WriteLine("Breathing in...");
            Timer(5);

            Console.WriteLine($"Breathe out...");
            Timer(5);
            
            duration-=10;
        }


        DisplayEndMessage();


    }

}