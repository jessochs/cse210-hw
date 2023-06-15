using System;

public class Shape
{
    protected string _color;

    // public Shape()
    // {
    //     _color;
    // }


    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 1;
    }
}