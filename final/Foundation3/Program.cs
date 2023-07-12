using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture();
        Console.WriteLine("Lecture Events:");
        Console.WriteLine();

        lecture.StandardLecture();
        Console.WriteLine();
        lecture.FullLecture();
        Console.WriteLine();
        lecture.ShortLecture();

        Reception reception = new Reception();
        Console.WriteLine("Reception Events:");
        Console.WriteLine();
        reception.StandardReception();
        Console.WriteLine();
        reception.FullReception();
        Console.WriteLine();
        reception.ShortReception();

        Outdoor outdoor = new Outdoor();
        Console.WriteLine("Outdoor Events:");
        Console.WriteLine();
        outdoor.StandardOutdoor();
        Console.WriteLine();
        outdoor.FullOutdoor();
        Console.WriteLine();
        outdoor.ShortOutdoor();


    }
}