public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private FileHandling io = new FileHandling();



    // METHODS

    // AddEntry()

    // DisplayEntries()
    public void Save()
    {
        io.Save(entries);
    }
   
    // Load()
        // io.Load()
    public void Load()
    {
        io.Load();
    }
}