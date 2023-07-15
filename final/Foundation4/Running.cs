using System;


public class Running : Activity
{

    public Running()
    {
        _date = "12 July 2023";
        _activity = "Running";
        _speed = 5.0f;
        _time = 30;
    }

    public override double Distance()
    {
        _distance = _speed * (_time / 60);

        return _distance;
    }

    public override float Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        _pace = 60 / _speed;
        return _pace;
    }
}