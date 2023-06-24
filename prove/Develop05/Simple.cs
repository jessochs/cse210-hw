using System;

public class Simple : Goal
{

    // constructor that passes parameters to the base class
    // simple(*paramters*) : base (*paramters*)

    public Simple(){}

    public Simple(string goalName, string description, int pointsEarned, bool isCompleted) : base (goalName, description, pointsEarned, isCompleted)
    {
    }

    public override int RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"Congrats! You have earned {_pointsEarned} points!");
        return _pointsEarned;
    }

    public override string SaveFormat()
    {
        return $"{this.GetType()}|{_goalName}|{_description}|{_pointsEarned}|{_isCompleted}";
    }
    
}