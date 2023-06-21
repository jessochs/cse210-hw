using System;

public class Eternal : Goal 
{
    // same as simple
   public override int RecordEvent()
    { 
        Console.WriteLine("Congrats! You have earned {_pointsEarned} points!");
        return _pointsEarned;
    }
}