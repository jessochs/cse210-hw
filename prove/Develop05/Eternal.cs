using System;

public class Eternal : Goal 
{
    public Eternal(string goalName, string description, int pointsEarned) : base (goalName, description, pointsEarned)
    {
        _goalName = goalName;
        _description = description;
        _pointsEarned = pointsEarned;
    }
   public override int RecordEvent()
    { 
        Console.WriteLine("Congrats! You have earned {_pointsEarned} points!");
        return _pointsEarned;
    }
}