using System;

public abstract class Activity
{
    protected string _date;
    protected int _time;
    protected string _activity;
    protected int _distance;
    protected int _speed;
    protected int _pace;

    public void GetFormat()
    {
        Console.WriteLine($"{_date} {_activity} ({_time}): Distance {_distance} miles, Speed {_speed} mph, Pace {_pace} min per mile");
    }
    

    public abstract int Distance();

    public abstract int Speed();

    public abstract int Pace();



}