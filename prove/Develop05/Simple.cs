using System;

public class Simple : Goal
{

    // constructor that passes parameters to the base class
    // simple(*paramters*) : base (*paramters*)

    public override int RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine("Congrats! You have earned {_pointsEarned} points!");
        return _pointsEarned;
    }

    
}