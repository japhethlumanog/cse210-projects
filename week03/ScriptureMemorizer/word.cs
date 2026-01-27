class Word
{
    // The actual text and the word should be hidden
    private string _text;
    private bool _isHidden;

    // Visible word
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide this word
    public void Hide()
    {
        _isHidden = true;
    }

    // If this word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Get display (word or blanks)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_',_text.Length);
        }
        else
        {
            return _text;
        }
    }
}