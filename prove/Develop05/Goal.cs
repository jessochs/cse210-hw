using System;

public abstract class Goal 
{
    protected string _goalName;
    protected string _description;
    protected int _pointsEarned;
    protected bool _isCompleted = false;
   

    public string GoalName { get{ return _goalName;} }
    // create propertiues for the other variables

    public string Description {get{ return _description;}}

    public bool IsCompleted {get{ return _isCompleted;}}


    public Goal()
    {
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();

        Console.WriteLine("What is a short description og your goal?");
        _description = Console.ReadLine();

        Console.WriteLine("how many points will you get for completing this goal?");
        _pointsEarned = int.Parse(Console.ReadLine());
    }

    public Goal(string goalName, string description, int pointsEarned, bool isCompleted)
    {
        
        _goalName = goalName;
        _description = description;
        _pointsEarned =pointsEarned;
        _isCompleted = isCompleted;
    }
    // new constructor to read in all the variables  ( goal(name, description, pointes erned, iscompleted)  - set the variable based on the parameters)

    public char Complete()
    {
        if (_isCompleted == true)
        {
            return 'X';
        }
        else
        {
            return ' ';
        }
    }

    //add virtual method to record the event of completing the goal
    public abstract int RecordEvent();
    public abstract string SaveFormat();
   


}