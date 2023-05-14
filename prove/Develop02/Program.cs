using System;

class Program
{
    private List<Entry> entries = new List<Entry>();
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        bool choice = false;
        while (!choice) {
            //display menu
            Console.WriteLine("Enter a number");
            //get user input
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                //write an entry
                //pulls up a prompt you can respond to
                journal.addEntry();
                break;
                case "2":
                journal.DisplayEntries();
                break;
                case "3":
                journal.Save();
                break;
                case "4":
                journal.Load();
                break;
                case "5":
                return;

                
            }
            //case and switch
            
        } 
    }
}