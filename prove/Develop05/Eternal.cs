using System;

public class Eternal : Goal 
{
    public Eternal(){}
    public Eternal(string goalName, string description, int pointsEarned) : base (goalName, description, pointsEarned, false)
    {
    }
   public override int RecordEvent()
    { 
        Console.WriteLine($"Congrats! You have earned {_pointsEarned} points!");
        return _pointsEarned;
    }

    public override string SaveFormat()
    {
        return $"{this.GetType()}|{_goalName}|{_description}|{_pointsEarned}";
    }
}