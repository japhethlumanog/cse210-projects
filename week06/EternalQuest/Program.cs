using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string choice = "";

        while (choice != "7")
        {
            manager.DisplayScore();

            Console.WriteLine("\n=== MAIN MENU ===");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals to File");
            Console.WriteLine("5. Load Goals from File");
            Console.WriteLine("6. View File");
            Console.WriteLine("7. Quit");

            Console.Write("\nSelect: ");
            choice = Console.ReadLine();

            if (choice == "1") CreateGoalMenu(manager);
            else if (choice == "2") manager.ListGoals();
            else if (choice == "3") manager.RecordGoal();
            else if (choice == "4") manager.SaveGoals();
            else if (choice == "5") manager.LoadGoals();
            else if (choice == "6") manager.ViewFile();
        }
    }

    static void CreateGoalMenu(GoalManager manager)
    {
        Console.WriteLine("\n1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select: ");
        string choice = Console.ReadLine();

        if (choice == "1") manager.AddSimpleGoal();
        else if (choice == "2") manager.AddEternalGoal();
        else if (choice == "3") manager.AddChecklistGoal();
    }
}
