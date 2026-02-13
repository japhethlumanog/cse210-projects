using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        Console.Write("> ");
        string? input = Console.ReadLine();
        int duration;
        while (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.Write("Please enter a positive number of seconds: ");
            input = Console.ReadLine();
        }
        _duration = duration;

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        char[] frames = new char[] { '|', '/', '-', '\\' };

        try { Console.CursorVisible = false; } catch { }

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(100);
            Console.Write("\b \b");
            i++;
        }

        try { Console.CursorVisible = true; } catch { }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}