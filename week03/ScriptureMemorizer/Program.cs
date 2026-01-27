using System;

class Program
{
    static void Main(string[] args)
    {
        // Create reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        // Create scriptures verse text with reference
        Scripture scripture = new Scripture(reference, 
        "Trust in the lord with all thine heart and lean not unto thine own understanding");
        
        // Main loop
        while (true)
        {
            // Show the scripture verse and ask user input.
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit;");
            string input = Console.ReadLine() ?? "";

            // If user want to quit
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words
            scripture.HideRandomWords(3);

            // If all words are hidden
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nGreat job! All words are hidden!");
                break;
            }
        }
    }

}