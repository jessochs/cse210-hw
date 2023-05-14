using System.IO;
using System;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    //private List<Prompt> prompts = new List<Prompt>();
    Prompt prompt = new Prompt();
    //Entry entries = new Entry();

    //private FileHandling io = new FileHandling();
    string fileName = "journal.txt";

    public void addEntry() {
        Entry entry = new Entry();
        entry._prompt = Console.Write($"Your prompt is {prompt.getPrompt()}");
        entry._response = "";
        //entry._theCurrentTime = DateTime.Now();
        this.entries.Add(entry);



        // Console.WriteLine($"Your prompt is {prompt.getPrompt()}");
        // Console.Write("");
        // string newEntry = Console.ReadLine();
        // File.AppendText()

        
        
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
        Console.ReadLine();
        
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
    public List<Entry> Load()
    {
        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] data = line.Split("~");
            Entry entry = new Entry(data[0], data[1], data[2]);
            entries.Add(entry);
        }
        return entries;
    }
}