// public class FileHandling
// {
//     // Save
//     string fileName = "journal.txt";
    
//     public void Save(List<Entry> entries)
//     {
//         using (StreamWriter outputFile = new StreamWriter(fileName, true))
//         {
//             foreach (Entry entry in entries) {
//                 outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._response}");
//             }
//         }
//     }
//     // Load

//     public List<Entry> Load()
//     {
//         List<Entry> entries = new List<Entry>();
//         string[] lines = System.IO.File.ReadAllLines(fileName);
//         foreach (string line in lines)
//         {
//             string[] data = line.Split("~");
//             Entry entry = new Entry(data[0], data[1], data[2]);
//             entries.Add(entry);
//         }
//         return entries;
//     }
// }   