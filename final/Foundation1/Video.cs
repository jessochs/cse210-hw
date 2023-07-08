using System;

public class Video
{
    public string _title;
    public string _author;
    public string _length;
    private List<Comment> comments = new List<Comment>();

    public Video(){}
    public Video(string title, string author, string length) 
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment()
    {
        Comment c = new Comment();
        Console.WriteLine("Comment:");
        Console.ReadLine();

        comments.Add(c);

    }

    public void DisplayComments()
    {
        foreach(Comment c in comments)
        {
            c.Display();
        }
    }

    public void Display()
    {
        Console.WriteLine($"{_title}, {_author}, {_length}");
    }
}