using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;
    private string filename = "goals.txt";

    public void DisplayScore()
    {
        Console.WriteLine($"\nYour Score: {score}\n");
    }

    public void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    public void RecordGoal()
    {
        ListGoals();
        Console.Write("Choose goal: ");
        string userInput = Console.ReadLine();
        int choice = int.Parse(userInput);

        int pointsEarned = goals[choice - 1].RecordEvent();
        score = score + pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");
    }

    public void AddSimpleGoal()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        string pointsInput = Console.ReadLine();
        int points = int.Parse(pointsInput);
        
        goals.Add(new SimpleGoal(name, description, points));
    }

    public void AddEternalGoal()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        string pointsInput = Console.ReadLine();
        int points = int.Parse(pointsInput);
        
        goals.Add(new EternalGoal(name, description, points));
    }

    public void AddChecklistGoal()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        string pointsInput = Console.ReadLine();
        int points = int.Parse(pointsInput);

        Console.Write("Times needed: ");
        string timesInput = Console.ReadLine();
        int timesNeeded = int.Parse(timesInput);

        Console.Write("Bonus: ");
        string bonusInput = Console.ReadLine();
        int bonus = int.Parse(bonusInput);

        goals.Add(new ChecklistGoal(name, description, points, timesNeeded, bonus));
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save (default: goals.txt): ");
        string userFilename = Console.ReadLine();
        
        if (userFilename == "" || userFilename == null)
        {
            userFilename = "goals.txt";
        }
        
        try
        {
            StreamWriter writer = new StreamWriter(userFilename);
            writer.WriteLine(score);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
            
            writer.Close();
            Console.WriteLine($"Goals saved successfully to {userFilename}!");
            filename = userFilename;
        }
        catch (Exception error)
        {
            Console.WriteLine($"Error saving goals: {error.Message}");
        }
    }

    public void LoadGoals()
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("No save file found.");
                return;
            }

            goals.Clear();
            StreamReader reader = new StreamReader(filename);
            string scoreLine = reader.ReadLine();
            score = int.Parse(scoreLine);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                
                if (parts.Length > 0)
                {
                    if (parts[0] == "Simple")
                        goals.Add(new SimpleGoal(parts[1], "", 0));
                    else if (parts[0] == "Eternal")
                        goals.Add(new EternalGoal(parts[1], "", 0));
                    else if (parts[0] == "Checklist")
                        goals.Add(new ChecklistGoal(parts[1], "", 0, 0, 0));
                }
            }
            
            reader.Close();
            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Error loading goals: {error.Message}");
        }
    }

    public void ViewFile()
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("No save file found.");
                return;
            }

            Console.WriteLine("\n=== FILE CONTENTS ===");
            StreamReader reader = new StreamReader(filename);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            reader.Close();
            
            Console.WriteLine();
        }
        catch (Exception error)
        {
            Console.WriteLine($"Error viewing file: {error.Message}");
        }
    }
}
