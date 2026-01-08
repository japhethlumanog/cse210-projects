using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;

        List<int> collectionNum = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string value = Console.ReadLine();
            number = int.Parse(value);

            if (number != 0)
            {
                collectionNum.Add(number);
            }
            
        }

        int total = 0;

        foreach (int n in collectionNum)
        {
            total += n;
        }
        
        double average = (double)total / collectionNum.Count;

        int largest = collectionNum[0];

        foreach (int n in collectionNum)
        {
            if (n > largest)
            {
                largest = n;
            }
        }

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }  
}