using System;
using System.Globalization;


class Scripture
{   
    // Store scripture reference, list of word in verse, pick a random word to hide.
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    // Constructor. Split text to single word.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    // Hide random words from the scripture
    public void HideRandomWords(int numberTohide)
    {
        List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());

        for (int i = 0; i < numberTohide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }


    }

    // If all words are hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }

}