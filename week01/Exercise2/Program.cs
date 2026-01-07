using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string valueInText = Console.ReadLine(); 
        int number = int.Parse(valueInText);

        string letter = string.Empty;

        if (number >= 90 )
        {
            letter = "A";
        }

        else if (number >= 80)
        {
            letter = "B";
        }

        else if (number >= 70)
        {
            letter = "C";
        }

        else if (number >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }
        // adding sign
        string sign = string.Empty;
        float lastDegit = number % 10;

        if (lastDegit >= 7)
        {
            sign = "+";
        }

        else if (lastDegit <= 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        // Handle the A+ grades

        if (number >= 93)
        {
            sign = "";
        }

        // Handle the F+ and F- grades

        if (letter == "F")
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is {sign}{letter}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulation you pass the course.");
        }
        
        else
        {
            Console.WriteLine("Unfortunately you did not pass the course. We encourage you to take the course again.");
            
        }

    }
}