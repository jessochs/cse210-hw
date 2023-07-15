using System;

public class Swimming : Activity
{
    private float _laps = 12f;

    public Swimming()
    {
        _date = "11 June 2015";
        _activity = "Swimming";
        _time = 60;
        _speed = 10;
    
    }

    public override double Distance()
    {
        _distance = _laps * 50 / 1000 * 0.62f;
        // 
        return Math.Round(_distance, 2);
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