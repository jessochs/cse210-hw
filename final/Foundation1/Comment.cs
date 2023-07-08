using System;

public class Comment
{
    public string _name;
    public string _commentText;

    public Comment(){}
    public Comment(string name, string commentText)
    {
        _name = name;
       _commentText = commentText;
    }

    public void Display()
    {
        Console.WriteLine($"{_name}: {_commentText}");
    }
}