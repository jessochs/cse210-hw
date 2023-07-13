using System;

public class Swimming : Activity
{
    private int _laps = 12;

    public Swimming()
    {
        _date = "11 June 2015";
        _activity = "Swimming";
        _time = 60;
        _speed = 10;
    
    }

    public override int Distance()
    {
        _distance = 10;
        // _laps * 50 / 1000 * 0.62;
        return _distance;
    }

    public override int Speed()
    {
        return _speed;
    }

    public override int Pace()
    {
        _pace = 60 / _speed;
        return _pace;
    }
}