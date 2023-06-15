using System;

public class SquareShape : Shape 
{
    private double _side;

    public  SquareShape()
    {
        _color = "pink";
        _side = 5;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}