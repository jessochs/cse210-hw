using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        Manage manage = new Manage();
    
        // create manage object
        int totalPoints = 0;

        bool choice = false;
        while (!choice)
        {
            Console.WriteLine(totalPoints);
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" ");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Please enter a number");

            // Console.WriteLine(
            //     "Menu Options:\n\n",
            //     "1. Create new goal\n",

            //         )
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("Which goal would you like to make?");
                    string goalNumber = Console.ReadLine();

                    switch (goalNumber)
                    {
                        case "1":
                            Simple simple = new Simple();
                            goals.Add(simple);
                            break;
                        case "2":
                            Eternal eternal = new Eternal();
                            goals.Add(eternal);
                            break;
                        case "3":
                            Checklist checklist = new Checklist();
                            goals.Add(checklist);
                            break;
                    }
                    break;
                case "2":
                    int counter = 1;

                    foreach (Goal g in goals)
                    {
                        Console.WriteLine($"{counter}. [{g.Complete()}] {g.GoalName}. {g.Description}");
                        counter++;
                    }
                    break;
                case "3":
                    manage.Save(goals, totalPoints);
                    break;
                case "4":
                    goals = manage.Load(ref totalPoints);
                    break;
                case "5":
                    counter = 1;

                    List<int> indexes = new List<int>();
                    // 0    1   2   3   ...
                    // 2    4   7   8 ....
                    for (int i = 0; i < goals.Count; i++)
                    {
                        if (!goals[i].IsCompleted)
                        {
                            Console.WriteLine($"{counter}. {goals[i].GoalName}. {goals[i].Description}");
                            indexes.Append(i);
                            counter++;
                        }
                    }

                    Console.WriteLine("Goal: ");
                    int goal = int.Parse(Console.ReadLine());
                    totalPoints += goals[indexes[goal - 1]].RecordEvent();
                    break;
                case "6":
                    return;


            }


        }

    }



}