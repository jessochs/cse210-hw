using System;

public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(){}
    public Video(string title, string author, string length) 
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // public void AddComment()
    // {
    //     Comment c = new Comment();
    //     Console.WriteLine("Comment:");
    //     Console.ReadLine();

    //     comments.Add(c);

    // }

    public void Display()
    {
        Console.WriteLine($"{_title}, {_author}, {_length}");
        foreach(Comment c in _comments)
        {
            c.Display();
        }
    }

    
}