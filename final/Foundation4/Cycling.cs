using System;

public class Cycling : Activity
{
    
    public Cycling()
    {
        _date = "02 August 2022";
        _time = 60;
        _activity = "Cycling";
        _distance = 14f;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override float Speed()
    {
        _speed = (_distance / _time) * 60;
        return _speed;
    }

    public override double Pace()
    {
        _pace = _time / _distance;
        return Math.Round(_pace, 2);
    }
}