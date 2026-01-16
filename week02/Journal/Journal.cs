using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry e)
    {
        _entries.Add(e);
    }

    public void DisplayJournal()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                sw.WriteLine($"{e._date}|{e._prompt}|{e._response}");
            }
        }
        Console.WriteLine("Journal saved!");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry e = new Entry();
                e._date = parts[0];
                e._prompt = parts[1];
                e._response = parts[2];
                _entries.Add(e);
            }
        }
        Console.WriteLine("Journal loaded!");
    }
}
