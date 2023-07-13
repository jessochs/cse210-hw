using System;

public class Cycling : Activity
{
    
    public Cycling()
    {
        _date = "02 August 2022";
        _time = 60;
        _activity = "Cycling";
        _distance = 14;
    }

    public override int Distance()
    {
        return _distance;
    }

    public override int Speed()
    {
        _speed = (_distance / _time) * 60;
        return _speed;
    }

    public override int Pace()
    {
        _pace = _time / _distance;
        return _pace;
    }
}