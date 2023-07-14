using System;

public class Checklist : Goal 
{

    // same as simple except the number to complete and bonus points parameters will be set in this constructor
    private int _numberToComplete;
    private int _bonusPoints;

    private int _timesCompleted;
    public Checklist()
    {
        Console.WriteLine("How many times will you need to complete this goal?");
        _numberToComplete = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points will you earn?");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public Checklist(string goalName, string description, int pointsEarned, bool isCompleted, int numberToComplete, int bonusPoints) : base (goalName, description, pointsEarned, isCompleted)
    {
        
        _numberToComplete = numberToComplete;
        _bonusPoints = bonusPoints;
    }

   public override int RecordEvent()
    {   
        int pointsEarned = 0;
        Console.WriteLine("How many times have you completed this goal?");
        int timesCompleted = int.Parse(Console.ReadLine());
        _timesCompleted += timesCompleted;

        if (_timesCompleted >= _numberToComplete)
        {
            pointsEarned += _bonusPoints;
            _isCompleted = true;

        }
        
        pointsEarned = _pointsEarned * timesCompleted;
        Console.WriteLine($"Congrats! You have earned {pointsEarned} points!");
        return pointsEarned;
    }

    public override string SaveFormat()
    {
        
        return $"{this.GetType()}|{_goalName}|{_description}|{_pointsEarned}|{_isCompleted}|{_numberToComplete}|{_bonusPoints}";
    }
}