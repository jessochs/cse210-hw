using System;

public class RectangleShape : Shape 
{
    private double _length;
    private double _width;

    public RectangleShape()
    {
        _color = "green";
        _length = 3;
        _width = 4;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}