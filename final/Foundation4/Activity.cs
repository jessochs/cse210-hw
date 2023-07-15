using System;

public abstract class Activity
{
    protected string _date;
    protected float _time;
    protected string _activity;
    protected float _distance;
    protected float _speed;
    protected float _pace;

    public void GetFormat()
    {
        Console.WriteLine($"{_date} {_activity} ({_time}): Distance {Distance()} miles, Speed {Speed()} mph, Pace {Pace()} min per mile");
    }
    

    public abstract double Distance();

    public abstract float Speed();

    public abstract double Pace();



}