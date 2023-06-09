using System;

class Program
{
    static void Main(string[] args)
    {
    
        BreatheActivity breathe = new BreatheActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        
        Console.WriteLine("Welcome to the activity page!");
        
        bool choice = false;
        while(!choice)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please enter a number");
            string option = Console.ReadLine();

            switch(option)
            {
                case "1":
                breathe.RunBreathingActivity();
                break;
                case "2":
                reflection.DisplayReflectionActivity();
                break;
                case "3":
                listing.DisplayListingActivity();
                break;
                case "4":
                return;



            }

        }


        



    }
}