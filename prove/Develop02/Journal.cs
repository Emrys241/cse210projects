class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("hh:mm:ss tt"), response);
        entries.Add(newEntry);
    }

    public void SaveToCSV()
    {
        List<string> records = new List<string>();
        foreach (Entry entry in entries)
        {
            records.Add(entry.getEntryAsCSV());
        }
        Console.WriteLine("Name of the file to save? ");
        string _fileName = Console.ReadLine();

        File.WriteAllLines(_fileName, records);
    }

    public void LoadFromCSV()
    {
        Console.WriteLine("Name of file to load?");
        string _fileName = Console.ReadLine();
        List<string> records = System.IO.File.ReadAllLines(_fileName).ToList();
        foreach (string record in records)
        {
            string[] splitString = record.Split('|');
            Entry entry = new Entry(splitString[0], splitString[1], splitString[2], splitString[3]);
            entries.Add(entry);
        }
    }
}
