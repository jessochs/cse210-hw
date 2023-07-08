using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video();
        vid1._title = "How to make Cupcakes";
        vid1._author = "Julia Child";
        vid1._length = "32:47";
        

        Video vid2 = new Video();
        vid2._title = "Lesson 01: Python Print Statements";
        vid2._author = "Microsoft";
        vid2._length = "5:61";

        Video vid3 = new Video();
        vid3._title = "Mario Kart Tutorial";
        vid3._author = "Dr. Matt Allred";
        vid3._length = "10:11";


    }
}