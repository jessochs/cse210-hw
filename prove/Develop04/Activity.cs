using System;

public class Activity
{
    protected string _startMessage = "";
    protected string _endMessage = "";
    protected string _activityDescription = "";
    protected string _message1 = "";
    protected string _message2 = "";

    public string GetStartMessage()
    {
        return _startMessage;
    }
    public void SetStartMessage(string startMessage)
    {
        _startMessage = startMessage;
    }
    
    public string GetEndMessage()
    {
        return _endMessage;
    }
    
    public void SetEndMessage(string endMessage)
    {
        _endMessage = endMessage;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }
     public string GetMessageOne()
    {
        return _message1;
    }
    public void SetMessageOne(string message1)
    {
        _message1 = message1;
    }

    public string GetMessageTwo()
    {
        return _message2;
    }
    public void SetMessageTwo(string message2)
    {
        _message2 = message2;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public void DisplayIntro()
    {
        Console.WriteLine($"{_startMessage}");
        Console.WriteLine($"{_activityDescription}");
    }

    public string DisplayEndMessage()
    {
        return $"{_endMessage}";
    }

    public void Time()
    {
        Console.Write("Please enter an amount of time in seconds to set the duration of the activity");
        string activityTime = Console.ReadLine();
    }
    
}