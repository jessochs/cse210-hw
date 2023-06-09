using System;

public class BreatheActivity : Activity
{
    // private string _message1 = "";
    // private string _message2 = "";
    private int _count = 0;

    // public string GetMessageOne()
    // {
    //     return _message1;
    // }
    // public void SetMessageOne(string message1)
    // {
    //     _message1 = message1;
    // }

    // public string GetMessageTwo()
    // {
    //     return _message2;
    // }
    // public void SetMessageTwo(string message2)
    // {
    //     _message2 = message2;
    // }
    public int GetCount()
    {
        return _count;
    }
    public void SetCount(int count)
    {
        _count = count;
    }
    
    public void DisplayBreathingActivity()
    {
        Console.WriteLine($"{_message1}");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine($"{_message2}");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

}