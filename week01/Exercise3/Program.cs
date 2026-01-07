using System;

class Program
{
    static void Main(string[] args)
    {

        string playAgain;

        do
        {
            
        
        
            // Console.Write("What is magic number? ");
            // string valueGiven = Console.ReadLine();
            // int magicNumber = int.Parse(valueGiven);

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guess = -1;

            int numberGuesses = 0;


            while (guess != magicNumber)
            {
                
                Console.Write("What is your guess? ");
                string guessGiven = Console.ReadLine();
                guess = int.Parse(guessGiven);

                numberGuesses += 1;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher!");
                }

                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower!");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {numberGuesses} guesses.");
                    break;
                }

            } // end guessing loop

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain != null && playAgain.Equals("yes", StringComparison.OrdinalIgnoreCase));
        // end game loop
        

        

    }
}