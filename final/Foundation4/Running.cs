using System;


public class Running : Activity
{

    public Running()
    {
        _date = "12 July 2023";
        _activity = "Running";
        _speed = 5;
        _time = 30;
    }

    public override float Distance()
    {
        _distance = _speed * (_time / 60);

        return _distance;
    }

    public override float Speed()
    {
        return _speed;
    }
    public override float Pace()
    {
        _pace = 60 / _speed;
        return _pace;
    }
}