using System.IO;
using System;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    //private List<Prompt> prompts = new List<Prompt>();
    Prompt prompt = new Prompt();
    //Entry entries = new Entry();

    //private FileHandling io = new FileHandling();
    

    public void addEntry() {
        Entry entry = new Entry();
        entry._prompt = prompt.getPrompt();
        Console.WriteLine(entry._prompt);
        entry._response = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        entry._date = dateText;
        // entry._date = DateTime.Now;
        this.entries.Add(entry);

        
        
    }

    public void DisplayEntries() {
        foreach (Entry entry in entries) {
            entry.Display();
        }
    }
    // METHODS

    // AddEntry()

    // DisplayEntries()
    public void Save()
    {
        //io.Save(entries);
        Console.Write("What is the name of your journal file?");
        string fileName = Console.ReadLine();
        
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (Entry entry in entries) {
                outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._response}");
            }
        }
    }
    }
   
    // Load()
        // io.Load()
    public void Load()
    {   
        entries.Clear();
        Console.Write("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] data = line.Split("~");
            Entry entry = new Entry(data[0], data[1], data[2]);
            entries.Add(entry);
        }
        Console.WriteLine("Entries are loaded.");
    }
}