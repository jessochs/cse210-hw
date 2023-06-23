using System;

public class Manage
{ 

    public void Save(List<Goal> goals, int totalPoints)
    {
        Console.WriteLine("What file would you like it saved to?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal g in goals) 
            {
                outputFile.WriteLine(g.SaveFormat());
            }
        }
        // same as Journal
        // get file name
        // using (StreamWriter out = new StreamWriter(filename, true))
        // out("*print variable here seperated by a distinguised character like |*")
    }

    public List<Goal> Load(ref int totalPoints)
    {
        List<Goal> goals = new List<Goal>();
        Console.Write("What is the file name?");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        totalPoints = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] data = line.Split("|");
            switch (data[0])
            {
                case "Simple":
                    Simple goal = new Simple(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]));
                    goals.Add(goal);
                    break;
                case "Eternal":
                    Eternal eternal = new Eternal(data[1], data[2], int.Parse(data[3]));
                    goals.Add(eternal);
                    break;
                case "Checklist":
                    Checklist checklist = new Checklist(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]));
                    goals.Add(checklist);
                    break;
            }
            //Goal goal = new Goal(data[0], data[1], data[2]);
            //goals2.Add();

        }
        // same concept as Journal
        // itilize the File.ReadAllLines and the Split("|")
        return goals;
    }
}