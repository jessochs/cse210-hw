using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Comment comment1 = new Comment();
        comment1._name = "Andy Allen";
        comment1._commentText = "I liked how simple this video was to follow.";

        Comment comment2 = new Comment();
        comment2._name = "Barry Barker";
        comment2._commentText = "What tempereature did she say to bake them at?";

        Comment comment3 = new Comment();
        comment3._name = "Carol Cantor";
        comment3._commentText = "These were some of the best cupcakes ever.";

        Comment comment4 = new Comment();
        comment4._name = "Doug Dennis";
        comment4._commentText = "This heped clear some thing up for me, thank you";

        Comment comment5 = new Comment();
        comment5._name = "Earl Eggington";
        comment5._commentText = "How can I put a new line within the same print statement?";

        Comment comment6 = new Comment();
        comment6._name = "Fanny Ferris";
        comment6._commentText = "I feel comfident in this lesson so far!";

        Comment comment7 = new Comment();
        comment7._name = "Grace Goodwin";
        comment7._commentText = "How long did it take you to build this track? So cool!";

        Comment comment8 = new Comment();
        comment8._name = "Harry Henson";
        comment8._commentText = "Are you planning on making more videos?";

        Comment comment9 = new Comment();
        comment9._name = "Isla Indigo";
        comment9._commentText = "I noticed that one of the cars flew off the waterslide. Did you ever find it?";


        Video vid1 = new Video();
        vid1._title = "How to make Cupcakes";
        vid1._author = "Julia Child";
        vid1._length = "32:47";
        vid1._comments.Add(comment1);
        vid1._comments.Add(comment2);
        vid1._comments.Add(comment3);
        videos.Add(vid1);
        

        Video vid2 = new Video();
        vid2._title = "Lesson 01: Python Print Statements";
        vid2._author = "Microsoft";
        vid2._length = "5:61";
        vid2._comments.Add(comment4);
        vid2._comments.Add(comment5);
        vid2._comments.Add(comment6);
        videos.Add(vid2);

        Video vid3 = new Video();
        vid3._title = "Mario Kart Tutorial";
        vid3._author = "Dr. Matt Allred";
        vid3._length = "10:11";
        vid3._comments.Add(comment7);
        vid3._comments.Add(comment8);
        vid3._comments.Add(comment9);
        videos.Add(vid3);

        foreach( Video v in videos)
        {

            v.Display();
            Console.WriteLine();
        }

        



    }   
}