using System;

public class CircleShape : Shape 
{
    private double _radius;

    public CircleShape()
    {
        _color = "blue";
        _radius = 3;
    }

    public override double GetArea()
    {
        return _radius * _radius * 3.14;

    }
}