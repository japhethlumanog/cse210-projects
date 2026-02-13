using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment homeWork = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(homeWork.GetSummary());

        MathAssignment mathWork = new MathAssignment("Roberto Rodriguez", "Fraction", "Section 7.3", "Problem 8-19");
        Console.WriteLine(mathWork.GetHomeWorkList());

        WritingAssignment writeWork = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mark Waters");
        Console.WriteLine(writeWork.GetWritingInformation());
    }
}