using System;

public class Manage
{ 
    private List<Goal> goals2 = new List<Goal>();

    public void Save()
    {
        Console.WriteLine("What file would you like it saved to?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Goal g in goals2) 
            {
                outputFile.WriteLine($"");
            }
        }
        // same as Journal
        // get file name
        // using (StreamWriter out = new StreamWriter(filename, true))
        // out("*print variable here seperated by a distinguised character like |*")
    }

    public void Load()
    {
        goals2.Clear();
        Console.Write("What is the file name?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] date = line.Split("|");

            //Goal goal = new Goal(data[0], data[1], data[2]);
            //goals2.Add();

        }
        // same concept as Journal
        // itilize the File.ReadAllLines and the Split("|")
    }
}