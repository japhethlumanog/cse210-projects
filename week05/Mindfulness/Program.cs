using System;

class Program
{
    static void Main(string[] args)
    {
       bool running = true;

       while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness program");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;

                case "2":
                    new ReflectionActivity().Run();
                    break;

                case "3":
                    new ListingActivity().Run();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                Console.WriteLine("Invalid choice.");
                break;

            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}