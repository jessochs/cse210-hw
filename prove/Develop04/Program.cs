using System;

class Program
{
    static void Main(string[] args)
    {
    //    BreatheActivity activity1 = new BreatheActivity();
    //    activity1.SetStartMessage("Welcome to the Breathe Activity");
    //    activity1.SetActivityDescription("This activity will take a few seconds to help you breathe.");
    //    activity1.SetMessageOne("Breathe in...");
    //    activity1.SetMessageTwo("Breathe out...");
    //    activity1.SetEndMessage("You have completed the activity.");

    //    activity1.DisplayIntro();
    //    activity1.DisplayBreathingActivity();
    //    Console.WriteLine(activity1.DisplayEndMessage());

       ReflectionActivity activity2 = new ReflectionActivity();
       activity2.SetStartMessage("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
       activity2.SetActivityDescription("This activity will help you reflect on life recently.");
       
        ListingActivity activity3 = new ListingActivity();
        activity3.SetStartMessage("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        activity3.SetActivityDescription("In this activity you will list things based off the prompt you are given");
        activity3.SetMessageOne("Please begin thinking about the prompt you were given.");
        activity3.SetMessageTwo("Please list as many items as you can that correlate with the prompt.");
        activity3.SetEndMessage("You have completed the activity.");
        
        activity3.DisplayIntro();
        Console.WriteLine(activity3.GetQuestion());
        Console.WriteLine(activity3.GetMessageOne());
        activity3.DisplayListingActivity();
        Console.WriteLine(activity3.GetMessageTwo());
        activity3.DisplayListingActivity();
        Console.WriteLine(activity3.DisplayEndMessage());

    }
}